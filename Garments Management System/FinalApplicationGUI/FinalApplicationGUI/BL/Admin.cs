using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.BL
{
    class Admin : MUser//MUser as A Admin (Child Class)
    {
        private List<pro_duct> products;
        private List<string> feedback;
        public Admin(string name, string password, string role) : base(name, password, role)//Constructors for initiallizing the List
        {
            products = new List<pro_duct>();
            feedback = new List<string>();
        }
        public Admin()
        {

        }
        public Admin(string name, string password) : base(name,password)//Constructors for taking the name and Password as a parameter from pArent Class
        {
            this.name = name;
            this.password = password;
        }
        //Funstion tto add feedbacks into tthe List
        public void addFeedback(string F)
        {
            feedback.Add(F);
        }
        //Getter setterof the List of FeedBack
        public void setFeedback(List<string> feedback)
        {
            this.feedback = feedback;
        }
        public List<string> getAllFeedback()
        {
            return feedback;
        }
        //Function to Add Products Into List
        public void addProducts(pro_duct F)
        {
            products.Add(F);
        }
        //Getter setter of the List of Products
        public void setAllProducts(List<pro_duct> products)
        {
            this.products = products;
        }
        public List<pro_duct> getAllProducts()
        {
            return products;
        }
        //Function to Add Products Into List
        public void addDiscount(pro_duct F)
        {
            products.Add(F);
        }
        //Getter setter of the List of Discount's List
        public void setDiscount(List<pro_duct> products)
        {
            this.products = products;
        }
        public List<pro_duct> getDiscount()
        {
            return products;
        }
        //Function to Add Bill of the Every Customer in List
        public void makeBill(pro_duct F)
        {
            products.Add(F);
        }
        //Getter  Setter of the Bill
        public void setBill(List<pro_duct> products)
        {
            this.products = products;
        }
        public List<pro_duct> getBill()
        {
            return products;
        }
        //PolyMorphism in the Role
        public override void setRole(string role)
        {
            this.role = "admin";
        }

        //Return Role of the Admin
        public override string getRole()
        {
            return role;
        }
    }
}
