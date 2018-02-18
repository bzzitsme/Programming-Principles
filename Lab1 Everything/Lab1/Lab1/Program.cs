using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine(); // Считываем нашу строку с цифрами
            args = line.Split(' '); // Сплитим, чтобы каждый элемент в аргсе был отдельным
            foreach (string s in args) // Проходимся по всему аргументу
            {
                int x = int.Parse(s); // Переводим число которое в стринге в инт
                bool ok = true; // Нужен для проверки на простоту
                for (int i = 2; i * i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok & x != 1) // Если все нормально, то идём дальше
                {
                    Console.WriteLine(x); // Выводим наш интеджер
                }
                ok = true;
            }
            Console.ReadKey(); // Чтобы не закрылась консоль


        }
    }
}
