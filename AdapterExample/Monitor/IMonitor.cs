using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample.Monitor
{
    internal interface IMonitor
    {
        string name { get; }
        string GetMatrixInfo();
    }
}
