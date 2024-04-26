using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Challange1pd7
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid m = new Grid(@"C:\Users\AL-FATAH LAPTOP\OneDrive\Desktop\mazePacman.txt", 19, 60);
            m.draw_Maze();
            Console.ReadKey();
        }
    }
}
