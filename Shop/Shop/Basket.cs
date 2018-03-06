using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    [Serializable]
    class Basket
    {
        public static List<string> basket;
       
        public Basket()
        {
            basket = new List<string>();
        }

        public static void AddGoods(string name)
        {
            basket.Add(name);
        }
        public static void ShowBasket()
        {
            
            for (int i = 0; i < Basket.basket.Count();i++)
            {
                Console.WriteLine(Basket.basket[i]);
            }
            
        }
    }
}
