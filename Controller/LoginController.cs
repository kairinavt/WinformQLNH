using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.Model;
using BankingSystem.Utils;
namespace BankingSystem.Controller
{
public class LoginController
{ 
//    private DataHelper db = new DataHelper();
//    public bool CheckLogin(string id, string password, string role)
//    {
//        string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE id = @id AND password = @password AND role = @role";
//        SqlParameter[] parameters = {
//            new SqlParameter("@id", id),
//            new SqlParameter("@password", password),
//            new SqlParameter("@role", role)
//        };

//        object result = db.ExecuteScalar(query, parameters);

//        return Convert.ToInt32(result) > 0; 
//    }
//}
private DataHelper db = new DataHelper();

public bool CheckLogin(Employee employee)
{
    using (SqlConnection connection = new SqlConnection(db.connectionString))
    {
        connection.Open();

        // Tạo đối tượng SqlCommand để thực hiện truy vấn
        using (SqlCommand command = new SqlCommand())
        {
            // Gán kết nối cho command
            command.Connection = connection;

            // Định nghĩa câu truy vấn với các tham số
            command.CommandText = "SELECT COUNT(*) FROM Users WHERE id = @id AND password = @password AND role = @role";

            // Thêm các tham số vào SqlCommand
            command.Parameters.Add(new SqlParameter("@id", employee.id));
            command.Parameters.Add(new SqlParameter("@password", employee.password));
            command.Parameters.Add(new SqlParameter("@role", employee.role));

            // Thực thi truy vấn và trả về kết quả
            int result = (int)command.ExecuteScalar();

            // Kiểm tra kết quả trả về
            return result > 0;  // Nếu có bản ghi khớp, trả về true
        }
    }

}
}
}

