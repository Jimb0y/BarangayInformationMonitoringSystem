using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BarangayInformationMonitoringSystem.Forms
{
    public partial class frmResidents : Form
    {
        public frmResidents()
        {
            InitializeComponent();
        }

        // DATABASE CONNECTION
        private String DBConnection =
            "Data Source=|DataDirectory|\\barangay.db";

        private SQLiteConnection conn = new SQLiteConnection();

        bool adding = false;
        bool editing = false;
      
        // FORM LOAD

        private void frmResidents_Load(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = DBConnection;
                conn.Open();

               /* MessageBox.Show(
                    "Connected to Database",
                    "Success");*/

                // SEX
                cboSex.Items.Clear();
                cboSex.Items.Add("Male");
                cboSex.Items.Add("Female");

                // PUROK
                cboPurok.Items.Clear();
                cboPurok.Items.Add("Purok 1");
                cboPurok.Items.Add("Purok 2");
                cboPurok.Items.Add("Purok 3");
                cboPurok.Items.Add("Purok 4");
                cboPurok.Items.Add("Purok 5");
                cboPurok.Items.Add("Purok 6");
                cboPurok.Items.Add("Purok 7");

                // PWD
                cboPWD.Items.Clear();
                cboPWD.Items.Add("Yes");
                cboPWD.Items.Add("No");

                // Resident ID cannot be edited
                txtResidentID.ReadOnly = true;

                // LOAD DATABASE
                LoadResidents();

                btnAdd.Text = "Add";
                btnEdit.Text = "Edit";
                btnDel.Text = "Del";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error");
            }
        }


        // ==============================
        // LOAD RESIDENTS
        // ==============================

        private void LoadResidents()
        {
            try
            {
                string sql =
                    "SELECT ResidentID, FullName, Age, Sex, " +
                    "Purok, PWD, ContactNumber,DateTimeCreated,DateTimeModified " +
                    "FROM residents";

                using (SQLiteDataAdapter da =
                    new SQLiteDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvResidents.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Load Error");
            }
        }


        // ==============================
        // ADD BUTTON
        // ==============================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!adding && !editing)
            {
                // START ADD

                adding = true;

                btnAdd.Text = "Save";
                btnEdit.Text = "Clear";

                ClearFields();

                txtFullName.Focus();
            }
            else if (adding)
            {
                // SAVE NEW RESIDENT

                SaveResident();
            }
            else if (editing)
            {
                // SAVE EDIT

                SaveEditedResident();
            }
        }


        // ==============================
        // SAVE NEW RESIDENT
        // ==============================

        private void SaveResident()
        {
            int age;

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter Full Name.");

                txtFullName.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show(
                    "Please enter valid Age.");

                txtAge.Focus();
                return;
            }

            if (cboSex.Text == "")
            {
                MessageBox.Show(
                    "Please select Sex.");

                return;
            }

            if (cboPurok.Text == "")
            {
                MessageBox.Show(
                    "Please select Purok.");

                return;
            }

            if (cboPWD.Text == "")
            {
                MessageBox.Show(
                    "Please select PWD.");

                return;
            }

            try
            {
                string sql =
                    "INSERT INTO residents " +
                    "(FullName, Age, Sex, Purok, PWD, ContactNumber,DateTimeCreated,DateTimeModified) " +
                    "VALUES " +
                    "(@FullName, @Age, @Sex, @Purok, @PWD, @ContactNumber,@DateTimeCreated,@DateTimeModified)";

                using (SQLiteCommand cmd =
                    new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        txtFullName.Text);

                    cmd.Parameters.AddWithValue(
                        "@Age",
                        age);

                    cmd.Parameters.AddWithValue(
                        "@Sex",
                        cboSex.Text);

                    cmd.Parameters.AddWithValue(
                        "@Purok",
                        cboPurok.Text);

                    cmd.Parameters.AddWithValue(
                        "@PWD",
                        cboPWD.Text);

                    cmd.Parameters.AddWithValue(
                        "@ContactNumber",
                        txtContact.Text);

                    cmd.Parameters.AddWithValue(
                       "@DateTimeCreated",
                       dtpCreated.Text);

                    cmd.Parameters.AddWithValue(
                       "@DateTimeModified",
                       dtpModified.Text);


                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Resident saved successfully!",
                    "Success");

                adding = false;

                btnAdd.Text = "Add";
                btnEdit.Text = "Edit";

                ClearFields();

                // REFRESH DATAGRIDVIEW
                LoadResidents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Save Error");
            }
        }


        // ==============================
        // EDIT BUTTON
        // ==============================

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (adding)
            {
                ClearFields();
                return;
            }

            if (!editing)
            {
                if (dgvResidents.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Please select a resident first.");

                    return;
                }

                if (txtResidentID.Text == "")
                {
                    MessageBox.Show(
                        "Please select a resident first.");

                    return;
                }

                editing = true;

                btnAdd.Text = "Save";
                btnEdit.Text = "Clear";

                txtFullName.Focus();
            }
            else
            {
                editing = false;

                btnAdd.Text = "Add";
                btnEdit.Text = "Edit";

                ClearFields();
            }
        }


        // ==============================
        // SAVE EDIT
        // ==============================

        private void SaveEditedResident()
        {
            int age;

            if (txtResidentID.Text == "")
            {
                MessageBox.Show(
                    "Please select a resident first.");

                return;
            }

            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show(
                    "Please enter valid Age.");

                return;
            }

            try
            {
                string sql =
                    "UPDATE residents SET " +
                    "FullName=@FullName, " +
                    "Age=@Age, " +
                    "Sex=@Sex, " +
                    "Purok=@Purok, " +
                    "PWD=@PWD, " +
                    "ContactNumber=@ContactNumber " +
                    "WHERE ResidentID=@ResidentID";

                using (SQLiteCommand cmd =
                    new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        txtFullName.Text);

                    cmd.Parameters.AddWithValue(
                        "@Age",
                        age);

                    cmd.Parameters.AddWithValue(
                        "@Sex",
                        cboSex.Text);

                    cmd.Parameters.AddWithValue(
                        "@Purok",
                        cboPurok.Text);

                    cmd.Parameters.AddWithValue(
                        "@PWD",
                        cboPWD.Text);

                    cmd.Parameters.AddWithValue(
                        "@ContactNumber",
                        txtContact.Text);

                    cmd.Parameters.AddWithValue(
                        "@ResidentID",
                        Convert.ToInt32(
                            txtResidentID.Text));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Resident updated successfully!",
                    "Success");

                editing = false;

                btnAdd.Text = "Add";
                btnEdit.Text = "Edit";

                ClearFields();

                // REFRESH DATAGRIDVIEW
                LoadResidents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Update Error");
            }
        }


        // DELETE
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtResidentID.Text == "")
            {
                MessageBox.Show(
                    "Please select a resident first.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this resident?",
                    "Delete",
                    MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql =
                        "DELETE FROM residents " +
                        "WHERE ResidentID=@ResidentID";

                    using (SQLiteCommand cmd =
                        new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@ResidentID",
                            Convert.ToInt32(
                                txtResidentID.Text));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Resident deleted successfully!",
                        "Success");

                    ClearFields();

                    // REFRESH DATAGRIDVIEW
                    LoadResidents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Delete Error");
                }
            }
        }



        // DATAGRIDVIEW ROW CLICK

        private void dgvResidents_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvResidents.Rows[e.RowIndex];

                txtResidentID.Text = row.Cells["ResidentID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                cboSex.Text = row.Cells["Sex"].Value.ToString();
                cboPurok.Text = row.Cells["Purok"].Value.ToString();
                cboPWD.Text = row.Cells["PWD"].Value.ToString();
                txtContact.Text = row.Cells["ContactNumber"].Value.ToString();
            }

        }

    // CLEAR

    private void ClearFields()
        {
            txtResidentID.Clear();
            txtFullName.Clear();
            txtAge.Clear();

            cboSex.SelectedIndex = -1;
            cboPurok.SelectedIndex = -1;
            cboPWD.SelectedIndex = -1;

            txtContact.Clear();
        }



        // EMPTY EVENTS

        private void textBox1_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void txtFullName_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void txtAge_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void cboSex_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void cboPurok_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void cboPWD_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void txtContact_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMain frm = new frmMain();
            frm.Show();
        }
        // TOTAL RESIDENTS
        public int GetTotalResident()
        {
            return GetCount("SELECT COUNT(*) FROM residents");
        }

        // TOTAL SENIOR CITIZENS (AGE 60 AND ABOVE)
        public int GetTotalAge()
        {
            return GetCount(
                "SELECT COUNT(*) FROM residents WHERE CAST(Age AS INTEGER) >= 60"
            );
        }

        // TOTAL PWD RESIDENTS
        public int GetTotalPWD()
        {
            return GetCount(
                "SELECT COUNT(*) FROM residents WHERE LOWER(TRIM(PWD)) = 'yes'"
            );
        }

        // HELPER METHOD FOR COUNTING
        private int GetCount(string sql)
        {
            bool openedHere = false;

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    openedHere = true;
                }

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                if (openedHere && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}