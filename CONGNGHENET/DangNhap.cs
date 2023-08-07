using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONGNGHENET
{
    public partial class DangNhap : Form
    {
        XULYCSDL xldl = new XULYCSDL();
        string chuoiketnoi;
        //dien server và database
        string server = "GREEND\\SQLEXPRESS";
        string database = "QUANLYXEMAY";
        public DangNhap()
        {
            InitializeComponent();
            textUserName.MaxLength = 36;
            textPassWord.MaxLength = 16;
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            textUserName.Text = "admin";
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            chuoiketnoi = string.Format("server={0}; database={1}; Integrated Security = false; uid={2}; pwd={3}", server, database, textUserName.Text, textPassWord.Text);

            if (xldl.testConnection(chuoiketnoi)) //kt ket noi, ket noi dc thi load form
            {
                //lưu chuỗi kết nối hiện tại
                LuuAppConfig LuuAppConfig = new LuuAppConfig();
                LuuAppConfig.SetConnectionString("QUANLYXEMAYConnectionString", chuoiketnoi);
                //load form
                this.Hide();
                Loading f = new Loading();

                //chuyền user và con sang form khác
                f.text_userLD = textUserName.Text;
                f.chuoiketnoi_LD = chuoiketnoi;
                f.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
