using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.DL;
using Layers.UI;

namespace Layers.BL
{
    public class Student
    {
        public string name;
        public int age;
        public double fscmarks;
        public double ecatmarks;
        public double merit;
        public List<Degree_Program> preferences;
        public List<Subject> regsubjects;
        public Degree_Program regDegree;

        public Student()
        {

        }
        public Student(string name, int age, double fscmarks, double em, List<Degree_Program> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscmarks = fscmarks;
            this.ecatmarks = em;
            this.preferences = preferences;
            regsubjects = new List<Subject>();
        }

        public void calculatemerit()
        {
            this.merit = (((fscmarks / 1100) * 0.45F) + ((ecatmarks / 400) * 0.55F)) * 100;
        }

        public int getcrdithours()
        {
            int count = 0;
            for (int idx = 0; idx < regsubjects.Count; idx++)
            {
                count = count + regsubjects[idx].credithours;
            }
            return count;

        }
        public bool regStudentSub(Subject s)
        {
            int ch = getcrdithours();
            if (regDegree != null && regDegree.isSubjectexists(s) && ch + s.credithours <= 9)
            {
                regsubjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }

        }

        public float calculatefee()
        {
            float fees = 0;
            if (regDegree != null)
            {
                for (int idx = 0; idx < regsubjects.Count; idx++)
                {
                    fees = fees + regsubjects[idx].subjectfees;
                }

            }
            return fees;

        }

        public class Degree_Program
        {
            public string degreeName;
            public int degreeDuration;
            public int seats;
            public List<Subject> subjects;

            public Degree_Program()
            {

            }
            public Degree_Program(string name, int duration, int seats)
            {
                this.degreeName = name;
                this.degreeDuration = duration;
                this.seats = seats;
                subjects = new List<Subject>();
            }

            public int calculatecredithours()
            {
                int count = 0;
                for (int idx = 0; idx < subjects.Count; idx++)
                {
                    count = count + subjects[idx].credithours;
                }
                return count;
            }

            public bool addsubject(Subject s)
            {
                int ch = calculatecredithours();
                if (ch + s.credithours <= 20)
                {
                    subjects.Add(s);
                    return true;

                }
                else
                {
                    return false;
                }
            }

            public bool isSubjectexists(Subject sub)
            {
                for (int idx = 0; idx < subjects.Count; idx++)
                {
                    if (subjects[idx].subjectcode == sub.subjectcode)
                    {
                        return true;
                    }
                }
                return false;

            }

        }


        public class Subject
        {

            public string subjectcode;
            public string subjecttype;
            public int credithours;
            public int subjectfees;

            public Subject()
            {

            }
            public Subject(string code, string type, int ch, int fees)
            {
                this.subjectcode = code;
                this.subjecttype = type;
                this.credithours = ch;
                this.subjectfees = fees;
            }
        }

    }
}
