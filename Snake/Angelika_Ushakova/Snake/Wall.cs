using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        List<Figure> wallList;
        public Wall(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            //Отрисовка рамки
            {
                HorizontalLine top = new HorizontalLine(0, 78, 0, '+');
                HorizontalLine bottom = new HorizontalLine(0, 78, 24, '+');
                VerticalLine left = new VerticalLine(0, 24, 0, '+');
                VerticalLine right = new VerticalLine(0, 24, 78, '+');

                wallList.Add(top);
                wallList.Add(bottom);
                wallList.Add(left);
                wallList.Add(right);
            }
        }

        internal void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
