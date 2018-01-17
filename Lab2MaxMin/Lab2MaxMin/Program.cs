using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\User\Desktop\PP2Labs\Lab2MaxMin\input.txt");
            string[] a = text.Split();
            int[] n = new int[a.Count()];
            for(int i = 0; i < a.Length; i++)
            {
                n[i] = int.Parse(a[i]);
            }
            Console.WriteLine(n.Max());
            Console.WriteLine(n.Min());
            Console.ReadKey();
        }
    }
}
