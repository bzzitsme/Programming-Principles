using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string l1 = Console.ReadLine(); // Считываем данные
            args = l1.Split(' '); // сплитим
            foreach(string s in args) // Перебираем каждую цифру в строке и меняет значение на инт
            {
                int x = int.Parse(s);
                bool Plov = true; // boolean
                for(int i = 2; i*i <= x; ++i) // Проверяем на простоту
                {
                    if(x % i == 0)
                    {
                        Plov = false;
                        break;
                    }
                }
                if(Plov & x!=1) // esli chislo vipolnyaet uslovie
                {
                    Console.WriteLine(x); // vivodim ee
                }
            }
            Console.ReadKey(); // wtobi console ne zakrivalas`
        }
    }
}
