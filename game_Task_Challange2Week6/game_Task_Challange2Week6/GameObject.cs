using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_Task_Challange2Week6
{
    class GameObject
    {
        public char[,] shape;
        public Point Starting_point;
        public Boundary Premises;
        public string Direction;

        public GameObject() { }
        public GameObject(char[,] shape, Point Starting_point, Boundary Premises, string Dir)
        {
            this.shape = shape;
            this.Starting_point = Starting_point;
            this.Premises = Premises;
            this.Direction = Dir;
        }

        public GameObject(char[,] shape, Point Starting_point)
        {
            this.shape = shape;
            this.Starting_point = Starting_point;
            this.Premises = new Boundary();
            this.Direction = "lefttoright";

        }

        public void draw()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(this.Starting_point.x, this.Starting_point.y + i);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(shape[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void erase()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(this.Starting_point.x, this.Starting_point.y + i);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void move()
        {
            if (Direction == "Left_to_Right")
            {
                move_Left_to_Right();
            }

            else if (Direction == "Right_to_Left")
            {
                move_Right_to_Left();
            }

            else if (Direction == "patrolleft" || Direction == "patrolright")
            {
                movepatrol();
            }

            else if (Direction == "diagonal")
            {
                move_In_Diagonal();
            }

        }

        public void move_Left_to_Right()
        {
            if (Starting_point.y > Premises.top_left.y && Starting_point.y < Premises.top_right.y)
            {
                erase();
                Starting_point.x = Starting_point.x + 1;
                draw();
            }
            Console.ReadKey();
        }
        public void move_Right_to_Left()
        {
            if (Starting_point.y > Premises.top_left.y && Starting_point.y < Premises.top_right.y)
            {
                erase();
                Starting_point.x = Starting_point.x - 1;
                draw();

            }


        }
        public void movepatrol()
        {

            if (Direction == "patrol")
            {
                if (Starting_point.y > Premises.top_left.y && Starting_point.y <= Premises.top_right.y)
                {
                    erase();
                    Starting_point.x = Starting_point.x - 1;
                    draw();
                }
                else
                {
                   Direction = "patrolright";
                }
            }

            else if (Direction == "patrolright")
            {
                if (Starting_point.y >= Premises.top_left.y && Starting_point.y < Premises.top_right.y)
                {
                    erase();
                    Starting_point.x = Starting_point.x + 1;
                    draw();
                }
                else
                {
                    Direction = "patrol";
                }
            }
        }
        public void move_In_Projectile()
        {
            //if (Starting_point.y > Premises.top_left.y && Starting_point.y < Premises.top_right.y)
            //{
            //    erase();
            //    Starting_point.x = Starting_point.x + 2;
            //    Starting_point.y = Starting_point.y - 1;
            //    draw();
            //    if ()
            //    {
            //        erase();
            //        Starting_point.x = Starting_point.x + 1;
            //        draw();
            //        if ()
            //        {
            //            erase();
            //            Starting_point.y = Starting_point.y + 1;
            //            draw();
            //        }
            //    }
            //}
        }

        public void move_In_Diagonal()
        {
            if (Starting_point.y > Premises.top_left.y && Starting_point.y < Premises.top_right.y)
            {
                erase();
                Starting_point.x = Starting_point.x + 2;
                Starting_point.y = Starting_point.y - 1;
                draw();
            }
        }
    }
}
