using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Program
    {
        class Student
        {
            string std_Name;
            int std_age;
            double std_Fsc_Marks;
            double std_Ecat_Mark;
            public double merit;
            public List<Degree_Program> preferences;
            public List<Subject> regSubject;
            public Degree_Program regDegree;
            public Student(string std_Name, int std_age, double std_Fsc_Marks, double std_Ecat_Mark, List<Degree_Program> preferences)
            {
                this.std_Name = std_Name;
                this.std_age = std_age;
                this.std_Fsc_Marks = std_Fsc_Marks;
                this.std_Ecat_Mark = std_Ecat_Mark;
            }

            public void regStudentSubject(Subject s)
            {
                int stCH = getCreditHours();
                if (regDegree != null &&
                regDegree.isSubjectExists(s) && stCH || s.credit_hours <= 9)
                {
                    regSubject.Add(s);
                }
                else
                {
                    Console.WriteLine("A student cannot have more than 9 CH or Wrong] Subject");
                }

            }
            public void calculateMerit()
            {

            }

            public int getCreditHours()
            {
                return 0;
            }

            public float calculateFee()
            {

                return 0f;
            }
        }
        
        class Subject
        {
            int subject_code;
            int credit_hours;
            char subject_Type;
            int subject_Fee;

            public Subject(string code,string type, int creditHours, int subjectFees)
            {

            }
        }

        class Degree_Program
        {
            string degree_title;
            string degree_Duration;
            int seats;

            public Degree_Program(string degreeName, string degree_Duration, int seats)
            {
                this.degree_title = degreeName;
                this.degree_Duration = degree_Duration;
                this.seats = seats;
                subjects = new List<Subject>();
            }

            bool isSubjectExists(Subject sub)
            {
                return false;
            }

            void AddSubject(Subject s)
            {

            }

            int calculateCreditHours()
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = Menu();
                clearScreen();
                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    addIntoDegreeList(d);
                }

                else if (option == 3)
                {
                    sortStudentsByMerit();
                    giveAdmission();
                    printStudents();
                }
                else if (option == 4)
                {
                    viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name);
                    if (s != null)
                    {
                        s.viewSubjects();
                        registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    calculateFee();
                }
                Console.Clear();
            }
            while (option != 8);
            Console.ReadKey();
        }
    }
}
