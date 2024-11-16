using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.BL
{
    class MUser
    {
        protected string name;
        protected string password;
        protected string role;
        public MUser() { }
        public MUser(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

        public MUser(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public virtual void setRole(string role)
        {
            this.role = role;
        }
        public virtual string getRole()
        {
            return role;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name; ;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
             this.password = password;
        }

        public bool isAdmin()
        {
            if (role == "Admin" || role == "admin")
            {
                return true;
            }
            return false;
        }

        public bool isCustomer()
        {
            if (role == "Customer" || role == "customer")
            {
                return true;
            }
            return false;
        }
    }
}
