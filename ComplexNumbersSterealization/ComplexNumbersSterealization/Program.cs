using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ComplexNumbersSterealization
{
    [Serializable]
    class Program
    {
        static void EfOdin(Complex e, Complex r, Complex t, Complex y)
        {
            List<Complex> vector = new List<Complex>();
            vector.Add(e);
            vector.Add(r);
            vector.Add(t);
            vector.Add(y);
            XmlSerializer xs = new XmlSerializer(typeof(List<Complex>));
            FileStream fs = new FileStream(@"ezikk.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            xs.Serialize(fs, vector);
            fs.Close();
        }
        static void f3()
        {
            List<Complex> vector1 = new List<Complex>();
            FileStream fs = new FileStream(@"ezikk.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Complex>));
            vector1 = xs.Deserialize(fs) as List<Complex>;
            for(int i = 0; i < vector1.Count; i++)
            {
                Console.WriteLine(vector1[i]);
            }
            fs.Close();
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string keks = Console.ReadLine();
            string[] f1 = new string[2];
            f1 = text.Split('/');
            string[] f2 = new string[2];
            f2 = keks.Split('/');
            int a = int.Parse(f1[0]);
            int b = int.Parse(f1[1]);
            int c = int.Parse(f2[0]);
            int d = int.Parse(f2[1]);
            Complex q = new Complex(a, b);
            Complex w = new Complex(c, d);
            Complex e = q + w;
            Complex r = q - w;
            Complex t = q * w;
            Complex y = q / w;
            /* Console.WriteLine(e);
            Console.WriteLine(r);
            Console.WriteLine(t);
            Console.WriteLine(y); */
            EfOdin(e, r, t, y);
            f3();
            Console.ReadKey();     
        }
    }
}
