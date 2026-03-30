using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ChatApp.Controller
{
    public class ConnectionList
    {
        public IObservable<Connection> Connections { get; private set; }
    }
}
