
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployee
{
    class Program
    {
        class Product
        {
            public string pro_Name;
            public int pro_Price;
            public int pro_Stock;

            public Product()
            {

            }
            public Product(string pro_Name, int pro_Price, int pro_Stock)
            {
                this.pro_Name = pro_Name;
                this.pro_Price = pro_Price;
                this.pro_Stock = pro_Stock;
            }
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
        }


            
    }
}
