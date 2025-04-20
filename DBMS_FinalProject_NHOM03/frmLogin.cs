using DBMS_FinalProject_NHOM03.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DBMS_FinalProject_NHOM03
{
    public partial class frmLogin : Form
    {
        Database db = new Database();
        private BLLogin log;
        public frmLogin()
        {
            InitializeComponent();
            log = new BLLogin(db);
            
        }
      

        private void pc_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }



    }
    public static class CurrentUser
    {
        // Thuộc tính lưu trữ thông tin tên người dùng
        public static string Username { get; set; }

        // Thuộc tính lưu trữ vai trò của người dùng (Admin, Staff, v.v...)
        public static string Role { get; set; }

        // Thuộc tính để kiểm tra xem người dùng có phải là Admin không
        public static bool IsAdmin => Role == "Admin";

        // Phương thức để xóa thông tin người dùng hiện tại (đăng xuất)
        public static void Clear()
        {
            Username = null;
            Role = null;
        }
    }

}
