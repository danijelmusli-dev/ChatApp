using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Controller
{
    public class Connection
    {
        public string Name { get; set; }
            public string IP { get; set; }
            public int Port { get; set; }
            public bool IsConnected { get; set; }

            public Connection(string name, string ip, int port)
            {
                Name = name;
                IP = ip;
                Port = port;
                IsConnected = false;
            }

            public override string ToString()
            {
                return $"{Name} ({IP}:{Port}) - {(IsConnected ? "Connected" : "Disconnected")}";
            }
    }
}
