namespace Game
{
    partial class frmLogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdNewGame = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Gray;
            this.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdExit.FlatAppearance.BorderSize = 3;
            this.cmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.White;
            this.cmdExit.Location = new System.Drawing.Point(77, 335);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(221, 54);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "EXIT";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmdNewGame
            // 
            this.cmdNewGame.BackColor = System.Drawing.Color.Gray;
            this.cmdNewGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdNewGame.FlatAppearance.BorderSize = 3;
            this.cmdNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.cmdNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.cmdNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNewGame.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNewGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdNewGame.Location = new System.Drawing.Point(77, 188);
            this.cmdNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNewGame.Name = "cmdNewGame";
            this.cmdNewGame.Size = new System.Drawing.Size(221, 54);
            this.cmdNewGame.TabIndex = 5;
            this.cmdNewGame.Text = "NEW GAME";
            this.cmdNewGame.UseVisualStyleBackColor = false;
            this.cmdNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(13, 39);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(405, 66);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "The Pirates";
            // 
            // frmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.dayso_ql_l2lVoxKI_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 654);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdNewGame);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogo";
            this.Text = "ThePirates";
            this.Load += new System.EventHandler(this.temp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdNewGame;
        private System.Windows.Forms.Label lblHeader;
    }
}