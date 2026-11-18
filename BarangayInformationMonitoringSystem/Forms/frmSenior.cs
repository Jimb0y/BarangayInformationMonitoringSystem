using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace BarangayInformationMonitoringSystem.Forms
{
    public partial class frmSenior : Form
    {
        public frmSenior()
        {
            InitializeComponent();
        }

        private void frmSenior_Load(object sender, EventArgs e)
        {
            LoadSeniorList();
        }

        private void LoadSeniorList()
        {
            try
            {
                string dbPath = Path.Combine(Application.StartupPath, "barangay.db");

                if (!File.Exists(dbPath))
                {
                    MessageBox.Show("Hindi mahanap ang database:\n" + dbPath, "Senior List");
                    return;
                }

                string connectionString = "Data Source=" + dbPath + ";Version=3;";

                string sql = @"
                    SELECT ResidentId, FullName, Age, Sex, Purok, ContactNumber
                    FROM residents
                    WHERE Age >= 60
                    ORDER BY FullName ASC";

                DataTable dt = new DataTable();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }

                dgvSeniorList.AutoGenerateColumns = true;
                dgvSeniorList.DataSource = dt;

                label1.Text = "SENIOR CITIZENS LIST (" + dt.Rows.Count + ")";

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Walang senior citizen records na nakita.", "Senior List");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading senior list:\n" + ex.Message, "Database Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}