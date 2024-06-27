using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

namespace Waterpedia_Winform
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            tBoxPassword.UseSystemPasswordChar = true;
        }

        private void cBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShowPass.Checked)
            {
                tBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*sqlConnect.Open();
            sqlQuery = "SELECT * FROM USER WHERE ID = '" + tBoxEmail.Text + "' and PASSWORD = '" + tBoxPassword.Text + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Login);*/

            /*if (Login.Rows.Count > 0)
            {
                namaPegawai = Login.Rows[0][2].ToString();
                statusPegawai = Login.Rows[0][7].ToString();*/
                Form FormPilihDivisi = new FormPilihDivisi();
                FormPilihDivisi.Show();
            this.Visible = false;
            /*}
            else
            {
                MessageBox.Show("User / Password Salah");
            }*/
        }
    }
}