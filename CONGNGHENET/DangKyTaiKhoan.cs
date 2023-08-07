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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CONGNGHENET
{
    public partial class DangKyTaiKhoan : Form
    {
        XULYCSDL xuly = new XULYCSDL();
        public DangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void DangKyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if (txt_mk.Text == txt_mk2.Text)
            {
                try
                {
                    string lenhsql = string.Format("exec TAOTAIKHOAN '{0}', '{1}'", txt_tk.Text, txt_mk.Text);
                    xuly.XuLyTaiKhoan(lenhsql);
                    MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    QuanLyTaiKhoan f = new QuanLyTaiKhoan();
                    f.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyTaiKhoan f = new QuanLyTaiKhoan();
            f.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
