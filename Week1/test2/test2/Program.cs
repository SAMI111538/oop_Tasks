using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        class student
        {
            public string name;
            public int roll_no;
            public float cgpa;

        }
        static void Main(string[] args)
        {
            //task1();
            //task2();
            task3();
            
        }
        static void task1()
        {
            student s1 = new student();
            s1.name = "sami";
            s1.roll_no = 5;
            s1.cgpa = 3.5F;
            Console.WriteLine("Name : {0}  Roll No. : {1}  CGPA {2}", s1.name, s1.roll_no, s1.cgpa);
            Console.ReadKey();
        }
        static void task2()
        {
            Console.Clear();
            student s_1 = new student();
            s_1.name = "sami";
            s_1.roll_no = 5;
            s_1.cgpa = 3.5F;
            Console.WriteLine("Name : {0}  Roll No. : {1}  CGPA {2}", s_1.name, s_1.roll_no, s_1.cgpa);
            student s_2 = new student();
            s_2.name = "Adeel";
            s_2.roll_no = 5;
            s_2.cgpa = 3.5F;
            Console.WriteLine("Name : {0}  Roll No. : {1}  CGPA {2}", s_2.name, s_2.roll_no, s_2.cgpa);
            Console.ReadKey();
        }
        static void task3()
        {
            Console.Clear();
            student s3 = new student();
            Console.WriteLine("Enter Name : ");
            s3.name = Console.ReadLine();
            Console.WriteLine("Enter Roll No. : ");
            s3.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA : ");
            s3.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0}  Roll No. : {1}  CGPA {2}", s3.name, s3.roll_no, s3.cgpa);
            Console.ReadKey();

        }
    }
}
