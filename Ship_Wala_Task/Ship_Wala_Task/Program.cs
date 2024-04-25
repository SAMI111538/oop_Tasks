using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship_Constructor__Week5pd
{
    class Program
    {
        class Angle
        {
            public int degree;
            public float minutes;
            public char direction;


            public Angle()
            {

            }
            public Angle(int degree, float minutes, char direction)

            {
                this.degree = degree;
                this.minutes = minutes;
                this.direction = direction;
            }
        }


        class Ship
        {
            public Angle lattitude;
            public Angle longitude;
            public string Ship_Number;

            public Ship()
            {

            }
            public Ship(string Ship_Number, Angle lattitude, Angle longitude)
            {
                this.Ship_Number = Ship_Number;
                this.lattitude = lattitude;
                this.longitude = longitude;
            }

            //public int getLongitude()
            //{
            //    return longitude;
            //}


            public Ship Add_Ship_Info()
            {
                string Ship_Number;
                Angle a = new Angle();
                Angle b = new Angle();
                Console.WriteLine("Enter the Ship Number : ");
                Ship_Number = Console.ReadLine();

                Console.WriteLine("Enter ship latitude : ");
                Console.Write("Enter the latitude's Degree : ");
                a.degree = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the latitude's Minutes : ");
                a.minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the latitude's direction");
                a.direction = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter ship longitude : ");
                Console.WriteLine("Enter the longitude's Degree:");
                b.degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the longitude's Minutes : ");
                b.minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the longitude's direction");
                b.direction = char.Parse(Console.ReadLine());

                Ship c = new Ship(Ship_Number, a, b);
                return c;
            }


            static void Main(string[] args)
            {
                List<Ship> m = new List<Ship>();
                Ship s = new Ship();
                int option_Menu = 0;
                do
                {
                    Console.Clear();
                    option_Menu = Menu();

                    if (option_Menu == 1)
                    {
                        Ship b = s.Add_Ship_Info();
                        m.Add(b);
                        Console.ReadKey();
                    }
                    if (option_Menu == 2)
                    {
                        View_Ship_Position(m);
                        Console.ReadKey();
                    }

                    if (option_Menu == 3)
                    {
                        string result = View_Ship_Number(m);
                        Console.WriteLine("THE SERIAL NUMBER OF THE SHIP IS : " + result);
                        Console.ReadKey();
                    }

                    if (option_Menu == 4)
                    {
                        change_ShipPosition(m);
                        Console.ReadKey();
                    }
                    if (option_Menu == 5)
                    {
                        break;
                    }

                } while (option_Menu < 6);
            }

            static int Menu()
            {
                int option;
                Console.WriteLine("1.Add the ship");
                Console.WriteLine("2.View ship Postion");
                Console.WriteLine("3.View Ship Serial Number");
                Console.WriteLine("4.Change Ship Position");
                Console.WriteLine("5.Exit");
                option = int.Parse(Console.ReadLine());
                return option;
            }



            public void getLattitude()
            {

            }
            public void setLattitude(int latti)
            {
                Console.WriteLine("Enter the Lattitude of the ship:");
                latti = int.Parse(Console.ReadLine());
            }

            static void View_Ship_Position(List<Ship> m)
            {
                string shipno;
                Console.WriteLine("Enter the Ship Number : ");
                shipno = Console.ReadLine();
                for (int idx = 0; idx < m.Count; idx++)
                {
                    if (shipno == m[idx].Ship_Number)
                    {
                        Console.WriteLine("Ship is at  " + m[idx].lattitude.degree + " " + "\u00b0" + " " + m[idx].lattitude.minutes + " " + m[idx].lattitude.direction + "  and  " + m[idx].longitude.degree + "\u00b0" + m[idx].longitude.minutes + " " + m[idx].longitude.direction);

                    }
                }
            }
            static string View_Ship_Number(List<Ship> m)
            {
                Console.WriteLine("Enter ship latitude : ");
                Console.Write("Enter the latitude's Degree : ");
                int degree = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the latitude's Minutes : ");
                float minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the latitude's direction");
                char direction = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter ship longitude : ");
                Console.WriteLine("Enter the longitude's Degree:");
                int degree1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the longitude's Minutes : ");
                float minutes1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the longitude's direction");
                char direction1 = char.Parse(Console.ReadLine());
                for (int idx = 0; idx < m.Count; idx++)
                {
                    if (degree == m[idx].lattitude.degree && minutes == m[idx].lattitude.minutes && direction == m[idx].lattitude.direction && degree1 == m[idx].longitude.degree && minutes1 == m[idx].longitude.minutes && direction1 == m[idx].longitude.direction)
                    {
                        return m[idx].Ship_Number;
                    }
                }
                return null;
            }

            static void change_ShipPosition(List<Ship> m)
            {
                string serial_Number;
                Console.WriteLine("Enter the serial number of the ship whose you wanna change the position: ");
                serial_Number = Console.ReadLine();
                for (int idx = 0; idx < m.Count; idx++)
                {
                    if (serial_Number == m[idx].Ship_Number)
                    {
                        Console.WriteLine("Enter ship latitude : ");
                        Console.Write("Enter the latitude's Degree : ");
                        m[idx].lattitude.degree = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the latitude's Minutes : ");
                        m[idx].lattitude.minutes = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the latitude's direction");
                        m[idx].lattitude.direction = char.Parse(Console.ReadLine());

                        Console.WriteLine("Enter ship longitude : ");
                        Console.WriteLine("Enter the longitude's Degree:");
                        m[idx].longitude.degree = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the longitude's Minutes : ");
                        m[idx].longitude.minutes = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the longitude's direction");
                        m[idx].longitude.direction = char.Parse(Console.ReadLine());
                    }
                }
            }
        }
    }
}