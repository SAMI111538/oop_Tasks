using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApplicationGUI
{
    public partial class frmAdminMainMenu : Form
    {
        public frmAdminMainMenu()
        {
            InitializeComponent();
        }
        private void loadforms(UC_AddProduct frm)
        {
            try
            {
                this.screenpanel.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.screenpanel.Controls.Add(f);
                this.screenpanel.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tblAdminFirstPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdminMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void screenpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAddProduct_Click(object sender, EventArgs e)
        {
            loadforms(new UC_AddProduct());
        }
    }
}
