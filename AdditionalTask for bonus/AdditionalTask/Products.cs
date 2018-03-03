using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdditionalTask
{
    class Products
    {
        /* public string name;
        public int amount;
        public int price; */
        /* public product(string name, int amount, int price)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;
        } */
        public Products()
        {

        }
        public void Expensive()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\PP-2-Labs\AdditionalTask for bonus\the most expensive.txt");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            Console.ReadKey();
        }
        public void Cheapest()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\PP-2-Labs\AdditionalTask for bonus\the chepeast.txt");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            Console.ReadKey();
        }
    }
}
