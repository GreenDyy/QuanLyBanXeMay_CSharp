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
    public partial class ThongKe : Form
    {
        DataTable dtHD;
        XULYCSDL xuly = new XULYCSDL();
        public ThongKe()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);

            txt_nam.Enabled = false;
            txt_thang.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            try
            {
                if (rd_nam.Checked)
                {
                    dtHD = xuly.LayDuLieu("EXEC P_THONGKEDOANHTHUTHEONAM '" + txt_nam.Text + "'");
                    dataGridView1.DataSource = dtHD;
                    lb_thongbao.Text = "Doanh thu năm " + txt_nam.Text;
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns[0].DataPropertyName = dtHD.Columns[0].ColumnName;
                }
                else
                {
                    dtHD = xuly.LayDuLieu("EXEC P_THONGKEDOANHTHUTHEOTHANG " + txt_thang.Text + "," + txt_nam.Text);
                    dataGridView1.DataSource = dtHD;
                    lb_thongbao.Text = "Doanh thu tháng " + txt_thang.Text + " năm " + txt_nam.Text;
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns[0].DataPropertyName = dtHD.Columns[0].ColumnName;

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void rd_nam_CheckedChanged(object sender, EventArgs e)
        {
            txt_nam.Enabled = true;
            txt_thang.Enabled = false;
            txt_nam.Clear();
            txt_thang.Clear();
        }

        private void rd_thang_CheckedChanged(object sender, EventArgs e)
        {
            txt_nam.Enabled = true;
            txt_thang.Enabled = true;
            txt_nam.Clear();
            txt_thang.Clear();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            ThongKeNhanVienTreChamChi();
        }
        public void ThongKeNhanVienTreChamChi()
        {
            DataTable dtNhanVienChamChi;
            string lenhsql = "select NHANVIEN.MaNV, TenNV, NgaySinh, count(MaKH) as 'Khach' " +
                             "from NHANVIEN LEFT JOIN BAOHANH ON NHANVIEN.MaNV = BAOHANH.MaNV " +
                             "where DATEDIFF(year, NgaySinh, GETDATE()) in (select DATEDIFF(year, NgaySinh, GETDATE()) from nhanvien where DATEDIFF(year, NgaySinh, GETDATE()) < 25) " +
                             "group by NHANVIEN.MaNV, TenNV, NgaySinh " +
                             "having count(MaKH) > 0 " +
                             "order by count(MaKH) desc";
            dtNhanVienChamChi = xuly.LayDuLieu(lenhsql);
            dataGridView2.DataSource = dtNhanVienChamChi;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.Columns[0].DataPropertyName = "MaNV";
            dataGridView2.Columns[1].DataPropertyName = "TenNV";
            dataGridView2.Columns[2].DataPropertyName = "NgaySinh";
            dataGridView2.Columns[3].DataPropertyName = "Khach";
        }
    }
}
