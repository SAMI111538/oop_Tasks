using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace game_Task_Challange2Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] shape = new char[5, 5] { { ' ', ' ', '*', ' ', ' ' }, { ' ', '*', '*', '*', ' ' }, { '*', '*', '*', '*', '*' }, { ' ', '*', '*', '*', ' ' }, { ' ', ' ', '*', ' ', ' ' } };

            Boundary b = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            //GameObject g1  = new GameObject(shape, new Point(5,5) ,b, "Left_to_Right");
            //GameObject g2 = new GameObject(shape, new Point(30,10 ),b,"Right_to_Left");
            //GameObject g3 = new GameObject(shape, new Point(5, 15), b, "diagonal");
            //GameObject g4 = new GameObject(shape, new Point(5, 20), b, "projectile");
            GameObject g5 = new GameObject(shape, new Point(5, 25), b, "patrolright");
            List<GameObject> lst = new List<GameObject>();
            //lst.Add(g1);
            //lst.Add(g2);
            //lst.Add(g3);
            //lst.Add(g4);
            lst.Add(g5);

            while (true)
            {
                Thread.Sleep(1000);
                foreach (GameObject g in lst)
                {
                    g.erase();
                    g.move();
                    g.draw();
                }
            }
        }

        
    }
}
