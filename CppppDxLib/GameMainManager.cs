using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace CppppDxLib
{
    class GameMainManager
    {
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
            DX.DrawPixel(320, 240, DX.GetColor(255, 255, 255));
            DX.WaitKey();
            GameEnd();
        }

        private void GameEnd()
        {
            DX.DxLib_End();
        }
    }
}
