using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_BL;
using Week_5_UAMS__BL___DL___UI_.Student_BL;

namespace Week_5_UAMS__BL___DL___UI_.Student_DL
{
    public class studentCRUD
    { 
        public static void addintostudentlist(student s , List<student> studentlist)
        {
            studentlist.Add(s);
        }

         public static student studentpresent(string name , List<student> studentlist)
         {
            foreach (student s in studentlist)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
         }

        public static void Calculatefee(List<student> studentlist)
        {
            foreach (student s in studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " has " + s.calculatefee() + " fees ");
                }
            }
        }
        public static List<student> sortstudentsbymerit(List<student> studentlist)
        {
            List<student> sortedstudentlist = new List<student>();
            foreach (student s in studentlist)
            {
                s.calculatemerit();
            }
            sortedstudentlist = studentlist.OrderByDescending(o => o.merit).ToList();
            return sortedstudentlist;

        }

        public static void giveadmission(List<student> sortedstudentlist)
        {
            foreach (student s in sortedstudentlist)
            {
                foreach (degreeProgram d in s.preferences)
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

         public static void printstudent(List<student> studentlist)
        {
            foreach (student s in studentlist)
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

       public static void viewstudentindegree(string degrename , List<student> studentlist)
        {
            Console.WriteLine("Name    Fsc      Ecat    Age  ");
            foreach (student s in studentlist)
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
        public static void viewregisteredstudents(List<student> studentlist)
        {
            Console.WriteLine("Name    Fsc      Ecat    Age  ");
            foreach (student s in studentlist)
            {
                if (s.regDegree != null)
                {

                    Console.WriteLine(s.name + "  " + s.fscmarks + "  " + s.ecatmarks + "  " + s.age);

                }
            }

        }




    }
}
