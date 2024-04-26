using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6_CHALLANGE1_Coffee.BL;
using Lab6_CHALLANGE1_Coffee.UI;

namespace Lab6_CHALLANGE1_Coffee.DL
{
    class data
    {
        public static string viewCheapestItem()
        {
            int cheap = CoffeeShop.menu[0].price;
            string name = CoffeeShop.menu[0].itemName;
            foreach (MenuItem m in CoffeeShop.menu)
            {
                if (m.price < cheap)
                {
                    cheap = m.price;
                    name = m.itemName;
                }
            }
            return name;
        }

        static string addOrder()
        {
            Console.Write("ENTER THE NAME OF THE ITEM YOU WANT TO ORDER: ");
            string name = Console.ReadLine();
            return name;

        }

        public static void addOrdersIntoList(string name)
        {
            foreach (MenuItem m in CoffeeShop.menu)
            {
                if (m.itemName == name)
                {
                    Console.WriteLine("THE " + name + " IS AVAILABLE.");
                    CoffeeShop.orders.Add(name);
                }

                else
                {
                    Console.WriteLine("THE ITEM IS CURRENTLY UNAVAILABLE.");
                }
            }
        }

        public static void viewOrders()
        {
            Console.WriteLine("--> ORDERS");
            foreach (String o in CoffeeShop.orders)
            {
                Console.WriteLine(o);
            }
        }
        public static int fulfillOrders()
        {
            int total = 0;

            if (CoffeeShop.orders != null)
            {
                for (int idx = 0; idx < CoffeeShop.orders.Count; idx++)
                {
                    Console.WriteLine("The " + CoffeeShop.orders[idx] + " is ready.");
                    foreach (MenuItem m in CoffeeShop.menu)
                    {
                        if (CoffeeShop.orders[idx] == m.itemName)
                        {
                            total = total + m.price;
                        }

                    }
                    CoffeeShop.orders.Remove(CoffeeShop.orders[idx]);
                }
            }

            else if (CoffeeShop.orders == null)
            {
                Console.WriteLine("ALL ORDERS HAVE BEEN FULFILLED.");
            }
            return total;
        }

        public static void dueAmount(int total)
        {
            Console.WriteLine("YOUR TOTAL IS: {0}", total);
        }


        public static void addItemIntoList(MenuItem i)
        {

            CoffeeShop.menu.Add(i);
        }



        public static void viewDrinksMenu()
        {
            foreach (MenuItem m in CoffeeShop.menu)
            {
                if (m.type == "drink")
                {
                    Console.WriteLine("ITEM: {0}", m.itemName);
                    Console.WriteLine("PRICE: {0}", m.price);
                }
            }
        }

        public static void viewFoodMenu()
        {
            foreach (MenuItem m in CoffeeShop.menu)
            {
                if (m.type == "food")
                {
                    Console.WriteLine("ITEM: {0}", m.itemName);
                    Console.WriteLine("PRICE: {0}", m.price);
                }
            }
        }

    }
}
