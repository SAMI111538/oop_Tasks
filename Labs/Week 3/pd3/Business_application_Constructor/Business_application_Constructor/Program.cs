using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Business_Application_Constructor
{
    class Program
    {
        class MUser
        {
            public string name;
            public string password;
            public string role;
            public MUser(string name, string password)
            {
                this.name = name;
                this.password = password;
            }
            public MUser()
            {

            }
            public MUser(string name, string password, string role)
            {
                this.name = name;
                this.password = password;
                this.role = role;
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

        class pro_duct
        {
            public string pro_Name;
            public int pro_Price;
            public int pro_Stock;
            public double discount;
            public int quantity;
            public double Bill;

            public pro_duct()
            {

            }
            public pro_duct(string pro_Name, int pro_Price, int pro_Stock)
            {
                this.pro_Name = pro_Name;
                this.pro_Price = pro_Price;
                this.pro_Stock = pro_Stock;
            }
            public pro_duct(string pro_Name, int pro_Price, int pro_Stock, double discount)
            {
                this.pro_Name = pro_Name;
                this.pro_Price = pro_Price;
                this.pro_Stock = pro_Stock;
                this.discount = discount;
            }


            public pro_duct(string pro_Name, int pro_Price)
            {
                this.pro_Name = pro_Name;
                this.pro_Price = pro_Price;
            }


            public pro_duct(int pro_Price, int pro_Stock)
            {
                this.pro_Price = pro_Price;
                this.pro_Stock = pro_Stock;
            }



        }
        static void Main(string[] args)
        {
            List<MUser> users = new List<MUser>();
            List<pro_duct> products = new List<pro_duct>();
            List<string> feedbacks = new List<string>();
            string path = @"C:\Users\AL-FATAH LAPTOP\OneDrive\Desktop\i.txt";
            string path1 = @"C:\Users\AL-FATAH LAPTOP\OneDrive\Desktop\data.txt";
            int option;
            bool check = readData(path, users);
            if (check)
                Console.WriteLine("Data Loaded SuccessFully");
            else
                Console.WriteLine("Data Not Loaded");

            bool check1 = readProductData(path1, products);
            if (check)
            {
                Console.WriteLine("pro_Data Loaded SuccessFully");
            }
            else
            {
                Console.WriteLine("p_Data Not Loaded");
            }
            Console.ReadKey();
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    MUser user = takeInputWithRole();
                    if (user != null)
                    {
                        storeDataInFile(path, user);
                        storeDataInList(users, user);
                    }
                }
                else if (option == 2)
                {
                    MUser user = takeInputWithoutRole();
                    if (user != null)
                    {
                        user = signIn(user, users);
                        if (user == null)
                            Console.WriteLine("Invalid User");
                        else if (user.isAdmin())
                        {
                            Console.WriteLine("Admin Menu");
                            adminInterface(path1, products, feedbacks, users);
                        }
                        else if (user.isCustomer())
                        {
                            Console.WriteLine("Customer Menu");
                            customerInterface(products, users, feedbacks);
                        }
                        else
                        {
                            Console.WriteLine("InValid Input");
                        }
                    }


                }
                Console.ReadKey();
            }
            while (option < 3);
        }

        static int menu()
        {
            int option;
            Console.WriteLine("1. SignUp");
            Console.WriteLine("2. SignIn");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static bool readData(string path, List<MUser> users)

        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    MUser user = new MUser(name, password, role);
                    storeDataInList(users, user);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length;
            x++)

            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        static MUser takeInputWithoutRole()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if (name != null && password != null)
            {
                MUser user = new MUser(name, password);
                return user;
            }
            return null;

        }

        static MUser takeInputWithRole()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Role: ");
            string role = Console.ReadLine();
            if (name != null && password != null && role != null)
            {
                MUser user = new MUser(name, password, role);
                return user;
            }
            return null;
        }

        static void storeDataInList(List<MUser> users, MUser user)
        {
            users.Add(user);
        }

        static void storeDataInFile(string path, MUser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.name + "," + user.password + "," + user.role);
            file.Flush();
            file.Close();
        }

        static MUser signIn(MUser user, List<MUser> users)
        {
            foreach (MUser storedUser in users)
            {
                if (user.name == storedUser.name && user.password == storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }

        static int adminMenu()
        {
            Console.Clear();
            int i = 0;
            int option = 0;
            Console.WriteLine(" SLECT ONE OF THE FOLLOWING OPTIONS--------- ");
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.View Product");
            Console.WriteLine("3.Update Price of Product");
            Console.WriteLine("4.Delete Product	");
            Console.WriteLine("5.Give Discount");
            Console.WriteLine("6.Sort Data In List(Most Expensive Product)");
            Console.WriteLine("7.Most Sold Product");
            Console.WriteLine("8.Calculate Bill");
            Console.WriteLine("9.View Customer's Reviews");
            Console.WriteLine("10.Change Password");
            Console.WriteLine("10.Exit ");
            Console.WriteLine("Your Option.....");
            while (!(option >= 1 && option <= 11) && (i <= 3))
            {
                option = int.Parse(Console.ReadLine());
                if (option >= 1 && option <= 11)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Option is not Valid! ");
                }
                i++;
            }
            return option;
        }
        static void adminInterface(string path1, List<pro_duct> products, List<string> feedbacks, List<MUser> users)
        {
            int adminOption = 0;
            do
            {
                adminOption = adminMenu();
                pro_duct f = new pro_duct();
                MUser s = new MUser();
                if (adminOption == 1)
                {
                    Console.Clear();
                    Console.WriteLine("<<<--------ADD NEW PRODUCT------->>>");
                    pro_duct pro = takeInputProduct(path1, products);
                    store_Data_In_File(path1, pro);
                    storeProductDataInList(products, pro);
                    Console.ReadKey();
                }
                else if (adminOption == 2)
                {
                    view_Product(products);

                }
                if (adminOption == 3)
                {
                    updateProducts(products);
                }
                if (adminOption == 4)
                {
                    deleteProduct(products);

                }
                if (adminOption == 5)
                {
                    Discount(products, f);
                }
                if (adminOption == 6)
                {
                    sorting(products);
                    Console.ReadKey();
                }
                if (adminOption == 7)
                {
                    Most_Popular_Product(SortByQuntity(products));
                    Console.ReadKey();
                }
                if (adminOption == 8)
                {
                    billsCheck(products);
                    Console.ReadKey();
                }
                if (adminOption == 9)
                {
                    View_Customers_Reviews(feedbacks, s);
                    Console.ReadKey();
                }
                if (adminOption == 10)
                {
                    changePassword1(users, s);
                }
                if (adminOption == 11)
                {
                    break;
                }
            }
            while (adminOption < 11);
            Console.ReadKey();
        }
        static pro_duct takeInputProduct(string path1, List<pro_duct> products)
        {
            Console.Write("ENTER THE Name OF THE PRODUCT : ");
            string pro_Name = Console.ReadLine();
            Console.Write("ENTER THE Price OF THE PRODUCT : ");
            int pro_Price = int.Parse(Console.ReadLine());
            Console.Write("ENTER THE STOCK OF THE PRODUCT :");
            int pro_Stock = int.Parse(Console.ReadLine());
            if (pro_Name != null && pro_Price > 0 && pro_Stock > 0)
            {
                pro_duct pro = new pro_duct(pro_Name, pro_Price, pro_Stock);
                //store_Data_In_File(path1, pro);
                return pro;
            }
            return null;
        }

        static void store_Data_In_File(string path1, pro_duct pro)
        {
            StreamWriter myfile = new StreamWriter(path1, true);
            myfile.WriteLine(pro.pro_Name + "," + pro.pro_Price + "," + pro.pro_Stock);
            myfile.Flush();
            myfile.Close();
        }

        static bool readProductData(string path1, List<pro_duct> products)
        {
            if (File.Exists(path1))
            {
                StreamReader fileVariable = new StreamReader(path1);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string pro_Name = parseData(record, 1);
                    int pro_Price = int.Parse(parseData(record, 2));
                    int pro_Stock = int.Parse(parseData(record, 3));
                    pro_duct pro = new pro_duct(pro_Name, pro_Price, pro_Stock);
                    storeProductDataInList(products, pro);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        static void storeProductDataInList(List<pro_duct> products, pro_duct pro)
        {
            products.Add(pro);
        }

        static void view_Product(List<pro_duct> products)
        {
            Console.Clear();
            Console.WriteLine("Name \t\t " + ":" + " Price \t\t" + ":" + "Stock\t\t" + ":" + "Discount\t\t");
            foreach (pro_duct storedUser in products)
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3}", storedUser.pro_Name, storedUser.pro_Price, storedUser.pro_Stock, storedUser.discount);
            }
            Console.ReadKey();
        }

        static void updateProducts(List<pro_duct> products)
        {
            Console.Clear();
            bool flag = false;
            int index;
            Console.WriteLine("Enter the index of product you want to change");
            index = int.Parse(Console.ReadLine());
            foreach (pro_duct storedUser in products)
            {
                if (index <= products.Count)
                {
                    flag = true;
                }

                if (flag == true)
                {
                    Console.WriteLine("Enter the new price of the product.");
                    int Price = int.Parse(Console.ReadLine());
                    storedUser.pro_Price = Price;
                    Console.WriteLine("Enter the new stock of the product.");
                    int Stock = int.Parse(Console.ReadLine());
                    storedUser.pro_Stock = Stock;
                    break;
                }
                if (flag == false)
                {
                    Console.WriteLine("Product doesnot exist");
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            }

        }

        static void deleteProduct(List<pro_duct> products)
        {
            int index;
            Console.WriteLine("Enter the index of product you want to delete");
            index = int.Parse(Console.ReadLine());
            products.RemoveAt(index);
        }

        static string changePassword1(List<MUser> users, MUser u)
        {
            bool flag = false;
            Console.WriteLine("ENTER THE USER NAME = ");
            string username = Console.ReadLine();

            Console.WriteLine("ENTER THE OLD PASSWORD = ");
            string oldPassword = Console.ReadLine();

            foreach (MUser s in users)
            {
                if ((s.name == username) && (s.role == "Admin" || s.role == "admin") && (s.password == oldPassword))
                {
                    flag = true;
                    u = s;
                }
            }
            if (flag)
            {
                Console.WriteLine("ENTER YOUR NEW PASSWORD : ");
                string newPassword = Console.ReadLine();
                u.password = newPassword;
                Console.WriteLine("YOU HAVE CHANGED THE PASSWORD SUCCESSFULLY!");
                return u.password;
            }
            else if (!flag)
            {
                Console.WriteLine("SORRY!YOU HAVE ENTERED WRONG PASSWORD....");
            }

            return null;
        }
        static void sorting(List<pro_duct> products)
        {
            List<pro_duct> sortedList = products.OrderByDescending(o => o.pro_Price).ToList();
            Console.WriteLine("Product Name " + " : " + "Product Price " + " : " + "Product Stock" + " : " + "Product Discount");
            foreach (pro_duct storedUser in sortedList)
            {
                Console.WriteLine(storedUser.pro_Name + "             :     " + storedUser.pro_Price + "         :  " + storedUser.pro_Stock + "     :     " + storedUser.discount);
            }
        }

        static double Discount(List<pro_duct> products, pro_duct c)
        {
            bool flag_discount = false;
            string temp_name = "";
            Console.Clear();
            Console.WriteLine("Product Name " + " : " + "Product Price " + " : " + "Product Stock" + " : " + "Product Discount");
            foreach (pro_duct storedUse in products)
            {
                Console.WriteLine(storedUse.pro_Name + "             :     " + storedUse.pro_Price + "         :  " + storedUse.pro_Stock + "     :     " + storedUse.discount);
            }
            Console.WriteLine("Enter the name of the product you wanna give discount on: ");
            temp_name = Console.ReadLine();

            foreach (pro_duct p in products)
            {

                if (temp_name == p.pro_Name)
                {
                    flag_discount = true;
                    c = p;
                    break;
                }
            }

            if (flag_discount == true)
            {
                Console.WriteLine("Enter the discount:  ");
                double discount1 = double.Parse(Console.ReadLine());
                c.discount = discount1;
                return c.discount;
            }
            else if (flag_discount == false)
            {
                Console.WriteLine("Item don't exist");
            }
            return 0;

        }

        static double billsCheck(List<pro_duct> products)
        {
            foreach (pro_duct p in products)
            {
                if (p.quantity != 0)
                {
                    Console.WriteLine("The Product : " + p.pro_Name + "with the Quantity : " + p.quantity + "with the Price : " + p.pro_Price + "is Added Into The Cart ");
                }
            }

            int price;
            double total_Bill = 0;
            foreach (pro_duct p in products)
            {
                if (p.quantity > 0)
                {
                    p.discount = p.quantity * p.pro_Price * (p.discount / 100);
                    price = p.pro_Price * p.quantity;
                    p.Bill = price - p.discount;

                    if (p.Bill != 0)
                    {
                        Console.WriteLine("<<<YOUR Bill OF.... : " + p.pro_Name + "with Price " + p.pro_Price + " IS : " + p.Bill);
                    }
                    total_Bill = total_Bill + p.Bill;
                }
            }
            Console.WriteLine("YOUR TOTAL BILL IS : " + total_Bill);
            return total_Bill;

        }

        static void View_Customers_Reviews(List<string> feedbacks, MUser s)
        {
            Console.WriteLine("<<<<<<<<<<<<<The feedback of the Customer >>>>>>>>>>>>>>");

            for (int idx = 0; idx < feedbacks.Count; idx++)
            {
                Console.WriteLine(feedbacks[idx]);
            }
        }

        static void View_Products_Available(List<pro_duct> products)
        {
            foreach (pro_duct b in products)
            {
                Console.WriteLine("The Product " + b.pro_Name + " with price " + b.pro_Price + " and Stock of " + b.pro_Stock + " having dicount of " + b.discount + "%");
            }
        }

        static List<pro_duct> SortByQuntity(List<pro_duct> products)
        {
            List<pro_duct> sortedList1 = products.OrderByDescending(o => o.quantity).ToList();
            return sortedList1;

        }
        static void Most_Popular_Product(List<pro_duct> products)
        {
            Console.WriteLine("NAME\tQUANTITY");
            foreach (pro_duct p in products)
            {
                Console.WriteLine(p.pro_Name + "\t" + p.quantity);
            }
        }
        static void Popular_Product(List<pro_duct> products)
        {
            Console.WriteLine("NAME\tQUANTITY");
            Console.WriteLine(products[0].pro_Name + "\t" + products[0].quantity);
        }

        static int customerMenu()
        {
            int option;
            Console.WriteLine(" SLECT ONE OF THE FOLLOWING OPTION' --------- ");
            Console.WriteLine(" 1.View Product");
            Console.WriteLine(" 2.View Popular  r4Products");
            Console.WriteLine(" 3.Add to cart");
            Console.WriteLine(" 4.Remove Product from the cart");
            Console.WriteLine(" 5.Bills");
            Console.WriteLine(" 6.Change Password");
            Console.WriteLine(" 7.Feedback");
            Console.WriteLine(" 8.FulfillOrder");
            Console.WriteLine(" 9.Exit");
            Console.WriteLine("Your Option... ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void customerInterface(List<pro_duct> products,  List<MUser> users, List<string> feedbacks)
        {
            int userOption = 0;
            MUser u = new MUser();
            do
            {
                Console.Clear();
                userOption = customerMenu();
                Console.Clear();
                if (userOption == 1)
                {
                    Console.Clear();
                    View_Products_Available(products);
                    Console.ReadKey();
                }
                if (userOption == 2)
                {
                    Popular_Product(SortByQuntity(products));
                    Console.ReadKey();
                }
                if (userOption == 3)
                {
                    Console.Clear();
                    add_To_Cart(products);
                }
                if (userOption == 4)
                {
                    Console.Clear();
                    Remove_From_Cart(products);
                }
                if (userOption == 5)
                {
                    Console.Clear();
                    double result = 0;
                    viewBill(result);
                    Console.ReadKey();
                }
                if (userOption == 6)
                {
                    Console.Clear();
                    change_Customer_Password(users, u);
                    Console.ReadKey();
                }
                if (userOption == 7)
                {
                    Console.Clear();
                    Give_feedBack_On_Product(feedbacks);
                    Console.ReadKey();
                }
                if (userOption == 8)
                {
                    Console.Clear();
                    Give_feedBack_On_Product(feedbacks);
                    Console.ReadKey();
                }
                if (userOption == 9)
                {
                    break;
                }
            }
            while (userOption != 11);
            Console.ReadKey();
            Console.Clear();
        }

        static void add_To_Cart(List<pro_duct> products)
        {
            int index = 0;

            while (index != products.Count)
            {
                foreach (pro_duct p in products)
                {
                    Console.WriteLine("The Name Of the Product is " + p.pro_Name + " with Price " + p.pro_Price + " and Stock of " + p.pro_Stock + "With the Discount of " + p.discount);
                }

                Console.WriteLine("Do you want to add product in cart (yes/no): ");
                string press = Console.ReadLine();

                if (press == "yes" || press == "Yes")
                {
                    Console.WriteLine("ENTER THE NAME OF THE PRODUCT : ");
                    string name = Console.ReadLine();

                    Console.WriteLine("ENTER  THE QUANTITY OF PRODUCT TO ADD IN YOUR CART : ");
                    int stockToAddCart = int.Parse(Console.ReadLine());

                    foreach (pro_duct p in products)
                    {
                        if (name == p.pro_Name)
                        {
                            p.quantity = stockToAddCart;
                            p.pro_Stock = p.pro_Stock - p.quantity;
                        }
                    }

                    for (int idx = 0; idx < products.Count; idx++)
                    {
                        if (products[idx].pro_Stock == 0)
                        {
                            products.RemoveAt(idx);
                        }
                    }
                    foreach (pro_duct p in products)
                    {
                        Console.WriteLine(p.pro_Name + " : " + p.quantity);
                    }
                }
                else if (press == "no" || press == "No")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("YOU HAVE ENTER WRONG INPUT!TRY AGAIN....");
                }
                Console.Clear();

                index++;
            }
        }
        static void Remove_From_Cart(List<pro_duct> products)
        {

            int index = 0;

            string name = null;
            while (index != products.Count)
            {
                Console.WriteLine("NAME OF THE PRODUCTS ARE ...... ");
                foreach (pro_duct p in products)
                {
                    if (p.quantity != 0)
                    {
                        Console.WriteLine("The Product : " + p.pro_Name + "with the Quantity : " + p.quantity + "with the Price : " + p.pro_Price + "is Added Into The Cart ");
                    }
                }

                Console.WriteLine("SLECT ONE OF THE ABOVE PRODUCT....");

                Console.WriteLine("Do you want to remove product in cart (yes/no): ");
                string press = Console.ReadLine();

                if (press == "yes" || press == "Yes")
                {
                    Console.WriteLine("ENTER THE NAME OF THE PRODUCT : ");
                    name = Console.ReadLine();

                }

                Console.WriteLine("ENTER  THE QUANTITY OF PRODUCT TO REMOVE IN YOUR CART : ");
                int stockToRemoveCart = int.Parse(Console.ReadLine());

                foreach (pro_duct p in products)
                {
                    int reAdd = p.pro_Stock + stockToRemoveCart;
                    if (reAdd > p.pro_Stock)
                    {
                        Console.WriteLine("SORRY! YOUR INPUT IS EXCEEDED TO THE ORIGINAL STOCK ....   ");
                        break;
                    }
                    else if (reAdd < p.pro_Stock)
                    {

                        p.quantity = stockToRemoveCart;
                        if (p.pro_Name == name)
                        {
                            p.pro_Stock = p.pro_Stock + p.quantity;
                            Console.WriteLine(p.pro_Name + " : " + p.quantity);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("YOU HAVE ENTER WRONG INPUT!TRY AGAIN....");
                            break;
                        }
                    }
                }

                if (press == "no" || press == "No")
                {
                    break;
                }
                index++;
                Console.Clear();
            }
        }

        static void viewBill(double total_Bill)
        {
            Console.WriteLine("YOUR TOTAL BILL IS : " + total_Bill);
        }

        static string change_Customer_Password(List<MUser> users, MUser u)
        {
            bool flag = false;
            Console.WriteLine("ENTER THE USER NAME = ");
            string username = Console.ReadLine();

            Console.WriteLine("ENTER THE OLD PASSWORD = ");
            string oldPassword = Console.ReadLine();

            foreach (MUser s in users)
            {
                if ((s.name == username) && (s.role == "Customer" || s.role == "customer") && (s.password == oldPassword))
                {
                    flag = true;
                    u = s;
                }
            }
            if (flag)
            {
                Console.WriteLine("ENTER YOUR NEW PASSWORD : ");
                string newPassword = Console.ReadLine();
                u.password = newPassword;
                Console.WriteLine("YOU HAVE CHANGED THE PASSWORD SUCCESSFULLY!");
                return u.password;
            }
            else if (!flag)
            {
                Console.WriteLine("SORRY!YOU HAVE ENTERED WRONG PASSWORD....");
            }

            return null;
        }


        static List<string> Give_feedBack_On_Product(List<string> feedbacks)
        {

            Console.WriteLine("Enter YOUR FEEDBACK ON PRODUCT:");
            string feedback = Console.ReadLine();
            feedbacks.Add(feedback);

            Console.WriteLine("THANKS FOR LEAVING YOUR REVIEW ON OUR PRODUCTS....!");
            return feedbacks;
        }
    }
}
