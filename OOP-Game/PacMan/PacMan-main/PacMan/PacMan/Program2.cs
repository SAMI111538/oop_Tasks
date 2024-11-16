using System;
using System.Threading;
using EZInput;
using System.IO;
using PacMan.GL;
namespace PacMan
{
    
    class Program2
    {
        static int score = 0;
        static void MainOld(string[] args)
        {
            // PacMan Coordinates
            PacManPlayer pacMan = new PacManPlayer(9,31);

            // Ghost 1 (Horizontal) Information

            Ghost ghost1 = new Ghost(15, 39, "left", 0.1F);
            char previous1 = ' ';
            float deltaChange1=0;

            // Ghost 2 (Vertical) Information
            Ghost ghost2 = new Ghost(20, 57, "up", 0.01F);
            char previous2 = ' ';
            float deltaChange2 = 0;

            // Ghost 3 (Random) Information
            Ghost ghost3 = new Ghost(19, 25, "up", 0.5F);
            char previous3 = ' ';
            float deltaChange3 = 0;

            // Ghost 4 (Smart) Information
            Ghost ghost4 = new Ghost(21, 30, "up", 0.9F);
            char previous4 = ' ';
            float deltaChange4 = 0;

            char[,] maze = new char[24, 71];

            readData(maze);
            printMaze(maze);

            Console.SetCursorPosition(pacMan.pacmanX, pacMan.pacmanY);
            Console.Write("P");

            bool gameRunning = true;
            while (true)
            {
                Thread.Sleep(90);
                printScore();
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    movePacManUp(maze, pacMan);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    movePacManDown(maze, pacMan);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    movePacManLeft(maze, pacMan);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    movePacManRight(maze, pacMan);
                }
               
                
                deltaChange1 = deltaChange1 + ghost1.speed;
                if (Math.Floor(deltaChange1) == 1)            // Slowest Movement
                {
                    gameRunning = moveGhostInLine(ghost1, maze, ref previous1);
                    if (gameRunning == false)
                    { break;
                    }
                    deltaChange1 = 0;
                }

                
                deltaChange2 = deltaChange2 + ghost2.speed;
                if (Math.Floor(deltaChange2) == 1)            // Slow Movement
                {
                    gameRunning = moveGhostInLine(ghost2, maze, ref previous2);
                    if (gameRunning == false)
                    {
                        break;
                    }
                    deltaChange2= 0;
                }

                deltaChange3 = deltaChange3 + ghost3.speed;
                if (Math.Floor(deltaChange3) == 1) 
                {
                    gameRunning = moveGhostRandom(maze, ghost3, ref previous3);
                    if (gameRunning == false)
                    {
                        break;
                    }
                    deltaChange3 = 0;
                }

                deltaChange4 = deltaChange4 + ghost4.speed;
                if (Math.Floor(deltaChange4) == 1)
                {
                    gameRunning = moveGhostSmart(maze,ghost4, ref previous4, pacMan);
                    if (gameRunning == false) {
                        break;
                    }
                    deltaChange4 = 0;
                }
               
            }
        }

        static void printScore()
        {
            Console.SetCursorPosition(79, 12);
            Console.WriteLine("Score: " + score);
        }

