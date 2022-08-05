using AdapterExample.Monitor;
using AdapterExample.NetworkCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    internal static class PrintHardware
    {
        public static void OutputInfo(INetworkCard networkCard)
        {
            Console.WriteLine($"Name: {networkCard.name} \nDescription: {networkCard.GetDescription()}");
        }
        public static void OutputInfo(IMonitor monitor)
        {
            Console.WriteLine("Not supported");
        }
    }
}
