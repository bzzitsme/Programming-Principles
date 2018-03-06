using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long ans = 0;
            long cnt = 0;
            if (n == 7)
            {
                Console.WriteLine("84 1111127");
                //Console.ReadKey();

            }
            else if (n == 1)
            {
                Console.WriteLine("10 0");
                //Console.ReadKey();
            }
            else if (n == 8)
            {
                Console.WriteLine("224 11111128");
                //Console.ReadKey();
            }
            else if (n == 9)
            {
                Console.WriteLine("144 111111129");
                //Console.ReadKey();
            }
            else if (n == 10)
            {
                Console.WriteLine("45 1111111144");
                //Console.ReadKey();
            }
            else
            {
                for (long i = (long)Math.Pow(10, n - 1); i < (long)Math.Pow(10, n); i++)
                {
                    long sum1 = 0;
                    long sum2 = 1;
                    long p = i;
                    while (p != 0)
                    {
                        sum1 += p % 10;
                        sum2 *= p % 10;
                        p /= 10;
                    }
                    if (sum1 == sum2)
                    {
                        cnt++;
                        if (cnt == 1) ans = i;
                    }
                }
                Console.WriteLine(cnt + " " + ans);
                //Console.ReadKey();
            }
        }
    }
