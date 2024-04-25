
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ums
{
    class Program
    {
        class Student
        {
            public string Name;
            public int roll_Number;
            public float cGPA;
            public int matric_Marks;
            public float fsc_Marks;
            public float ecat_Marks;
            public string home_Town;
            public string CheckHostelite;
            public bool is_Hostelite;

            public float claculateMerit()
            {
                float merit;
                ecat_Marks = (ecat_Marks * 40.0f) / 400;
                fsc_Marks = (fsc_Marks * 60.0f) / 1100;
                merit = ecat_Marks + fsc_Marks;
                return merit;
            }
            public Student()
            {

            }
            public Student(string Name, int roll_Number, float cGPA, int matric_Marks, float fsc_Marks, float ecat_Marks, string home_Town, string CheckHostelite)
            {
                this.Name = Name;
                this.roll_Number = roll_Number;
                this.cGPA = cGPA;
                this.matric_Marks = matric_Marks;
                this.fsc_Marks = fsc_Marks;
                this.ecat_Marks = ecat_Marks;
                this.home_Town = home_Town;
                this.CheckHostelite = CheckHostelite;
            }
            public Student(int fsc_Marks, int ecat_Marks)
            {
                this.fsc_Marks = fsc_Marks;
                this.ecat_Marks = ecat_Marks;
            }


            public bool is_Eligible_for_Scholarship(double merit)
            {
                bool flag = false;
                if (merit > 80)
                {
                    Console.WriteLine("You are eligible for Scolarship and you will get hostels!");
                    return true;
                }
                else
                {
                    Console.WriteLine("You are not eligible for Scolarship and you will not get hostels!");
                    return flag;
                }
            }
            public Student takeInputDataOfStudet()
            {
                Console.WriteLine("Enter the name of the student : ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the roll number of the student : ");
                roll_Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the CGPA of the student : ");
                cGPA = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the matric Marks of the student : ");
                matric_Marks = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Inter Marks of the student : ");
                fsc_Marks = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Ecat Marks of the student : ");
                ecat_Marks = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of the Home Town : ");
                home_Town = Console.ReadLine();
                Console.WriteLine("Enter the Choice (Hostelite or NotHostelite) [Yes 0r No] ");
                CheckHostelite = Console.ReadLine();
                Student user = new Student(Name, roll_Number, cGPA, matric_Marks, fsc_Marks, ecat_Marks, home_Town, CheckHostelite);
                return user;

            }

        }
        static void Main(string[] args)
        {
            Student L = new Student();
            List<Student> malik = new List<Student>();
            int option = 0;
            float merit = 0;
            do
            {
                option = menu();
                if (option == 1)
                {
                    Console.Clear();
                    Student MUser = L.takeInputDataOfStudet();
                    malik.Add(MUser);
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    merit = L.claculateMerit();
                    Console.WriteLine(merit);
                    Console.ReadKey();
                }

                else if (option == 3)
                {
                    Console.Clear();
                    bool malikk = L.is_Eligible_for_Scholarship(merit);
                    Console.ReadKey();
                }
            }
            while (option < 4);


        }


        static int menu()
        {
            int option;
            Console.WriteLine("1.Add the Student record");
            Console.WriteLine("2.Calculate merit");
            Console.WriteLine("3.Are  U eligble for scolarShip");
            Console.WriteLine("4.Exit the Application");
            Console.WriteLine("Enter the Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
