using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    [Serializable]
    class Save
    {
        public List<Brands> brand;
        public Market market;
        public Basket basket;


        public Save(Market market, List<Brands> brand, Basket basket)
        {
            this.market = market;
            this.brand = brand;
            this.basket = basket;
        }
        public Save()
        {
            brand = new List<Brands>();
            market = new Market();
        }

        public Market getMarket()
        {
            return market;
        }
        public List<Brands> getBrands()
        {
            return brand;
        }
    }
}
