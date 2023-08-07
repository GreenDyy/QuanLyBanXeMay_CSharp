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
    public partial class Customer : Form
    {
        XULYCSDL xldl = new XULYCSDL();
        DataTable dtCustomer;
        DataColumn[] key = new DataColumn[1];
        public Customer()
        {
            InitializeComponent();
            text_MaKH.Enabled = false;
            text_TenKH.Enabled = false;
            text_DiaChi.Enabled = false;
            //text_GioiTinh.Enabled = false;
            text_SDT.Enabled = false;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            THEMMOI = false;
            DataRow delrow = dtCustomer.Rows.Find(text_MaKH.Text);
            if (delrow != null) //tim thay
            {
                delrow.Delete();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
           
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dtCustomer = xldl.LayDuLieu("SELECT * FROM KHACHHANG");
            key[0] = dtCustomer.Columns[0];
            dtCustomer.PrimaryKey = key;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtCustomer;
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nu");
            dataGridView1.Columns[0].DataPropertyName = "MaKH";
            dataGridView1.Columns[1].DataPropertyName = "TenKH";
            //DataGridViewComboBoxColumn colGioiTinh = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            dataGridView1.Columns[2].DataPropertyName = "GioiTinh";
            dataGridView1.Columns[3].DataPropertyName = "SDT";
            dataGridView1.Columns[4].DataPropertyName = "NamSinh";
            dataGridView1.Columns[5].DataPropertyName = "DiaChi";
            customerBindings();


        }
        void customerBindings()
        {
            text_MaKH.DataBindings.Add("Text", dtCustomer, "MaKH");
            text_TenKH.DataBindings.Add("Text", dtCustomer, "TenKH");
            text_SDT.DataBindings.Add("Text", dtCustomer, "SDT");
            text_DiaChi.DataBindings.Add("Text", dtCustomer, "DiaChi");
            comboBox1.DataBindings.Add("Text", dtCustomer, "GioiTinh");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dtCustomer, "NamSinh");

        }

        private void text_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        bool THEMMOI = true;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            THEMMOI = true;
            text_MaKH.DataBindings.Clear();
            text_TenKH.DataBindings.Clear();
            text_DiaChi.DataBindings.Clear();
            text_SDT.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            comboBox1.DataBindings.Clear();
            text_MaKH.Enabled = true;
            text_TenKH.Enabled = true;
            text_DiaChi.Enabled = true;
            text_SDT.Enabled = true;
            btnLuu.Enabled = true;
            text_MaKH.Clear();
            text_TenKH.Clear();
            text_DiaChi.Clear();
            text_SDT.Clear();
            text_MaKH.Focus();

            
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            THEMMOI = false;
            text_TenKH.Enabled = true;
            text_DiaChi.Enabled = true;
            text_SDT.Enabled = true;
            text_TenKH.Focus();
            text_DiaChi.Focus();
            text_SDT.Focus();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (xldl.CAPNHAT("SELECT * FROM KHACHHANG", dtCustomer) > 0)
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Bạn phải nhấn lưu trước mới có thể cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_MaKH.Text == "")
                {
                    errorProvider1.SetError(text_MaKH, "Mã khách hàng không được rỗng");
                }
                else if (text_TenKH.Text == "")
                {
                    errorProvider1.SetError(text_TenKH, "Tên khách không được rỗng");
                }
                else if (text_DiaChi.Text == "")
                {
                    errorProvider1.SetError(text_DiaChi, "Địa chỉ khách hàng không được rỗng");
                }
                else if (text_SDT.Text == "")
                {
                    errorProvider1.SetError(text_SDT, "Số điện thoại khách hàng không được rỗng");
                }
                else if (THEMMOI) //LA THEM MOI
                {
                    DataRow newrow = dtCustomer.NewRow();
                    newrow["MaKH"] = text_MaKH.Text;
                    newrow["TenKH"] = text_TenKH.Text;
                    newrow["DiaChi"] = text_DiaChi.Text;
                    newrow["SDT"] = text_SDT.Text;
                    newrow["GioiTinh"] = comboBox1.Text;
                    newrow["NamSinh"] = dateTimePicker1.Text;
                    dtCustomer.Rows.Add(newrow);
                    customerBindings();
                    text_MaKH.Enabled = false;
                    text_TenKH.Enabled = false;
                    text_DiaChi.Enabled = false;
                    text_SDT.Enabled = false;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDon main = new HoaDon();
            this.Hide();
            main.Show();
        }

        private void text_MaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            DataTable dtTAM= new DataTable();
            string sql = "EXEC P_KT_XEKHACHDAMUA '"+ txt_thongtinkt.Text +"'";
            dtTAM = xldl.LayDuLieu(sql);
            dataGridView2.DataSource = dtTAM;
            dataGridView2.Visible= true; 
        }
    }
}
