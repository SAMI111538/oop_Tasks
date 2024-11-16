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

namespace Lab_11_Pacman_Game
{
    public partial class Form1 : Form
    {
        int bullete_timer = 0;
        int enemyBlackLastTimeToFire = 0;
        int enemyBlueLastTimeToFire = 0;
        int enemyBlueTimeToFire = 0;
        int enemyBlackTimeToFire = 0;

        List<PictureBox> playerFires = new List<PictureBox>();
        List<PictureBox> enemyFires = new List<PictureBox>();
        PictureBox enemyBlack;
        PictureBox enemyBlue;
        Random rand = new Random();
        string enemyBlackDirection = "";
        string enemyBlueDirection = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void pbPlayer_Click(object sender, EventArgs e)
        {

        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pbPlayer.Left = pbPlayer.Left + 25;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pbPlayer.Left = pbPlayer.Left - 25;
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pbPlayer.Top = pbPlayer.Top - 25;
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pbPlayer.Top = pbPlayer.Top + 25;
            }
            if (bullete_timer == 1)
            {
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    PictureBox pbFire = new PictureBox();
                    Image fireImage = Lab_11_Pacman_Game.Properties.Resources.laserRed01;
                    pbFire.Image = fireImage;
                    pbFire.Width = fireImage.Width;
                    pbFire.Height = fireImage.Height;
                    pbFire.BackColor = Color.Transparent;
                    System.Drawing.Point firelocation = new System.Drawing.Point();
                    firelocation.X = pbPlayer.Left + (pbPlayer.Width / 2) - 5;
                    firelocation.Y = pbPlayer.Top;
                    pbFire.Location = firelocation;
                    playerFires.Add(pbFire);
                    this.Controls.Add(pbFire);
                }
                bullete_timer = 0;
            }

            foreach (PictureBox bullet in playerFires)
            {
                bullet.Top = bullet.Top - 20;
            }
            bullete_timer++;


            for (int idx = 0; idx < playerFires.Count; idx++)
            {
                if (playerFires[idx].Bottom < 0)
                {
                    playerFires.Remove(playerFires[idx]);
                }
            }


            if (enemyBlueLastTimeToFire >= enemyBlueTimeToFire)
            {
                Image fireImage = Lab_11_Pacman_Game.Properties.Resources.laserBlue16;
                PictureBox pbFire = createFire(fireImage, enemyBlue);
                enemyFires.Add(pbFire);
                this.Controls.Add(pbFire);
                enemyBlueLastTimeToFire = 0;
            }


            if (enemyBlackLastTimeToFire >= enemyBlackTimeToFire)
            {
                Image fireImage = Lab_11_Pacman_Game.Properties.Resources.laserBlue01;
                PictureBox pbFire = createFire(fireImage, enemyBlack);
                enemyFires.Add(pbFire);
                this.Controls.Add(pbFire);
                enemyBlackLastTimeToFire = 0;
            }

            foreach (PictureBox enemyfire in enemyFires)
            {
                enemyfire.Top = enemyfire.Top + 20;
            }
            for (int idx = 0; idx < enemyFires.Count; idx++)
            {
                if (enemyFires[idx].Top < this.Height)
                {
                    enemyFires.Remove(enemyFires[idx]);
                }
            }
            enemyBlueLastTimeToFire++;
            enemyBlackLastTimeToFire++;
            moveEnemy(enemyBlue, ref enemyBlueDirection);
            moveEnemy(enemyBlack, ref enemyBlackDirection);
        }

        private PictureBox createEnemy(Image img)
        {
            PictureBox pbEnemy = new PictureBox();
            int left = rand.Next(30, this.Width);
            int top = rand.Next(5, img.Height + 2);
            pbEnemy.Left = left;
            pbEnemy.Top = top;
            pbEnemy.Height = img.Height;
            pbEnemy.Width = img.Width;
            pbEnemy.BackColor = Color.Transparent;
            pbEnemy.Image = img;
            return pbEnemy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enemyBlack = createEnemy(Lab_11_Pacman_Game.Properties.Resources.enemyBlack2);
            enemyBlue = createEnemy(Lab_11_Pacman_Game.Properties.Resources.enemyBlue1);
            this.Controls.Add(enemyBlack);
            this.Controls.Add(enemyBlue);
        }
        private void moveEnemy(PictureBox enemy, ref string enemyDirection)
        {
            if (enemyDirection == "MovingRight")
            {
                enemy.Left = enemy.Left + 10;
            }
            if (enemyDirection == "MovingLeft")
            {
                enemy.Left = enemy.Left - 10;
            }
            if ((enemy.Left + enemy.Width) > this.Width)
            {
                enemyDirection = "MovingLeft";
            }
            if (enemy.Left <= 2)
            {
                enemyDirection = "MovingRight";
            }
        }
        private PictureBox createFire(Image fireImage, PictureBox source)
        {
            PictureBox pbFire = new PictureBox();
            pbFire.Image = fireImage;
            pbFire.Width = fireImage.Width;
            pbFire.Height = fireImage.Height;
            pbFire.BackColor = Color.Transparent;
            System.Drawing.Point firelocation = new System.Drawing.Point();
            firelocation.X = source.Left + (source.Width / 2) - 5;
            firelocation.Y = source.Top;
            pbFire.Location = firelocation;
            return pbFire;

        }
    }

}
