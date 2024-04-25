using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_BL;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_DL;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_UI;
using Week_5_UAMS__BL___DL___UI_.menu_UI;
using Week_5_UAMS__BL___DL___UI_.Student_BL;
using Week_5_UAMS__BL___DL___UI_.Student_DL;
using Week_5_UAMS__BL___DL___UI_.student_UI;
using Week_5_UAMS__BL___DL___UI_.subject_DL;
using Week_5_UAMS__BL___DL___UI_.subject_UI;

namespace Week_5_UAMS__BL___DL___UI_
{
    public class Program
    {
        static List<student> studentlist = new List<student>();
        static List<degreeProgram> programs = new List<degreeProgram>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                option = menuUI.menu();
                Console.Clear();
                if (option == 1)
                {
                    if (programs.Count > 0)
                    {
                        student s = studentUI.takeinputforstudent(programs);
                       studentCRUD.addintostudentlist(s , studentlist);
                        Console.ReadKey();
                    }

                }
                else if (option == 2)
                {
                    degreeProgram d = degreeProgramUI.takeinputfordegree();
                    degreeProgramCRUD.addintodegreelist(d , programs);
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    List<student> sortedstudentlist = new List<student>();
                    sortedstudentlist = studentCRUD.sortstudentsbymerit(studentlist);
                    studentCRUD.giveadmission(sortedstudentlist);
                    studentCRUD.printstudent(studentlist);
                    Console.ReadKey();

                }
                else if (option == 4)
                {
                    studentCRUD.viewregisteredstudents(studentlist);
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    string degree;
                    Console.WriteLine("Enter the degree name : ");
                    degree = Console.ReadLine();
                   studentCRUD.viewstudentindegree(degree , studentlist);
                    Console.ReadKey();

                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter the student name : ");
                    string name = Console.ReadLine();
                    student s = studentCRUD.studentpresent(name , studentlist);
                    if (s != null)
                    {
                       subjectCRUD.viewsubjects(s);
                       subjectUI.registersubjects(s);

                    }
                    Console.ReadKey();
                }
                else if (option == 7)
                {
                    studentCRUD.Calculatefee(studentlist);
                    Console.ReadKey();
                }
                else if (option == 8)
                {
                    break;
                }


            }
            while (option < 9);
            Console.Read();
        }
    }
}
