using FinalApplicationGUI.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplicationGUI.DL
{
    class AdminDL
    {
        public static List<string> feedbacks = new List<string>();
        public static Admin ad= new Admin();
           
        public static void setAdmin(Admin admin)
        {
            ad = admin;
        }
        public static Admin GetAdmin()
        {
            return ad;
        }
    
    }
}
