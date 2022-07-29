using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample.NetworkCard
{
    internal interface INetworkCard
    {
        string name { get; }
        string GetDescription();
    }
}
