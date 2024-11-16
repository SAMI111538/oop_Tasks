using FinalApplicationGUI.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.DL
{
    class CustomerDL
    {
        public static Customer q = new Customer();//Static Customer Object
        private static List<Customer> customersList = new List<Customer>();//List of Customer's Info
        public static void addCustomerInList(Customer temp)//Function to Store  Data In List
        {
            customersList.Add(temp);
        }

        public static List<Customer> GetCustomerList()
        {
            return customersList;
        }

        public static double showBill(string name)
        {
            double bill = -1;
            for(int x=0; x< customersList.Count; x++)
            {
                if(customersList[x].getName() == name)
                {
                    bill = customersList[x].returnBill();
                }
            }
            return bill;

        }
        public static int getLengthOfCustomerList()
        {
            return customersList.Count();
        }
        
        //get object by product name

        public static string GetCustomerID()
        {
            Random random = new Random();
            int customerId = random.Next(1000, 10000);
            return customerId.ToString();
        }
        public static Customer getParticularCustomer(string name)
        {
            foreach (Customer c in customersList)
            {   
                if(c.getName() == name)
                {
                    return c;
                }
            }
            return null;
        }
        public static void editCustomer(Customer c,string id,string address,string mail,string city,string contactNumber)
        {
            c.setID(id);
            c.setAddress(address);
            c.setMail(mail);
            c.setCity(city);
            c.setContactNumber(contactNumber);
            
            

        }
    }
}
