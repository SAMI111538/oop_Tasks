using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using malik_UAMS_with_LAYERS.BL;
using System.IO;

namespace malik_UAMS_with_LAYERS.DL
{
    public class data
    {
        public static void viewsubjects(Student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code    Sub Type");
                foreach (Subject sub in s.regDegree.Subjects)
                {
                    Console.WriteLine(sub.Subjectcode + "      " + sub.Subjecttype);
                }
            }
        }

        public static void addintostudentlist(Student s, List<Student> studentlist)
        {
            studentlist.Add(s);
        }

        public static void addSubjectintolist(Subject sub, List<Subject> subjectlist)
        {
            subjectlist.Add(sub);
        }

        //public static bool read_SubjectData_from_File(string path)
        //{
        //    StreamReader f = new StreamReader(path,true);
        //    string record;
        //    if(File.Exists(path))
        //    {
        //        while((record = f.ReadLine()) != null)
        //        {
        //            string[] splitted_Record = record.Split(',');
        //            string code = splitted_Record[0];
        //            string type = splitted_Record[1];
        //            int credit_Hours = int.Parse(splitted_Record[2]);
        //            int Subject_Fee = int.Parse(splitted_Record[3]);
        //            Subject s = new Subject(code, type, credit_Hours, Subject_Fee);
        //            addSubjectintolist(s);
        //        }
        //        f.Close();
        //        return true;
        //    }

        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static void  store_Subject_Data_inFile(Subject s, string path)
        //{
        //    StreamWriter f = new StreamWriter(path);
        //    f.WriteLine(s.Subjectcode + s.Subjecttype + s.credithours + s.Subjectfees);
        //    f.Flush();
        //    f.Close();
        //}

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


       /* public static void store_DegreeData_inFile(string path,Student s)
        {
            StreamWriter f = new StreamWriter(path);
            string degreeName = "";
            for(int x = 0; x < s.preferences.Count - 1; x++)
            {

            }

        }*/
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


    }
}
