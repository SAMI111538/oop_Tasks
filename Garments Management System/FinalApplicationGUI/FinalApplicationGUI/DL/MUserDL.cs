using FinalApplicationGUI.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.DL
{
    class MUserDL//Data LAyer of the MUser
    {
        public static List<MUser> users = new List<MUser>();//List for storing the Users
        public static bool readData(string path, List<MUser> users)//ReadDAta of the Users from the File
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
                    storeDataInList(user);
                    if (role == "customer" || role == "Customer")
                    {
                        CustomerDL.addCustomerInList(new Customer(name, password, role));
                    }
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        public static string parseData(string record, int field)//Function for using the Comma Count to read tge Data From the File
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
        public static MUser signIn(MUser user)//Function for signIn As a User 
        {
            foreach (MUser storedUser in users)
            {
                if (user.getName() == storedUser.getName() && user.getPassword() == storedUser.getPassword())
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static void storeDataInList(MUser user)//Funtion for storing the Data in File
        {
            users.Add(user);
        }

        public static void storeDataInFile(string path, MUser user)//Funtion for storing the Data in List
        {
            StreamWriter file = new StreamWriter("Data.txt");
            file.WriteLine(user.getName() + "," + user.getPassword() + "," + user.getRole());
            file.Flush();
            file.Close();
        }
        public static void storeDataInFile()//Funtion for storing the Data in List
        {
            StreamWriter file = new StreamWriter("Data.txt");
            foreach (MUser user in users)
            {
                file.WriteLine(user.getName() + "," + user.getPassword() + "," + user.getRole());
            }
            file.Flush();
            file.Close();
        }


        public static string GetPathforUsersFile()
        {
            string path = @"C:\Users\AL-FATAH LAPTOP\OneDrive\Desktop\i.txt";
            return path;
        }
        public static void topHeader()
        {
            Console.WriteLine("                                                                                                                          ");
            Console.WriteLine("                                                                                                                          ");
            Console.WriteLine("                                                                                                                          ");
            Console.WriteLine("        GGGGGGGGGGGGGMMMMMMMM               MMMMMMMM   SSSSSSSSSSSSSSS         PPPPPPPPPPPPPPPPP   KKKKKKKKK    KKKKKKK");
            Console.WriteLine( "     GGG::::::::::::GM:::::::M             M:::::::M SS:::::::::::::::S        P::::::::::::::::P  K:::::::K    K:::::K" );
            Console.WriteLine( "   GG:::::::::::::::GM::::::::M           M::::::::MS:::::SSSSSS::::::S        P::::::PPPPPP:::::P K:::::::K    K:::::K" );
            Console.WriteLine( "  G:::::GGGGGGGG::::GM:::::::::M         M:::::::::MS:::::S     SSSSSSS        PP:::::P     P:::::PK:::::::K   K::::::K" );
            Console.WriteLine( " G:::::G       GGGGGGM::::::::::M       M::::::::::MS:::::S                      P::::P     P:::::PKK::::::K  K:::::KKK" );
            Console.WriteLine( "G:::::G              M:::::::::::M     M:::::::::::MS:::::S                      P::::P     P:::::P  K:::::K K:::::K   " );
            Console.WriteLine( "G:::::G              M:::::::M::::M   M::::M:::::::M S::::SSSS                   P::::PPPPPP:::::P   K::::::K:::::K    " );
            Console.WriteLine( "G:::::G    GGGGGGGGGGM::::::M M::::M M::::M M::::::M  SS::::::SSSSS              P:::::::::::::PP    K:::::::::::K     " );
            Console.WriteLine( "G:::::G    G::::::::GM::::::M  M::::M::::M  M::::::M    SSS::::::::SS            P::::PPPPPPPPP      K:::::::::::K     " );
            Console.WriteLine( "G:::::G    GGGGG::::GM::::::M   M:::::::M   M::::::M       SSSSSS::::S           P::::P              K::::::K:::::K    " );
            Console.WriteLine( "G:::::G        G::::GM::::::M    M:::::M    M::::::M            S:::::S          P::::P              K:::::K K:::::K   " );
            Console.WriteLine( " G:::::G       G::::GM::::::M     MMMMM     M::::::M            S:::::S          P::::P            KK::::::K  K:::::KKK" );
            Console.WriteLine( "  G:::::GGGGGGGG::::GM::::::M               M::::::MSSSSSSS     S:::::S        PP::::::PP          K:::::::K   K::::::K" );
            Console.WriteLine( "   GG:::::::::::::::GM::::::M               M::::::MS::::::SSSSSS:::::S  ....  P::::::::P          K:::::::K    K:::::K" );
            Console.WriteLine( "     GGG::::::GGG:::GM::::::M               M::::::MS:::::::::::::::SS  ...... P::::::::P          K:::::::K    K:::::K" );
            Console.WriteLine( "        GGGGGG   GGGGMMMMMMMM               MMMMMMMM SSSSSSSSSSSSSSS     ....  PPPPPPPPPP          KKKKKKKKK    KKKKKKK" );
        }

    }
}
