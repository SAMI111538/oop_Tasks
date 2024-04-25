using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    public class Student
    {
        public string std_Name;
        public int std_age;
        public double fsc_Marks;
        public double ecat_Marks;
        public double merit;
        public static List<Student> listofStudent;
        public List<Degree_Program> preferences;
        public List<Subject> reg_Subject;
        public Degree_Program reg_Degree;


        public Student(string std_Name, int std_age, double fsc_Marks, double ecat_Marks, List<Degree_Program> preferences)
        {
            this.std_Name = std_Name;
            this.std_age = std_age;
            this.fsc_Marks = fsc_Marks;
            this.ecat_Marks = ecat_Marks;
            this.preferences = preferences;
            reg_Subject = new List<Subject>();
        }

        public bool add_subjects(Subject s)
        {

            int credit_hours = reg_Degree.calculate_credit_hours();
            if (credit_hours + s.credit_hours <= 20)
            {
                subjects.Add(s);
                return true;
            }

            else
            {
                return false;
            }

        }

        public bool is_Subject_Exists(Subject sub)
        {
            foreach (Subject s in subjects)
            {
                if (s.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }

        public void Calculate_merit()
        {
            this.merit = (((fsc_Marks / 1100) * 0.45F) + ((ecat_Marks / 400) * 0.55F)) * 100;
        }

    }

    public class Subject
    {
        public string code;
        public string type;
        public int credit_hours;
        public int subject_Fees;

        public Subject(string code, string type, int credit_hours, int subject_Fees)
        {
            this.code = code;
            this.type = type;
            this.credit_hours = credit_hours;
            this.subject_Fees = subject_Fees;
        }


    }

    public class Degree_Program
    {
        public string Degree_Name;
        public float Degree_Duration;
        public List<Subject> subjects;
        public int seats;

        public Degree_Program(string Degree_Name, float Degree_Duration, List<Subject> subjects, int seats)
        {
            this.Degree_Name = Degree_Name;
            this.Degree_Duration = Degree_Duration;
            this.subjects = subjects;
            this.seats = seats;
        }

        public int calculate_credit_Hours()
        {
            int counter = 0;
            for (int idx = 0; idx < subjects.Count; idx++)
            {
                counter = counter + subjects[idx].credit_hours;
            }
            return counter;
        }

        public bool reg_Student_Subject(Subject s)
        {
            int stCH = get_Credit_Hours();
            if (reg_Degree != null && reg_Degree.is_Subject_Exists(sub) && stCH  + s.credit_hours <=9)
            {
                reg_Subject . Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int get_Credit_Hours()
        {
            int counter = 0;
            foreach(Subject sub in reg_Subject)
            {
                counter = counter + sub.credit_hours;
            }
            return counter;
        }

        public float Calculate_fee()
        {
            float fee = 0;
            if (reg_Degree != null)
            {
                foreach(Subject sub in reg_Subject)
                {
                    fee = fee + sub.subject_Fees;
                }
            }
            return fee;
        }


    }
}
