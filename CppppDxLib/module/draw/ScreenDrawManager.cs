using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace CppppDxLib.module.draw
{
    class ScreenDrawManager:template.Template
    {
        public void initDraw()
        {

        }

        public void clearScreen()
        {
            //描画を裏画面にまわす
            DX.SetDrawScreen(DX.DX_SCREEN_BACK);
            //描画を消す
            DX.ClsDrawScreen();
        }

        public void reflectionScreen()
        {
            //裏画面に回した内容を表画面に反映
            DX.ScreenFlip();
        }
    }
}
