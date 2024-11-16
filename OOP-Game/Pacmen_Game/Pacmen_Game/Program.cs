using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace Pacmen_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 70);
            GameCell start = new GameCell(12, 22, grid);
            GameCell ver = new GameCell(12, 2, grid);
            GameCell hor = new GameCell(1, 10, grid);
            GameCell rand = new GameCell(12, 26, grid);


            GamePacManPlayer pacman = new GamePacManPlayer('p', start);
            Vertical_Ghost v = new Vertical_Ghost('V', ver);
            Horizontal_ghost h = new Horizontal_ghost('H', hor);
            Random_Ghost r = new Random_Ghost('R', rand);

            List<Ghost> ghost = new List<Ghost>();
            ghost.Add(v);
            ghost.Add(h);
            ghost.Add(r);

            printMaze(grid);
            printGameObject(pacman);


            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, GameDirection.Up);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(pacman, GameDirection.Down);
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.Right);
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.Left);
                }

                foreach (Ghost g in ghost)
                {
                    moveGameObjectenemy(g);
                }
            }
            Console.ReadKey();
        }
        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.Y, gameCell.X);
            Console.Write(newGameObject.DisplayCharacter);
        }
        static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.Y, gameObject.CurrentCell.X);
            Console.Write(gameObject.DisplayCharacter);

        }

        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.nextCell(direction);
            if (nextCell != null)
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                GameCell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }
        }
        static void moveGameObjectenemy(GameObject gameObject)
        {
            GameCell nextCell = gameObject.move();
            if (nextCell != null)
            {
                GameObject newGO = new GameObject(GameObjectType.ENEMY, nextCell.CurrentGameObject.DisplayCharacter);
                GameCell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }
        }

        static void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.row; x++)
            {
                for (int y = 0; y < grid.cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    printCell(cell);
                }
            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }
    }
}

