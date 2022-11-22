using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    enum E_SnakeBody_Type 
    {
        Body,
        Head
    }
    internal class SnakeBody : GameObject
    {
        private E_SnakeBody_Type type;

        public SnakeBody(E_SnakeBody_Type type,int x,int y)
        {
            this.type = type;
            Pos = new Position(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(Pos.x, Pos.y);
            Console.ForegroundColor = type == E_SnakeBody_Type.Head ? ConsoleColor.Yellow : ConsoleColor.Green;
            Console.WriteLine(type == E_SnakeBody_Type.Head ? "●" : "○");
        }
    }
}
