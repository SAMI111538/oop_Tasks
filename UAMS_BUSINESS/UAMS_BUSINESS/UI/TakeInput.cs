using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_BUSINESS.BL;
using UAMS_BUSINESS.DL;

namespace UAMS_BUSINESS.UI
{
    public class TakeInput
    {

       public static int Menu()
        {
            Console.Clear();
            int option;
            Console.WriteLine("1. ADD STUDENT. ");
            Console.WriteLine("2. ADD DEGREE PROGRAM. ");
            Console.WriteLine("3. GENERATE MERIT. ");
            Console.WriteLine("4. VIEW REGISTERED STUDENTS. ");
            Console.WriteLine("5. VIEW STUDENTS OF A SPECIFIC PROGRAM. ");
            Console.WriteLine("6. REGISTER SUBJECT FOR A SPECIFIC STUDENT. ");
            Console.WriteLine("7. CALCULATE FEES FOR ALL  REGISTERED STUDENTS. ");
            Console.WriteLine("8. EXIT. ");
            Console.WriteLine("--> ENTER YOUR OPTION: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static Student take_input_Student(List<Degree_Program> d)
        {
            List<Degree_Program> preferences = new List<Degree_Program>();
            Console.WriteLine("ENTER YOUR NAME: ");
            string name = Console.ReadLine();
            Console.WriteLine("ENTER YOUR AGE: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR FSC MARKS: ");
            double fscMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR ECAT MARKS: ");
            double ecatMarks = double.Parse(Console.ReadLine());

            Console.WriteLine("Available degree Programs : ");
            Data.viewDegreeList();
            Console.WriteLine("Enter how many prefences you want to add");
            int count = int.Parse(Console.ReadLine());

            for (int idx = 0; idx < count; idx++)
            {
                string degname = Console.ReadLine();
                bool flag = false;
                foreach (Degree_Program dp in d)
                {
                    if (degname == dp.degreeTitle && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }

                }
                if (flag == false)
                {
                    Console.WriteLine("Invalid degree Program!!!");
                    idx--;

                }

            }

            Student s = new Student(name,age,fscMarks,ecatMarks, preferences);
            Data.Add_Student(s);
            return s;
           
        }

        public static Subject take_input_Subject()
        {

            Console.WriteLine("ENTER THE SUBJECT CODE: ");
            string subjectCode = Console.ReadLine();
            Console.WriteLine("ENTER THE SUBJECT TYPE: ");
            string subjectType = Console.ReadLine();
            Console.WriteLine("ENTER THE SUBJECT CREDIT HOURS: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SUBJECT FEES: ");
            int subjectFee = int.Parse(Console.ReadLine());

            Subject sub = new Subject(subjectCode, creditHours, subjectType, subjectFee);
            Data.Add_Subjects(sub);
            return sub;
        }

        public static void take_input_Degree_Program()
        {
            Console.WriteLine("ENTER THE DEGREE TITLE: ");
            string degreeTitle = Console.ReadLine();
            Console.WriteLine("ENTER THE DURATION: ");
            float duration = float.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SEATS AVAILABLE: ");
            int seats = int.Parse(Console.ReadLine());
            Degree_Program d = new Degree_Program(degreeTitle, duration, seats);
            Data.Add_Degree_Program(d);
            Console.WriteLine("ENTER HOW MANY SUBJECTS TO ENTER: ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {

               
                if(Data.AddSubject(take_input_Subject()))
                {
                    Console.WriteLine("Successfully Registered!");
                }

            }
        }

        public static void registersubjects(Student s)
        {
            Console.WriteLine("How many subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < count; idx++)
            {
                Console.WriteLine("Enter the subject code : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.subjectCode && !(s.regsubjects.Contains(sub)))
                    {
                        s.regStudentSub(sub);
                        flag = true;
                        break;


                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter valid course");
                    idx--;
                }
            }

        }

    }
}
