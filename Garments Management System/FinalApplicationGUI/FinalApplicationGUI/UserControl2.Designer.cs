
namespace FinalApplicationGUI
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.g = new System.Windows.Forms.DataGridView();
            this.tblDiscountsFirst = new System.Windows.Forms.TableLayoutPanel();
            this.tblDiscountsSecond = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiscountsHeader = new System.Windows.Forms.Label();
            this.tblDiscountsThird = new System.Windows.Forms.TableLayoutPanel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscouontsName = new System.Windows.Forms.Label();
            this.lblDiscounts = new System.Windows.Forms.Label();
            this.btnAddDis = new System.Windows.Forms.Button();
            this.btnDiscountsBack = new System.Windows.Forms.Button();
            this.txtDiscountsProName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.tblDiscountsFirst.SuspendLayout();
            this.tblDiscountsSecond.SuspendLayout();
            this.tblDiscountsThird.SuspendLayout();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g.Location = new System.Drawing.Point(540, 3);
            this.g.Name = "g";
            this.g.RowHeadersWidth = 51;
            this.g.RowTemplate.Height = 24;
            this.g.Size = new System.Drawing.Size(506, 761);
            this.g.TabIndex = 1;
            // 
            // tblDiscountsFirst
            // 
            this.tblDiscountsFirst.ColumnCount = 2;
            this.tblDiscountsFirst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.23558F));
            this.tblDiscountsFirst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.76442F));
            this.tblDiscountsFirst.Controls.Add(this.tblDiscountsSecond, 0, 0);
            this.tblDiscountsFirst.Controls.Add(this.g, 1, 0);
            this.tblDiscountsFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDiscountsFirst.Location = new System.Drawing.Point(0, 0);
            this.tblDiscountsFirst.Name = "tblDiscountsFirst";
            this.tblDiscountsFirst.RowCount = 1;
            this.tblDiscountsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDiscountsFirst.Size = new System.Drawing.Size(1049, 767);
            this.tblDiscountsFirst.TabIndex = 1;
            // 
            // tblDiscountsSecond
            // 
            this.tblDiscountsSecond.ColumnCount = 1;
            this.tblDiscountsSecond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDiscountsSecond.Controls.Add(this.lblDiscountsHeader, 0, 0);
            this.tblDiscountsSecond.Controls.Add(this.tblDiscountsThird, 0, 1);
            this.tblDiscountsSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDiscountsSecond.Location = new System.Drawing.Point(3, 3);
            this.tblDiscountsSecond.Name = "tblDiscountsSecond";
            this.tblDiscountsSecond.RowCount = 2;
            this.tblDiscountsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33167F));
            this.tblDiscountsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.66833F));
            this.tblDiscountsSecond.Size = new System.Drawing.Size(531, 761);
            this.tblDiscountsSecond.TabIndex = 0;
            // 
            // lblDiscountsHeader
            // 
            this.lblDiscountsHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscountsHeader.AutoSize = true;
            this.lblDiscountsHeader.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountsHeader.Location = new System.Drawing.Point(151, 43);
            this.lblDiscountsHeader.Name = "lblDiscountsHeader";
            this.lblDiscountsHeader.Size = new System.Drawing.Size(228, 45);
            this.lblDiscountsHeader.TabIndex = 3;
            this.lblDiscountsHeader.Text = "Discounts";
            // 
            // tblDiscountsThird
            // 
            this.tblDiscountsThird.ColumnCount = 2;
            this.tblDiscountsThird.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.74056F));
            this.tblDiscountsThird.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.25944F));
            this.tblDiscountsThird.Controls.Add(this.txtDiscount, 1, 1);
            this.tblDiscountsThird.Controls.Add(this.lblDiscouontsName, 0, 0);
            this.tblDiscountsThird.Controls.Add(this.lblDiscounts, 0, 1);
            this.tblDiscountsThird.Controls.Add(this.btnAddDis, 1, 2);
            this.tblDiscountsThird.Controls.Add(this.btnDiscountsBack, 0, 2);
            this.tblDiscountsThird.Controls.Add(this.txtDiscountsProName, 1, 0);
            this.tblDiscountsThird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDiscountsThird.Location = new System.Drawing.Point(3, 134);
            this.tblDiscountsThird.Name = "tblDiscountsThird";
            this.tblDiscountsThird.RowCount = 3;
            this.tblDiscountsThird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDiscountsThird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDiscountsThird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDiscountsThird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDiscountsThird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDiscountsThird.Size = new System.Drawing.Size(525, 624);
            this.tblDiscountsThird.TabIndex = 0;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(333, 295);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(182, 34);
            this.txtDiscount.TabIndex = 10;
            // 
            // lblDiscouontsName
            // 
            this.lblDiscouontsName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscouontsName.AutoSize = true;
            this.lblDiscouontsName.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscouontsName.Location = new System.Drawing.Point(39, 73);
            this.lblDiscouontsName.Name = "lblDiscouontsName";
            this.lblDiscouontsName.Size = new System.Drawing.Size(245, 62);
            this.lblDiscouontsName.TabIndex = 0;
            this.lblDiscouontsName.Text = "Enter Product Name:";
            // 
            // lblDiscounts
            // 
            this.lblDiscounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscounts.AutoSize = true;
            this.lblDiscounts.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscounts.Location = new System.Drawing.Point(35, 296);
            this.lblDiscounts.Name = "lblDiscounts";
            this.lblDiscounts.Size = new System.Drawing.Size(253, 31);
            this.lblDiscounts.TabIndex = 2;
            this.lblDiscounts.Text = "Enter Discount:";
            // 
            // btnAddDis
            // 
            this.btnAddDis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDis.Location = new System.Drawing.Point(387, 508);
            this.btnAddDis.Name = "btnAddDis";
            this.btnAddDis.Size = new System.Drawing.Size(75, 23);
            this.btnAddDis.TabIndex = 4;
            this.btnAddDis.Text = "Confirm";
            this.btnAddDis.UseVisualStyleBackColor = true;
            // 
            // btnDiscountsBack
            // 
            this.btnDiscountsBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiscountsBack.Location = new System.Drawing.Point(124, 508);
            this.btnDiscountsBack.Name = "btnDiscountsBack";
            this.btnDiscountsBack.Size = new System.Drawing.Size(75, 23);
            this.btnDiscountsBack.TabIndex = 8;
            this.btnDiscountsBack.Text = "Back";
            this.btnDiscountsBack.UseVisualStyleBackColor = true;
            // 
            // txtDiscountsProName
            // 
            this.txtDiscountsProName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscountsProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountsProName.Location = new System.Drawing.Point(333, 87);
            this.txtDiscountsProName.Name = "txtDiscountsProName";
            this.txtDiscountsProName.Size = new System.Drawing.Size(182, 34);
            this.txtDiscountsProName.TabIndex = 9;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDiscountsFirst);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1049, 767);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.tblDiscountsFirst.ResumeLayout(false);
            this.tblDiscountsSecond.ResumeLayout(false);
            this.tblDiscountsSecond.PerformLayout();
            this.tblDiscountsThird.ResumeLayout(false);
            this.tblDiscountsThird.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView g;
        private System.Windows.Forms.TableLayoutPanel tblDiscountsFirst;
        private System.Windows.Forms.TableLayoutPanel tblDiscountsSecond;
        private System.Windows.Forms.Label lblDiscountsHeader;
        private System.Windows.Forms.TableLayoutPanel tblDiscountsThird;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscouontsName;
        private System.Windows.Forms.Label lblDiscounts;
        private System.Windows.Forms.Button btnAddDis;
        private System.Windows.Forms.Button btnDiscountsBack;
        private System.Windows.Forms.TextBox txtDiscountsProName;
    }
}
