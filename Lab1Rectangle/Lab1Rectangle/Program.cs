using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Rectangle
{
    class Rectangle
    {
            public int width, height, area, perimeter;
        public Rectangle(int a)
        {
            width = a;
            height = a;
            findArea();
            findPerimeter();
        }
        public Rectangle(int a, int b)
        {
            width = a;
            height = b;
            findArea();
            findPerimeter();
        }
        public void findArea()
        {
            area = width * height;
        }
        public void findPerimeter()
        {
            perimeter = width * height * width * height;
        }
        public override string ToString()
        {
            return "area = " + area + "\nperimeter = " + perimeter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Rectangle q = new Rectangle(a);
            Rectangle w = new Rectangle(b,c);
            Console.WriteLine(q);
            Console.WriteLine(w);
            Console.ReadKey();
        }
    }
}
