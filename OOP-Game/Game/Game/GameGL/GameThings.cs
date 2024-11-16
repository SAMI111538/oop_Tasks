using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.GameGL
{
    internal class GameThings
    {
        private static int score = 0;

        private static int playerHealth = 10;

        private static int horizontalEnemyHealth = 10;
        
        private int timer = 0;
        
        private Form gameGUI;

        private GamePlayer player;

        private GameGrid grid;

        private List<GameEnemy> enemies;

        public GameThings(Form gameGUI)
        {
            this.gameGUI = gameGUI;
            grid = new GameGrid("maze.txt", 20, 45);
            enemies = new List<GameEnemy>();
            printMaze(grid);
            GameCell cell = grid.getCell(3, 4);
            player = new GamePlayer(ImageGiver.getPlayerImage(), cell);
        }

        public GamePlayer getPlayer()
        {
            return player;
        }

        public int getScore()
        {
            return score;
        }

        public int getPlayerHealth()
        {
            return playerHealth;
        }

        public int getHorizontalEnemyHealth()
        {
            return horizontalEnemyHealth;
        }

        public int getTimer()
        {
            return timer;
        }

        public List<GameEnemy> GetEnemies()
        {
            return enemies;
        }

        public void Timer()
        {
            timer++;
        }

        public GameCell getCell(int x, int y)
        {
            return grid.getCell(x, y);
        }

        public void addEnemyInList(GameEnemy enemy)
        {
            enemies.Add(enemy);
        }

        private void printMaze(GameGrid grid)
        {
            for (int i = 0; i < grid.Rows; i++)
            {
                for (int j = 0; j < grid.Cols; j++)
                {
                    GameCell cell = grid.getCell(i, j);
                    gameGUI.Controls.Add(cell.PictureBox);
                }
            }
        }

        public static void addScore(int increment)
        {
            score += increment;
        }

        public static void decreasePlayerHealth(int decrement)
        {
            playerHealth -= decrement;
        }

        public void produceHeartRandomly()
        {
            if (timer % 30 == 0)
            {
                Random rand = new Random();
                int x = rand.Next(20);
                int y = rand.Next(45);
                GameCell cell = grid.getCell(x, y);
                if (cell.CurrentGameObject.GameObjectType == GameObjectType.NONE)
                {
                    cell.setGameObject(ImageGiver.GiveHeart());
                }
            }
        }
    }
}
