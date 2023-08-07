using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONGNGHENET
{
    public partial class BanXe : Form
    {
        public BanXe()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);
        }
        XULYCSDL xuly = new XULYCSDL();
        DataColumn[] keyXe = new DataColumn[1];
        DataTable dtXe;
        void loadData()
        {
            string sql = "SELECT * FROM XE";
            dtXe = xuly.LayDuLieu(sql);
            keyXe[0] = dtXe.Columns[0];
            dtXe.PrimaryKey = keyXe;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtXe;
            dataGridView1.Columns[0].DataPropertyName = "MaXe";
            dataGridView1.Columns[1].DataPropertyName = "TenXe";
            dataGridView1.Columns[3].DataPropertyName = "GiaXe";
            dataGridView1.Columns[2].DataPropertyName = "LoaiXe";
            dataGridView1.Columns[4].DataPropertyName = "HINH";

        }
        void databiding()
        {
            txt_maxe.DataBindings.Add("Text", dtXe, "MaXe");
            txt_tenxe.DataBindings.Add("Text", dtXe, "TenXe");
            txt_giaxe.DataBindings.Add("Text", dtXe, "GiaXe");
            txt_loaixe.DataBindings.Add("Text", dtXe, "LoaiXe");
        }
        private void BanXe_Load(object sender, EventArgs e)
        {
            loadData();
            databiding();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string lenhsql = "EXEC P_NGHIEPVUBANXE '" + txt_maxe.Text + "', " + numericUpDown1.Text;
                xuly.XuLyTaiKhoan(lenhsql);
                Customer main = new Customer();
                this.Hide();
                main.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).
                Parent.FullName + "\\AnhXe\\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }

        private void btn_capnhattien_Click(object sender, EventArgs e)
        {
            double giaxe = double.Parse(txt_giaxe.Text);
            double soluong = double.Parse(numericUpDown1.Text);
            double tongtien = giaxe * soluong;
            txt_tongtien.Text = tongtien.ToString() + " VND";
        }
    }
}
