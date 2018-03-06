using System;
 class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            int b = 0;
            List<int> v = new List<int>();
            for(int i = 0;i < n; i++)
            {
                b = Console.Read();
                v.Add(b);
            }
            for(int i = 0; i < n - 1; i++)
            {
                if (v[i] + 1 != v[i + 1])
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
