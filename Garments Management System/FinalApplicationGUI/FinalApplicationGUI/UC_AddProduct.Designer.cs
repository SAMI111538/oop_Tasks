
namespace FinalApplicationGUI
{
    partial class UC_AddProduct
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
            this.tblMainAddPro = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddProMain = new System.Windows.Forms.Label();
            this.tblsecondAddPro = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddProBack = new System.Windows.Forms.Button();
            this.txtAddProStock = new System.Windows.Forms.TextBox();
            this.txtAddProPrice = new System.Windows.Forms.TextBox();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblAddProStock = new System.Windows.Forms.Label();
            this.lblAddProPrice = new System.Windows.Forms.Label();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.txtAddProName = new System.Windows.Forms.TextBox();
            this.tblMainAddPro.SuspendLayout();
            this.tblsecondAddPro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainAddPro
            // 
            this.tblMainAddPro.ColumnCount = 1;
            this.tblMainAddPro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMainAddPro.Controls.Add(this.lblAddProMain, 0, 0);
            this.tblMainAddPro.Controls.Add(this.tblsecondAddPro, 0, 1);
            this.tblMainAddPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainAddPro.Location = new System.Drawing.Point(0, 0);
            this.tblMainAddPro.Name = "tblMainAddPro";
            this.tblMainAddPro.RowCount = 2;
            this.tblMainAddPro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.03825F));
            this.tblMainAddPro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.96175F));
            this.tblMainAddPro.Size = new System.Drawing.Size(1114, 746);
            this.tblMainAddPro.TabIndex = 1;
            this.tblMainAddPro.Paint += new System.Windows.Forms.PaintEventHandler(this.tblMainAddPro_Paint);
            // 
            // lblAddProMain
            // 
            this.lblAddProMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddProMain.AutoSize = true;
            this.lblAddProMain.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProMain.Location = new System.Drawing.Point(386, 51);
            this.lblAddProMain.Name = "lblAddProMain";
            this.lblAddProMain.Size = new System.Drawing.Size(342, 54);
            this.lblAddProMain.TabIndex = 1;
            this.lblAddProMain.Text = "ADD PRODUCT";
            this.lblAddProMain.Click += new System.EventHandler(this.lblAddProMain_Click);
            // 
            // tblsecondAddPro
            // 
            this.tblsecondAddPro.ColumnCount = 2;
            this.tblsecondAddPro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblsecondAddPro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblsecondAddPro.Controls.Add(this.btnAddProBack, 0, 3);
            this.tblsecondAddPro.Controls.Add(this.txtAddProStock, 1, 2);
            this.tblsecondAddPro.Controls.Add(this.txtAddProPrice, 1, 1);
            this.tblsecondAddPro.Controls.Add(this.lblAddProductName, 0, 0);
            this.tblsecondAddPro.Controls.Add(this.lblAddProStock, 0, 2);
            this.tblsecondAddPro.Controls.Add(this.lblAddProPrice, 0, 1);
            this.tblsecondAddPro.Controls.Add(this.btnAddPro, 1, 3);
            this.tblsecondAddPro.Controls.Add(this.txtAddProName, 1, 0);
            this.tblsecondAddPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblsecondAddPro.Location = new System.Drawing.Point(3, 159);
            this.tblsecondAddPro.Name = "tblsecondAddPro";
            this.tblsecondAddPro.RowCount = 5;
            this.tblsecondAddPro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.5137F));
            this.tblsecondAddPro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.11644F));
            this.tblsecondAddPro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.74657F));
            this.tblsecondAddPro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.34932F));
            this.tblsecondAddPro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10274F));
            this.tblsecondAddPro.Size = new System.Drawing.Size(1108, 584);
            this.tblsecondAddPro.TabIndex = 0;
            this.tblsecondAddPro.Paint += new System.Windows.Forms.PaintEventHandler(this.tblsecondAddPro_Paint);
            // 
            // btnAddProBack
            // 
            this.btnAddProBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProBack.Location = new System.Drawing.Point(239, 456);
            this.btnAddProBack.Name = "btnAddProBack";
            this.btnAddProBack.Size = new System.Drawing.Size(75, 23);
            this.btnAddProBack.TabIndex = 7;
            this.btnAddProBack.Text = "Back";
            this.btnAddProBack.UseVisualStyleBackColor = true;
            this.btnAddProBack.Click += new System.EventHandler(this.btnAddProBack_Click);
            // 
            // txtAddProStock
            // 
            this.txtAddProStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddProStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddProStock.Location = new System.Drawing.Point(641, 330);
            this.txtAddProStock.Name = "txtAddProStock";
            this.txtAddProStock.Size = new System.Drawing.Size(380, 34);
            this.txtAddProStock.TabIndex = 6;
            this.txtAddProStock.TextChanged += new System.EventHandler(this.txtAddProStock_TextChanged);
            // 
            // txtAddProPrice
            // 
            this.txtAddProPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddProPrice.Location = new System.Drawing.Point(641, 199);
            this.txtAddProPrice.Name = "txtAddProPrice";
            this.txtAddProPrice.Size = new System.Drawing.Size(380, 34);
            this.txtAddProPrice.TabIndex = 5;
            this.txtAddProPrice.TextChanged += new System.EventHandler(this.txtAddProPrice_TextChanged);
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProductName.Location = new System.Drawing.Point(70, 55);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(414, 38);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Enter Product Name: ";
            this.lblAddProductName.Click += new System.EventHandler(this.lblAddProductName_Click);
            // 
            // lblAddProStock
            // 
            this.lblAddProStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddProStock.AutoSize = true;
            this.lblAddProStock.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProStock.Location = new System.Drawing.Point(64, 328);
            this.lblAddProStock.Name = "lblAddProStock";
            this.lblAddProStock.Size = new System.Drawing.Size(426, 38);
            this.lblAddProStock.TabIndex = 2;
            this.lblAddProStock.Text = "Enter Product Stock: ";
            this.lblAddProStock.Click += new System.EventHandler(this.lblAddProStock_Click);
            // 
            // lblAddProPrice
            // 
            this.lblAddProPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddProPrice.AutoSize = true;
            this.lblAddProPrice.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProPrice.Location = new System.Drawing.Point(69, 197);
            this.lblAddProPrice.Name = "lblAddProPrice";
            this.lblAddProPrice.Size = new System.Drawing.Size(416, 38);
            this.lblAddProPrice.TabIndex = 1;
            this.lblAddProPrice.Text = "Enter Product Price: ";
            this.lblAddProPrice.Click += new System.EventHandler(this.lblAddProPrice_Click);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPro.Location = new System.Drawing.Point(793, 456);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(75, 23);
            this.btnAddPro.TabIndex = 3;
            this.btnAddPro.Text = "Add";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // txtAddProName
            // 
            this.txtAddProName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddProName.Location = new System.Drawing.Point(641, 57);
            this.txtAddProName.Name = "txtAddProName";
            this.txtAddProName.Size = new System.Drawing.Size(380, 34);
            this.txtAddProName.TabIndex = 4;
            this.txtAddProName.TextChanged += new System.EventHandler(this.txtAddProName_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMainAddPro);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1114, 746);
            this.tblMainAddPro.ResumeLayout(false);
            this.tblMainAddPro.PerformLayout();
            this.tblsecondAddPro.ResumeLayout(false);
            this.tblsecondAddPro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainAddPro;
        private System.Windows.Forms.Label lblAddProMain;
        private System.Windows.Forms.TableLayoutPanel tblsecondAddPro;
        private System.Windows.Forms.Button btnAddProBack;
        private System.Windows.Forms.TextBox txtAddProStock;
        private System.Windows.Forms.TextBox txtAddProPrice;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddProStock;
        private System.Windows.Forms.Label lblAddProPrice;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.TextBox txtAddProName;
    }
}
