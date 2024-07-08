using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterpedia_Winform
{
    public partial class FormFrontPanel : Form
    {
        public FormFrontPanel()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnWTP_Click(object sender, EventArgs e)
        {

        }

        private void FormFrontPanel_Load(object sender, EventArgs e)
        {
            /*when form load will show user name*/
            lblWellcome.Text = "Wellcome " + FormLogin.Nama;
            if (FormLogin.Izin_Akses == "Admin")
            {
                btnViewUser.Enabled = true;
            }
            else
            {
                btnViewUser.Enabled = false;
            }
        }
    }
}
