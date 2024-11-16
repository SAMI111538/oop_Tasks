using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using GUIpacman.GameGl;
using System.IO;
using System.Net.Sockets;

namespace GUIpacman
{
    public partial class Form1 : Form
    {
        GamePacManPlayer gamePacManPlayer;
        HGhost horizontalGhost;
        VGhost verticalGhost;
        RGhost randomGhost;
        SGhost smartGhost;
        ZigZagGhost ZigZagGhost;
        public static int totalScore = 0;
        public static int lives = 3;
        Label score;
        Label live;
        List<Ghost> ghosts = new List<Ghost>();
        List<Collision> collisions = new List<Collision>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 70);
            Image pacManImage = Game.getGameObject('P');
            GameCell startCell = grid.getCell(8, 10);
            gamePacManPlayer = new GamePacManPlayer(pacManImage, startCell);
            startCell.SetGameObject(gamePacManPlayer);

            GameCell ghostCellHorizontal = grid.getCell(22, 10);
            GameCell previousItem = new GameCell(22, 10, grid);
            previousItem.SetGameObject(Game.getBlankgameObject());
            horizontalGhost = new HGhost(Properties.Resources.d5b9ae79f5254caaf0fdcf2affcec5b0_w200__1_, ghostCellHorizontal, previousItem);
            ghostCellHorizontal.SetGameObject(horizontalGhost);

            GameCell ghostCellVertical = grid.getCell(16, 28);
            GameCell PreviousItem = new GameCell(16, 28, grid);
            PreviousItem.SetGameObject(Game.getBlankgameObject());
            verticalGhost = new VGhost(Properties.Resources.output_onlinepngtools__3_, ghostCellVertical, PreviousItem);
            ghostCellVertical.SetGameObject(verticalGhost);

            GameCell ghostCellRandom = grid.getCell(11, 55);
            GameCell pItem = new GameCell(11, 55, grid);
            pItem.SetGameObject(Game.getBlankgameObject());
            randomGhost = new RGhost(Properties.Resources.output_onlinepngtools__3_, ghostCellRandom, pItem);
            ghostCellRandom.SetGameObject(randomGhost);

            GameCell ghostCellSmart = grid.getCell(12, 39);
            GameCell prevItem = new GameCell(12, 39, grid);
            prevItem.SetGameObject(Game.getBlankgameObject());
            smartGhost = new SGhost(Properties.Resources.d5b9ae79f5254caaf0fdcf2affcec5b0_w200__1_, ghostCellSmart, prevItem);
            ghostCellSmart.SetGameObject(smartGhost);

            GameCell GHZ = grid.getCell(15, 51);
            GameCell PI= new GameCell(15, 51, grid);
            PI.SetGameObject(Game.getBlankgameObject());
            ZigZagGhost = new ZigZagGhost(Properties.Resources.d5b9ae79f5254caaf0fdcf2affcec5b0_w200__1_, GHZ, PI);
            GHZ.SetGameObject(smartGhost);

            PacmanPalleteCollision pacmanPalleteCollision = new PacmanPalleteCollision(GameObjectType.Main, GameObjectType.REWARD);
            collisions.Add(pacmanPalleteCollision);

            pacmanGhostCollision pacmanGhostCollision = new pacmanGhostCollision(GameObjectType.ENEMY, GameObjectType.Main);
            collisions.Add(pacmanGhostCollision);

            score = new Label();
            score.Top = 500;
            score.Left = 100;
            score.Text = "Total Score: " + totalScore.ToString();
            score.ForeColor = Color.Red;
            score.Height = 100;
            score.Width = 100;
            score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Controls.Add(score);

            live = new Label();
            live.Top = 500;
            live.Left = 500;
            live.Text = "Lives Left: " + lives.ToString();
            live.ForeColor = Color.Red;
            live.Height = 100;
            live.Width = 100;
            live.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Controls.Add(live);
            printMaze(grid);

            ghosts.Add(horizontalGhost);
            ghosts.Add(verticalGhost);
            ghosts.Add(smartGhost);
            ghosts.Add(randomGhost);
            ghosts.Add(ZigZagGhost);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            GameCell pacmanNextCell = null ;
            //Pacman
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pacmanNextCell = gamePacManPlayer.movePacman(GameDirection.Up);
            }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacmanNextCell = gamePacManPlayer.movePacman(GameDirection.Down);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pacmanNextCell = gamePacManPlayer.movePacman(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pacmanNextCell = gamePacManPlayer.movePacman(GameDirection.Left);
            }
            collisionDetection(gamePacManPlayer.CurrentCell, pacmanNextCell);

            score.Text = "Total Score: " + totalScore.ToString();
            live.Text = "Lives Left: " + lives.ToString();

            ghostMovement();

            if (lives == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over");
                this.Close();
            }
        }
   
        void printMaze(GameGrid grid)
        {
            for(int x = 0; x < grid.Rows; x++)
            {
                for(int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.pictureBox);
                }
            }
        }
        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

        private void collisionDetection(GameCell pacmanCell, GameCell nextCell)
        {
            if (pacmanCell != null && nextCell != null)
            {
                foreach(Collision collide in collisions)
                {
                    if(collide.FirstObject == pacmanCell.CurrentGameObject.GameObjectType && collide.SecondObject == nextCell.CurrentGameObject.GameObjectType)
                    {
                        collide.Action();
                    }
                }
            }
        }
        private void ghostMovement()
        {
            foreach(Ghost ghost in ghosts)
            {
                GameCell newCell = ghost.move();
                collisionDetection(ghost.CurrentCell, newCell); 

            }
        }
    }
}
