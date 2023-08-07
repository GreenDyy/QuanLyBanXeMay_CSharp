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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            text_MaHD.Enabled = false;
            text_Tien.Enabled = false;
            cbx_MaKH.Enabled = false;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);
        }
        XULYCSDL xuly = new XULYCSDL();
        DataColumn[] keyMaHD = new DataColumn[1];
        DataTable dtHOADON;
        DataTable dtKHACHHANG;
        private void HoaDon_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadData();
            databiding();
        }
        void loadData()
        {
            string sql = "SELECT * FROM HOADON";
            dtHOADON = xuly.LayDuLieu(sql);
            keyMaHD[0] = dtHOADON.Columns[0];
            dtHOADON.PrimaryKey = keyMaHD;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtHOADON;
            dataGridView1.Columns[0].DataPropertyName = "MAHD";
            dataGridView1.Columns[1].DataPropertyName = "Ngay";
            DataGridViewComboBoxColumn colMaKH = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            colMaKH.DataSource = dtKHACHHANG;
            colMaKH.DisplayMember = "MaKH";
            colMaKH.ValueMember = "MaKH";
            colMaKH.DataPropertyName = "MaKH";
            dataGridView1.Columns[3].DataPropertyName = "TongTien";

        }
        void loadCombobox()
        {
            string sql = "SELECT * FROM KHACHHANG";
            dtKHACHHANG = xuly.LayDuLieu(sql);
            cbx_MaKH.DataSource = dtKHACHHANG;
            cbx_MaKH.DisplayMember = "MaKH";
            cbx_MaKH.ValueMember = "MaKH";
        }

        void databiding()
        {
            text_MaHD.DataBindings.Add("Text", dtHOADON, "MaHD");
            dateTimePicker1.DataBindings.Add("Text", dtHOADON, "Ngay");
            text_Tien.DataBindings.Add("Text", dtHOADON, "TongTien");
            cbx_MaKH.DataBindings.Add("SelectedValue", dtHOADON, "MaKH");
        }
        

        private void text_MKH_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (xuly.CAPNHAT("SELECT * FROM HOADON", dtHOADON) > 0)
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Bạn phải nhấn lưu trước mới có thể cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_MaHD.Text == "")
                {
                    errorProvider1.SetError(text_MaHD, "Mã Hoá Đơn Không Được Rỗng");
                }
                else if (text_Tien.Text == "")
                {
                    errorProvider1.SetError(text_MaHD, "Tiền Không Được Rỗng");
                }
                else if (THEMMOI)
                {
                    DataRow newrow = dtHOADON.NewRow();
                    newrow["MaHD"] = text_MaHD.Text;
                    newrow["Ngay"] = dateTimePicker1.Text;
                    newrow["MaKH"] = cbx_MaKH.SelectedValue.ToString();
                    newrow["TongTien"] = text_Tien.Text;
                    dtHOADON.Rows.Add(newrow);
                    databiding();
                    btn_Save.Enabled = false;
                }
                else
                {
                    btn_Save.Enabled = false;
                    dataGridView1.Refresh();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool THEMMOI = true;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            THEMMOI = true;
            text_MaHD.Enabled = true;
            cbx_MaKH.Enabled = true;
            text_Tien.Enabled = true;

            text_MaHD.Clear();
            text_Tien.Clear();

            text_MaHD.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            text_Tien.DataBindings.Clear();
            cbx_MaKH.DataBindings.Clear();
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            THEMMOI = false;
            text_MaHD.Enabled = false;
            text_Tien.Enabled = true;
            cbx_MaKH.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            THEMMOI = false;
            DataRow delrow = dtHOADON.Rows.Find(text_MaHD.Text);
            if (delrow != null) //tim thay
            {
                delrow.Delete();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private void btn_cthd_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon fr = new ChiTietHoaDon();
            this.Hide();
            fr.Show();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string sql = "EXEC P_TIMHOADON '"+ txt_tim.Text +"'";
            dtHOADON = xuly.LayDuLieu(sql);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtHOADON;
            dataGridView1.Columns[0].DataPropertyName = "MAHD";
            dataGridView1.Columns[1].DataPropertyName = "Ngay";
            DataGridViewComboBoxColumn colMaKH = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            colMaKH.DataSource = dtKHACHHANG;
            colMaKH.DisplayMember = "MaKH";
            colMaKH.ValueMember = "MaKH";
            colMaKH.DataPropertyName = "MaKH";
            dataGridView1.Columns[3].DataPropertyName = "TongTien";
            dataGridView1.ReadOnly = true;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
    public class KHACHHANG
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }

    }
}