        static bool moveGhostSmart(char[,] maze, Ghost ghost, ref char previous, PacManPlayer pacMan)
        {
            double[] distance = new double[4] { 1000000, 1000000, 1000000, 1000000 };
            if (maze[ghost.ghostX, ghost.ghostY - 1] != '|' && maze[ghost.ghostX, ghost.ghostY - 1] != '%')
            {
                distance[0] = (calculateDistance(ghost.ghostX, ghost.ghostY - 1, pacMan.pacmanX, pacMan.pacmanY));
            }
            if (maze[ghost.ghostX, ghost.ghostY + 1] != '|' && maze[ghost.ghostX, ghost.ghostY + 1] != '%')
            {
                distance[1] = (calculateDistance(ghost.ghostX, ghost.ghostY + 1, pacMan.pacmanX, pacMan.pacmanY));
            }
            if (maze[ghost.ghostX + 1, ghost.ghostY] != '|' && maze[ghost.ghostX + 1, ghost.ghostY] != '%' && maze[ghost.ghostX + 1, ghost.ghostY] != '#')
            {
                distance[2] = (calculateDistance(ghost.ghostX + 1, ghost.ghostY, pacMan.pacmanX, pacMan.pacmanY));
            }
            if (maze[ghost.ghostX - 1, ghost.ghostY] != '|' && maze[ghost.ghostX - 1, ghost.ghostY] != '%' && maze[ghost.ghostX - 1, ghost.ghostY] != '#')
            {
                distance[3] = (calculateDistance(ghost.ghostX - 1, ghost.ghostY, pacMan.pacmanX, pacMan.pacmanY));
            }
            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                ghost.ghostDirection = "left"; 
                return moveGhostInLine(ghost, maze, ref previous);
            }
            if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                ghost.ghostDirection = "right";
                return moveGhostInLine(ghost, maze, ref previous);
            }
            if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                
                ghost.ghostDirection = "down";
                return moveGhostInLine(ghost, maze, ref previous);
            }
            else
            {
                ghost.ghostDirection = "up";
                return moveGhostInLine(ghost, maze, ref previous);
            }
        }

        static double calculateDistance(int X, int Y, int pX, int pY)
        {
            return Math.Sqrt(Math.Pow((pX - X), 2) + Math.Pow((pY - Y), 2));
        }

        static bool moveGhostInLine(Ghost ghost, char[,] maze, ref char previous)
        {
            if (maze[ghost.ghostX, ghost.ghostY - 1] == 'P' || maze[ghost.ghostX, ghost.ghostY + 1] == 'P' || maze[ghost.ghostX + 1, ghost.ghostY] == 'P' || maze[ghost.ghostX - 1, ghost.ghostY] == 'P')
            {
                return false;
            }
            if (ghost.ghostDirection == "left" && (maze[ghost.ghostX, ghost.ghostY - 1] == ' ' || maze[ghost.ghostX, ghost.ghostY - 1] == '.'))
            {
                maze[ghost.ghostX, ghost.ghostY] = previous;
                Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                Console.Write(previous);

                ghost.ghostY = ghost.ghostY - 1;

                previous = maze[ghost.ghostX, ghost.ghostY];
                Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                Console.Write("G");
                if (maze[ghost.ghostX, ghost.ghostY - 1] == '|')
                {
                    ghost.ghostDirection = "right";
                }
            }
            else if (ghost.ghostDirection == "right" && (maze[ghost.ghostX, ghost.ghostY + 1] == ' ' || maze[ghost.ghostX, ghost.ghostY + 1] == '.'))
            {
                maze[ghost.ghostX, ghost.ghostY] = previous;
                Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                Console.Write(previous);

                ghost.ghostY = ghost.ghostY + 1;

                previous = maze[ghost.ghostX, ghost.ghostY];
                Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                Console.Write("G");
                if (maze[ghost.ghostX, ghost.ghostY + 1] == '|')
                {
                    ghost.ghostDirection = "left";
                }
            }
            else if (ghost.ghostDirection == "up" && (maze[ghost.ghostX - 1, ghost.ghostY] == ' ' || maze[ghost.ghostX - 1, ghost.ghostY] == '.'))
            {
                maze[ghost.ghostX, ghost.ghostY] = previous;
                Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                Console.Write(previous);

                ghost.ghostX = ghost.ghostX - 1;

                previous = maze[ghost.ghostX, ghost.ghostY];
                Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                Console.Write("G");
                if (maze[ghost.ghostX - 1, ghost.ghostY] == '%' || maze[ghost.ghostX - 1, ghost.ghostY] == '#')
                {
                    ghost.ghostDirection = "down";
                }
            }
            else if (ghost.ghostDirection == "down" && (maze[ghost.ghostX + 1, ghost.ghostY] == ' ' || maze[ghost.ghostX + 1, ghost.ghostY] == '.'))
            {
                maze[ghost.ghostX, ghost.ghostY] = previous;
                Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                Console.Write(previous);

                ghost.ghostX = ghost.ghostX + 1;

                previous = maze[ghost.ghostX, ghost.ghostY];
                Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                Console.Write("G");
                if (maze[ghost.ghostX + 1, ghost.ghostY] == '%' || maze[ghost.ghostX + 1, ghost.ghostY] == '#')
                {
                    ghost.ghostDirection = "up";
                }
            }
            return true;
        }

        static int ghostDirection()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }

        static bool moveGhostRandom(char[,] maze, Ghost ghost, ref char previous)
        {
            if (maze[ghost.ghostX, ghost.ghostY - 1] == 'P' || maze[ghost.ghostX, ghost.ghostY + 1] == 'P' || maze[ghost.ghostX + 1, ghost.ghostY] == 'P' || maze[ghost.ghostX - 1, ghost.ghostY] == 'P')
            {
                return false;
            }
            int value = ghostDirection();
            if (value == 0)
            {
                if (maze[ghost.ghostX, ghost.ghostY - 1] == ' ' || maze[ghost.ghostX, ghost.ghostY - 1] == '.' || maze[ghost.ghostX, ghost.ghostY - 1] == 'P')
                {
                    maze[ghost.ghostX, ghost.ghostY] = previous;
                    Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                    Console.Write(previous);

                    ghost.ghostY = ghost.ghostY - 1;
                    previous = maze[ghost.ghostX, ghost.ghostY];
                    Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                    Console.Write('G');
                }
            }
            else if (value == 1)
            {
                if (maze[ghost.ghostX, ghost.ghostY + 1] == ' ' || maze[ghost.ghostX, ghost.ghostY + 1] == '.' || maze[ghost.ghostX, ghost.ghostY + 1] == 'P')
                {
                    maze[ghost.ghostX, ghost.ghostY] = previous;
                    Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                    Console.Write(previous);
                    ghost.ghostY = ghost.ghostY + 1;
                    previous = maze[ghost.ghostX, ghost.ghostY];
                    Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                    Console.Write('G');
                }
            }
            else if (value == 2)
            {
                if (maze[ghost.ghostX - 1, ghost.ghostY] == ' ' || maze[ghost.ghostX - 1, ghost.ghostY] == '.' || maze[ghost.ghostX - 1, ghost.ghostY] == 'P')
                {
                    maze[ghost.ghostX, ghost.ghostY] = previous;
                    Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                    Console.Write(previous);
                    ghost.ghostX = ghost.ghostX - 1;
                    previous = maze[ghost.ghostX, ghost.ghostY];
                    Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                    Console.Write('G');
                }
            }
            else if (value == 3)
            {
                if (maze[ghost.ghostX + 1, ghost.ghostY] == ' ' || maze[ghost.ghostX + 1, ghost.ghostY] == '.' || maze[ghost.ghostX + 1, ghost.ghostY] == '.')
                {
                    maze[ghost.ghostX, ghost.ghostY] = previous;
                    Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                    Console.Write(previous);
                    ghost.ghostX = ghost.ghostX + 1;
                    previous = maze[ghost.ghostX, ghost.ghostY];
                    Console.SetCursorPosition(ghost.ghostY, ghost.ghostX);
                    Console.Write('G');
                }
            }
            return true;
        }
        static void calculateScore()
        {
            score = score + 1;
        }


        static void movePacManUp(char[,] maze, PacManPlayer pacMan)
        {
            if (maze[pacMan.pacmanX - 1, pacMan.pacmanY] == ' ' || maze[pacMan.pacmanX - 1, pacMan.pacmanY] == '.')
            {
                maze[pacMan.pacmanX, pacMan.pacmanY] = ' ';
                Console.SetCursorPosition(pacMan.pacmanY, pacMan.pacmanX);
                Console.Write(" ");
                pacMan.pacmanX = pacMan.pacmanX - 1;
                if (maze[pacMan.pacmanX, pacMan.pacmanY] == '.')
                {
                    calculateScore();
                }
                Console.SetCursorPosition(pacMan.pacmanY, pacMan.pacmanX);
                maze[pacMan.pacmanX, pacMan.pacmanY] = 'P';
                Console.Write("P");

            }
        }
        static void movePacManDown(char[,] maze, PacManPlayer pacMan)
        {
            if (maze[pacMan.pacmanX + 1, pacMan.pacmanY] == ' ' || maze[pacMan.pacmanX + 1, pacMan.pacmanY] == '.')
            {
                maze[pacMan.pacmanX, pacMan.pacmanY] = ' ';
                Console.SetCursorPosition(pacMan.pacmanY, pacMan.pacmanX);
                Console.Write(" ");
                pacMan.pacmanX = pacMan.pacmanX + 1;
                Console.SetCursorPosition(pacMan.pacmanY, pacMan.pacmanX);
                if (maze[pacMan.pacmanX, pacMan.pacmanY] == '.')
                {
                    calculateScore();
                }
                maze[pacMan.pacmanX, pacMan.pacmanY] = 'P';
                Console.Write("P");

            }
        }
        static void movePacManLeft(char[,] maze, PacManPlayer pacMan)
        {

            if (maze[pacMan.pacmanX, pacMan.pacmanY - 1] == ' ' || maze[pacMan.pacmanX, pacMan.pacmanY - 1] == '.')
            {
                maze[pacMan.pacmanX, pacMan.pacmanY] = ' ';
                Console.SetCursorPosition(pacMan.pacmanY, pacMan.pacmanX);
                Console.Write(" ");
                pacMan.pacmanY = pacMan.pacmanY - 1;
                if (maze[pacMan.pacmanX, pacMan.pacmanY] == '.')
                {
                    //  calculateScore();
                }
                Console.SetCursorPosition(pacMan.pacmanY, pacMan.pacmanX);
                maze[pacMan.pacmanX, pacMan.pacmanY] = 'P';
                Console.Write("P");

            }
        }
        static void movePacManRight(char[,] maze, PacManPlayer pacMan)
        {
            if (maze[pacMan.pacmanX, pacMan.pacmanY + 1] == ' ' || maze[pacMan.pacmanX, pacMan.pacmanY + 1] == '.')
            {
                maze[pacMan.pacmanX, pacMan.pacmanY] = ' ';
                Console.SetCursorPosition(pacMan.pacmanY, pacMan.pacmanX);
                Console.Write(" ");
                pacMan.pacmanY = pacMan.pacmanY + 1;
                if (maze[pacMan.pacmanX, pacMan.pacmanY] == '.')
                {
                    calculateScore();
                }
                Console.SetCursorPosition(pacMan.pacmanY, pacMan.pacmanX);
                maze[pacMan.pacmanX, pacMan.pacmanY] = 'P';
                Console.Write("P");

            }
        }

        static void printMaze(char[,] maze)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    Console.Write(maze[x,y]);
                }
                Console.WriteLine();
            }
        }

    static void readData(char [,] maze) {
            StreamReader fp = new StreamReader("maze.txt");
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x < 71; x++)
                {
                    maze[row, x] = record[x];
                }
                row++;
            }

            fp.Close();
        }
    }
}

