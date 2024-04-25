using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.Student_BL;
using Week_5_UAMS__BL___DL___UI_.Subject_BL;

namespace Week_5_UAMS__BL___DL___UI_.subject_DL
{
    public class subjectCRUD
    {
       public static void viewsubjects(student s)
       {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code    Sub Type");
                foreach (subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.subjectcode + "      " + sub.subjecttype);
                }
            }
       }
        
    }
}
