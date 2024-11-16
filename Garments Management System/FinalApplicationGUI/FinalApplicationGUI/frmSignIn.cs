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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            DataDL.SetSignInObject(takeInputWithRoleSignIn());
            if (DataDL.GetSignInObject() != null)
            {
                DataDL.SetSignInObject(MUserDL.signIn(DataDL.GetSignInObject()));
                if (DataDL.GetSignInObject() == null)
                {
                    MessageBox.Show("InValid Command");
                }
                else if (DataDL.GetSignInObject().isAdmin())
                {
                    this.Hide();
                    frmAdminMainMenu SignInObject = new frmAdminMainMenu();
                    SignInObject.ShowDialog();
                    this.Show();
                }
                else if (DataDL.GetSignInObject().isCustomer())
                {
                    this.Hide();
                    frmCustomerMainMenu SignInObject = new frmCustomerMainMenu();
                    SignInObject.ShowDialog();
                    this.Show();

                }
            }
        }
        private MUser takeInputWithRoleSignIn()
        {
            string name = txtNameSignIn.Text;
            
            string password = txtPasswordSignIn.Text;
            
            if (name != null && password != null)
            {
                MUser user = new MUser(name, password);
                return user;
            }
            return null;
        }

        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSignUp signUp = new frmSignUp();
            signUp.ShowDialog();
        }
    }
}
