using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAn1
{
    public class Connect
    {
        private SqlConnection connection;
        private string connectionString;

        public Connect()
        {
            connectionString = DoAn1.Properties.Settings.Default.QLQUANANConnectionString;
        }

        // Hàm kết nối
        public void OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        // Hàm xem dữ liệu
        public SqlDataReader ExecuteQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            return command.ExecuteReader();
        }

        // Hàm đóng kết nối
        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM NGUOI_DUNG WHERE USERNAME = @username AND PASSWORD = @password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true; // Đăng nhập thành công
            }
            else
            {
                return false; // Đăng nhập thất bại
            }
        }
    }

}
