using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BarangayInformationMonitoringSystem
{
    public static class DbSqLite
    {
        private String DBConnection = "Data Source=E:\\Estrada, James Gerald C in PC\\OOP\\BarangayInformationMonitoringSystem\\BarangayInformationMonitoringSystem\\Data\\barangay.db";
        public static SQLiteConnection GetConn()
        {
            return new SQLiteConnection(DBConnection);
        }

        public static DataTable GetData(string sql)
        {
            using (SQLiteConnection con = GetConn())
            {
                con.Open();

                DataTable dt = new DataTable();

                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }

                return dt;
            }
        }
    }
}