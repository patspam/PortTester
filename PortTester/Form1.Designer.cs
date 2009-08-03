namespace PortTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bn_Connect = new System.Windows.Forms.Button();
            this.tb_Send = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Receive = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bn_Send = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_Port = new System.Windows.Forms.ComboBox();
            this.bw_Connect = new System.ComponentModel.BackgroundWorker();
            this.tmr_Receive = new System.Windows.Forms.Timer(this.components);
            this.tmr_ConnectionMonitor = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_Connect
            // 
            this.bn_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bn_Connect.Image = ((System.Drawing.Image)(resources.GetObject("bn_Connect.Image")));
            this.bn_Connect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_Connect.Location = new System.Drawing.Point(139, 3);
            this.bn_Connect.Name = "bn_Connect";
            this.bn_Connect.Size = new System.Drawing.Size(196, 39);
            this.bn_Connect.TabIndex = 3;
            this.bn_Connect.Text = "&Connect";
            this.bn_Connect.UseVisualStyleBackColor = true;
            this.bn_Connect.Click += new System.EventHandler(this.bn_Connect_Click);
            // 
            // tb_Send
            // 
            this.tb_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Send.BackColor = System.Drawing.Color.White;
            this.tb_Send.Location = new System.Drawing.Point(3, 5);
            this.tb_Send.Name = "tb_Send";
            this.tb_Send.Size = new System.Drawing.Size(258, 20);
            this.tb_Send.TabIndex = 2;
            this.tb_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Send_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Receive, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bn_Connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 291);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tb_Receive
            // 
            this.tb_Receive.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_Receive, 2);
            this.tb_Receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Receive.Location = new System.Drawing.Point(3, 149);
            this.tb_Receive.Multiline = true;
            this.tb_Receive.Name = "tb_Receive";
            this.tb_Receive.ReadOnly = true;
            this.tb_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Receive.Size = new System.Drawing.Size(332, 139);
            this.tb_Receive.TabIndex = 10;
            this.tb_Receive.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Port);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 39);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port";
            // 
            // tb_Port
            // 
            this.tb_Port.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PortTester.Properties.Settings.Default, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Port.Location = new System.Drawing.Point(3, 16);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(124, 20);
            this.tb_Port.TabIndex = 0;
            this.tb_Port.Text = global::PortTester.Properties.Settings.Default.Port;
            this.tb_Port.TextChanged += new System.EventHandler(this.tb_Port_TextChanged);
            this.tb_Port.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Port_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_IP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 39);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host / IP";
            // 
            // tb_IP
            // 
            this.tb_IP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PortTester.Properties.Settings.Default, "Host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_IP.Location = new System.Drawing.Point(3, 16);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(124, 20);
            this.tb_IP.TabIndex = 0;
            this.tb_IP.Text = global::PortTester.Properties.Settings.Default.Host;
            this.tb_IP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_IP_KeyDown);
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 50);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Controls.Add(this.bn_Send, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Send, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(326, 31);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // bn_Send
            // 
            this.bn_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bn_Send.Enabled = false;
            this.bn_Send.Image = ((System.Drawing.Image)(resources.GetObject("bn_Send.Image")));
            this.bn_Send.Location = new System.Drawing.Point(267, 3);
            this.bn_Send.Name = "bn_Send";
            this.bn_Send.Size = new System.Drawing.Size(56, 25);
            this.bn_Send.TabIndex = 5;
            this.bn_Send.UseVisualStyleBackColor = true;
            this.bn_Send.Click += new System.EventHandler(this.bn_Send_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_Port);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(139, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 39);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Port Selector";
            // 
            // cb_Port
            // 
            this.cb_Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Port.FormattingEnabled = true;
            this.cb_Port.Location = new System.Drawing.Point(3, 16);
            this.cb_Port.Name = "cb_Port";
            this.cb_Port.Size = new System.Drawing.Size(190, 21);
            this.cb_Port.TabIndex = 0;
            this.cb_Port.SelectedIndexChanged += new System.EventHandler(this.cb_Port_SelectedIndexChanged);
            this.cb_Port.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Port_KeyDown);
            // 
            // bw_Connect
            // 
            this.bw_Connect.WorkerReportsProgress = true;
            this.bw_Connect.WorkerSupportsCancellation = true;
            // 
            // tmr_Receive
            // 
            this.tmr_Receive.Tick += new System.EventHandler(this.tmr_Receive_Tick);
            // 
            // tmr_ConnectionMonitor
            // 
            this.tmr_ConnectionMonitor.Tick += new System.EventHandler(this.tmr_ConnectionMonitor_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 315);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(346, 349);
            this.Name = "Form1";
            this.Text = "Port Tester";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Button bn_Connect;
        private System.Windows.Forms.TextBox tb_Send;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.TextBox tb_Receive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bn_Send;
        private System.ComponentModel.BackgroundWorker bw_Connect;
        private System.Windows.Forms.Timer tmr_Receive;
        private System.Windows.Forms.Timer tmr_ConnectionMonitor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_Port;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

