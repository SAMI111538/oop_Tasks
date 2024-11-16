
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.BL
{
    class Customer : MUser //Child Class for the Customer with the Parent of the MUser
    {
        //Attributes of the Class
        private List<pro_duct> Bought_Products= new List<pro_duct>();
        private string email;
        private string id;
        private string Address;
        private string city;
        private string Contact_Number;
       // private float bill;

        public double returnBill()
        {
            double bill = 0;
            double price = 0;
            for(int x=0; x<Bought_Products.Count; x++)
            {
                if (Bought_Products[x].getDiscount() != 0 )
                {
                    price = (Bought_Products[x].get_pro_Price() - Bought_Products[x].getDiscount()) * Bought_Products[x].get_pro_Stock(); 
                }
                else
                {
                    price = Bought_Products[x].get_pro_Price() * Bought_Products[x].get_pro_Stock(); 
                }
                bill = bill + price;
            }
            return bill;
        }

        public List<pro_duct> getBuyProducts()//Every Customer's OrderList
        {
            return Bought_Products;
        }
        public Customer(string name, string password, string role) : base(name, password, role)//Constructors for the Customers Input
        {
        }
        public Customer(string name, string password,string email, string id,string Address) : base(name, password)//Constructors for Adding Info of the Every New Coming Customers
        {
            this.Address = Address;
            this.email = email;
            this.id = id;
        }

        //Getter Setter for Address
        public string getAddress()
        {
            return Address;
        }
        public void setAddress(string Address)
        {
            this.Address = Address;
        }
        //Getter Setter for Mail
        public string getMail()
        {
            return email;
        }
        public void setMail(string email)
        {
            this.email = email;
        }
        //Getter Setter for ID
        public string getID()
        {
            return id;
        }
        public void setID(string id)
        {
            this.id = id;
        }
        //Getter Setter For Customer City
        public string getCity()
        {
            return city;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        
        //Getter Setter For Customer Contact No.
        public string getContactNumber()
        {
            return Contact_Number;;
        }
        public void setContactNumber(string Contact_Number)
        {
            this.Contact_Number = Contact_Number;
        }
        //Default Constructor for the Customer Class
        public Customer() {  }

        //Constructor for the Name And Password
        public Customer(string name, string password) : base()
        {
            this.name = name;
            this.password = password;
        }
        //Getter Setter For the List of the Order
        public void addbuyProduct(pro_duct F)
        {
            Bought_Products.Add(F);
        }
        public void setParticularProduct(string product,int stock)
        {
           for(int i = 0; i < Bought_Products.Count; i++)
            {
                if(Bought_Products[i].get_pro_Name() == product)
                {
                    Bought_Products[i].set_pro_Stock(stock);
                }
            }
        }
        public void removeParticularProduct(pro_duct product, int stock)
        {
            foreach (pro_duct p in Bought_Products)
            {
                if (product.get_pro_Name() == p.get_pro_Name())
                {
                    p.set_pro_Stock(p.get_pro_Stock() - stock);
                }
            }
        }
        public List<pro_duct> viewAllProducts()
        {
            return Bought_Products;
        }

        //Polymorphism for Function taking Role As Input
        //Role GEtter Setter
        public override void setRole(string role)
        {
            this.role = "customer";
        }
        public override string getRole()
        {
            return role;
        }
        public void removeOrderedProduct(pro_duct p)
        {
            Bought_Products.Remove(p);
        }
    }
}
