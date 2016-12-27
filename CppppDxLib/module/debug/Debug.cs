using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CppppDxLib.module.debug
{
    class Debug
    {
        public void trace(string tracetext)
        {
            Trace.WriteLine(tracetext);
        }
    }
}
