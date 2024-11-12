using BankingSystem.Controller;
using BankingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class LoginView : Form
    {
        private LoginController loginController = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
             string id = txtId.Text;  // Lấy id người dùng nhập
            string password = txtPassword.Text;  // Lấy mật khẩu người dùng nhập
            string role = comboBoxRoleLogin.SelectedItem.ToString();  // Lấy role người dùng nhập (ví dụ: admin, user, etc.)

            if (comboBoxRoleLogin.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò trước khi đăng nhập.");
                return;  // Dừng thực hiện nếu chưa chọn role
            }

            bool isValidLogin = loginController.CheckLogin(Employee employee);

            if (isValidLogin)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Chuyển sang màn hình chính hoặc hành động tiếp theo
            }
            else
            {
                MessageBox.Show("Sai id, mật khẩu hoặc vai trò.");
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
