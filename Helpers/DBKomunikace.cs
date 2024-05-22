using System.Data;
using System.Data.SqlClient;

namespace SediM.Helpers
{
    internal static class DBKomunikace
    {
        private static SqlConnection connection = new SqlConnection($"Data Source={Properties.Settings.Default.MySQL_server};Initial Catalog={Properties.Settings.Default.MySQL_databaze};User ID={Properties.Settings.Default.MySQL_uzivatel};Password={Properties.Settings.Default.MySQL_heslo}");

        public static DataTable NactiSkoly()
        {
            connection.Open();

            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;
            SqlCommand cmd = new("SELECT * FROM Skoly", connection);

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            connection.Close();

            return data;
        }

        public static DataTable NactiTridy()
        {
            connection.Open();

            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;

            SqlCommand cmd = new($"SELECT * FROM Tridy", connection);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            connection.Close();

            return data;
        }

        public static DataTable NactiZaky()
        {
            connection.Open();

            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;
            SqlCommand cmd = new("SELECT * FROM Studenti", connection);

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            connection.Close();

            return data;
        }

        public static DataTable NactiUcitele()
        {
            connection.Open();

            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;
            SqlCommand cmd = new("SELECT * FROM AspNetUsers", connection);

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            connection.Close();

            return data;
        }

        public static DataTable NactiUcitele(string id)
        {
            connection.Open();

            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter;
            SqlCommand cmd = new($"SELECT * FROM AspNetUsers WHERE Id = '{id}'", connection);

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);

            connection.Close();

            return data;
        }
    }
}
