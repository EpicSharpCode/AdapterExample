using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample.Monitor
{
    internal class MonGame_I370 : IMonitor
    {
        public string name { get; }
        string matrixInfo;

        public MonGame_I370()
        {
            name = "MonGame I370";
            matrixInfo = "IPS";
        }

        public string GetMatrixInfo() => matrixInfo;
    }
}
