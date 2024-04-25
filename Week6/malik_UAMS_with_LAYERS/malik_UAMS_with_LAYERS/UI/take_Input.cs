using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using malik_UAMS_with_LAYERS.BL;
using malik_UAMS_with_LAYERS.DL;

namespace malik_UAMS_with_LAYERS.UI
{
    class take_Input
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
                obj.addSubject(take_Input.takeinputforsubject());
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
            data.viewdegreePrograms(programs);
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
                foreach (Subject sub in s.regDegree.Subjects)
                {
                    if (code == sub.Subjectcode && !(s.regSubjects.Contains(sub)))
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


        public static int menu()
        {
            int option;
            Console.WriteLine("1. Add a Student");
            Console.WriteLine("2. Add degree program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View registered students");
            Console.WriteLine("5. View students of a specific program");
            Console.WriteLine("6. Register subjects for a specific student");
            Console.WriteLine("7. Calculates fees for all registered students");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter the option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }


    }
}
