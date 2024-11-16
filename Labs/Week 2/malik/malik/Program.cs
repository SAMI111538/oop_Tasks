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
        class noodles
        {
            public string noodlesName;
            public int noodlePrice;
            public int noodlesStock;
        }


        static void Main(string[] args)
        {
            string path = @"C:\Users\AL-FATAH LAPTOP\OneDrive\Desktop\malikk.txt";
            int usersCount = 0;
            int userArrSize = 100;
            int noodleCounter = 0;
            credential[] s = new credential[100];
            noodles[] nood = new noodles[100];


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
                    Console.WriteLine("Enter Your Role (Admin or Customer) : ");
                    string r = Console.ReadLine();
                    signUp(path, n, p, ref s, ref usersCount, ref userArrSize);


                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter Name : ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password : ");
                    string p = Console.ReadLine();
                    signIn(n, p, s);
                    adminInterface(path, nood, ref noodleCounter);
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

        static void readData(credential[] s, string path, ref int usersCount)
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
                    s[x] = s1;
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
        static void signIn(string n, string p, credential[] s)
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
        static void signUp(string path, string n, string p, ref credential[] s, ref int usersCount, ref int userArrSize)
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
        static credential addUserData(string n, string p, ref credential[] s, ref int usersCount)
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
            Console.WriteLine(" ADMIN MAIN MENU ");
            Console.WriteLine("1.Add noodles");
            Console.WriteLine("2.View noodles details");
            Console.WriteLine("3.Update Price of noodles");
            Console.WriteLine("4.Delete noodles	");
            Console.WriteLine("5.Check list of noodles");
            Console.WriteLine("6.Most Sold noodles");
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
        static void adminInterface(string path1, noodles[] nood, ref int noodleCounter)
        {
            int adminOption = 0;
            while (true)
            {
                adminOption = adminMenu();
                if (adminOption == 1)
                {
                    Console.Clear();
                    string opt2 = "";
                    Console.WriteLine("1.ADD NEW noodles");
                    Console.WriteLine("2.UPDATE STOCK");
                    Console.WriteLine("Enter your option");

                    opt2 = Console.ReadLine();
                    if (opt2 == "1")
                    {
                        addNewnoodles(path1, nood, ref noodleCounter);
                    }
                    else if (opt2 == "2")
                    {
                        addnoodles(nood, ref noodleCounter);
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
                    viewnoodles(nood, ref noodleCounter);
                    Console.ReadKey();
                }

                if (adminOption == 3)
                {
                    Console.Clear();
                    //updatenoodlesPrice(pro, ref noodleCounter);
                    Console.ReadKey();
                }

                if (adminOption == 4)
                {
                    Console.Clear();
                    string opt3 = "";
                    Console.WriteLine("1.REMOVE noodles");
                    Console.WriteLine("2.REMOVE STOCK");
                    Console.WriteLine("ENTER OPTION---->>>");
                    opt3 = Console.ReadLine();
                    if (opt3 == "1")
                    {
                        //removenoodlessFromArray(pro, ref noodleCounter);
                        Console.ReadKey();
                    }
                    else if (opt3 == "2")
                    {
                        //deletenoodles(pro,ref noodleCounter);
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
        static void addNewnoodles(string path1, noodles[] nood, ref int noodleCounter)
        {
            string noodles = "";
            int Price = 0;
            int pStock = 0;
            bool flag1 = true;
            Console.Write("ENTER THE Name OF THE Noodles : ");
            noodles = Console.ReadLine();
            while (flag1)
            {
                for (int i = 0; i < noodles.Count(); i++)
                {
                    if (!((noodles[i] >= 97 && noodles[i] <= 122) || (noodles[i] >= 65 && noodles[i] <= 90)))
                    {
                        Console.WriteLine("Invalid!! Enter Again : ");
                        noodles = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        flag1 = false;
                    }
                }
            }


            Console.Write("ENTER THE Price OF THE noodles : ");
            Price = int.Parse(Console.ReadLine());

            Console.Write("ENTER THE STOCK OF THE noodles :");
            pStock = int.Parse(Console.ReadLine());

            nood[noodleCounter].noodlesName = noodles;
            nood[noodleCounter].noodlePrice = Price;
            nood[noodleCounter].noodlesStock = pStock;
            StreamWriter myfile = new StreamWriter(path1, true);
            myfile.WriteLine(noodles + "," + Price + "," + pStock);
            myfile.Flush();
            myfile.Close();
            noodleCounter++;
        }
        static void readData1(string path1, noodles[] nood, ref int noodleCounter)
        {
            int x = 0;
            if (File.Exists(path1))
            {
                StreamReader fileVariable = new StreamReader(path1);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    nood[x].noodlesName = parseData(record, 1);
                    nood[x].noodlePrice = stoi(parseData(record, 2));
                    nood[x].noodlesStock = stoi(parseData(record, 3));

                    x++;
                    noodleCounter++;
                    if (noodleCounter > 100)
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

        static void addnoodles(noodles[] nood, ref int noodleCounter)
        {
            Console.WriteLine("NAME OF THE noodles types is:  ");
            for (int idx = 0; idx < noodleCounter; idx++)
            {
                Console.WriteLine("{0} . {1}", idx + 1, nood[idx].noodlesName);
            }
            string press;
            string name1 = " ";
            int idx1 = 0;
            int stockToAdd;
            int temp = 0;
            while (idx1 != noodleCounter)
            {
                Console.WriteLine("ENTER THE NAME OF noodles.. ");
                name1 = Console.ReadLine();

                for (int idx = 0; idx < noodleCounter; idx++)
                {
                    if (nood[idx].noodlesName == name1)
                    {
                        temp = idx;
                        Console.WriteLine("TOTAL STOCK OF {0} IS : {1}", name1, nood[idx].noodlesStock);
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
                    nood[temp].noodlesStock = nood[temp].noodlesStock + stockToAdd;
                    Console.WriteLine(nood[temp].noodlesStock);

                }
                if (press == "no" || press == "No")
                {
                    break;
                }

            }
        }
        static void removenoodlessFromArray(noodles[] nood, ref int noodleCounter)
        {

            string noodles_Name;
            Console.WriteLine("ENTER THE NAME OF noodles YOU WANT TO REMOVE : ");
            noodles_Name = Console.ReadLine();
            for (int i = 0; i < noodleCounter; i++)
            {
                if (nood[i].noodlesName == noodles_Name)
                {
                    for (int j = i; j < noodleCounter; j++)
                    {

                        nood[j].noodlesName = nood[j + 1].noodlesName;
                        nood[j].noodlePrice = nood[j + 1].noodlePrice;
                        nood[j].noodlesStock = nood[j + 1].noodlesStock;
                    }
                    Console.WriteLine("Noodlels are removed :)");
                    noodleCounter--;
                }
            }

        }
        static void viewnoodles(noodles[] nood, ref int noodleCounter)
        {
            Console.WriteLine("NOODLES TYPE NAME Price Stock");
            for (int idx = 0; idx < noodleCounter; idx++)
            {
                Console.WriteLine("{0} : {1}  : {2} ", nood[idx].noodlesName, nood[idx].noodlePrice, nood[idx].noodlesStock);
            }
        }



        static void updatenoodlesPrice(noodles[] nood, ref int noodleCounter)
        {
            bool flag = false;
            int price;

            Console.WriteLine("NAME OF THE NOODLES ARE : ");

            for (int idx = 0; idx < noodleCounter; idx++)
            {
                Console.WriteLine("{0} . {1}", idx + 1, nood[idx].noodlesName);
            }
            string name2;
            Console.WriteLine("ENTER THE TYPE OF NOODLES TO UPDATE : ");
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
            for (int idx1 = 0; idx1 < noodleCounter; idx1++)
            {
                if (nood[idx1].noodlesName == name2)
                {
                    i = idx1;
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("PRICE OF THIS NOODLES TYPE IS : {0}", nood[i].noodlePrice);
                Console.WriteLine("ENTER THE NEW PRICE OF THE NOODLES : ");
                price = int.Parse(Console.ReadLine());

                nood[i].noodlePrice = price;
                Console.WriteLine("YOUR NEW PRICE IS : {0}", nood[i].noodlePrice);
            }
            else if (!flag)
            {

                Console.WriteLine("YOU HAVE ENTER WRONG INPUT! TRY AGAIN....");
            }
        }
        static void updateListCheck(noodles[] nood, ref int noodleCounter)
        {
            Console.WriteLine("NOODLES TYPE NAME   Price  Stock");
            for (int idx = 0; idx < noodleCounter; idx++)
            {
                Console.WriteLine("{0}  : {1} : {2}", nood[idx].noodlesName, nood[idx].noodlePrice, nood[idx].noodlesStock);
            }
        }

        static void deletenoodles(noodles[] nood, ref int noodleCounter)
        {
            Console.WriteLine("NAME OF THE NOODLES ARE : ");
            for (int idx = 0; idx < noodleCounter; idx++)
            {
                Console.WriteLine("{0} . {1}", idx + 1, nood[idx].noodlesName);
            }
            string press;
            string name3;
            int stockToDelete;
            int index = 0;
            int tempVar = 0;

            while (index != noodleCounter)
            {
                Console.WriteLine("ENTER THE NAME OF NOODLES .. ");
                name3 = Console.ReadLine();
                for (int index1 = 0; index1 < noodleCounter; index1++)
                {
                    if (nood[index1].noodlesName == name3)
                    {
                        tempVar = index1;
                        Console.WriteLine("TOTAL STOCK OF {0} IS : {1}", name3, nood[index1].noodlesStock);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("YOU HAVE ENTER WRONG INPUT!TRY AGAIN....");
                        break;
                    }
                }
                Console.WriteLine("Do you want to DELETE stock in it(yes/no): ");
                press = Console.ReadLine();
                if (press == "yes" || press == "Yes")
                {
                    Console.WriteLine("ENTER NEW STOCK TO Delete : ");
                    stockToDelete = int.Parse(Console.ReadLine());
                    nood[tempVar].noodlesStock = nood[tempVar].noodlesStock - stockToDelete;
                    Console.WriteLine("{0}", nood[index].noodlesStock);
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
