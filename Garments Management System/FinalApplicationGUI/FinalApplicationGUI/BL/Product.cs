using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.BL
{
    class pro_duct//Products Class
    {
        //Attributes of the class
        protected string pro_Name;
        protected double pro_Price;
        protected int    pro_Stock;
        protected double discount;
        protected int quantity;
        protected int sales_item;
        protected bool isLocal = true;
        public pro_duct(string pro_Name, int pro_Price, int pro_Stock, double discount, int quantity)//Constructors of the class ALL Attributes
        {
            this.discount = discount;
            this.pro_Name = pro_Name;
            this.pro_Price = pro_Price;
            this.pro_Stock = pro_Stock;
            this.quantity = quantity;
        }

        public pro_duct(string pro_Name, int pro_Price, int pro_Stock)//Constructors of the Class 3 Attributes of [Name,Price,Stock]
        {
            this.pro_Name = pro_Name;
            this.pro_Price = pro_Price;
            this.pro_Stock = pro_Stock;
        }
        public pro_duct()//Default Constructor of the Class
        {

        }
        //Getter Setter of the Quantity
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }
        //Getter Setter of the Name
        public void set_pro_Name(string name)
        {
            this.pro_Name = name;
        }
        public string get_pro_Name()
        {
            return pro_Name;
        }

        //Getter Setter of the Price
        public void set_pro_Price(double pro_Price)
        {
            this.pro_Price = pro_Price;
        }
        public double get_pro_Price()
        {
            return pro_Price;
        }
        //Getter Setter of the Stock
        public void set_pro_Stock(int pro_Stock)
        {
            this.pro_Stock = pro_Stock;
        }
        public int get_pro_Stock()
        {
            return pro_Stock;
        }
        //Getter Setter of the Sales_item Quantity
        public void set_Sales_item(int Sales_item)
        {
            this.sales_item = Sales_item;
        }
        public int get_Sales_item()
        {
            return sales_item;
        }

        //Getter Setter of the Add Stock in Cart nd remove stock in Cart
        public void set_pro_Stock_to_decr(int stock_buy)
        {
            this.pro_Stock = pro_Stock - stock_buy;
        }
        public void set_pro_Stock_to_rev(int stock_back)
        {
            this.pro_Stock = pro_Stock + stock_back;
        }
        
        //Getter Setter of the Discount
        public void setDiscount(double discount)
        {
            this.discount = discount;
        }
        public double getDiscount()
        {
            return discount;
        }

        //Constructors of the Class 2 Attributes of [Price,Stock]
        public pro_duct(int pro_Price, int pro_Stock)
        {
            this.pro_Price = pro_Price;
            this.pro_Stock = pro_Stock;
        }
        //Constructors of the Class 2 Attributes of [Name,Price]
        public pro_duct(string pro_Name, int pro_Price)
        {
            this.pro_Name = pro_Name;
            this.pro_Price = pro_Price;
        }


        //GETTER SETTER OF THE GET COUNTRY
        public bool getCountry()
        {
            return isLocal;
        }
        public void setCountry(bool isLocal)
        {
            this.isLocal = isLocal;
        }


    }
}
