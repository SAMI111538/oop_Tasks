using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.DL;
using Layers.BL;

namespace Layers.UI
{
    public class Take_input
    {
        public static Degree_Program takeinputfordegree()
        {

            Console.WriteLine("Enter the degree title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the degree duration");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seats in this degree program");
            int seats = int.Parse(Console.ReadLine());
            Degree_Program obj = new Degree_Program(title, duration, seats);

            Console.WriteLine("Enter how many subjects you want to add in this degree program");
            int sub = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < sub; idx++)
            {
                obj.addsubject(subjectUI.takeinputforsubject());
            }
            return obj;

        }

        public static Student takeinputforstudent(List<Degree_Program> programs)
        {
            List<Degree_Program> preferences = new List<Degree_Program>();
            Console.WriteLine("Enter Student name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student's age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student FSC marks : ");
            double fsc = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student ECAT marks : ");
            double ecat = double.Parse(Console.ReadLine());

            Console.WriteLine("Available degree Programs : ");
            Data.viewdegreePrograms(programs);
            Console.WriteLine("Enter how many prefences you want to add");
            int count = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < count; idx++)
            {
                string degname = Console.ReadLine();
                bool flag = false;
                foreach (Degree_Program dp in programs)
                {
                    if (degname == dp.degreeName && !(preferences.Contains(dp)))
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
            Student s = new Student(name, age, fsc, ecat, preferences);
            return s;


        }

        public static Subject takeinputforsubject()
        {
            Console.WriteLine("Enter Subject code : ");
            string code = Console.ReadLine();
            Console.WriteLine("Enter subject type : ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter subject credit hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter suject fees : ");
            int fees = int.Parse(Console.ReadLine());
            Subject s = new Subject(code, type, hours, fees);
            return s;
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
                    if (code == sub.subjectcode && !(s.regsubjects.Contains(sub)))
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


