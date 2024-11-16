using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.UI
{
    class Student
    {

        static Student Take_Input_Student()
        {
            string std_Name;
            int std_age;
            double fsc_Marks;
            double ecat_Marks;

            Console.WriteLine("Enter Student's Name : ");
            std_Name = Console.ReadLine();
            Console.WriteLine("Enter Student's Age : ");
            std_age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student's Inter Marks : ");
            fsc_Marks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student's Ecat Marks : ");
            ecat_Marks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student's Available Degree Program ");

            Console.WriteLine("ENTER YOUR PREFERENCES: ");
            int size = int.Parse(Console.ReadLine());
            for (int x = 0; x < size; x++)
            {
                string degName;
                bool flag = false;
                Console.WriteLine("ENTER DEGREE NAME: ");
                degName = Console.ReadLine();
                foreach (Degree_Program dp in programList)
                {
                    if (degName == dp.degree_Title && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }

                    else if (flag == false)
                    {
                        Console.WriteLine("ENTER VALID DEGREE NAME. ");
                        x--;
                    }
                }
            }
            Student data = new Student(std_Name, std_age, fsc_Marks, ecat_Marks, preferences);
            return data;
        }

    }

    class Subject
    {
        static Subject Take_Input_Subject()
        {
            string code;
            string type;
            int credit_Hours;
            int subject_Fees;

            Console.WriteLine("ENTER THE SUBJECT CODE: ");
            code = Console.ReadLine();
            Console.WriteLine("ENTER THE SUBJECT TYPE: ");
            type = Console.ReadLine();
            Console.WriteLine("ENTER THE SUBJECT CREDIT HOURS: ");
            credit_Hours = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SUBJECT FEES: ");
            subject_Fees = int.Parse(Console.ReadLine());
            Subject s = new Subject(code, type, credit_Hours, subject_Fees);
            return s;
        }

    }

        class Degree_Program
        {
        static Degree_Program takeInputForDegree()
        {

            Console.WriteLine("ENTER THE DEGREE TITLE: ");
            string degreeTitle = Console.ReadLine();
            Console.WriteLine("ENTER THE DURATION: ");
            float duration = float.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SEATS AVAILABLE: ");
            int seats = int.Parse(Console.ReadLine());
            Degree_Program d = new Degree_Program(degreeTitle, duration, seats);
            Console.WriteLine("ENTER HOW MANY SUBJECTS TO ENTER: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {

                d.AddSubject(takeInputForSubject());

            }
            return d;
        }

    }

}

