using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class Wall : GameObject
    {
        public Wall(int x,int y)
        {
            Pos = new Position(x, y);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(Pos.x, Pos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■");
        }
    }
}
