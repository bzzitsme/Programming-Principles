using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int FinalScore = 0;
            Console.CursorVisible = false;
            int level = 1;
            if(level == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(40, 10);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter your name : ");
                Console.SetCursorPosition(59, 10);
                name = Console.ReadLine();
                Console.Clear();
            }
            Snake snake = new Snake();
            Wall wall = new Wall(level);
            Fruit f = new Fruit(wall);
            Fruit c = new Fruit(wall);
            Fruit d = new Fruit(wall);
            snake.Draw();
            wall.Draw();
            f.FoodDrawer();
            int cnt = 0;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.DownArrow)
                {
                    snake.Move(0, 1);
                }
                if(key.Key == ConsoleKey.UpArrow)
                {
                    snake.Move(0, -1);
                }
                if(key.Key == ConsoleKey.LeftArrow)
                {
                    snake.Move(-1, 0);
                }
                if(key.Key == ConsoleKey.RightArrow)
                {
                    snake.Move(1, 0);
                }
                if(key.Key == ConsoleKey.R)
                {
                    level = 1;
                    snake = new Snake();
                    wall = new Wall(level);
                    f = new Fruit(wall);
                    FinalScore = 0;
                }
                if(snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(40, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over, Good Luck Next Time");
                    Console.ReadKey();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                    f = new Fruit(wall);
                    FinalScore = 0;
                }
                Console.Clear();
                if (snake.CollisionWithFood(f))
                {
                    snake.body.Add(new Point(0, 0));
                    f = new Fruit(wall);
                    f.FoodDrawer();
                    if(level == 2)
                    {
                        c = new Fruit(wall);
                        c.FoodDrawer();
                    }
                    if(level == 3)
                    {
                        c = new Fruit(wall);
                        c.FoodDrawer();
                        d = new Fruit(wall);
                        d.FoodDrawer();
                    }
                }
                if (snake.body.Count > 0)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 16, 1);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Name " + name);
                }
                if (snake.body.Count > 0)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 16, Console.WindowHeight - 1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    int n = snake.body.Count - 1;
                    Console.WriteLine("Score = " + n);
                }
                if(snake.body.Count % 6 == 0 && level == 1)
                {
                    level++;
                    wall = new Wall(level);
                    snake = new Snake();
                    f = new Fruit(wall);
                    Console.Clear();
                    wall.Draw();
                    snake.Draw();
                    f.FoodDrawer();
                    FinalScore += 5;
                }
                if(snake.body.Count % 11 == 0 && level == 2)
                {
                    level++;
                    wall = new Wall(level);
                    snake = new Snake();
                    f = new Fruit(wall);
                    Console.Clear();
                    wall.Draw();
                    snake.Draw();
                    f.FoodDrawer();
                    FinalScore += 10;
                }
                if(snake.body.Count % 16 == 0 && level == 3)
                {
                    FinalScore += 15;
                    level++;
                    Console.Clear();
                }
                /* if(level == 4)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("Congratuations, you have won this game " + name + "!!!!");
                    Console.SetCursorPosition(40, 11);
                    Console.WriteLine("Your Final Score was " + FinalScore);
                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine("Press R to Restart");
                    Console.Clear();
                    Console.ReadKey();
                    break;
                } */
                snake.Draw();
                wall.Draw();
                f.FoodDrawer();
            }
        }
    }
}
