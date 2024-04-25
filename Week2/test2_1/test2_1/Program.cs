using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2_1
{
    class Program
    {
        class student
        {
            public string name;
            public int roll_no;
            public float cgpa;
            public char is_Hostelide;
            public string department;

        }
        static void Main(string[] args)
        {
            student[] std1 = new student[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    std1[count] = addStudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    view_student(std1, count);
                }
                else if (option == '3')
                {
                    Top_Student(std1, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            while (option != 4);
            Console.WriteLine("Press Enter To Exit");
            Console.ReadKey();

        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press1 for Adding students");
            Console.WriteLine("Press2 for for viewing students");
            Console.WriteLine("Press3 for Top three students");
            Console.WriteLine("Press4 for to exit.");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static student addStudent()
        {
            Console.Clear();
            student std1 = new student();
            Console.WriteLine("Enter Name : ");
            std1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll No. : ");
            std1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA : ");
            std1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department : ");
            std1.department = Console.ReadLine();
            Console.WriteLine("Enter IsHostelide : ");
            std1.is_Hostelide = char.Parse(Console.ReadLine());
            return std1;

        }
        static void view_student(student[] std1,int count)
        {
            Console.Clear();
            for(int idx2 =0;idx2<count; idx2++)
            {
                Console.WriteLine("Name : {0}  Roll No. : {1}  CGPA {2} Department : {3} IsHostelide : {4}", std1[idx2].name, std1[idx2].roll_no, std1[idx2].cgpa, std1[idx2].department,std1[idx2].is_Hostelide);
            }
            Console.WriteLine("Press any Key To Continue !");
            Console.ReadKey();
        }
        static void  Top_Student(student[] std1, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Present!");
                Console.ReadKey();
            }
            else if (count==1)
            {
                view_student(std1, 1);
            }
            else if (count == 2)
            {
                for (int idx1 = 0; idx1 < 2; idx1++)
                {
                    int index = largest(std1, idx1, count);
                    student temp = std1[index];
                    std1[index] = std1[idx1];
                    std1[idx1] = temp;
                }
                view_student(std1, 2);
            }
            else
            {
                for (int idx1 = 0; idx1 < 3; idx1++)
                {
                    int index = largest(std1, idx1, count);
                    student temp = std1[index];
                    std1[index] = std1[idx1];
                    std1[idx1] = temp;
                }
                view_student(std1, 3);
            }
        }
        static int largest(student[] std1,int start,int end)
        {
            int index = start;
            float large = std1[start].cgpa;
            for (int idx1 = start; idx1<end;idx1++)
            {
                if (large< std1[idx1].cgpa)
                {
                    large = std1[idx1].cgpa;
                    index = idx1;
                }
            }
            return index;
        }
    }
}