using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace CppppDxLib
{
    class GameMainManager:template.Template
    {
        [STAThread]
        public static void Main()
        {
            GameMainManager Game = new GameMainManager();
            DX.ChangeWindowMode(DX.TRUE);
            if (DX.DxLib_Init() == -1)
            {
                return;
            }
            Game.GameMain();
        }

        private void GameMain()
        {
            //module.KeyCodeManager keyInput = new module.KeyCodeManager();
            //keyInput.initKeyCode();
            DX.DrawPixel(320, 240, DX.GetColor(255, 255, 255));
            
            while(true){
                if (DX.ProcessMessage() == -1)
                {
                    break;
                }
                //keyInput.getPressKeyCode();
            }
            GameEnd();
        }

        private void GameEnd()
        {
            DX.DxLib_End();
        }
    }
}
