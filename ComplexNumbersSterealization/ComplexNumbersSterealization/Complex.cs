using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbersSterealization
{
    [Serializable]
    public class Complex
    {
        public Complex()
        {

        }
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
            int a_ = a;
            int b_ = b;
            int c = gcd(a_, b_);
            this.a = this.a / c;
            this.b = this.b / c;
        }
        public static Complex operator +(Complex m, Complex n)
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
            Complex p = new Complex(m.a * n.b, m.b * n.a);
            p.Simple();
            return p;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
}
