using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Fruit
    {
        Wall w;
        Random rnd = new Random();
        public Point fruit = new Point(0, 0);
        public Fruit(Wall w)
        {
            this.w = w;
            FoodMaker(w);
        }
        public void FoodMaker(Wall w)
        {
            bool isCollision = true;
            while (true)
            {
                fruit.x = rnd.Next(5, Console.WindowWidth - 15);
                fruit.y = rnd.Next(5, Console.WindowHeight - 5);
                foreach(Point p in w.body)
                {
                    if (p.x == fruit.x && p.y == fruit.y)
                    {
                        isCollision = true;
                    }
                    else isCollision = false; 
                }
                if (!isCollision) break;
            }
        }
        public void FoodDrawer()
        {
            Console.SetCursorPosition(fruit.x, fruit.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("$");
        }
    }
}
