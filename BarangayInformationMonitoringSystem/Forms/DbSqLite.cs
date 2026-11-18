using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BarangayInformationMonitoringSystem
{
    public static class DbSqLite
    {
        private static string DBConnection =
            "Data Source=" +
            Application.StartupPath +
            "\\Data\\barangay.db;Version=3;";

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

                using (SQLiteDataAdapter da =
                    new SQLiteDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }

                return dt;
            }
        }
    }
}