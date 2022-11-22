using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class GameScene : ISceneUpdate
    {
        Map map;
        Snake snake;
        Food food;

        int updateIndex = 0;
        public GameScene()
        {
            map = new Map();
            snake = new Snake(40, 10);
            food = new Food(snake);
        }
        public void Update()
        {
            
            if (updateIndex%4444==0)
            {
                map.Draw();
                food.Draw();
                snake.Move();
                snake.Draw();

                if (snake.CheckEnd(map))
                {
                    Game.SceneChange(E_SceneType.End);
                }

                snake.CheckEatFood(food);

                updateIndex = 0;
            }
            updateIndex++;

            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(E_MoveDir.Right);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(E_MoveDir.Down);
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
