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
            public string name;
            public int age;
            public double fscMarks;
            public double ecatMarks;
            public double merit;
            public List<DegreeProgram> preferences;
            public List<Subject> regSubject;
            public DegreeProgram regDegree;

            public Student(string name, int age, double fscMarks, double ecatMarks)
            {
                this.name = name;
                this.age = age;
                this.fscMarks = fscMarks;
                this.ecatMarks = ecatMarks;
            }

            public Student(string name, int age, double fscMarks, double ecatMarks, List<DegreeProgram> preferences)
            {
                this.name = name;
                this.age = age;
                this.fscMarks = fscMarks;
                this.ecatMarks = ecatMarks;
                this.preferences = preferences;
                regSubject = new List<Subject>();
            }

            public void calculateMerit()
            {
                this.merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F)) * 100;
            }


            public bool regStudentSubject(Subject s)
            {
                int stCH = getCreditHours();
                if (regDegree != null && regDegree.isSubjectExists(s) && stCH + s.creditHours <= 9)
                {
                    regSubject.Add(s);
                    return true;
                }
                else
                {
                    Console.WriteLine("A student cannot have more than 9 CH or Wrong Subject");
                    return false;
                }
            }

            public int getCreditHours()
            {
                int creditHour = 0;
                foreach (Subject s in regSubject)
                {
                    creditHour = creditHour + s.creditHours;
                }
                return creditHour;
            }

            public float calculateFee()
            {
                float fees = 0;
                if (regDegree != null)
                {
                    foreach (Subject s in regSubject)
                    {
                        fees = fees + s.subjectFee;
                    }
                }
                return fees;
            }




            public Student()
            {

            }
        }

        class DegreeProgram
        {
            public string degreeTitle;
            public float duration;
            public int seats;
            public List<Subject> subjects;

            public DegreeProgram(string degreeTitle, float duration, int seats)
            {
                this.degreeTitle = degreeTitle;
                this.duration = duration;
                this.seats = seats;

                subjects = new List<Subject>();

            }

            public int calculateCreditHours()
            {
                int count = 0;
                for (int x = 0; x < subjects.Count; x++)
                {
                    count = count + subjects[x].creditHours;
                }
                return count;

            }
            public bool isSubjectExists(Subject sub)
            {
                foreach (Subject s in subjects)
                {
                    if (sub.subjectCode == s.subjectCode)
                    {
                        return true;
                    }

                }
                return false;
            }

            public bool AddSubject(Subject s)
            {
                int creditHours = calculateCreditHours();
                if (creditHours + s.creditHours <= 20)
                {
                    subjects.Add(s);
                    return true;
                }
                else
                {
                    Console.WriteLine("20 credit hour limit exceeded.");
                    return false;
                }
            }

            public DegreeProgram()
            {

            }


        }

        class Subject
        {
            public string subjectCode;
            public int creditHours;
            public string subjectType;
            public int subjectFee;

            public Subject(string subjectCode, int creditHours, string subjectType, int subjectFee)
            {
                this.subjectCode = subjectCode;
                this.creditHours = creditHours;
                this.subjectType = subjectType;
                this.subjectFee = subjectFee;
            }

            public Subject()
            {

            }
        }
        static List<Student> studentList = new List<Student>();
        static List<DegreeProgram> programList = new List<DegreeProgram>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = Menu();
                Console.Clear();
                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(s);
                        Console.ReadKey();
                    }
                }

                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    addIntoDegreeList(d);
                    Console.ReadKey();
                }

                else if (option == 3)
                {
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = sortedStudents();
                    giveAdmissions(sortedStudentList);
                    printStudents();
                    Console.ReadKey();
                }

                else if (option == 4)
                {
                    viewRegisteredStudents();
                    Console.ReadKey();
                }

                else if (option == 5)
                {
                    Console.WriteLine("ENTER THE DEGREE NAME: ");
                    string name = Console.ReadLine();
                    viewStudentsInDegreee(name);
                    Console.ReadKey();
                }

                else if (option == 6)
                {
                    Console.WriteLine("ENTER THE STUDENT NAME: ");
                    string name = Console.ReadLine();
                    Student s = presentStudents(name);
                    if (s != null)
                    {
                        viewSubjects(s);
                        regSubjects(s);
                    }
                    Console.ReadKey();
                }

                else if (option == 7)
                {
                    calculateFeeforAll();
                    Console.ReadKey();
                }

                else if (option == 8)
                {
                    break;
                }
                Console.Clear();
            } while (option != 8);
            Console.ReadKey();
        }

        static int Menu()
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

        static Student takeInputForStudent()
        {
            int size;
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            Console.WriteLine("ENTER YOUR NAME: ");
            string name = Console.ReadLine();
            Console.WriteLine("ENTER YOUR AGE: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR FSC MARKS: ");
            double fscMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR ECAT MARKS: ");
            double ecatMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("AVAILABLE DEGREE PROGRAM: ");
            viewDegreeList();
            Console.WriteLine("ENTER YOUR PREFERENCES: ");
            size = int.Parse(Console.ReadLine());
            for (int x = 0; x < size; x++)
            {
                string degName;
                bool flag = false;
                Console.WriteLine("ENTER DEGREE NAME: ");
                degName = Console.ReadLine();
                foreach (DegreeProgram dp in programList)
                {
                    if (degName == dp.degreeTitle && !(preferences.Contains(dp)))
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
            Student data = new Student(name, age, fscMarks, ecatMarks, preferences);
            return data;
        }

        static void addIntoStudentList(Student s)
        {
            studentList.Add(s);
        }

        static DegreeProgram takeInputForDegree()
        {

            Console.WriteLine("ENTER THE DEGREE TITLE: ");
            string degreeTitle = Console.ReadLine();
            Console.WriteLine("ENTER THE DURATION: ");
            float duration = float.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SEATS AVAILABLE: ");
            int seats = int.Parse(Console.ReadLine());
            DegreeProgram d = new DegreeProgram(degreeTitle, duration, seats);
            Console.WriteLine("ENTER HOW MANY SUBJECTS TO ENTER: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {

                d.AddSubject(takeInputForSubject());

            }
            return d;
        }

        static Subject takeInputForSubject()
        {
            string subjectCode;
            string subjectType;
            int creditHours;
            int subjectFee;

            Console.WriteLine("ENTER THE SUBJECT CODE: ");
            subjectCode = Console.ReadLine();
            Console.WriteLine("ENTER THE SUBJECT TYPE: ");
            subjectType = Console.ReadLine();
            Console.WriteLine("ENTER THE SUBJECT CREDIT HOURS: ");
            creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SUBJECT FEES: ");
            subjectFee = int.Parse(Console.ReadLine());
            Subject s = new Subject(subjectCode, creditHours, subjectType, subjectFee);
            return s;
        }

        static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }

        static List<Student> sortedStudents()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        static void giveAdmissions(List<Student> sortedstudentList)
        {
            foreach (Student s in sortedstudentList)
            {
                foreach (DegreeProgram d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }

        static void printStudents()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " GOT ADMISSION IN " + s.regDegree.degreeTitle);
                }
                else
                {
                    Console.WriteLine(s.name + " DID NOT GET ADMISSION IN ANY PROGRAM ");
                }
            }
        }

        static Student presentStudents(string name)
        {
            foreach (Student s in studentList)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }

        static void viewStudentsInDegreee(string degName)
        {
            Console.WriteLine("NAME\tFSC\tECAT\tAGE");
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    if (degName == s.regDegree.degreeTitle)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                    }
                }
            }
        }

        static void viewRegisteredStudents()
        {
            Console.WriteLine("NAME\tFSC\tECAT\tAGE");
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }
            }
        }

        static void regSubjects(Student s)
        {
            Console.WriteLine("ENTER HOW MANY SUBJECTS YOU WANT TO REGISTER: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("ENTER THE SUBJECT CODE: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.subjectCode && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;
                    }

                }
                if (flag == false)
                {
                    Console.WriteLine("ENTER VALID COURSE.");
                    x--;
                }
            }
        }

        static void calculateFeeforAll()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " HAS " + s.calculateFee() + " FEES ");
                }
            }
        }

        static void viewDegreeList()
        {
            foreach (DegreeProgram dp in programList)
            {
                Console.WriteLine(dp.degreeTitle);
            }
        }

        static void viewSubjects(Student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("SubCode\tSubType");
                foreach (Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.subjectCode + "\t\t" + sub.subjectType);
                }
            }
        }
    }
}