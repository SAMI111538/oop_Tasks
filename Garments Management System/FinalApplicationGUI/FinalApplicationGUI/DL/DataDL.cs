using FinalApplicationGUI.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.DL
{
    class DataDL
    {
        private static string option;
        private static string adminOption;
        private static string customerOption;
        private static string path;
        private static string path1;
        private static bool check;
        private static bool check1;
        private static MUser signUp;
        private static MUser signIn;
        private static bool flag;
        private static bool flag1;
        private static double total;
        public static Customer customer;

        public static void SetOption(string option1)
        {
            option = option1;
        }

        public static string GetOption()
        {
            return option;
        }

        public static void SetAdminOption(string adminOption1)
        {
            adminOption = adminOption1;
        }

        public static string GetAdminOption()
        {
            return adminOption;
        }

        public static void SetCustomerOption(string customerOption1)
        {
            customerOption = customerOption1;
        }

        public static string GetCustomerOption()
        {
            return customerOption;
        }

        public static void SetUsersPath(string path1)
        {
            path = path1;
        }
        public static string GetUsersPath()
        {
            return path;
        }

        public static void SetProductsPath(string path2)
        {
            path1 = path2;
        }
        public static string GetProductsPath()
        {
            return path1;
        }

        public static void SetCheck(bool check1)
        {
            check = check1;
        }

        public static bool GetCheck()
        {
            return check;
        }

        public static void SetCheck1(bool check2)
        {
            check1 = check2;
        }

        public static bool GetCheck1()
        {
            return check1;
        }

        public static void SetSignUpObject(MUser u)
        {
            signUp = u;
        }

        public static MUser GetSignUpObject()
        {
            return signUp;
        }

        public static void SetSignInObject(MUser s)
        {
            signIn = s;
        }

        public static MUser GetSignInObject()
        {
            return signIn;
        }

        public static void SetFlag(bool flag1)
        {
            flag = flag1;
        }

        public static bool GetFlag()
        {
            return flag;
        }

        public static void SetFlag1(bool flag2)
        {
            flag1 = flag2;
        }

        public static bool GetFlag1()
        {
            return flag1;
        }

        public static void SetTotal(double total1)
        {
            total = total1;
        }

        public static double GetTotal()
        {
            return total;
        }

        public static void AddCustomerObject(Customer c)
        {
            customer = c;
        }

        public static MUser GetCustomerObject()
        {
            return customer;
        }
    }
}
