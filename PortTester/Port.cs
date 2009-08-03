using System;
using System.Collections.Generic;
using System.Text;

namespace PortTester
{
    class Port
    {
        public string name;
        public string port;
        public string comboBoxDisplay
        {
            get { return name + " - " + port; }
        }
        public Port(string n, string p)
        {
            name = n;
            port = p;
        }
    }    
}
