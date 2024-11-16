using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace malik_UAMS_with_LAYERS.BL
{
    public class Subject
    {

        public string Subjectcode;
        public string Subjecttype;
        public int credithours;
        public int Subjectfees;

        public Subject()
        {

        }
        public Subject(string code, string type, int ch, int fees)
        {
            this.Subjectcode = code;
            this.Subjecttype = type;
            this.credithours = ch;
            this.Subjectfees = fees;
        }
    }
    public class Student
    {
        public string name;
        public int age;
        public double fscmarks;
        public double ecatmarks;
        public double merit;
        public List<Degree_Program> preferences;
        public List<Subject> regSubjects;
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
            regSubjects = new List<Subject>();
        }

        public void calculatemerit()
        {
            this.merit = (((fscmarks / 1100) * 0.45F) + ((ecatmarks / 400) * 0.55F)) * 100;
        }

        public int getcrdithours()
        {
            int count = 0;
            for (int idx = 0; idx < regSubjects.Count; idx++)
            {
                count = count + regSubjects[idx].credithours;
            }
            return count;

        }
        public bool regStudentSub(Subject s)
        {
            int ch = getcrdithours();
            if (regDegree != null && regDegree.isSubjectexists(s) && ch + s.credithours <= 9)
            {
                regSubjects.Add(s);
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
                for (int idx = 0; idx < regSubjects.Count; idx++)
                {
                    fees = fees + regSubjects[idx].Subjectfees;
                }

            }
            return fees;
        }
    }


    public class Degree_Program
    {
        public string degreeName;
        public int degreeDuration;
        public int seats;
        public List<Subject> Subjects;

        public Degree_Program()
        {

        }
        public Degree_Program(string name, int duration, int seats)
        {
            this.degreeName = name;
            this.degreeDuration = duration;
            this.seats = seats;
            Subjects = new List<Subject>();
        }

        public int calculatecredithours()
        {
            int count = 0;
            for (int idx = 0; idx < Subjects.Count; idx++)
            {
                count = count + Subjects[idx].credithours;
            }
            return count;
        }

        public bool addSubject(Subject s)
        {
            int ch = calculatecredithours();
            if (ch + s.credithours <= 20)
            {
                Subjects.Add(s);
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool isSubjectexists(Subject sub)
        {
            for (int idx = 0; idx < Subjects.Count; idx++)
            {
                if (Subjects[idx].Subjectcode == sub.Subjectcode)
                {
                    return true;
                }
            }
            return false;

        }

    }
}
