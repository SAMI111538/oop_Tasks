using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Student subj1 = new Student(1, "SAMI", "143");
            Student subj2 = new Student(2, "KOORAY ALLA", "157");
            Student subj3 = new Student(3, "LADY DIANA", "131");
            Student.Students.Add(subj1);
            Student.Students.Add(subj2);
            Student.Students.Add(subj3);
            dataGridView1.DataSource = Student.Students;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text.ToLower() != "samimalik")
            {
                lblName.ForeColor = Color.Red;
                lblName.Text = "InValid Input";
            }
            else
            {
                lblName.ForeColor = Color.Green;
                lblName.Text = "Valid Input";
            }
        }

    }
}
