using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Office.Interop.Excel;

namespace CONGNGHENET
{
    public partial class SaoLuuPhucHoi : Form
    {
        //lay tu form dang nhap qua
        public string chuoiketnoi;
        //SqlConnection con = new SqlConnection("server=GREEND\\SQLEXPRESS; database=QUANLYXEMAY; Integrated Security=false; uid=admin; pwd=1");
        SqlConnection con;

        public SaoLuuPhucHoi()
        {
            InitializeComponent();

        }
        private void SaoLuuPhucHoi_Load(object sender, EventArgs e)
        {
            //label1.Text = chuoiketnoi;
            try
            {
                con = new SqlConnection(chuoiketnoi);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kết nối thất bại!");
            }
            btn_saoluu.Enabled = false;
        }

        private void btn_path_backup_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Title = "Sao lưu Database";
            savefiledialog.Filter = "Full, Diff(*.bak)|*.bak|Log, Taillog(*.trn)|*.trn";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                txt_duongdan1.Text = savefiledialog.FileName;
                btn_saoluu.Enabled = true;
            }
        }
        private void btn_saoluu_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if(txt_duongdan1.Text == string.Empty) 
            {
                MessageBox.Show("Vui lòng chọn đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txt_duongdan1.Text + "'";
                try 
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(cmd, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sao lưu Database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                    btn_saoluu.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sao lưu Database thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btn_path_restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "Phục hồi Database";
            openfiledialog.Filter = "Full, Diff(*.bak)|*.bak|Log, Taillog(*.trn)|*.trn";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                txt_duongdan2.Text= openfiledialog.FileName;
                btn_phuchoi.Enabled = true;
            }
        }
        private void btn_phuchoi_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if (txt_duongdan2.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    string str = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(str, con);
                    cmd1.ExecuteNonQuery();
                    string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + txt_duongdan2.Text + "' WITH REPLACE;";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    cmd2.ExecuteNonQuery();
                    string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand cmd3 = new SqlCommand(str3, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Phục hồi database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Phục hồi database thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        //test với log, diff nhưng k chạy dc
        //private void btn_phuchoi_Click(object sender, EventArgs e)
        //{
        //    string database = con.Database.ToString();
        //    if (txt_duongdan2.Text == string.Empty)
        //    {
        //        MessageBox.Show("Vui lòng chọn đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //    }
        //    else
        //    {
        //        if(rdo_recovery.Checked)
        //        {
        //            try
        //            {
        //                if (con.State == ConnectionState.Closed)
        //                {
        //                    con.Open();
        //                }
        //                string str = string.Format("ALTER DATABASE QUANLYXEMAY SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
        //                SqlCommand cmd1 = new SqlCommand(str, con);
        //                cmd1.ExecuteNonQuery();
        //                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + txt_duongdan2.Text + "' WITH RECOVERY, REPLACE";
        //                SqlCommand cmd2 = new SqlCommand(str2, con);
        //                cmd2.ExecuteNonQuery();
        //                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
        //                SqlCommand cmd3 = new SqlCommand(str3, con);
        //                cmd3.ExecuteNonQuery();
        //                MessageBox.Show("Phục hồi database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                con.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                //MessageBox.Show("Phục hồi database thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                MessageBox.Show(ex.Message);
        //            }
        //        }
        //        else if(rdo_norecovery.Checked)
        //        {
        //            try
        //            {
        //                if (con.State == ConnectionState.Closed)
        //                {
        //                    con.Open();
        //                }
        //                //string str = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
        //                //SqlCommand cmd1 = new SqlCommand(str, con);
        //                //cmd1.ExecuteNonQuery();
        //                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + txt_duongdan2.Text + "' WITH NORECOVERY, REPLACE";
        //                SqlCommand cmd2 = new SqlCommand(str2, con);
        //                cmd2.ExecuteNonQuery();
        //                //string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
        //                //SqlCommand cmd3 = new SqlCommand(str3, con);
        //                //cmd3.ExecuteNonQuery();
        //                MessageBox.Show("Phục hồi database thành công(norecovery)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                //con.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Phục hồi database thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Vui lòng chọn chế độ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //        }

        //    }   
        //}
    }
}
