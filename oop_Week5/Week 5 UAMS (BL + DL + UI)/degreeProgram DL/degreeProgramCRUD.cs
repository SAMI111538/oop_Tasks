using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_BL;

namespace Week_5_UAMS__BL___DL___UI_.degreeProgram_DL
{
    public  class degreeProgramCRUD
    {
        public static void viewdegreePrograms(List <degreeProgram> programs)
        {
            for (int idx = 0; idx < programs.Count; idx++)
            {
                Console.WriteLine(programs[idx].degreeName);
            }
        }

        public static void addintodegreelist(degreeProgram d , List<degreeProgram> programs)
        {
            programs.Add(d);
        }
    }
}
