using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace BarangayInformationMonitoringSystem.Forms
{
    public partial class frmPWDList : Form
    {
        public frmPWDList()
        {
            InitializeComponent();
        }

        private void frmPWDList_Load(object sender, EventArgs e)
        {
            LoadPWDList();
        }

        private void LoadPWDList()
        {
            try
            {
                string dbPath = Path.Combine(Application.StartupPath, "barangay.db");

                if (!File.Exists(dbPath))
                {
                    MessageBox.Show("Hindi mahanap ang database:\n" + dbPath, "PWD List");
                    return;
                }

                string connectionString = "Data Source=" + dbPath + ";Version=3;";

                string sql = @"
                    SELECT ResidentId, FullName, Age, Sex, Purok, PWD, ContactNumber
                    FROM residents
                    WHERE LOWER(TRIM(COALESCE(PWD, ''))) IN ('yes', 'y', '1', 'oo', 'true')
                    ORDER BY FullName ASC";

                DataTable dt = new DataTable();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }

                dgvPWDList.AutoGenerateColumns = true;
                dgvPWDList.DataSource = dt;

                label1.Text = "Total PWD Residents: " + dt.Rows.Count;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Walang PWD records na nakita.\n" +
                        "I-check ang laman ng PWD column sa database.",
                        "PWD List");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading PWD list:\n" + ex.Message, "Database Error");
            }
        }

        private void dgvPWDList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void frmPWDList_Load_1(object sender, EventArgs e)
        {
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}