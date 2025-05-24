using MySql.Data.MySqlClient;

namespace AppHoja4
{
    public static class ConnectionDB
    {
        private static string connectionString = "server=localhost;database=prueba1;uid=root;pwd=H277353;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;

        }

    }
}
