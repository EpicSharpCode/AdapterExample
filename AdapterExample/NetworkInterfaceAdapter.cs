using AdapterExample.Monitor;
using AdapterExample.NetworkCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    internal class NetworkInterfaceAdapter : INetworkCard
    {
        IMonitor monitor;
        public string name { get { return monitor.name; } }

        public NetworkInterfaceAdapter(IMonitor _monitor)
        {
            monitor = _monitor;
        }

        public string GetDescription()
        {
            return monitor.GetMatrixInfo();
        }
    }
}
