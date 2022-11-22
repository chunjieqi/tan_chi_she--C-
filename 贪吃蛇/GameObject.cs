using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal abstract class GameObject : IDraw
    {
        public Position Pos;//表示游戏对象位置 

        //绘制实现
        public abstract void Draw();
        
    }
}
