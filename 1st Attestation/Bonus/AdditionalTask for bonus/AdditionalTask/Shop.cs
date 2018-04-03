using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdditionalTask
{
    class Shop
    {
        public int counter;
        public void ShowShop(List<String> v)
        {
            Console.Clear();
            int xd = 10;
            for (int i = 0; i < v.Count(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(50, xd);
                Console.WriteLine(i + 1 + ")" + v[i]);
                xd++;
            }
            xd = 10;
        }
        public void OpenShop(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            StreamReader srr = new StreamReader(@"C:\Users\Admin\Desktop\PP-2-Labs\AdditionalTask for bonus\" + name + ".txt");
            Console.WriteLine(srr.ReadToEnd());
            srr.Close();
            Console.ReadKey();
        }
    }
}
