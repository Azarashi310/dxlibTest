using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace CppppDxLib.module
{
    class KeyCodeManager:template.Template
    {
        private int key_up;
        private int key_down;
        private int key_left;
        private int key_right;
        private int custom_up;
        private int custom_down;
        private int custom_left;
        private int custom_right;
        private byte[] keystatebuf = new byte[256];
        private int keyflagnum = 0;
        [Flags]
        enum keyflags
        {
            none = 0,
            up = 1,
            down = 2,
            left = 4,
            right = 8,
            upleft = up | left,
            upright = up | right,
            downleft = down | left,
            downright = down | right
        }
        public void initKeyCode()
        {
            key_up = DX.KEY_INPUT_UP;
            key_down = DX.KEY_INPUT_DOWN;
            key_left = DX.KEY_INPUT_LEFT;
            key_right = DX.KEY_INPUT_RIGHT;
            DX.GetHitKeyStateAll(out keystatebuf[0]);
        }

        public void setCustomKeyCode(int[] keyCode)
        {

        }

        public void getPressKeyCode()
        {
            DX.GetHitKeyStateAll(out keystatebuf[0]);
            if ((keystatebuf[key_up] == 1)||(keystatebuf[custom_up] == 1))
            {
                debug.trace("up");
            }
            else if ((keystatebuf[key_down] == 1)||(keystatebuf[custom_down] == 1))
            {
                debug.trace("down");
            }
            else if ((keystatebuf[key_left] == 1)||(keystatebuf[custom_left] == 1))
            {
                debug.trace("left");
            }
            else if ((keystatebuf[key_right] == 1)||(keystatebuf[custom_right] == 1))
            {
                debug.trace("right");
            }
            else
            {
                
            }
        }
    }
}
