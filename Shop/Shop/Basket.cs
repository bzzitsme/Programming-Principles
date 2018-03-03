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
        public List<string> basket;
       
        public Basket()
        {
            basket = new List<string>();
        }

        public void AddGoods(string name)
        {
            basket.Add(name);
        }
    }
}
