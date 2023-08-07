using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONGNGHENET
{
    public partial class NhaCungCap : Form
    {
        XULYCSDL xldl = new XULYCSDL();
        DataTable dtNhaCungCap;
        DataColumn[] key = new DataColumn[1];
        public NhaCungCap()
        {
            InitializeComponent();
            txt_MaNCC.Enabled = false;
            txt_TenNCC.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;
            btnLuu.Enabled = false;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dtNhaCungCap = xldl.LayDuLieu("SELECT * FROM NHACUNGCAP");
            key[0] = dtNhaCungCap.Columns[0];
            dtNhaCungCap.PrimaryKey = key;
            dataGridView1.DataSource = dtNhaCungCap;
            NhaCungCapBiding();
        }
        
        void NhaCungCapBiding()
        {
            txt_MaNCC.DataBindings.Add("Text", dtNhaCungCap, "MaNCC");
            txt_TenNCC.DataBindings.Add("Text", dtNhaCungCap, "TenNCC");
            txt_DiaChi.DataBindings.Add("Text", dtNhaCungCap, "DiaChi");
            txt_SDT.DataBindings.Add("Text", dtNhaCungCap, "SDT");
        }
        bool THEMMOI = true;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            THEMMOI = true;
            txt_MaNCC.DataBindings.Clear();
            txt_TenNCC.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_MaNCC.Enabled = true;
            txt_TenNCC.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            txt_MaNCC.Focus();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaNCC.Text == "")
                {
                    errorProvider1.SetError(txt_MaNCC, "Mã nhà cung cấp không được rỗng");
                }
                else if (txt_TenNCC.Text == "")
                {
                    errorProvider1.SetError(txt_TenNCC, "Tên nhà cung cấp không được rỗng");
                }
                else if (txt_DiaChi.Text == "")
                {
                    errorProvider1.SetError(txt_DiaChi, "Địa chỉ nhà cung cấp không được rỗng");
                }
                else if (txt_SDT.Text == "")
                {
                    errorProvider1.SetError(txt_SDT, "Số điện thoại nhà cung cấp không được rỗng");
                }
                else if (THEMMOI) //LA THEM MOI
                {
                    DataRow newrow = dtNhaCungCap.NewRow();
                    newrow["MaNCC"] = txt_MaNCC.Text;
                    newrow["TenNCC"] = txt_TenNCC.Text;
                    newrow["DiaChi"] = txt_DiaChi.Text;
                    newrow["SDT"] = txt_SDT.Text;
                    dtNhaCungCap.Rows.Add(newrow);
                    NhaCungCapBiding();
                    txt_MaNCC.Enabled = false;
                    txt_TenNCC.Enabled = false;
                    txt_DiaChi.Enabled = false;
                    txt_SDT.Enabled = false;
                    btnLuu.Enabled = false;
                }
                else
                {
                    btnLuu.Enabled = false;
                    //txt_TenNCC.Enabled = false;
                    //txt_DiaChi.Enabled = false;
                    //txt_SDT.Enabled = false;
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            THEMMOI = false;
            DataRow delrow = dtNhaCungCap.Rows.Find(txt_MaNCC.Text);
            if (delrow != null) //tim thay
            {
                delrow.Delete();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (xldl.CAPNHAT("SELECT * FROM NHACUNGCAP", dtNhaCungCap) > 0)
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Bạn phải nhấn lưu trước mới có thể cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            THEMMOI = false;
            txt_TenNCC.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            txt_TenNCC.Focus();
            txt_DiaChi.Focus();
            txt_SDT.Focus();        
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
