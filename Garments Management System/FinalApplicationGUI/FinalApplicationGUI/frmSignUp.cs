using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalApplicationGUI.BL;
using FinalApplicationGUI.DL;

namespace FinalApplicationGUI
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataDL.SetSignUpObject(TakeInputWithRoleSignUp());
            if (DataDL.GetSignUpObject() != null)
            {
                MUser signUp_User = DataDL.GetSignUpObject();
                MUserDL.storeDataInList(signUp_User);
                if (signUp_User.getRole() == "customer")
                {
                    CustomerDL.addCustomerInList(new Customer(signUp_User.getName(), signUp_User.getPassword(), signUp_User.getRole()));
                }
                MUserDL.storeDataInFile(DataDL.GetUsersPath(), DataDL.GetSignUpObject());
                frmSignIn form = new frmSignIn();
                form.Show();
                this.Hide();
            }
        }
        private MUser TakeInputWithRoleSignUp()
        {
            string name = txtNameSignUp.Text;

            string password = txtPasswordSignUp.Text;

            string role = txtRoleSignUp.Text;
            if (name != null && password != null && role != null)
            {
                if (role == "Customer" || role == "customer")
                {
                    Customer user = new Customer(name, password, role);
                    MessageBox.Show("SignedUp Successfully");
                    return user;
                }
                if (role == "Admin" || role == "admin")
                {
                    Admin user = new Admin(name, password, role);
                    MessageBox.Show("SignedUp Successfully");
                    return user;
                }
                else
                {
                    MessageBox.Show("SignUp Failed");
                }
            }
            return null;
        }

        private void linklblforSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSignIn signIn = new frmSignIn();
            signIn.ShowDialog();
        }
    }
}
