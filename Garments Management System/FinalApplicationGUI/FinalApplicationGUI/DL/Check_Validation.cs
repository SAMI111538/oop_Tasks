using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.DL
{
    class Check_Validation
    {
        public static bool check_ADRESS(string ip_adress)
        {
            if (ip_adress.Length < 15)
            {
                for (int i = 0; i < ip_adress.Length; i++)
                {
                    if ((ip_adress[i] >= 48 && ip_adress[i] <= 57) || (ip_adress[i] > 64 && ip_adress[i] < 89) || (ip_adress[i] > 96 && ip_adress[i] < 122) || (ip_adress[i] == 35))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\n ADRESS must be consist of only numeric characters ,alphabets and #  .\n ");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckStock(int stock)
        {
            if (stock < 0)
            {
                Console.WriteLine("InValid Input");
                return false;
            }
            return true;
        }
        public static bool CheckPrice(double price)
        {
            if (price < 0)
            {
                Console.WriteLine("InValid Input");
                return false;
            }
            return true;
        }

        public static bool CheckUsername(string username)
        {
            if (username.Length <= 16)
            {
                for (int i = 0; i < username.Length; i++)
                {
                    if ((username[i] >= 48 && username[i] <= 57) || (username[i] > 64 && username[i] < 91) || (username[i] > 96 && username[i] < 123))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("NO SPECIAL CHARACTERS ALLOWED. ");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("YOU CAN ONLY ENTER 16 CHARACTERS.");
                return false;
            }
        }

        public static bool CheckPassword(string pass)
        {
            if (pass.Length <= 8)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if ((pass[i] >= 48 && pass[i] <= 57) || (pass[i] > 64 && pass[i] < 89) || (pass[i] > 96 && pass[i] < 122))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\n PASSWORD MUST BE CONSIST OF ONLY NUMERIC CHARACTERS AND ALPHABETS.\n ");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("\n ONLY EIGHT CHARACTERS.");
                return false;
            }
        }
    }
}
