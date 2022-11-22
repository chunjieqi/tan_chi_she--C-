using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class Food : GameObject
    {
        public Food(Snake snake)
        {
            RandomPos(snake);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(Pos.x, Pos.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("♦");
        }

        public void RandomPos(Snake snake)
        {
            Random r = new Random();
            int x = r.Next(2, Game.w / 2 - 1) * 2;
            int y = r.Next(1, Game.h - 4);
            Pos = new Position(x, y);

            if (snake.CheckSamePos(Pos))
            {
                RandomPos(snake);
            }

        }
    }
}
