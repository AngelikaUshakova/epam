using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point()
        {
        }

        public Point(Point tail)
        {
            x = tail.x;
            y = tail.y;
            symbol = tail.symbol;
        }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x += offset;
            }
            else if(direction == Direction.LEFT)
            {
                x -= offset;
            }
            else if(direction == Direction.UP)
            {
                y -= offset;
            }
            else
            {
                y += offset;
            }
        }

        internal void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        internal bool IsHit(Point food)
        {
            return food.x == x && food.y == y;
        }
    }
}
