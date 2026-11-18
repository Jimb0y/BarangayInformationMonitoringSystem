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

namespace BarangayInformationMonitoringSystem.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void mnuResidents_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmResidents frm = new frmResidents();

            frm.FormClosed += (s, args) => this.Show();

            frm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
        }

        private void mnuDashboard_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Exit";

            if (MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutTheAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAuthor frm = new frmAuthor();

            frm.FormClosed += (s, args) => this.Show();

            frm.Show();
        }

        private void aboutTheSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This System is for academic purposes only!";

            MessageBox.Show(
                message,
                "About the System",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // TOTAL RESIDENTS
        private void totalResidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResidents resForm =
                Application.OpenForms.OfType<frmResidents>().FirstOrDefault();

            if (resForm != null)
            {
                int total = resForm.GetTotalResident();

                MessageBox.Show(
                    "Total Residents: " + total,
                    "Count Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please open Resident Information first.",
                    "Notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // TOTAL SENIOR CITIZENS
        private void totalSeniorCitizensToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmResidents resForm =
                Application.OpenForms.OfType<frmResidents>().FirstOrDefault();

            if (resForm != null)
            {
                int total = resForm.GetTotalAge();

                MessageBox.Show(
                    "Total Senior Citizens: " + total,
                    "Count Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please open Resident Information first.",
                    "Notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // TOTAL HOUSEHOLDS
        private void totalHouseholdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Household counting is not yet available.",
                "Notice",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // TOTAL PWD
        private void totalPWDToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmResidents resForm =
                Application.OpenForms.OfType<frmResidents>().FirstOrDefault();

            if (resForm != null)
            {
                int total = resForm.GetTotalPWD();

                MessageBox.Show(
                    "Total PWD Residents: " + total,
                    "Count Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please open Resident Information first.",
                    "Notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void pWDListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPWDList frm = new frmPWDList();

            frm.FormClosed += (s, args) => this.Show();

            frm.Show();
        }

        private void seniorSitizenListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSenior frm = new frmSenior();

            frm.FormClosed += (s, args) => this.Show();

            frm.Show();
        }
    }
}