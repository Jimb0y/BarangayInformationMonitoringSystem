using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarangayInformationMonitoringSystem.Forms;

namespace BarangayInformationMonitoringSystem
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Exit";

            if (MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = "Admin";
            string pass = "6767";

            if (txtUsername.Text == uname)
            {
                if (txtPassword.Text == pass)
                {
                    this.Hide();

                    frmMain frm = new frmMain();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Incorrect Password",
                        "Error",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);

                    txtPassword.SelectAll();
                    //txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show(
                    "UserName Not Found...",
                    "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning);

                txtUsername.SelectAll();
                txtUsername.Focus();
            }
        }

        private void txtUsername_TextChanged(
            object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtPassword_TextChanged(
            object sender, EventArgs e)
        {
        }

        private void frmLogin_Load(
            object sender, EventArgs e)
        {
            
        }
    }
}