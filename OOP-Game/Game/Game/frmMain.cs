using EZInput;
using Game.GameGL;
using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private static GamePlayer pacman;
        GameThings game;

        internal static GamePlayer Pacman { get => pacman; set => pacman = value; }

        public Form1()
        {
            InitializeComponent();
            game = new GameThings(this);
            //pacman = new GamePlayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMalrioHealth.Location = new System.Drawing.Point(330, 630);
            lblMalrioHealthCount.Location = new System.Drawing.Point(510, 630);
            lblMalrioScore.Location = new System.Drawing.Point(90, 630);
            lblMalrioScoreCount.Location = new System.Drawing.Point(201, 630);
            VerticalEnemy ve = new VerticalEnemy(ImageGiver.getVerticalEnemyImage(), game.getCell(3, 40));
            RandomEnemy re = new RandomEnemy(ImageGiver.getRandomEnemyImage(), game.getCell(18, 12));
            SmartGhost se = new SmartGhost(ImageGiver.getSmartEnemyImage(), game.getCell(18, 40),game.getPlayer());
            game.addEnemyInList(ve);
            game.addEnemyInList(re);
            HorizontalEnemy he = new HorizontalEnemy(ImageGiver.getHorizontalEnemyImage(), game.getCell(6, 38));
            game.addEnemyInList(he);
            game.addEnemyInList(se);
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            GamePlayer player = game.getPlayer();
            GameCell potentialNewCell = player.CurrentCell;
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Left);
            }
            else if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Right);
            }
            else if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Up);
            }
            else
            {
                potentialNewCell = player.CurrentCell.nextCell(
                    GameDirection.Down);
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                player.generateBullet();
            }
            if (potentialNewCell.CurrentGameObject.GameObjectType == GameObjectType.HEART)
            {
                GameThings.decreasePlayerHealth(-1);
            }
            GameCell currentCell = player.CurrentCell;
            currentCell.setGameObject(ImageGiver.getBlankGameObject());
            player.move(potentialNewCell);
            isGameOver();
            game.Timer();
            player.moveBullets();

            game.produceHeartRandomly();

        }

        private void bulletLoop_Tick(object sender, EventArgs e)
        {
            foreach (var i in game.GetEnemies())
            {
                i.move(i.nextCell());
                if (game.getTimer() % 10 == 0)
                {
                    i.generateBullet();
                }
                i.moveBullets();
            }
            lblMalrioScoreCount.Text = game.getScore().ToString();
            lblMalrioHealthCount.Text = game.getPlayerHealth().ToString();
        }

        private void isGameOver()
        {
            if (game.getPlayerHealth() <= 0)
            {
                GameLoop.Enabled = false;
                bulletLoop.Enabled = false;
                MessageBox.Show("Game Over");
                this.Close();
            }
        }

        private void isHorizontalDestroyed()
        {
            //if(game.)
        }



    }
}
