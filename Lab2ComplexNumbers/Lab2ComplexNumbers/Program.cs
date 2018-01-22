using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            Complex q = new Complex(a1, a2);
            Complex w = new Complex(b1, b2);
            Complex e = q + w;
            Complex r = q - w;
            Complex t = q * w;
            Complex y = q / w;
        }
    }
    class Complex
    {
        public int a;
        public int b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Nod(int x, int y)
        {
            if (y == 0) return x;
            else return Nod(y, x % y);
        }
        public void Simple()
        {
            int _a = a;
            int _b = b;
            int q = Nod(_a, _b);
            this.a = this.a / q;
            this.b = this.b / q;
        }
        public static Complex operator *(Complex m, Complex n)
        {
            Complex t = new Complex(m.a * n.a, m.b * n.b);
            t.Simple();
            return t;
        }
        public static Complex operator /(Complex m, Complex n)
        {
            Complex _m = new Complex(m.a, m.b); // 3/4
            Complex _n = new Complex(n.a, n.b); // 5/9
            int r = _n.a; 
            _n.a = _n.b;
            _n.b = r;
            return _m * _n;
        }
        public static Complex operator +(Complex m, Complex n)
        {
            Complex t = new Complex(m.a * n.b / Nod(m.b, n.b) + n.a * m.b / Nod(m.b, n.b), m.b * n.b / Nod(m.b, n.b));
            t.Simple();
            return t;
        }
        public static Complex operator -(Complex m, Complex n)
        {
            Complex t = new Complex(m.a * n.b / Nod(m.b, n.b) - n.a * m.b / Nod(m.b, n.b), m.b * n.b / Nod(m.b, n.b));
            t.Simple();
            if (t.b < 0)
            {
                t.a = t.a * (-1);
                t.b = -t.b;
            }
            return t;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
}
