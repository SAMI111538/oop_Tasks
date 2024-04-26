using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6_CHALLANGE1_Coffee.BL;
using Lab6_CHALLANGE1_Coffee.UI;
using Lab6_CHALLANGE1_Coffee.DL;

namespace Lab6_CHALLANGE1_Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            int total = 0;
            do
            {
                Console.Clear();
                option = take_input.menu();
                if (option == 1)
                {
                    Console.Clear();
                    MenuItem m = take_input.addMenuItem();
                    data.addItemIntoList(m);
                }

                else if (option == 2)
                {
                    Console.Clear();
                    string n = data.viewCheapestItem();
                    Console.WriteLine("CHEAPEST ITEM IS: {0}", n);
                }

                else if (option == 3)
                {
                    Console.Clear();
                    data.viewDrinksMenu();
                }

                else if (option == 4)
                {
                    Console.Clear();
                    data.viewFoodMenu();
                }

                else if (option == 5)
                {
                    Console.Clear();
                    string name = take_input.addOrder();
                    data.addOrdersIntoList(name);
                }

                else if (option == 6)
                {
                    Console.Clear();
                    total = data.fulfillOrders();
                }

                else if (option == 7)
                {
                    Console.Clear();
                    data.viewOrders();
                }

                else if (option == 8)
                {
                    Console.Clear();
                    data.dueAmount(total);
                }

                Console.ReadKey();
            } while (option != 9);

        }
    }
}
