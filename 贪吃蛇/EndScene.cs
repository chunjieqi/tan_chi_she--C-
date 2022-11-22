using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class EndScene : BeginOrEndScene
    {
        public EndScene()
        {
            strTitle = "游戏结束";
            strOne = "回到开始界面";
        }
        //按j键做什么
        public override void EnterJDoSomething()
        {
            if (nowSelIndex == 0)
            {
                Game.SceneChange(E_SceneType.Begin);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
