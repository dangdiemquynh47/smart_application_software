using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    public class SqlClass
    {
        SqlConnection connection;

        public SqlClass()
        {
            this.connection = null; // Không cần thiết khi không khởi tạo ngay
        }

        public void CreateConnection(string pConnectionString)
        {
            try
            {
                connection = new SqlConnection(pConnectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR OPENING CONNECTION: " + ex.Message);
                // Có thể xử lý lỗi tại đây
            }
        }

        public bool TestConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        public DataTable ExecuteQuery(string pQuery)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(pQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                else
                {
                    Console.WriteLine("CONNECTION IS NOT OPEN");
                    // Có thể xử lý khi kết nối không mở
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EXECUTING QUERY: " + ex.Message);
                // Có thể xử lý lỗi khi thực thi câu truy vấn
            }
            return dataTable;
        }
    }
}
