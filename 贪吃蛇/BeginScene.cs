using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class BeginScene : BeginOrEndScene
    {

        public BeginScene()
        {
            strTitle = "贪吃蛇";
            strOne = "开始游戏";
        }
        //按j键做什么
        public override void EnterJDoSomething()
        {
            if (nowSelIndex == 0)
            {
                Game.SceneChange(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
