using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public List<Point> body;
        string sign;
        ConsoleColor color;
        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(3, 3));
            sign = "o";
            color = ConsoleColor.Yellow;
        }
        public void Move(int dx, int dy)
        {
            for(int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 17;
            if (body[0].x > Console.WindowWidth - 17)
                body[0].x = 1;
            if (body[0].y < 1)
                body[0].y = Console.WindowHeight - 1;
            if (body[0].y > Console.WindowHeight - 1)
                body[0].y = 1;
        }
        public void Draw()
        {
            foreach(Point p in body)
            {
                int index = 0;
                if (index == 0) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }
        }
        public bool CollisionWithWall(Wall w)
        {
            foreach(Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            }
            return false;
        }
        public bool Collision()
        {
            for(int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            return false;
        }
        public bool CollisionWithFood(Fruit f)
        {
            if (body[0].x == f.fruit.x && body[0].y == f.fruit.y) return true;
            else return false;
        }

    }
}
