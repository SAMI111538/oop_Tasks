using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_CHALLANGE1_Coffee.BL
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
}
