using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Application_Constructors
{
    class Program
    {
        class Customer
        {
            public string Customer_Name;
            public string Customer_Address;
            public string Customer_Contact;
            public List<Product> products = new List<Product>();
            public List<Product> get_All_Products()
            {
                return products;
            }

            public addProduct(Product p)
            {
                products.Add(p);
            }
        }

        class Product
        {
            public string Name;
            public string Category;
            public int price;

            public Product()
            {

            }
            public Product(string Name, string Category, int price)
            {
                this.Name = Name;
                this.Category = Category;
                this.price = price;
            }


            public float Calcultes_tax()
            {

                return null;
            }
        }

        static void Main(string[] args)
        {

        }

        static Product TakeInput()
        {

            Console.WriteLine("Enter the Name of the Product : ");
            string name =  Console.ReadLine();
            Console.WriteLine("Enter the Category of the Product : ");
            string Category  = Console.ReadLine();
        }
    }
}
