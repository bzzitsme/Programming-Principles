using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Timka", 17, 3.3);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
