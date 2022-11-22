using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    enum E_MoveDir
    {
        Up,
        Down,
        Right,
        Left

    }
    internal class Snake : IDraw
    {
        SnakeBody[] bodys;
        int nowNum;

        E_MoveDir dir;

        public Snake(int x,int y)
        {
            //粗暴的声明两百个空间
            bodys = new SnakeBody[200];
            bodys[0] = new SnakeBody(E_SnakeBody_Type.Head, x, y);
            nowNum = 1;
            dir = E_MoveDir.Right;
        }
        public void Draw()
        {
            for (int i = 0; i < nowNum; i++)
            {
                bodys[i].Draw();
            }
            
        }
        public void Move()
        {
            SnakeBody lastBody = bodys[nowNum - 1];
            Console.SetCursorPosition(lastBody.Pos.x, lastBody.Pos.y);
            Console.Write("  ");

            for (int i = nowNum-1; i >0; i--)
            {
                bodys[i].Pos = bodys[i - 1].Pos;

            }


            switch (dir)
            {
                case E_MoveDir.Up:
                    --bodys[0].Pos.y;
                    break;
                case E_MoveDir.Down:
                    ++bodys[0].Pos.y;
                    break;
                case E_MoveDir.Left:
                    bodys[0].Pos.x-=2;
                    break;
                case E_MoveDir.Right:
                    bodys[0].Pos.x += 2;
                    break;
                default:
                    break;
            }
        }

        public void ChangeDir(E_MoveDir dir)
        {
            if (dir == this.dir||nowNum>1&&
                (this.dir==E_MoveDir.Left&&dir==E_MoveDir.Right||
                this.dir == E_MoveDir.Right && dir == E_MoveDir.Left ||
                this.dir == E_MoveDir.Up && dir == E_MoveDir.Down ||
                this.dir == E_MoveDir.Down && dir == E_MoveDir.Up))
            {
                return;
            }
            this.dir = dir;
        }

        public bool CheckEnd(Map map)
        {
            for (int i = 0; i < map.walls.Length; i++)
            {
                if (bodys[0].Pos == map.walls[i].Pos)
                {
                    return true;
                }     
            }

            for (int i = 1; i < nowNum; i++)
            {
                if (bodys[0].Pos == bodys[i].Pos)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckSamePos(Position p)
        {
            for (int i = 0; i < nowNum; i++)
            {
                if (bodys[i].Pos == p)
                {
                    return true;
                }

            }
            return false;
        }
        public void CheckEatFood(Food food)
        {
            if (bodys[0].Pos==food.Pos)
            {
                food.RandomPos(this);
                AddBody();
            }
        }
        public void AddBody()
        {
            SnakeBody frontBody = bodys[nowNum - 1];
            bodys[nowNum] = new SnakeBody(E_SnakeBody_Type.Body, frontBody.Pos.x, frontBody.Pos.y);
            ++nowNum;

        }
    }
}
