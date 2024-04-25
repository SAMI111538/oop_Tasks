using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS
{

    class Program
    {

        class credential
        {
            public string name;
            public string password;
        }
        class product
        {
            public string pro_Name;
            public int pro_Price;
            public int pro_Stock;
        }


        static void Main(string[] args)
        {
            string path = "C:\\Users\\AL-FATAH LAPTOP\\OneDrive\\Desktop\\malik.txt";
            int usersCount = 0;
            int userArrSize = 100;
            int pCount = 0;
            List<credential> s = new List<credential>();
            List<product> pro = new List<product>();

            int option;
            readData(s, path, ref usersCount);

            do
            {
                Console.Clear();
                option = Menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name : ");
                    string n = Console.ReadLine();
                    bool flag = true;
                    while (flag)
                    {
                        for (int i = 0; i < n.Count(); i++)
                        {
                            if (!((n[i] >= 97 && n[i] <= 122) || (n[i] >= 65 && n[i] <= 90)))
                            {
                                Console.WriteLine("Invalid!! Enter Again : ");
                                n = Console.ReadLine();
                                break;
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                    }
                    Console.WriteLine("Enter Password : ");
                    string p = Console.ReadLine();
                    signUp(path, n, p, ref s, ref usersCount, ref userArrSize);


                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter Name : ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password : ");
                    string p = Console.ReadLine();
                    signIn(n, p, s);
                    adminInterface(path, pro, ref pCount);
                    Console.ReadKey();

                }
            }
            while (option < 4);
            Console.ReadKey();
        }

        static int Menu()
        {
            int option;
            Console.WriteLine("1.SignUp");
            Console.WriteLine("2.SignIn");
            Console.WriteLine("3.Exit the Application");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void readData(List<credential> s, string path, ref int usersCount)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    credential s1 = new credential();
                    s1.name = parseData(record, 1);
                    s1.password = parseData(record, 2);
                    s.Add(s1);
                    x++;
                    usersCount++;
                    if (usersCount > 100)
                    {
                        break;
                    }
                }

                fileVariable.Close();
            }
            else
            {
                Console.Write("No Exists");
            }
        }
        static void signIn(string n, string p, List<credential> s)
        {
            bool flag = false;
            for (int x = 0; x < 100; x++)
            {
                if (n == s[x].name && p == s[x].password)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Congrats! You are verified as a valid User");
            }
            else if (flag == false)
            {
                Console.WriteLine("Sorry! You have Enter the wrong Id");
            }
            Console.ReadKey();
        }

        static void signUp(string path, string n, string p, ref List<credential> s, ref int usersCount, ref int userArrSize)
        {

            StreamWriter myfile = new StreamWriter(path, true);
            myfile.WriteLine(n + "," + p);
            myfile.Flush();
            myfile.Close();
            if (usersCount < userArrSize)
            {
                s[usersCount] = addUserData(n, p, ref s, ref usersCount);
                usersCount++;
            }

        }
        static credential addUserData(string n, string p, ref List<credential> s, ref int usersCount)
        {
            credential s2 = new credential();
            s2.name = n;
            s2.password = p;
            return s2;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
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
            Console.WriteLine("5.Check list of Products");
            Console.WriteLine("6.Most Sold Products");
            Console.WriteLine("7.Discount");
            Console.WriteLine("8.Change Password");
            Console.WriteLine("9.Feedback ");
            Console.WriteLine("10.History ");
            Console.WriteLine("11.Exit ");
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
        static void adminInterface(string path1, List<product> pro, ref int pCount)
        {
            int adminOption = 0;
            while (true)
            {
                adminOption = adminMenu();
                if (adminOption == 1)
                {
                    Console.Clear();
                    string opt2 = "";
                    Console.WriteLine("1.ADD NEW PRODUCT");
                    Console.WriteLine("2.UPDATE STOCK");
                    Console.WriteLine("Enter your option");

                    opt2 = Console.ReadLine();
                    if (opt2 == "1")
                    {
                        addNewProduct(path1, pro, ref pCount);
                    }
                    else if (opt2 == "2")
                    {
                        addProduct(pro, ref pCount);
                    }
                    else
                    {
                        Console.Write("Wrong Input");
                    }
                    Console.ReadKey();
                }
                if (adminOption == 2)
                {
                    Console.Clear();
                    viewProduct(pro, ref pCount);
                    Console.ReadKey();
                }

                if (adminOption == 3)
                {
                    Console.Clear();
                    //updateProductPrice(pro, ref pCount);
                    Console.ReadKey();
                }

                if (adminOption == 4)
                {
                    Console.Clear();
                    string opt3 = "";
                    Console.WriteLine("1.REMOVE PRODUCT");
                    Console.WriteLine("2.REMOVE STOCK");
                    Console.WriteLine("ENTER OPTION---->>>");
                    opt3 = Console.ReadLine();
                    if (opt3 == "1")
                    {
                        //removeProductsFromArray(pro, ref pCount);
                        Console.ReadKey();
                    }
                    else if (opt3 == "2")
                    {
                        //deleteProduct(pro,ref pCount);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input!");
                        Console.ReadKey();
                    }
                }
            }
        }
        static void addNewProduct(string path1, List<product> pro, ref int pCount)
        {
            string pName = "";
            int pPrice = 0;
            int pStock = 0;
            bool flag1 = true;
            Console.Write("ENTER THE Name OF THE PRODUCT : ");
            pName = Console.ReadLine();
            while (flag1)
            {
                for (int i = 0; i < pName.Count(); i++)
                {
                    if (!((pName[i] >= 97 && pName[i] <= 122) || (pName[i] >= 65 && pName[i] <= 90)))
                    {
                        Console.WriteLine("Invalid!! Enter Again : ");
                        pName = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        flag1 = false;
                    }
                }
            }


            Console.Write("ENTER THE Price OF THE PRODUCT : ");
            pPrice = int.Parse(Console.ReadLine());

            Console.Write("ENTER THE STOCK OF THE PRODUCT :");
            pStock = int.Parse(Console.ReadLine());

            pro[pCount].pro_Name = pName;
            pro[pCount].pro_Price = pPrice;
            pro[pCount].pro_Stock = pStock;
            StreamWriter myfile = new StreamWriter(path1, true);
            myfile.WriteLine(pName + "," + pPrice + "," + pStock);
            myfile.Flush();
            myfile.Close();
            pCount++;

        }
        static void readData1(string path1, List<product> pro, ref int pCount)
        {
            int x = 0;
            if (File.Exists(path1))
            {
                StreamReader fileVariable = new StreamReader(path1);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    pro[x].pro_Name = parseData(record, 1);
                    pro[x].pro_Price = stoi(parseData(record, 2));
                    pro[x].pro_Stock = stoi(parseData(record, 3));

                    x++;
                    pCount++;
                    if (pCount > 100)
                    {
                        break;
                    }
                }

                fileVariable.Close();
            }
            else
            {
                Console.Write("No Exists");
            }
        }

        private static int stoi(string v)
        {
            throw new NotImplementedException();
        }

        static void addProduct(List<product> pro, ref int pCount)
        {
            Console.WriteLine("NAME OF THE PRODUCTS ARE ...... ");
            for (int idx = 0; idx < pCount; idx++)
            {
                Console.WriteLine("{0} . {1}", idx + 1, pro[idx].pro_Name);
            }
            string press;
            string name1 = " ";
            int idx1 = 0;
            int stockToAdd;
            int temp = 0;
            while (idx1 != pCount)
            {
                Console.WriteLine("ENTER THE NAME OF PRODUCT .. ");
                name1 = Console.ReadLine();

                for (int idx = 0; idx < pCount; idx++)
                {
                    if (pro[idx].pro_Name == name1)
                    {
                        temp = idx;
                        Console.WriteLine("TOTAL STOCK OF {0} IS : {1}", name1, pro[idx].pro_Stock);
                        break;
                    }
                    // else
                    // {
                    //     cout<<"YOU HAVE ENTER WRONG INPUT!TRY AGAIN...."<<endl;
                    //     break;
                    // }
                }
                Console.Write("Do you want to add more stock in it(yes/no): ");
                press = Console.ReadLine();
                if (press == "yes" || press == "Yes")
                {
                    Console.Write("ENTER NEW STOCK TO ADD : ");
                    stockToAdd = int.Parse(Console.ReadLine());
                    pro[temp].pro_Stock = pro[temp].pro_Stock + stockToAdd;
                    Console.WriteLine(pro[temp].pro_Stock);

                }
                if (press == "no" || press == "No")
                {
                    break;
                }

            }
        }
        static void removeProductsFromArray(List<product> pro, ref int pCount)
        {

            string product_Name;
            Console.WriteLine("ENTER THE NAME OF PRODUCT YOU WANT TO REMOVE : ");
            product_Name = Console.ReadLine();
            for (int i = 0; i < pCount; i++)
            {
                if (pro[i].pro_Name == product_Name)
                {
                    for (int j = i; j < pCount; j++)
                    {

                        pro[j].pro_Name = pro[j + 1].pro_Name;
                        pro[j].pro_Price = pro[j + 1].pro_Price;
                        pro[j].pro_Stock = pro[j + 1].pro_Stock;
                    }
                    Console.WriteLine("------>>>PRODUCT REMOVED SUCCESSFULLY<<<------ ");
                    pCount--;
                }
            }

        }
        static void viewProduct(List<product> pro, ref int pCount)
        {
            Console.WriteLine("Product NAME Price Stock");
            for (int idx = 0; idx < pCount; idx++)
            {
                Console.WriteLine("{0} : {1}  : {2} ", pro[idx].pro_Name, pro[idx].pro_Price, pro[idx].pro_Stock);
            }
        }



        static void updateProductPrice(List<product> pro, ref int pCount)
        {
            bool flag = false;
            int price;

            Console.WriteLine("NAME OF THE PRODUCTS ARE ...... ");

            for (int idx = 0; idx < pCount; idx++)
            {
                Console.WriteLine("{0} . {1}", idx + 1, pro[idx].pro_Name);
            }
            string name2;
            Console.WriteLine("ENTER THE NAME OF PRODUCT TO UPDATE : ");
            name2 = Console.ReadLine();
            bool flag4 = true;
            while (flag4 == true)
            {
                for (int idx1 = 0; idx1 < name2.Count(); idx1++)
                {
                    if (!((name2[idx1] >= 97 && name2[idx1] <= 122) || (name2[idx1] >= 65 && name2[idx1] <= 90)))
                    {
                        Console.WriteLine("Invalid!! Enter Again");
                        name2 = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        flag4 = false;
                    }
                }
            }
            int i = 0;
            for (int idx1 = 0; idx1 < pCount; idx1++)
            {
                if (pro[idx1].pro_Name == name2)
                {
                    i = idx1;
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("PRICE OF THIS ITEM IS : {0}", pro[i].pro_Price);
                Console.WriteLine("ENTER THE NEW PRICE OF THE PRODUCT : ");
                price = int.Parse(Console.ReadLine());

                pro[i].pro_Price = price;
                Console.WriteLine("YOUR NEW PRICE IS : {0}", pro[i].pro_Price);
            }
            else if (!flag)
            {

                Console.WriteLine("YOU HAVE ENTER WRONG INPUT! TRY AGAIN....");
            }
        }
        static void updateListCheck(List<product> pro, ref int pCount)
        {
            Console.WriteLine("Product NAME   Price  Stock");
            for (int idx = 0; idx < pCount; idx++)
            {
                Console.WriteLine("{0}  : {1} : {2}", pro[idx].pro_Name, pro[idx].pro_Price, pro[idx].pro_Stock);
            }
        }

        static void deleteProduct(List<product> pro, ref int pCount)
        {
            Console.WriteLine("NAME OF THE PRODUCTS ARE ...... ");
            for (int idx = 0; idx < pCount; idx++)
            {
                Console.WriteLine("{0} . {1}", idx + 1, pro[idx].pro_Name);
            }
            string press;
            string name3;
            int stockToDelete;
            int index = 0;
            int tempVar = 0;

            while (index != pCount)
            {
                Console.WriteLine("ENTER THE NAME OF PRODUCT .. ");
                name3 = Console.ReadLine();
                for (int index1 = 0; index1 < pCount; index1++)
                {
                    if (pro[index1].pro_Name == name3)
                    {
                        tempVar = index1;
                        Console.WriteLine("TOTAL STOCK OF {0} IS : {1}", name3, pro[index1].pro_Stock);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("YOU HAVE ENTER WRONG INPUT!TRY AGAIN....");
                        break;
                    }
                }
                Console.WriteLine("Do you want to DELETE  stock in it(yes/no): ");
                press = Console.ReadLine();
                if (press == "yes" || press == "Yes")
                {
                    Console.WriteLine("ENTER NEW STOCK TO Delete : ");
                    stockToDelete = int.Parse(Console.ReadLine());
                    pro[tempVar].pro_Stock = pro[tempVar].pro_Stock - stockToDelete;
                    Console.WriteLine("{0}", pro[index].pro_Stock);
                    break;
                }
                else if (press == "no" || press == "No")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("SORRY...YOU HAVE ENTER WRONG NUMBER !");
                }

                index++;
            }
        }
    }
}