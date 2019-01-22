using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
       
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            pointList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, this.direction);
                pointList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPosition();
            pointList.Add(head);

            tail.Clear();
            head.Draw();
        }

        internal bool IsHitTail()
        {
            var head = pointList.Last();
            for (int i = 0; i < pointList.Count-2; i++)
            {
                if (head.IsHit(pointList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private Point GetNextPosition()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);

            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey( ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPosition();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                pointList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
