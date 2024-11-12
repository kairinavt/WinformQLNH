using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Utils
{
    public class DataHelper
    {
        public string connectionString = "Data Source=DESKTOP-58F566U\\SQLEXPRESS;Initial Catalog=banksystem;Integrated Security=True"; // Cập nhật chuỗi kết nối của bạn

        // Phương thức thực hiện câu truy vấn trả về DataTable
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        // Phương thức thực hiện câu truy vấn không trả về dữ liệu
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        // Phương thức thực hiện truy vấn trả về giá trị đơn
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    result = command.ExecuteScalar();
                }
            }
            return result;
        }
    }
}

