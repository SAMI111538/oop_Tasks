using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using malik_UAMS_with_LAYERS.BL;
using malik_UAMS_with_LAYERS.UI;
using malik_UAMS_with_LAYERS.DL;

namespace malik_UAMS_with_LAYERS
{
    class Program
    {
        static List<Student> studentlist = new List<Student>();
        static List<Degree_Program> programs = new List<Degree_Program>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                option = take_Input.menu();
                Console.Clear();
                if (option == 1)
                {
                    if (programs.Count > 0)
                    {
                        Student s = take_Input.takeinputforstudent(programs);
                        data.addintostudentlist(s, studentlist);
                        Console.ReadKey();
                    }

                }
                else if (option == 2)
                {
                    Degree_Program d = take_Input.takeinputfordegree();
                    data.addintodegreelist(d, programs);
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    List<Student> sortedstudentlist = new List<Student>();
                    sortedstudentlist = data.sortstudentsbymerit(studentlist);
                    data.giveadmission(sortedstudentlist);
                    data.printstudent(studentlist);
                    Console.ReadKey();

                }
                else if (option == 4)
                {
                    data.viewregisteredstudents(studentlist);
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    string degree;
                    Console.WriteLine("Enter the degree name : ");
                    degree = Console.ReadLine();
                    data.viewstudentindegree(degree, studentlist);
                    Console.ReadKey();

                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter the student name : ");
                    string name = Console.ReadLine();
                    Student s = data.studentpresent(name, studentlist);
                    if (s != null)
                    {
                        data.viewsubjects(s);
                        take_Input.registersubjects(s);

                    }
                    Console.ReadKey();
                }
                else if (option == 7)
                {
                    data.Calculatefee(studentlist);
                    Console.ReadKey();
                }
                else if (option == 8)
                {
                    break;
                }


            }
            while (option < 9);
            Console.Read();
        }
    }
}
