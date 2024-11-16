using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_BUSINESS.BL;
using UAMS_BUSINESS.UI;

namespace UAMS_BUSINESS.DL
{
    public class Data
    {
        public static List<Degree_Program> d = new List<Degree_Program>();
        public static List<Subject> sub = new List<Subject>();
        public static List<Student> stu = new List<Student>();

        public static List<Subject> reg_Subj = new List<Subject>();

        public static void Add_Regsubj(Subject s)
        {
            reg_Subj.Add(s);
        }

        public static void Add_Student(Student s)
        {
            stu.Add(s);
        }
        public static void Add_Degree_Program(Degree_Program q)
        {
            d.Add(q);
        }

        public static void Add_Subjects(Subject m)
        {
           sub.Add(m);
        }

        public static bool AddSubject(Subject s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.creditHours <= 20)
            {
                sub.Add(s);
                return true;
            }
            else
            {
                Console.WriteLine("20 credit hour limit exceeded.");
                return false;
            }
        }

        public bool isSubjectExists(Subject subj)
        {
            foreach (Subject s in sub)
            {
                if (subj.subjectCode == s.subjectCode)
                {
                    return true;
                }

            }
            return false;
        }

        public static int calculateCreditHours()
        {
            int count = 0;
            for (int x = 0; x < sub.Count; x++)
            {
                count = count + sub[x].creditHours;
            }
            return count;

        }

        public static void calculateMerit()
        {
            foreach(Student s in stu)
            {
                s.merit= (((s.fscMarks / 1100) * 0.45F) + ((s.ecatMarks / 400) * 0.55F)) * 100;
               
            }
           
        }

        public static int getCreditHours()
        {
            int creditHour = 0;
            foreach (Subject s in reg_Subj)
            {
                creditHour = creditHour + s.creditHours;
            }
            return creditHour;
        }

        public static int Calculate_Fee()
        {
            int fee = 0;
            foreach(Subject s in reg_Subj)
            {
                fee = fee + s.subjectFee;
            }
            return fee;
        }

        public static List<Student> sortedStudents()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in stu)
            {
                Data.calculateMerit();
            }
            sortedStudentList = stu.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }

        public static void giveAdmissions(List<Student> sortedstudentList)
        {
            foreach (Student s in sortedstudentList)
            {
                foreach (Degree_Program d in s.preferences)
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

        public static void Add_Subj_Input()
        {
            bool flag = false;
            Console.WriteLine("ENTER HOW MANY SUBJECTS YOU WANT TO REGISTER: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter code of subject:");
                string code = Console.ReadLine();
                foreach(Subject s in sub)
                {
                    if (s.subjectCode == code)
                    {
                        int count1 = Data.getCreditHours();
                        if(count1>=9)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            Subject q = new Subject(s.subjectCode, s.creditHours, s.subjectType, s.subjectFee);
                            Data.Add_Regsubj(q);
                            flag = true;
                        }
                        
                       
                    }

                }
                if(flag==false)
                {
                    Console.WriteLine("Wrong input!!!!");
                }
               
            }
        }


        public static void printStudents()
        {
            foreach (Student s in stu)
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

        public static Student presentStudents(string name)
        {
            foreach (Student s in stu)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }


        public static void viewStudentsInDegreee(string degName)
        {
            Console.WriteLine("NAME\tFSC\tECAT\tAGE");
            foreach (Student s in stu)
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


        public static void viewRegisteredStudents()
        {
            Console.WriteLine("NAME\tFSC\tECAT\tAGE");
            foreach (Student s in stu)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }
            }
        }

        public static void viewDegreeList()
        {
            foreach (Degree_Program dp in  d)
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
