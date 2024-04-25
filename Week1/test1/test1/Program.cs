using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            //Task15();
            Task16();
            //Lily();
            LoginMain();

        }
        static void Task1()
        {
            Console.Write("Hello World!!");
            Console.Write("hello malik!!");
            Console.ReadKey();
            Console.Clear();
        }
        static void Task2()
        {
            Console.WriteLine("Hello World!!");
            Console.Write("hello malik!!");
            Console.ReadKey();
            Console.Clear();

        }
        static void Task3()
        {
            int variable = 7;
            Console.WriteLine("Value:");
            Console.Write(variable);
            Console.ReadKey();
            Console.Clear();

        }
        static void Task4()
        {
            string variable = "I am string";
            Console.WriteLine("Value of variable is :");
            Console.Write(variable);
            Console.ReadKey();
            Console.Clear();


        }
        static void Task5()
        {
            char character = 'A';
            Console.WriteLine("Value of character is :");
            Console.Write(character);
            Console.ReadKey();
            Console.Clear();
        }
        static void Task6()
        {
            float variable = 6.5F;
            Console.WriteLine("Value of variable is :");
            Console.Write(variable);
            Console.ReadKey();
            Console.Clear();
        }
        static void Task7()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You have inputed the value : ");
            Console.WriteLine(str);
            Console.ReadKey();
            Console.Clear();
        }
        static void Task8()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You have inputed the value : ");
            int number = int.Parse(str);
            Console.WriteLine("The number is : ");
            Console.Write(number);
            Console.ReadKey();
            Console.Clear();
        }
        static void Task9()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("Enter your floating point number : ");
            float number = float.Parse(str);
            Console.WriteLine("The number is : ");
            Console.Write(number);
            Console.ReadKey();
            Console.Clear();
        }
        static void Task10()
        {
            float length;
            float area;
            string str;
            Console.WriteLine("Enter length");
            str = Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.WriteLine("the area is ");
            Console.Write(area);
            Console.ReadKey();
            Console.Clear();

        }
        static void Task11()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome to my World");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Task12()
        {
            int sum = 0;
            int num;
            Console.WriteLine("Enter Your Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum = sum + num;
                Console.Write("Enter Number : ");
                num = int.Parse(Console.ReadLine());
            }
            Console.Write("The sum is {0}", sum);
            Console.ReadKey();
            Console.Clear();
        }
        static void Task13()
        {
            int[] number = new int[3];
            for (int x = 0; x < 3; x++)
            {
                Console.Write("Enter Number {0}: ", x);
                number[x] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for (int x = 0; x < 3; x++)
            {
                if (number[x] > largest)
                {
                    largest = number[x];
                }
            }
            Console.Write("largest is {0}: ", largest);
            Console.ReadKey();
            Console.Clear();
        }
        static void Task14()
        {
            int num1;
            int num2;
            Console.WriteLine("Enter Number1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2 : ");
            num2 = int.Parse(Console.ReadLine());
            int result = add(num1, num2);
            Console.Write("The sum is {0}", result);
            Console.ReadKey();
            Console.Clear();
        }
        static int add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        static void Task15()
        {
            string path = "C:\\Users\\AL-FATAH LAPTOP\\OneDrive\\Desktop\\FINAL GAME\\file.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);

                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("No Exists");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Task16()
        {
            string path = "C:\\Users\\AL-FATAH LAPTOP\\OneDrive\\Desktop\\FINAL GAME\\malik.txt";
            StreamWriter fileVariable = new StreamWriter(path, true);
            fileVariable.WriteLine("\n hello");
            fileVariable.Flush();
            fileVariable.Close();
            Console.ReadKey();
            Console.Clear();
        }

        static void LoginMain()
        {
            string path = "C:\\Users\\AL-FATAH LAPTOP\\OneDrive\\Desktop\\FINAL GAME\\Names.txt";
            string[] names = new string[5];
            string[] password =new string[5];
            int option;
            do
            {
                readData(path, names, password);
                Console.Clear();
                option = Menu();
                Console.Clear();
                if(option==1)
                {
                    Console.WriteLine("Enter Name : ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password : ");
                    string p = Console.ReadLine();
                    signIn(n, p, names, password);
                }
                else if (option==2)
                {
                    Console.WriteLine("Enter Name : ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password : ");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }
            }
            while (option < 3);
            Console.ReadKey();
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.SignUp");
            Console.WriteLine("2.SignIn");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item="";
            for(int x=0;x<record.Length;x++)
            {
                if (record[x]==',')
                {
                    comma++;
                }
                else if (comma==field)
                {
                    item = item + record[x];

                }
            }
            return item="";
        }
        static void readData(string path,string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if(x>5)
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
        static void signIn(string n,string p,string[] names,string[] password)
        {
            bool flag = false;
            for(int x=0;x<5;x++)
            {
                if (n==names[x] && p==password[x])
                {
                    Console.WriteLine("Congrats! You are verified as a valid User");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry! You have Enter the wrong Id");
                    break;
                }
                Console.ReadKey();
            }
        }
        static void signUp(string path,string n,string p)
        {
            StreamWriter myfile = new StreamWriter(path, true);
            myfile.WriteLine(n + "," + p);
            myfile.Flush();
            myfile.Close();
        }
       static void Lily()
       {
           int age_Lily;
           int price_WM;
           int unitPriceForToys;
           int money;
           Console.WriteLine("Lilly's age  integer in the range of [1 ... 77] : ");
           age_Lily = int.Parse(Console.ReadLine());
           Console.WriteLine(" Price of the washing machine  the number in the range of[1.00... 10, 000.00] : ");
           price_WM = int.Parse(Console.ReadLine());
           Console.WriteLine("Unit price of each toy  integer in the range of [0 ... 40] : ");
           unitPriceForToys = int.Parse(Console.ReadLine());
           money = MoneyCalculator(age_Lily, price_WM, unitPriceForToys);
           if (money > 0)
           {
               Console.WriteLine("Yes! {0} is left ", money);
               Console.ReadKey();
           }
           if (money < 0)
           {
               money = -(money);
               Console.WriteLine("No! {0} is needed ", money);
               Console.ReadKey();
           }
       }

       static int MoneyCalculator(int age_Lily, int price_WM, int unitPriceForToys)
       {
           int Odd=0;
           int Even=0;
           int evenMoney = 0;
           int oddMoney;
           int presentMoney = 10;
           int BirthdayMoney;
           int totalMoney;
           if (age_Lily % 2 == 0)
           {
               Even = age_Lily / 2;
               Odd = Even;
           }
           if (age_Lily % 2 != 0)
           {
               Odd = age_Lily / 2 + 1;
               Even = age_Lily / 2;

           }
           for (int temp = 1; temp <= Even; temp++)
           {
               evenMoney = evenMoney + presentMoney;
               presentMoney = presentMoney + 10;
           }
           evenMoney = evenMoney - Even;
           oddMoney = Odd * unitPriceForToys;
           BirthdayMoney = oddMoney + evenMoney;
           totalMoney = BirthdayMoney - price_WM;
           return totalMoney;
       }
    }
}
