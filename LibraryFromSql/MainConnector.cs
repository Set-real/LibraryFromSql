using LibraryFromSql.Configurations;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibraryFromSql
{
    public class MainConnector
    {
        SqlConnection connection = new SqlConnection(ConnectionString.MsSqlConnection);
        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                await connection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
        public void DisconnectAsync()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return connection;
            }
            else
            {
                throw new Exception("Подключение уже закрыто!");
            }
        }
    }
}