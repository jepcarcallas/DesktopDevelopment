using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuko
{
    public class Product
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public Image ProductImage { get; set; }

        public decimal GetPriceForSize(string size)
        {
            decimal price = BasePrice;
            if (size == "Grande")
                price += 20;
            else if (size == "Venti")
                price += 30;
            return price;
        }
    }
}
