using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Customer
        {
            public string Customer_Name;
            public string Customer_Adress;
            public string Customer_Contact;
            public List<Product> products = new List<Product>();
            public List<Product> productsBuy = new List<Product>();

            public void addProduct(Product p)
            {
                products.Add(p);
            }

            public Customer()
            {
            }
            public Customer(string Customer_Name, string Customer_Adress, string Customer_Contact)
            {
                this.Customer_Name = Customer_Name;
                this.Customer_Adress = Customer_Adress;
                this.Customer_Contact = Customer_Contact;
            }

            public void getAllProducts(List<Product> products)
            {

                foreach (Product p in products)
                {
                    Console.WriteLine("{0} has catatgory {1} with  price {2}", p.name, p.catagory, p.price);
                }
            }
        }
        class Product
        {
            public string name;
            public string catagory;
            public int price;

            public Product()
            {

            }

            public Product(string name, string catagory, int price)
            {
                this.name = name;
                this.catagory = catagory;
                this.price = price;
            }
            public Product(string name)
            {
                this.name = name;
            }

            public Product buyProduct(List<Product> products)
            {
                Product a = new Product();
                Console.WriteLine("ENTER THE NAME OF THE PRODUCT : ");
                a.name = Console.ReadLine();

                Console.WriteLine("ENTER THE catagory OF THE PRODUCT : ");
                a.catagory = Console.ReadLine();

                Console.WriteLine("ENTER THE price OF THE PRODUCT : ");
                a.price = int.Parse(Console.ReadLine());

                for (int idx = 0; idx < products.Count; idx++)
                {

                    if (a.name == products[idx].name && a.catagory == products[idx].catagory && a.price == products[idx].price)
                    {
                        Console.WriteLine("Your product is purchased!");

                        products.RemoveAt(idx);
                        break;
                    }
                }
                return a;
            }



        }

        static int menu()
        {
            int option = 0;
            Console.WriteLine("1.ADD Product");
            Console.WriteLine("2.VIEW Product");
            Console.WriteLine("3.ADD CUSTOMER");
            Console.WriteLine("4.BUY ProductS");
            Console.WriteLine("5.GET ALL ProductS");
            Console.WriteLine("6.CALCULATE TAX");
            Console.WriteLine("7.EXIT");
            Console.WriteLine("Enter option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static Customer take_Customer_Info(Customer a)
        {
            Console.WriteLine("What is your name : ");
            a.Customer_Name = Console.ReadLine();
            Console.WriteLine("What is your adress : ");
            a.Customer_Adress = Console.ReadLine();
            Console.WriteLine("What is your contact number : ");
            a.Customer_Contact = Console.ReadLine();
            return a;
        }

        static Product Products_info(List<Product> products)
        {
            Console.WriteLine("Enter the name of the product: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the catagory of the product: ");
            string catagory = Console.ReadLine();
            Console.WriteLine("Enter the price of the product: ");
            int price = int.Parse(Console.ReadLine());

            Product pro = new Product(name, catagory, price);
            products.Add(pro);

            return pro;
        }
        static void viewProduct(List<Product> products)
        {
            for (int idx = 0; idx < products.Count; idx++)
            {
                Console.WriteLine("The product {0} has catagory {1} with price {2} ", products[idx].name, products[idx].catagory, products[idx].price);
            }

        }


        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product p = new Product();
            Customer c = new Customer();

            Console.Clear();
            int Menu_Option = 0;
            Console.Clear();

            do
            {
                Console.Clear();
                Menu_Option = menu();
                if (Menu_Option == 1)
                {
                    Console.Clear();
                    p = Products_info(products);
                }

                if (Menu_Option == 2)
                {
                    Console.Clear();
                    viewProduct(products);
                }

                if (Menu_Option == 3)
                {
                    Console.Clear();
                    c = take_Customer_Info(c);
                }

                if (Menu_Option == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Here you can see all the products available in store....");
                    viewProduct(products);
                    p = p.buyProduct(products);

                }

                if (Menu_Option == 5)
                {
                    c.getAllProducts(products);
                }
                Console.ReadKey();

            } while (Menu_Option < 7);
        }

        static float calculatetax(List<Product> products)
        {
            float tax = 0;
            int position = 0;
            Console.WriteLine("Enter the position of the product you want to calculate tax : ");
            position = int.Parse(Console.ReadLine());
            string price = Console.ReadLine();
            for (int idx = 0; idx < products.Count; idx++)
            {
                if (idx == position)
                {
                    return (tax = products[idx].price * 0.25F);
                    products.RemoveAt(idx);
                }
            }

            return 0;
        }
    }
}