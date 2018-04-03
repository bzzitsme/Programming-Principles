using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Products product = new Products();
            Console.SetCursorPosition(0, 0);
            int n = 6;
            List<string> v = new List<string>();
            StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\PP-2-Labs\AdditionalTask for bonus\shops.txt");
            int cnt = int.Parse(sr.ReadLine());
            Shop shop = new Shop();
            for (int i = 0; i < cnt; i++)
            {
                v.Add(sr.ReadLine());
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("Welcome to our Online Shop");
            Console.SetCursorPosition(40, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press Enter to Continue");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Press ESC to Exit");
            ConsoleKeyInfo test = Console.ReadKey();
            if (test.Key == ConsoleKey.Escape) return;
            if (test.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                int cnt1 = 1;
                int c1 = 0;
                int c2 = 0;
                int c3 = 0;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("a) Show all shops");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("b) Show the cheapest shop");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("c) Show most expensive shop");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("d) Exit");
                    ConsoleKeyInfo Key = Console.ReadKey();
                    if (Key.Key == ConsoleKey.A)
                    {
                        shop.ShowShop(v);
                        ConsoleKeyInfo lel = Console.ReadKey();
                        if (lel.Key == ConsoleKey.A)
                        {
                            string name = "Zara";
                            shop.OpenShop(name);
                        }
                        if(lel.Key == ConsoleKey.B)
                        {
                            string name = "Adidas";
                            shop.OpenShop(name);
                        }
                        if(lel.Key == ConsoleKey.C)
                        {
                            string name = "Nike";
                            shop.OpenShop(name);
                        }
                    }
                    if (Key.Key == ConsoleKey.B)
                    {
                        product.Cheapest();
                    }
                    if (Key.Key == ConsoleKey.C)
                    {
                        product.Expensive();
                    }
                    if (Key.Key == ConsoleKey.D)
                    {
                        return;
                    }
                    Console.Clear();
                }
            }
        }
    }
}
