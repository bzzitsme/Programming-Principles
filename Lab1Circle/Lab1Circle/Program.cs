using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Circle
{
    class Circle
    {
        double radius, diameter, circumference, area;
        public Circle(double  x)
        {
            radius = x;
            FindArea(radius);
            FindCircumference(radius);
            FindDiameter(radius);
        }
        public void FindArea(double x)
        {
            area = Math.PI * radius * radius;
        }
        public void FindDiameter(double x)
        {
            diameter = 2 * radius;
        }
        public void FindCircumference(double x)
        {
            circumference = Math.PI * 2 * radius;
        }
        public override string ToString()
        {
            return area + " " + diameter + " " + circumference;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double q = double.Parse(Console.ReadLine());
            Circle a = new Circle(q);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
