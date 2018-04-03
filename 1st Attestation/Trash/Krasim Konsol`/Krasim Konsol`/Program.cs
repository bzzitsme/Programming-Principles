using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krasim_Konsol_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            while(true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                {
                    if(keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Up");
                    }
                    if(keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Down");
                    }
                    if(keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Left");
                    }
                    if(keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Right");
                    }
                    if(keyInfo.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    if(keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                    }
                }
            }
        }
    }
}
