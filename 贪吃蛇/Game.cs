using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    //场景类型枚举
    enum E_SceneType
    {
        Begin,
        Game,
        End
    }
    class Game
    {
        //游戏窗口宽高
        public const int w = 80;
        public const int h = 20;

        //当前选中的场景
        public static ISceneUpdate nowScene;

        public Game()
        {
            //隐藏鼠标
            Console.CursorVisible = false;
            //设置窗口宽高
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            nowScene = new BeginScene();
        }

        //游戏开始的方法
        public void Start()
        {
            while (true)
            {
                //判断当前游戏场景不为空，就更新
                if (nowScene != null)
                {
                    nowScene.Update();
                }
            }
        }

        //场景切换
        public static void SceneChange( E_SceneType Type )
        {
            //清空
            Console.Clear();

            switch (Type)
            {
                case E_SceneType.Begin:
                    nowScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    nowScene = new GameScene();
                    break;
                case E_SceneType.End:
                    nowScene = new EndScene();
                    break;
              
            }

        }
        
    }
}
