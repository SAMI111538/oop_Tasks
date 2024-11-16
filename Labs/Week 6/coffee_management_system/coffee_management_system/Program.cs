using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_management
{
    class Program
    {
        class MenuItem
        {
            public string itemName;
            public string type;
            public int price;

            public MenuItem(string name, string type, int price)
            {
                this.itemName = name;
                this.type = type;
                this.price = price;
            }
        }

        class CoffeeShop
        {
            public string shopName;
            public static List<MenuItem> menu = new List<MenuItem>();
            public static List<string> orders = new List<string>();

            public CoffeeShop(string shopName)
            {
                this.shopName = shopName;
            }



        }

        static void Main(string[] args)
        {
            int option;
            int total = 0;
            do
            {
                Console.Clear();
                option = menu();
                if (option == 1)
                {
                    Console.Clear();
                    MenuItem m = addMenuItem();
                    addItemIntoList(m);
                }

                else if (option == 2)
                {
                    Console.Clear();
                    string n = viewCheapestItem();
                    Console.WriteLine("CHEAPEST ITEM IS: {0}", n);
                }

                else if (option == 3)
                {
                    Console.Clear();
                    viewDrinksMenu();
                }

                else if (option == 4)
                {
                    Console.Clear();
                    viewFoodMenu();
                }

                else if (option == 5)
                {
                    Console.Clear();
                    string name = addOrder();
                    addOrdersIntoList(name);
                }

                else if (option == 6)
                {
                    Console.Clear();
                    total = fulfillOrders();
                }

                else if (option == 7)
                {
                    Console.Clear();
                    viewOrders();
                }

                else if (option == 8)
                {
                    Console.Clear();
                    dueAmount(total);
                }

                Console.ReadKey();
            } while (option != 9);

        }

        static int menu()
        {
            Console.WriteLine("--> WELCOME TO TESHA'S COFFEE SHOP");
            Console.WriteLine("");
            Console.WriteLine("1.Add a Menu item");
            Console.WriteLine("2.View the Cheapest Item in the menu");
            Console.WriteLine("3.View the Drink’s Menu");
            Console.WriteLine("4.View the Food’s Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("7.View the Orders’s List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.WriteLine("");
            Console.Write("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        static MenuItem addMenuItem()
        {
            Console.Write("ENTER THE NAME OF THE ITEM: ");
            string name = Console.ReadLine();
            Console.Write("ENTER THE TYPE OF THE ITEM: ");
            string type = Console.ReadLine();
            Console.Write("ENTER THE PRICE OF THE ITEM: ");
            int price = int.Parse(Console.ReadLine());
            MenuItem i = new MenuItem(name, type, price);
            return i;
        }

        static void addItemIntoList(MenuItem i)
        {

            CoffeeShop.menu.Add(i);
        }



        static void viewDrinksMenu()
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

        static void viewFoodMenu()
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

        static string viewCheapestItem()
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

        static void addOrdersIntoList(string name)
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

        static void viewOrders()
        {
            Console.WriteLine("--> ORDERS");
            foreach (String o in CoffeeShop.orders)
            {
                Console.WriteLine(o);
            }
        }
        static int fulfillOrders()
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

        static void dueAmount(int total)
        {
            Console.WriteLine("YOUR TOTAL IS: {0}", total);
        }
    }
}