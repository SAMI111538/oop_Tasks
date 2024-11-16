using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.BL;

namespace Layers.DL
{
    public class Data
    {
        public static void viewdegreePrograms(List<Degree_Program> programs)
        {
            for (int idx = 0; idx < programs.Count; idx++)
            {
                Console.WriteLine(programs[idx].degreeName);
            }

        }

        public static void addintodegreelist(Degree_Program d, List<Degree_Program> programs)
        {
            programs.Add(d);
        }

        public static void addintostudentlist(Student s, List<Student> studentlist)
        {
            studentlist.Add(s);
        }

        public static Student studentpresent(string name, List<Student> studentlist)
        {
            foreach (Student s in studentlist)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }

        public static void Calculatefee(List<Student> studentlist)
        {
            foreach (Student s in studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " has " + s.calculatefee() + " fees ");
                }
            }
        }
        public static List<Student> sortstudentsbymerit(List<Student> studentlist)
        {
            List<Student> sortedstudentlist = new List<Student>();
            foreach (Student s in studentlist)
            {
                s.calculatemerit();
            }
            sortedstudentlist = studentlist.OrderByDescending(o => o.merit).ToList();
            return sortedstudentlist;

        }

        public static void giveadmission(List<Student> sortedstudentlist)
        {
            foreach (Student s in sortedstudentlist)
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

        public static void printstudent(List<Student> studentlist)
        {
            foreach (Student s in studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " got admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + " did not get admission!");
                }
            }
        }

        public static void viewstudentindegree(string degrename, List<Student> studentlist)
        {
            Console.WriteLine("Name    Fsc      Ecat    Age  ");
            foreach (Student s in studentlist)
            {
                if (s.regDegree != null)
                {
                    if (degrename == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "  " + s.fscmarks + "  " + s.ecatmarks + "  " + s.age);
                    }
                }
            }

        }
        public static void viewregisteredstudents(List<Student> studentlist)
        {
            Console.WriteLine("Name    Fsc      Ecat    Age  ");
            foreach (Student s in studentlist)
            {
                if (s.regDegree != null)
                {

                    Console.WriteLine(s.name + "  " + s.fscmarks + "  " + s.ecatmarks + "  " + s.age);

                }
            }

        }

        public class subjectCRUD
        {
            public static void viewsubjects(Student s)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine("Sub Code    Sub Type");
                    foreach (Subject sub in s.regDegree.subjects)
                    {
                        Console.WriteLine(sub.subjectcode + "      " + sub.subjecttype);
                    }
                }
            }

        }


    }
}

