using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public string Desciption { get; set; }
        public double Cost { get; set; }
        public int NumberOrdered { get; set; }
        public string ImageName { get; set; }

        public Product(string desciption, double cost, string photoName = null)
        {
            Desciption = desciption;
            Cost = cost;
            ImageName = photoName;
        }
    }
}
