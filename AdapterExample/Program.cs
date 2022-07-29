using AdapterExample.Monitor;
using AdapterExample.NetworkCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INetworkCard networkCard = new GlobalNet_v3100();
            PrintHardware.OutputInfo(networkCard);

            Console.WriteLine();

            IMonitor monitor = new MonGame_I370();
            PrintHardware.OutputInfo(monitor);

            Console.WriteLine();

            NetworkInterfaceAdapter monitorAdapter = new NetworkInterfaceAdapter(monitor);
            PrintHardware.OutputInfo(monitorAdapter);

            Console.ReadLine();
        }
    }
}
