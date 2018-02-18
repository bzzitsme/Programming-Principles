using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Student
{
    class Student
    {
        public string name, surname;
        public double gpa;
        public Student()
        {
            name = "FIT";
            surname = "KBTU";
            gpa = 4;
        }
        public Student(string a, string b)
        {
            name = a;
            surname = b;
            gpa = 3.47;
        }
        public Student(string a, string b, double c)
        {
            name = a;
            surname = b;
            gpa = c;
        }
        public override string ToString()
        {
            return name + " " + surname + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            Console.WriteLine(a);
            Student b = new Student("Timka", "Dyussyumbayev");
            Console.WriteLine(b);
            Student c = new Student(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
