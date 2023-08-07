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
using System.Xml;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace CONGNGHENET
{
    public partial class NhanVien : Form
    {
        XULYCSDL xuly = new XULYCSDL();
        DataColumn[] keyMaNV = new DataColumn[1];
        DataTable dtNhanVien;
        DataTable dtPhanQuyen;
        public NhanVien()
        {
            InitializeComponent();
            text_MaNV.Enabled = false;
            text_Email.Enabled = false;
            text_TenNV.Enabled = false;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            cbx_MaQuyen.Enabled = false;
            text_SDT.Enabled = false;
            btn_Save.Enabled = false;

            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);
        }
        
        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadData();
            databiding();
        }
        void loadCombobox()
        {
            string sql = "SELECT * FROM PHANQUYEN";
            dtPhanQuyen = xuly.LayDuLieu(sql);
            cbx_MaQuyen.DataSource = dtPhanQuyen;
            cbx_MaQuyen.DisplayMember = "MaQuyen";
            cbx_MaQuyen.ValueMember = "MaQuyen";

            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }
        void loadData()
        {
            string sql = "SELECT * FROM NHANVIEN";
            dtNhanVien = xuly.LayDuLieu(sql);
            keyMaNV[0] = dtNhanVien.Columns[0];
            dtNhanVien.PrimaryKey = keyMaNV;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtNhanVien;
            dataGridView1.Columns[0].DataPropertyName = "MaNV";
            dataGridView1.Columns[1].DataPropertyName = "TenNV";
            dataGridView1.Columns[2].DataPropertyName = "Email";
            dataGridView1.Columns[3].DataPropertyName = "SDT";
            dataGridView1.Columns[4].DataPropertyName = "GioiTinh";
            dataGridView1.Columns[5].DataPropertyName = "NgaySinh";
            dataGridView1.Columns[6].DataPropertyName = "MaQuyen";
            dataGridView1.ReadOnly = true;
        }
        void databiding()
        {
            text_MaNV.DataBindings.Add("Text", dtNhanVien, "MaNV");
            text_TenNV.DataBindings.Add("Text", dtNhanVien, "TenNV");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dtNhanVien, "NgaySinh");
            comboBox1.DataBindings.Add("Text", dtNhanVien, "GioiTinh");
            text_SDT.DataBindings.Add("Text", dtNhanVien, "SDT");
            cbx_MaQuyen.DataBindings.Add("SelectedValue", dtNhanVien, "MaQuyen");
            text_Email.DataBindings.Add("Text", dtNhanVien, "Email");
        }

        bool THEMMOI = true;
        private void btn_Add_Click(object sender, EventArgs e)
        {

            THEMMOI = true;
            text_MaNV.Enabled = true;
            text_Email.Enabled = true;
            text_TenNV.Enabled = true;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            text_SDT.Enabled = true;
            btn_Save.Enabled = true;

            cbx_MaQuyen.Enabled = true;
            text_MaNV.Clear();
            text_Email.Clear();
            text_TenNV.Clear();
            text_SDT.Clear();

            text_MaNV.Focus();

            text_MaNV.DataBindings.Clear();
            text_Email.DataBindings.Clear();
            text_TenNV.DataBindings.Clear();
            comboBox1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            cbx_MaQuyen.DataBindings.Clear();
            text_SDT.DataBindings.Clear();

        }
        private void btn_Fix_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            THEMMOI = false;
            text_Email.Enabled = true;
            text_Email.Enabled = true;
            text_TenNV.Enabled = true;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            cbx_MaQuyen.Enabled = true;
            text_SDT.Enabled = true;
            text_MaNV.Enabled = false;
            text_TenNV.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            if (MessageBox.Show("Bạn có chắc không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                THEMMOI = false;
                DataRow delrow = dtNhanVien.Rows.Find(text_MaNV.Text);
                if (delrow != null) //tim thay
                {
                    delrow.Delete();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (THEMMOI) //LA THEM MOI
            {
                try
                {
                    string manv = text_MaNV.Text; ;
                    string tennv = text_TenNV.Text;
                    string gmail = text_Email.Text;
                    string sdt = text_SDT.Text;
                    string gt = comboBox1.Text;
                    string ngaysinh = dateTimePicker1.Text;
                    string maquyen = cbx_MaQuyen.Text;
                    string lenhsql = "INSERT INTO NHANVIEN VALUES ('" + manv + "', N'" + tennv + "', '" + gmail + "', '" + sdt + "', N'" + gt + "', '" + ngaysinh + "', '" + maquyen + "')";
                    try
                    {
                        xuly.TRIGGER_KTTUOINV(dtNhanVien, lenhsql);
                        DataRow newrow = dtNhanVien.NewRow();
                        newrow["MaNV"] = text_MaNV.Text;
                        newrow["TenNV"] = text_TenNV.Text;
                        newrow["Email"] = text_Email.Text;
                        newrow["SDT"] = text_SDT.Text;
                        newrow["GioiTinh"] = comboBox1.Text;
                        newrow["NgaySinh"] = dateTimePicker1.Text;
                        newrow["MaQuyen"] = cbx_MaQuyen.Text;
                        btn_Save.Enabled = false;
                        dtNhanVien.Rows.Add(newrow);
                        databiding();
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Bạn không có quyền nhập hoặc Tuổi nhân viên phải trên 18!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                btn_Save.Enabled = false;
                dataGridView1.Refresh();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (xuly.CAPNHAT("SELECT * FROM NHANVIEN", dtNhanVien) > 0)
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Bạn phải nhấn lưu trước mới có thể cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        
        public string chuoiketnoi;
        private void btn_check_chucvu_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoiketnoi);
                    SqlCommand cmd = new SqlCommand("select dbo.F_Travechucvu('" + txt_check_chucvu.Text + "')", con);
                    cmd.Parameters.Add(new SqlParameter("@manv", SqlDbType.Char)).Value = 1;
                    con.Open();
                    MessageBox.Show("Chức vụ của " + txt_check_chucvu.Text + " là: " + cmd.ExecuteScalar().ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                txt_check_chucvu.Clear();
                txt_check_chucvu.Focus();
            }
        }
    }
}
