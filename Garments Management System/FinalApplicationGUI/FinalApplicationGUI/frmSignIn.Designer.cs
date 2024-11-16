
namespace FinalApplicationGUI
{
    partial class frmSignIn
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
            this.lblSignUpFirstPannel = new System.Windows.Forms.TableLayoutPanel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblSignUpSecondPannel = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameSignIn = new System.Windows.Forms.Label();
            this.lblPasswordSignIn = new System.Windows.Forms.Label();
            this.txtNameSignIn = new System.Windows.Forms.TextBox();
            this.txtPasswordSignIn = new System.Windows.Forms.TextBox();
            this.passwordShowButton = new System.Windows.Forms.RadioButton();
            this.LogInButton = new System.Windows.Forms.Button();
            this.linklblSignUp = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSignUpFirstPannel.SuspendLayout();
            this.lblSignUpSecondPannel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSignUpFirstPannel
            // 
            this.lblSignUpFirstPannel.BackgroundImage = global::FinalApplicationGUI.Properties.Resources.Garments;
            this.lblSignUpFirstPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblSignUpFirstPannel.ColumnCount = 3;
            this.lblSignUpFirstPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lblSignUpFirstPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lblSignUpFirstPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lblSignUpFirstPannel.Controls.Add(this.lblSignUp, 1, 1);
            this.lblSignUpFirstPannel.Controls.Add(this.lblSignUpSecondPannel, 1, 2);
            this.lblSignUpFirstPannel.Controls.Add(this.passwordShowButton, 2, 2);
            this.lblSignUpFirstPannel.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.lblSignUpFirstPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSignUpFirstPannel.Location = new System.Drawing.Point(0, 0);
            this.lblSignUpFirstPannel.Name = "lblSignUpFirstPannel";
            this.lblSignUpFirstPannel.RowCount = 6;
            this.lblSignUpFirstPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lblSignUpFirstPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lblSignUpFirstPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lblSignUpFirstPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lblSignUpFirstPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lblSignUpFirstPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lblSignUpFirstPannel.Size = new System.Drawing.Size(1476, 760);
            this.lblSignUpFirstPannel.TabIndex = 1;
            // 
            // lblSignUp
            // 
            this.lblSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(605, 168);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(265, 42);
            this.lblSignUp.TabIndex = 0;
            this.lblSignUp.Text = "Sign In Menu";
            // 
            // lblSignUpSecondPannel
            // 
            this.lblSignUpSecondPannel.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUpSecondPannel.ColumnCount = 2;
            this.lblSignUpSecondPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.lblSignUpSecondPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lblSignUpSecondPannel.Controls.Add(this.lblNameSignIn, 0, 0);
            this.lblSignUpSecondPannel.Controls.Add(this.lblPasswordSignIn, 0, 1);
            this.lblSignUpSecondPannel.Controls.Add(this.txtNameSignIn, 1, 0);
            this.lblSignUpSecondPannel.Controls.Add(this.txtPasswordSignIn, 1, 1);
            this.lblSignUpSecondPannel.Location = new System.Drawing.Point(495, 255);
            this.lblSignUpSecondPannel.Name = "lblSignUpSecondPannel";
            this.lblSignUpSecondPannel.RowCount = 2;
            this.lblSignUpSecondPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lblSignUpSecondPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lblSignUpSecondPannel.Size = new System.Drawing.Size(486, 117);
            this.lblSignUpSecondPannel.TabIndex = 1;
            // 
            // lblNameSignIn
            // 
            this.lblNameSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSignIn.AutoSize = true;
            this.lblNameSignIn.Font = new System.Drawing.Font("Algerian", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSignIn.Location = new System.Drawing.Point(40, 16);
            this.lblNameSignIn.Name = "lblNameSignIn";
            this.lblNameSignIn.Size = new System.Drawing.Size(76, 25);
            this.lblNameSignIn.TabIndex = 0;
            this.lblNameSignIn.Text = "NAME";
            // 
            // lblPasswordSignIn
            // 
            this.lblPasswordSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordSignIn.AutoSize = true;
            this.lblPasswordSignIn.Font = new System.Drawing.Font("Algerian", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSignIn.Location = new System.Drawing.Point(12, 75);
            this.lblPasswordSignIn.Name = "lblPasswordSignIn";
            this.lblPasswordSignIn.Size = new System.Drawing.Size(132, 25);
            this.lblPasswordSignIn.TabIndex = 1;
            this.lblPasswordSignIn.Text = "Password";
            // 
            // txtNameSignIn
            // 
            this.txtNameSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSignIn.Location = new System.Drawing.Point(160, 10);
            this.txtNameSignIn.Name = "txtNameSignIn";
            this.txtNameSignIn.Size = new System.Drawing.Size(323, 38);
            this.txtNameSignIn.TabIndex = 2;
            // 
            // txtPasswordSignIn
            // 
            this.txtPasswordSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignIn.Location = new System.Drawing.Point(160, 68);
            this.txtPasswordSignIn.Name = "txtPasswordSignIn";
            this.txtPasswordSignIn.PasswordChar = '*';
            this.txtPasswordSignIn.Size = new System.Drawing.Size(323, 38);
            this.txtPasswordSignIn.TabIndex = 2;
            // 
            // passwordShowButton
            // 
            this.passwordShowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordShowButton.AutoSize = true;
            this.passwordShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordShowButton.Location = new System.Drawing.Point(987, 359);
            this.passwordShowButton.Name = "passwordShowButton";
            this.passwordShowButton.Size = new System.Drawing.Size(17, 16);
            this.passwordShowButton.TabIndex = 3;
            this.passwordShowButton.UseVisualStyleBackColor = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(364, 3);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(119, 44);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "LogIn";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // linklblSignUp
            // 
            this.linklblSignUp.AutoSize = true;
            this.linklblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.linklblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblSignUp.Location = new System.Drawing.Point(3, 0);
            this.linklblSignUp.Name = "linklblSignUp";
            this.linklblSignUp.Size = new System.Drawing.Size(176, 29);
            this.linklblSignUp.TabIndex = 2;
            this.linklblSignUp.TabStop = true;
            this.linklblSignUp.Text = "Create Account";
            this.linklblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSignUp_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LogInButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.linklblSignUp, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(495, 381);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 120);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 760);
            this.Controls.Add(this.lblSignUpFirstPannel);
            this.Name = "frmSignIn";
            this.Text = "frmSignIn";
            this.lblSignUpFirstPannel.ResumeLayout(false);
            this.lblSignUpFirstPannel.PerformLayout();
            this.lblSignUpSecondPannel.ResumeLayout(false);
            this.lblSignUpSecondPannel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lblSignUpFirstPannel;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.TableLayoutPanel lblSignUpSecondPannel;
        private System.Windows.Forms.Label lblNameSignIn;
        private System.Windows.Forms.Label lblPasswordSignIn;
        private System.Windows.Forms.TextBox txtNameSignIn;
        private System.Windows.Forms.TextBox txtPasswordSignIn;
        private System.Windows.Forms.RadioButton passwordShowButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linklblSignUp;
    }
}