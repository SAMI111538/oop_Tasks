using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    class Student
    {
        int id;
        string Name;
        string Registration_Number;
        private static List<Student> students = new List<Student>();

        public Student(int id,string Name, string Registration_Number)
        {
            this.id = id;
            this.Name = Name;
            this.Registration_Number = Registration_Number;
        }

        public int Id { get => id; set => id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Registration_Number1 { get => Registration_Number; set => Registration_Number = value; }
        public static List<Student> Students { get => students; set => students = value; }
    }
}
