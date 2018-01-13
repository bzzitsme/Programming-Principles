using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class Student
    {
        public string name;
        public int age;
        public double gpa;

        public Student(string n, int a, double g)
        {
            name = n;
            age = a;
            gpa = g;
        }
        public override string ToString()
        {
            return name + " " + age + " " + gpa;
        }
    }
}