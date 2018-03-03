using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    [Serializable]
    class Program
    {
        public static Basket basket = new Basket();

        public static Save Init()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(@"data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                return bf.Deserialize(fs) as Save;
            }
            catch(Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
            Save res = new Save();
            return res;
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Market cur = new Market();

            Save data = Init();

            if(data.market != null)
                cur = data.market;
            basket = data.basket;

            int pos = 0;

            cur.ShowBrands(pos);


            while(true)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                Console.Clear();
                if (btn.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if(pos == -1)
                    {
                        pos = 2;
                    }
                }
                if(btn.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == 3)
                        pos = 0;
                }
                if(btn.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    cur.showProduct(pos);
                    Console.ReadKey();
                    Console.Clear();
                }
                if (btn.Key == ConsoleKey.K)
                {
                    Console.Clear();
                    for(int i = 0;i < basket.basket.Count;i ++)
                    {
                        Console.WriteLine(basket.basket[i]);
                    }
                    Console.ReadKey();
                }
                cur.ShowBrands(pos);
                SaveData(cur);
            }
        }
        public static void SaveData(Market saveMarket)
        {
            List<Brands> brands = saveMarket.brands;
            Save curSave = new Save(saveMarket, brands, basket);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(@"data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                bf.Serialize(fs, curSave);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
