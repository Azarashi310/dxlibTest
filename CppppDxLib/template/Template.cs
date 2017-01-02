using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace CppppDxLib.template
{
    class Template
    {
        //debug
        public module.debug.Debug debug;
        //keycode
        public module.KeyCodeManager keycode;

        public void initDebugModule()
        {
            debug = new module.debug.Debug();
        }

        public void initKeyCodeModule()
        {
            keycode = new module.KeyCodeManager();
        }
    }
}
