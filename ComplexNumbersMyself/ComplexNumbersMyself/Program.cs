using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbersMyself
{
    class Complex
    {
        public int a;
        public int b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int gcd(int x, int y)
        {
            if (y == 0) return x;
            else return gcd(y, x % y);
        }
        public void Simple()
        {
            int  a_ = a;
            int  b_ = b;
            int c = gcd(a_, b_);
            this.a = this.a / c;
            this.b = this.b / c;
        }
        public static Complex operator +(Complex m, Complex n) // 2/7 + 3/1
        {
            Complex p = new Complex((m.a * n.b + n.a * m.b) / gcd(m.b, n.b), m.b * n.b / gcd(m.b, n.b));
            p.Simple();
            return p;
        }
        public static Complex operator -(Complex m, Complex n)
        {
            Complex p = new Complex((m.a * n.b - n.a * m.b) / gcd(m.b, n.b), m.b * n.b / gcd(m.b, n.b));
            p.Simple();
            return p;
        }
        public static Complex operator *(Complex m, Complex n)
        {
            Complex p = new Complex(m.a * n.a, m.b * n.b);
            p.Simple();
            return p;
        }
        public static Complex operator /(Complex m, Complex n)
        {
            Complex p = new Complex(m.a * n.b, n.a * m.b);
            p.Simple();
            return p;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string l1 = Console.ReadLine();
            string l2 = Console.ReadLine();
            string[] l11 = new string[2];
            l11 = l1.Split('/');
            string[] l22 = new string[2];
            l22 = l2.Split('/');
            int a = int.Parse(l11[0]);
            int a1 = int.Parse(l11[1]);
            int b = int.Parse(l22[0]);
            int b1 = int.Parse(l22[1]);
            Complex q = new Complex(a, a1);
            Complex w = new Complex(b, b1);
            Complex e = q + w;
            Complex r = q - w;
            Complex t = q * w;
            Complex y = q / w;
            Console.WriteLine(e);
            Console.WriteLine(r);
            Console.WriteLine(t);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
