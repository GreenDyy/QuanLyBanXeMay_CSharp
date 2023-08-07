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
    public partial class ChiTietHoaDon : Form
    {
        XULYCSDL xldl = new XULYCSDL();
        DataTable dtCTHD;
        DataTable dtHOADON;
        DataColumn[] key = new DataColumn[2];
        public ChiTietHoaDon()
        {
            InitializeComponent();
            cb_mahd.Enabled = false;
            txt_maxe.Enabled = false;
            txt_dongia.Enabled = false;
            txt_soluong.Enabled = false;
            txt_thanhtien.Enabled = false;
            dataGridViewCTHD.ForeColor = Color.Black;
            dataGridViewCTHD.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);
        }
        public void loadData()
        {
            dtCTHD = xldl.LayDuLieu("SELECT * FROM CHITIETHD");
            key[0] = dtCTHD.Columns[0];
            dtCTHD.PrimaryKey = key;
            dataGridViewCTHD.AutoGenerateColumns = false;
            dataGridViewCTHD.DataSource = dtCTHD;
            dataGridViewCTHD.Columns[0].DataPropertyName = "MaHD";
            dataGridViewCTHD.Columns[1].DataPropertyName = "MaXe";
            dataGridViewCTHD.Columns[2].DataPropertyName = "DonGia";
            dataGridViewCTHD.Columns[3].DataPropertyName = "SoLuong";
            dataGridViewCTHD.Columns[4].DataPropertyName = "ThanhTien";
        }
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            loadData();
            loadCombobox();
            CTHDBindings();
        }
        void loadCombobox()
        {
            string sql = "SELECT * FROM HOADON";
            dtHOADON = xldl.LayDuLieu(sql);
            cb_mahd.DataSource = dtHOADON;
            cb_mahd.DisplayMember = "MaHD";
            cb_mahd.ValueMember = "MaHD";
        }
        void CTHDBindings()
        {
            cb_mahd.DataBindings.Add("Text", dtCTHD, "MaHD");
            txt_maxe.DataBindings.Add("Text", dtCTHD, "MaXe");
            txt_dongia.DataBindings.Add("Text", dtCTHD, "DonGia");
            txt_soluong.DataBindings.Add("Text", dtCTHD, "SoLuong");
            txt_thanhtien.DataBindings.Add("Text", dtCTHD, "ThanhTien");
        }
        void setControlEditTable(bool edit)
        {
            cb_mahd.Enabled = txt_maxe.Enabled = txt_soluong.Enabled = txt_dongia.Enabled = txt_thanhtien.Enabled = edit;
            btn_luu.Enabled = edit;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = !edit;
            dataGridViewCTHD.ReadOnly = !edit;
            dataGridViewCTHD.AllowUserToAddRows = !edit;
        }
        bool THEMMOI = true;
        private void btn_them_Click(object sender, EventArgs e)
        {
            THEMMOI = true;
            cb_mahd.DataBindings.Clear();
            txt_maxe.DataBindings.Clear();
            txt_dongia.DataBindings.Clear();
            txt_soluong.DataBindings.Clear();
            txt_thanhtien.DataBindings.Clear();
            
            txt_soluong.Clear();
            txt_dongia.Clear();
            txt_maxe.Clear();
            txt_thanhtien.Clear();
            txt_thanhtien.Text = "1";

            setControlEditTable(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {  
            if (MessageBox.Show("Bạn có chắc không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                THEMMOI = false;
                setControlEditTable(true);
                DataRow delrow = dtCTHD.Rows.Find(cb_mahd.Text);
                if (delrow != null) //tim thay
                {
                    delrow.Delete();
                }
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            THEMMOI = false;
            setControlEditTable(true);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (xldl.CAPNHAT("SELECT * FROM CHITIETHD", dtCTHD) > 0)
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Bạn phải nhấn lưu trước mới có thể cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                setControlEditTable(false);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Mã xe không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                setControlEditTable(false);
                if (txt_maxe.Text == "")
                {
                    errorProvider1.SetError(txt_maxe, "Mã xe không được rỗng");
                }
                else if (txt_dongia.Text == "")
                {
                    errorProvider1.SetError(txt_dongia, "Đơn giá không được rỗng");
                }
                else if (txt_soluong.Text == "")
                {
                    errorProvider1.SetError(txt_soluong, "Số lượng không được rỗng");
                }
                else if (txt_thanhtien.Text == "")
                {
                    errorProvider1.SetError(txt_thanhtien, "Thành tiền không được rỗng");
                }

                if (THEMMOI) //LA THEM MOI
                {
                    DataRow newrow = dtCTHD.NewRow();
                    newrow["MaHD"] = cb_mahd.Text;
                    newrow["MaXe"] = txt_maxe.Text;
                    newrow["DonGia"] = txt_dongia.Text;
                    newrow["SoLuong"] = txt_soluong.Text;
                    newrow["ThanhTien"] = txt_thanhtien.Text;
                    dtCTHD.Rows.Add(newrow);
                    CTHDBindings();
                }
                else
                {
                    dataGridViewCTHD.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            DataTable dt = xldl.LayDuLieu("SELECT * FROM CTHD_VIEW");
            FormBaoCao f = new FormBaoCao(dt, "CTHD_VIEW");
            f.Show();
        }

        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            DataTable dt = xldl.LayDuLieu("SELECT * FROM CTHD_HOADONCUOI");
            FormBaoCao f = new FormBaoCao(dt, "CTHD_HOADONCUOI");
            f.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btn_update_tien_Click(object sender, EventArgs e)
        {
            xldl.LayDuLieu("EXEC CAPNHATTINHTIEN");
            loadData();
            loadCombobox();
            cb_mahd.DataBindings.Clear();
            txt_maxe.DataBindings.Clear();
            txt_dongia.DataBindings.Clear();
            txt_soluong.DataBindings.Clear();
            txt_thanhtien.DataBindings.Clear();
            CTHDBindings();
            MessageBox.Show("Cập nhật tiền thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
