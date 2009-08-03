using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace PortTester
{
    public partial class Form1 : Form
    {
        private TcpClient tcp = new TcpClient(AddressFamily.InterNetwork);
        private IAsyncResult ConnectAsyncResult;
        private IAsyncResult ReceiveAsyncResult;
        private byte[] ReceiveBytes;
        private bool newConnection; // used to work out if we've already handled the connection closing

        public Form1()
        {
            InitializeComponent();
            tmr_Receive.Enabled = true;
            tb_IP.Select();
            cb_Port.DisplayMember = "comboBoxDisplay";
            cb_Port.Items.Add(new Port("Echo", "7"));
            cb_Port.Items.Add(new Port("Daytime", "13"));
            cb_Port.Items.Add(new Port("FTP", "21"));
            cb_Port.Items.Add(new Port("SSH", "22"));
            cb_Port.Items.Add(new Port("Telnet", "23"));
            cb_Port.Items.Add(new Port("SMTP", "25"));
            cb_Port.Items.Add(new Port("DNS", "53"));
            cb_Port.Items.Add(new Port("HTTP", "80"));
            cb_Port.Items.Add(new Port("POP3", "110"));
            cb_Port.Items.Add(new Port("NETBIOS-NS", "137"));
            cb_Port.Items.Add(new Port("NETBIOS-DGM", "138"));
            cb_Port.Items.Add(new Port("NETBIOS-SSN", "139"));
            cb_Port.Items.Add(new Port("IMAP", "143"));
            cb_Port.Items.Add(new Port("MySQL", "3306"));
            cb_Port.Items.Add(new Port("TermServices", "3389"));
            cb_Port.Items.Add(new Port("HTTPS", "443"));
            cb_Port.Items.Add(new Port("Postgres", "5432"));
            
            matchPortToCB();
        }

        private void bn_Connect_Click(object sender, EventArgs e)
        {
            connect(); 
        }
        private void connect()
        {
            bn_Send.Enabled = false;
            tcp.Close();
            tcp = new TcpClient(AddressFamily.InterNetwork);

            int port;

            if (int.TryParse(tb_Port.Text, out port))
            {
                Properties.Settings.Default.Save();

                Message("[Connecting..]");

                ConnectAsyncResult = tcp.BeginConnect(tb_IP.Text, port, MyCallback, tcp);

                tmr_ConnectionMonitor.Enabled = true;
            }
            else
            {
                Message("-> Invalid port number");
            }
            while (true)
            {
                System.Threading.Thread.Sleep(10);
            }
        }

        private void Message(string s)
        {
            tb_Receive.AppendText(s + "\r\n");
            
        }

        public void MyCallback(IAsyncResult ar)
        {
            // Do Nothing (can't access GUI from this thread)
        }

        private void tmr_ConnectionMonitor_Tick(object sender, EventArgs e)
        {
            if (ConnectAsyncResult == null)
            {
                return;
            }

            if (ConnectAsyncResult.IsCompleted)
            {
                tmr_ConnectionMonitor.Enabled = false;

                TcpClient t = (TcpClient)ConnectAsyncResult.AsyncState;

                if (t.Client == null)
                {
                    InformConnectionClosed();
                    return;
                }

                try
                {
                    t.EndConnect(ConnectAsyncResult);
                    Message("-> Connected to open port");
                    bn_Send.Enabled = true;
                    newConnection = true;
                    tb_Send.Select();
                }
                catch (Exception ex)
                {
                    Message("-> Connection failed: " + ex.Message);
                }
            }
        }

        private void tmr_Receive_Tick(object sender, EventArgs e)
        {
            if (tcp.Client == null)
            {
                InformConnectionClosed();
                return;
            }

            if (!tcp.Connected)
            {
                InformConnectionClosed();
                return;
            }

            if (ReceiveAsyncResult == null)
            {
                Socket s = tcp.Client;
                
                try
                {
                    int size = tcp.Available;
                    if (size > 0)
                    {
                        ReceiveBytes = new byte[size];
                        ReceiveAsyncResult = s.BeginReceive(ReceiveBytes, 0, size, SocketFlags.None, MyCallback, s);
                    }
                }
                catch (Exception ex)
                {
                    Message("-> Receive failed: " + ex.Message);
                }
            
            }
            else
            {
                if (ReceiveAsyncResult.IsCompleted)
                {
                    try
                    {
                        Socket s = (Socket)ReceiveAsyncResult.AsyncState;
                        SocketError socketError; // not really used, says "Succcess if receive worked
                        s.EndReceive(ReceiveAsyncResult, out socketError);
                        ReceiveAsyncResult = null;
                        Message(Encoding.ASCII.GetString(ReceiveBytes));
                    }
                    catch (Exception ex)
                    {
                        Message("-> Receive failed: " + ex.Message);
                    }                    
                }
            }
        }

        private void InformConnectionClosed()
        {
            if (newConnection)
            {
                newConnection = false;
                bn_Send.Enabled = false;
                Message("-> Connection closed");
                tb_IP.Select();
            }
        }

        private void bn_Send_Click(object sender, EventArgs e)
        {
            send();
        }

        private void send() {
            if (tcp.Client == null)
            {
                Message("-> Unable to send, not connected");
                return;
            }

            if (!tcp.Connected)
            {
                Message("-> Unable to send, not connected");
                return;
            }

            Socket s = tcp.Client;

            Byte[] barr = Encoding.ASCII.GetBytes(tb_Send.Text + "\r\n");

            try
            {
                s.Send(barr);
                Message("> " + tb_Send.Text);
            }
            catch (Exception ex)
            {
                Message("-> Send failed: " + ex.Message);
            }
        }

        private void captureEnter(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (bn_Send.Enabled)
                {
                    send();
                }
                else
                {
                    connect();
                }
            }
        }
        private void captureEnterConnectOnly(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                connect();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            captureEnter(e);
        }

        private void tb_Send_KeyDown(object sender, KeyEventArgs e)
        {
            captureEnter(e);
        }

        private void tb_IP_KeyDown(object sender, KeyEventArgs e)
        {
            captureEnterConnectOnly(e);
        }

        private void tb_Port_KeyDown(object sender, KeyEventArgs e)
        {
            captureEnterConnectOnly(e);
        }
        private void cb_Port_KeyDown(object sender, KeyEventArgs e)
        {
            captureEnterConnectOnly(e);
        }

        private void cb_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port s = (Port)cb_Port.SelectedItem;
            if (s != null)
            {
                tb_Port.Text = s.port;
            }
        }

        private void matchPortToCB()
        {
            foreach (Port i in cb_Port.Items)
            {
                if (i.port == tb_Port.Text)
                {
                    cb_Port.SelectedItem = i;
                    return;
                }
            }
            cb_Port.SelectedIndex = -1;
        }

        private void tb_Port_TextChanged(object sender, EventArgs e)
        {
            matchPortToCB();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Patrick Donelan (www.patspam.com)", "Port Tester", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}