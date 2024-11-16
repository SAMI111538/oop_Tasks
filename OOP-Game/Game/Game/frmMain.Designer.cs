namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.bulletLoop = new System.Windows.Forms.Timer(this.components);
            this.lblMalrioScoreCount = new System.Windows.Forms.Label();
            this.lblMalrioScore = new System.Windows.Forms.Label();
            this.lblMalrioHealth = new System.Windows.Forms.Label();
            this.lblMalrioHealthCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // bulletLoop
            // 
            this.bulletLoop.Enabled = true;
            this.bulletLoop.Tick += new System.EventHandler(this.bulletLoop_Tick);
            // 
            // lblMalrioScoreCount
            // 
            this.lblMalrioScoreCount.AutoSize = true;
            this.lblMalrioScoreCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMalrioScoreCount.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalrioScoreCount.ForeColor = System.Drawing.Color.Black;
            this.lblMalrioScoreCount.Location = new System.Drawing.Point(203, 435);
            this.lblMalrioScoreCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalrioScoreCount.Name = "lblMalrioScoreCount";
            this.lblMalrioScoreCount.Size = new System.Drawing.Size(29, 35);
            this.lblMalrioScoreCount.TabIndex = 0;
            this.lblMalrioScoreCount.Text = "0";
            // 
            // lblMalrioScore
            // 
            this.lblMalrioScore.AutoSize = true;
            this.lblMalrioScore.BackColor = System.Drawing.Color.Transparent;
            this.lblMalrioScore.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalrioScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMalrioScore.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblMalrioScore.Location = new System.Drawing.Point(63, 435);
            this.lblMalrioScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalrioScore.Name = "lblMalrioScore";
            this.lblMalrioScore.Size = new System.Drawing.Size(107, 36);
            this.lblMalrioScore.TabIndex = 1;
            this.lblMalrioScore.Text = "Score : ";
            // 
            // lblMalrioHealth
            // 
            this.lblMalrioHealth.AutoSize = true;
            this.lblMalrioHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblMalrioHealth.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalrioHealth.ForeColor = System.Drawing.Color.Black;
            this.lblMalrioHealth.Location = new System.Drawing.Point(296, 431);
            this.lblMalrioHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalrioHealth.Name = "lblMalrioHealth";
            this.lblMalrioHealth.Size = new System.Drawing.Size(122, 36);
            this.lblMalrioHealth.TabIndex = 3;
            this.lblMalrioHealth.Text = "Health : ";
            // 
            // lblMalrioHealthCount
            // 
            this.lblMalrioHealthCount.AutoSize = true;
            this.lblMalrioHealthCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMalrioHealthCount.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalrioHealthCount.ForeColor = System.Drawing.Color.Black;
            this.lblMalrioHealthCount.Location = new System.Drawing.Point(470, 425);
            this.lblMalrioHealthCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalrioHealthCount.Name = "lblMalrioHealthCount";
            this.lblMalrioHealthCount.Size = new System.Drawing.Size(42, 35);
            this.lblMalrioHealthCount.TabIndex = 2;
            this.lblMalrioHealthCount.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 608);
            this.Controls.Add(this.lblMalrioHealth);
            this.Controls.Add(this.lblMalrioHealthCount);
            this.Controls.Add(this.lblMalrioScore);
            this.Controls.Add(this.lblMalrioScoreCount);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Timer bulletLoop;
        private System.Windows.Forms.Label lblMalrioScoreCount;
        private System.Windows.Forms.Label lblMalrioScore;
        private System.Windows.Forms.Label lblMalrioHealth;
        private System.Windows.Forms.Label lblMalrioHealthCount;
    }
}

