using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CONGNGHENET
{
    public partial class QuanLyTaiKhoan : Form
    {
        XULYCSDL xuly = new XULYCSDL();
        DataTable dtUSER;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            //string lenhsql = "select name as 'TaiKhoan' from sys.database_principals where type not in ('A', 'G', 'R', 'X') and sid is not null and name != 'guest' and name != 'dbo' and name != 'admin'";
            string lenhsql = "SELECT * FROM TAIKHOAN";
            dtUSER = xuly.LayDuLieu(lenhsql);
            dataGridView1.DataSource = dtUSER;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[0].DataPropertyName = "TaiKhoan";
            dataGridView1.Columns[1].DataPropertyName = "MatKhau";
        }
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
            //binding tài khoản 
            txt_tk.DataBindings.Add("Text", dtUSER, "TaiKhoan");
            //Load combobox role
            DataTable dtRole = xuly.LayDuLieu("select name from sys.database_principals where name like 'role%'");
            cb_role.DataSource = dtRole;
            cb_role.DisplayMember = "name";

            //lOAD CB_BẢNG
            DataTable dtAllTable = xuly.LayDuLieu("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_NAME != 'TAIKHOAN'");
            cb_bang.DataSource = dtAllTable;
            cb_bang.DisplayMember = "TABLE_NAME";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //clear binding
                    txt_tk.DataBindings.Clear();

                    string lenhsql = string.Format("exec HUYTAIKHOAN '{0}'", txt_tk.Text);
                    xuly.XuLyTaiKhoan(lenhsql);
                    loaddata();
                    //binding lại
                    txt_tk.DataBindings.Add("Text", dtUSER, "TaiKhoan");
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btn_taotkmoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKyTaiKhoan f = new DangKyTaiKhoan();
            f.Show();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            try
            {
                string lenhsql = string.Format("exec DuaUserVaoNhomQuyenNV '{0}', '{1}'", cb_role.Text, txt_tk.Text);
                xuly.XuLyTaiKhoan(lenhsql);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            try
            {
                string lenhsql = string.Format("exec DuaUserRaNhomQuyenNV '{0}', '{1}'", cb_role.Text, txt_tk.Text);
                xuly.XuLyTaiKhoan(lenhsql);
                MessageBox.Show("Rút thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Rút thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //Tạo nhóm quyền
        private void btn_tao_role_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "EXEC TAONHOMQUYEN 'role_" + txt_nhaptenquyen.Text + "'";
                xuly.XuLyTaiKhoan(sql);
                DataTable dtRole = xuly.LayDuLieu("select name from sys.database_principals where name like 'role%'");
                cb_role.DataSource = dtRole;
                cb_role.DisplayMember = "name";
                MessageBox.Show("Tạo nhóm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhóm quyền đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Xoá nhóm quyền
        private void btn_xoanhomquyen_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "XOANHOMQUYEN '" + cb_role.Text + "'";
                xuly.XuLyTaiKhoan(sql);
                DataTable dtRole = xuly.LayDuLieu("select name from sys.database_principals where name like 'role%'");
                cb_role.DataSource = dtRole;
                cb_role.DisplayMember = "name";
                MessageBox.Show("Xoá nhóm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhóm quyền phải trống trước khi xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        string lenhsql;
        private void btn_themquyen_Click(object sender, EventArgs e)
        {
            try
            {
                // chon 1 cai
                //chọn select
                if (chk_select.Checked && chk_insert.Checked == false && chk_del.Checked == false && chk_update.Checked == false)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    //lenhsql = string.Format("GRANT SELECT ON NHANVIEN TO {0}", txt_tk.Text);
                    //MessageBox.Show("Thêm quyền "+chk_select.Text+" thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //chọn insert
                else if (chk_insert.Checked && chk_select.Checked == false && chk_del.Checked == false && chk_update.Checked == false)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT INSERT ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_insert.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT INSERT ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_insert.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //chọn update
                else if (chk_update.Checked && chk_select.Checked == false && chk_del.Checked == false && chk_insert.Checked == false)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT UPDATE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_update.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT UPDATE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_update.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //chọn delete
                else if (chk_del.Checked && chk_select.Checked == false && chk_update.Checked == false && chk_insert.Checked == false)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT DELETE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_del.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT DELETE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_del.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                //chon 2 cai
                //CHON SELECT, INSERT
                else if (chk_select.Checked && chk_insert.Checked && chk_del.Checked == false && chk_update.Checked == false)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, INSERT ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_insert.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, INSERT ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_insert.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                //CHON SELECT, DEL
                else if (chk_select.Checked && chk_insert.Checked == false && chk_del.Checked && chk_update.Checked == false)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, DELETE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, DELETE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //CHON SELECT, UPDATE
                else if (chk_select.Checked && chk_insert.Checked == false && chk_del.Checked == false && chk_update.Checked)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, UPDATE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, UPDATE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //CHON INSERT, DELETE
                else if (chk_select.Checked == false && chk_insert.Checked && chk_del.Checked && chk_update.Checked == false)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT INSERT, DELETE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_insert.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT INSERT, DELETE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_insert.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //CHON INSERT, UPDATE
                else if (chk_select.Checked == false && chk_insert.Checked && chk_del.Checked == false && chk_update.Checked)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT INSERT, UPDATE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_insert.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT INSERT, UPDATE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_insert.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //CHON DELETE, UPDATE
                else if (chk_select.Checked == false && chk_insert.Checked == false && chk_del.Checked && chk_update.Checked)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT DELETE, UPDATE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_del.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT DELETE, UPDATE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_del.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                //chon 3 cai
                //CHON SELECT, INSERT, DELTELE
                else if (chk_select.Checked && chk_insert.Checked && chk_del.Checked && chk_update.Checked == false)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, INSERT, DELETE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_insert.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, INSERT, DELETE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_insert.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //CHON SELECT, INSERT, UPDATE
                else if (chk_select.Checked && chk_insert.Checked && chk_del.Checked == false && chk_update.Checked)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, INSERT, UPDATE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_insert.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, INSERT, UPDATE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_insert.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //CHON INSERT, DELETE, UPDATE
                else if (chk_select.Checked == false && chk_insert.Checked && chk_del.Checked && chk_update.Checked)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT INSERT, DELETE, UPDATE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_insert.Text + ", " + chk_del.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT INSERT, DELETE, UPDATE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_insert.Text + ", " + chk_del.Text + ", " + chk_update.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //CHON DELETE, UPDATE, SELECT
                else if (chk_select.Checked && chk_insert.Checked == false && chk_del.Checked && chk_update.Checked)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, UPDATE, DELETE ON {0} TO {1}", cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_update.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT SELECT, UPDATE, DELETE ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_update.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                // full
                else if (chk_select.Checked && chk_insert.Checked && chk_del.Checked && chk_update.Checked)
                {
                    if (rdo_addquyenuser.Checked)
                    {
                        lenhsql = string.Format("GRANT DELETE, UPDATE, SELECT, INSERT ON {0} TO {1}",cb_bang.Text, txt_tk.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_insert.Text + ", " + chk_update.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + txt_tk.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (rdo_addquyennhom.Checked)
                    {
                        lenhsql = string.Format("GRANT DELETE, UPDATE, SELECT, INSERT ON {0} TO {1}", cb_bang.Text, cb_role.Text);
                        MessageBox.Show("Thêm quyền " + chk_select.Text + ", " + chk_insert.Text + ", " + chk_update.Text + ", " + chk_del.Text + " trên " + cb_bang.Text + " cho " + cb_role.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn thêm vào đâu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("?");
                }
                xuly.XuLyTaiKhoan(lenhsql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(lenhsql, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_thuhoi_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdo_addquyenuser.Checked)
                {
                    if (chk_select.Checked && chk_insert.Checked == false && chk_del.Checked == false && chk_update.Checked == false)
                    {
                        lenhsql = string.Format("REVOKE SELECT ON NHANVIEN FROM {0}", txt_tk.Text);

                    }
                    //chọn insert
                    else if (chk_insert.Checked && chk_select.Checked == false && chk_del.Checked == false && chk_update.Checked == false)
                    {
                        lenhsql = string.Format("REVOKE INSERT ON NHANVIEN FROM {0}", txt_tk.Text);

                    }
                    //chọn update
                    else if (chk_update.Checked && chk_select.Checked == false && chk_del.Checked == false && chk_insert.Checked == false)
                    {
                        lenhsql = string.Format("REVOKE UPDATE ON NHANVIEN FROM {0}", txt_tk.Text);

                    }
                    //chọn delete
                    else if (chk_del.Checked && chk_select.Checked == false && chk_update.Checked == false && chk_insert.Checked == false)
                    {
                        lenhsql = string.Format("REVOKE DELETE ON NHANVIEN FROM {0}", txt_tk.Text);

                    }
                    // chọn all
                    else if (chk_del.Checked && chk_select.Checked && chk_update.Checked && chk_insert.Checked)
                    {
                        lenhsql = string.Format("REVOKE ALL ON NHANVIEN FROM {0}", txt_tk.Text);

                    }
                }
                else if (rdo_addquyennhom.Checked)
                {
                    if (chk_select.Checked && chk_insert.Checked == false && chk_del.Checked == false && chk_update.Checked == false)
                    {
                        lenhsql = string.Format("REVOKE SELECT ON {0} FROM {1}",cb_bang.Text, cb_role.Text);

                    }
                    //chọn insert
                    else if (chk_insert.Checked && chk_select.Checked == false && chk_del.Checked == false && chk_update.Checked == false)
                    {
                        lenhsql = string.Format("REVOKE INSERT ON {0} FROM {1}", cb_bang.Text, cb_role.Text);

                    }
                    //chọn update
                    else if (chk_update.Checked && chk_select.Checked == false && chk_del.Checked == false && chk_insert.Checked == false)
                    {
                        lenhsql = string.Format("REVOKE UPDATE ON {0} FROM {1}", cb_bang.Text, cb_role.Text);

                    }
                    //chọn delete
                    else if (chk_del.Checked && chk_select.Checked == false && chk_update.Checked == false && chk_insert.Checked == false)
                    {
                        lenhsql = string.Format("REVOKE DELETE ON {0} FROM {1}", cb_bang.Text, cb_role.Text);

                    }
                    // chọn all
                    else if (chk_del.Checked && chk_select.Checked && chk_update.Checked && chk_insert.Checked)
                    {
                        lenhsql = string.Format("REVOKE ALL ON {0} FROM {1}", cb_bang.Text, cb_role.Text);
                    }
                }
                xuly.XuLyTaiKhoan(lenhsql);
                MessageBox.Show("Thu hồi quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thu hồi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

    }
}
