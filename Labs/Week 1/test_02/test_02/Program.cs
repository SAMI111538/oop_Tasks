using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2_1
{
    class Program
    {
        class product
        {
            public string ID;
            public string name;
            public int price;
            public string Category;
            public string BrandName;
            public string Country;

        }
        static void Main(string[] args)
        {
            product[] pdt = new product[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    pdt[count] = addProduct();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    view_Product(pdt, count);
                }

                else if (option == '3')
                {
                    int result = Total_Worth(pdt, count);
                    Console.WriteLine("Your total worth is : " + result);
                    Console.ReadKey();
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            while (option != 4);
            Console.WriteLine("Press Enter To Exit");
            Console.ReadKey();

        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press1 for Adding Product");
            Console.WriteLine("Press2 for for Viewing Product");
            Console.WriteLine("Press3 for Total Store Worth");
            Console.WriteLine("Press4 for to exit.");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static product addProduct()
        {
            Console.Clear();
            product pdt = new product();
            Console.WriteLine("Enter The Product Name : ");
            pdt.name = Console.ReadLine();
            Console.WriteLine("Enter Product ID. : ");
            pdt.ID = Console.ReadLine();
            Console.WriteLine("Enter price : ");
            pdt.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category : ");
            pdt.Category = Console.ReadLine();
            Console.WriteLine("Enter BrandName : ");
            pdt.BrandName = Console.ReadLine();
            Console.WriteLine("Enter Country : ");
            pdt.Country = Console.ReadLine();
            return pdt;

        }
        static void view_Product(product[] pdt, int count)
        {
            Console.Clear();
            for (int idx2 = 0; idx2 < count; idx2++)
            {
                Console.WriteLine("Name : {0}  ID : {1}  Price : {2} Category : {3} BrandName : {4} Country : {5}", pdt[idx2].name, pdt[idx2].ID, pdt[idx2].price, pdt[idx2].Category, pdt[idx2].BrandName, pdt[idx2].Country);
            }
            Console.WriteLine("Press any Key To Continue !");
            Console.ReadKey();
        }
        static int Total_Worth(product[] pdt,int count)
        {
            //int product_price = start;
            int sum = 0;
            for (int index =0; index < count; index++)
            {
                sum = sum + pdt[index].price;
                
            }
            return sum;
        }


    }
}
