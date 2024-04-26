using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6_CHALLANGE1_Coffee.BL;
using Lab6_CHALLANGE1_Coffee.DL;

namespace Lab6_CHALLANGE1_Coffee.UI
{
    class take_input
    {
        public static int menu()
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

        public static MenuItem addMenuItem()
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

        public static string addOrder()
        {
            Console.Write("ENTER THE NAME OF THE ITEM YOU WANT TO ORDER: ");
            string name = Console.ReadLine();
            return name;

        }
    }
}
