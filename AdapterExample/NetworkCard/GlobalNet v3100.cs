using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample.NetworkCard
{
    internal class GlobalNet_v3100 : INetworkCard
    {
        public string name { get; }
        public string description { get; }

        public GlobalNet_v3100()
        {
            name = "GlobalNet v3100";
            description = "Network card 10gbps";
        }

        public string GetDescription() => description;
    }
}
