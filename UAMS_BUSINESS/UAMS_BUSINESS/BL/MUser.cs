using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_BUSINESS.BL;
using UAMS_BUSINESS.DL;
using UAMS_BUSINESS.UI;

namespace UAMS_BUSINESS.BL
{
    public class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<Degree_Program> preferences;
        public Degree_Program regDegree;
        public List<Subject> regsubjects;
        public Student(string name, int age, double fscMarks, double ecatMarks, List<Degree_Program> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
            
        }
        public Student()
        {

        }



    }
    public class Subject
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
    public class Degree_Program
    {
        public string degreeTitle;
        public float duration;
        public int seats;

        public Degree_Program(string degreeTitle, float duration, int seats)
        {
            this.degreeTitle = degreeTitle;
            this.duration = duration;
            this.seats = seats;

        }

    }

}
