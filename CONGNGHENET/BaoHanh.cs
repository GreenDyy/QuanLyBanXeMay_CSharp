using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
//using Aspose.Cells;

namespace CONGNGHENET
{
    public partial class BaoHanh : Form
    {
        XULYCSDL xldl = new XULYCSDL();
        DataTable dtBaoHanh;
        DataColumn[] key = new DataColumn[1];
        public BaoHanh()
        {
            InitializeComponent();
            txt_maBH.Enabled = false;
            txt_maXe.Enabled = false;
            txt_maNV.Enabled = false;
            txt_maKH.Enabled = false;
            txt_noidung.Enabled = false;
            dataGridViewBH.ForeColor= Color.Black;
            dataGridViewBH.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);
        }
        void loadDataBaoHanh()
        {
            dtBaoHanh = xldl.LayDuLieu("SELECT * FROM BAOHANH");
            key[0] = dtBaoHanh.Columns[0];
            dtBaoHanh.PrimaryKey = key;
            dataGridViewBH.AutoGenerateColumns = false;
            dataGridViewBH.DataSource = dtBaoHanh;
            dataGridViewBH.Columns[0].DataPropertyName = "MaBaoHanh";
            dataGridViewBH.Columns[1].DataPropertyName = "MaXe";
            dataGridViewBH.Columns[2].DataPropertyName = "MaNV";
            dataGridViewBH.Columns[3].DataPropertyName = "MaKH";
            dataGridViewBH.Columns[4].DataPropertyName = "Ngay";
            dataGridViewBH.Columns[5].DataPropertyName = "NoiDung";
        }
        private void BaoHanh_Load(object sender, EventArgs e)
        {
            loadDataBaoHanh();
            BaoHanhBindings();
        }
        void setControlEditTable(bool edit)
        {
            txt_maBH.Enabled = txt_maXe.Enabled = txt_maKH.Enabled = txt_maNV.Enabled = dateTimePicker1.Enabled = txt_noidung.Enabled = edit;
            btn_luu.Enabled = edit;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = !edit;
            dataGridViewBH.ReadOnly = !edit;
            dataGridViewBH.AllowUserToAddRows = !edit;
        }
        void BaoHanhBindings()
        {
            txt_maBH.DataBindings.Add("Text", dtBaoHanh, "MaBaoHanh");
            txt_maXe.DataBindings.Add("Text", dtBaoHanh, "MaXe");
            txt_maNV.DataBindings.Add("Text", dtBaoHanh, "MaNV");
            txt_maKH.DataBindings.Add("Text", dtBaoHanh, "MaKH");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dtBaoHanh, "Ngay");
            txt_noidung.DataBindings.Add("Text", dtBaoHanh, "NoiDung");
        }
        //KT xem them hay la xoa bot
        bool THEMMOI = true;
        private void btn_them_Click(object sender, EventArgs e)
        {
            THEMMOI = true;
            txt_maBH.DataBindings.Clear();
            txt_maXe.DataBindings.Clear();
            txt_maNV.DataBindings.Clear();
            txt_maKH.DataBindings.Clear();
            txt_noidung.DataBindings.Clear();

            txt_maBH.Clear();
            txt_maKH.Clear();
            txt_maNV.Clear();
            txt_maXe.Clear();
            txt_noidung.Clear();

            txt_maBH.Focus();
            setControlEditTable(true);  
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            THEMMOI = false;
            setControlEditTable(true);
            txt_maBH.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            THEMMOI = false;
            setControlEditTable(true);
            if (MessageBox.Show("Bạn có chắc không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DataRow delrow = dtBaoHanh.Rows.Find(txt_maBH.Text);
                if (delrow != null) //tim thay
                {
                    delrow.Delete();
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (xldl.CAPNHAT("SELECT * FROM BAOHANH", dtBaoHanh) > 0)
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Bạn phải nhấn lưu trước mới có thể cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                setControlEditTable(false);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maBH.Text == "")
                {
                    errorProvider1.SetError(txt_maBH, "Mã bảo hành không được rỗng");
                }
                else if (txt_maKH.Text == "")
                {
                    errorProvider1.SetError(txt_maKH, "Mã Khách hàng không được rỗng");
                }
                else if (txt_maNV.Text == "")
                {
                    errorProvider1.SetError(txt_maNV, "Mã nhân viên không được rỗng");
                }
                else if (txt_maXe.Text == "")
                {
                    errorProvider1.SetError(txt_maXe, "Mã xe không được rỗng");
                }
                else if (txt_noidung.Text == "")
                {
                    errorProvider1.SetError(txt_noidung, "Nội dung không được rỗng");
                }
                else if (THEMMOI) //LA THEM MOI
                {
                    DataRow newrow = dtBaoHanh.NewRow();
                    newrow["MaBaoHanh"] = txt_maBH.Text;
                    newrow["MaXe"] = txt_maXe.Text;
                    newrow["MaNV"] = txt_maNV.Text;
                    newrow["MaKH"] = txt_maKH.Text;
                    newrow["Ngay"] = dateTimePicker1.Text;
                    newrow["NoiDung"] = txt_noidung.Text;

                    dtBaoHanh.Rows.Add(newrow);
                    BaoHanhBindings();
                }
                else
                {
                    dataGridViewBH.Refresh();
                }
                setControlEditTable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        //Nhập xuất bằng Excel------------------------------------------------------------------------------------
        private void btn_xuat_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Title = "Xuất File Excel";
            savefiledialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string lenhsql = "INSERT INTO OPENROWSET('Microsoft.ACE.OLEDB.12.0','Excel 12.0;Database="+savefiledialog.FileName+";','SELECT * FROM [Sheet1$]') SELECT * FROM BAOHANH";
                    xldl.XuLyTaiKhoan(lenhsql);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn phải tạo file exel với các tên thuộc tính trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        //Nhập file excel
        private void btn_nhap_excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "Nhập File Excel";
            openfiledialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string lenhsql = 
                                    "INSERT INTO BAOHANH " +
                                    "SELECT * FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0', 'Excel 12.0 Xml;" +
                                    "Database="+ openfiledialog.FileName +";', Sheet1$);";
                    xldl.XuLyTaiKhoan(lenhsql);
                    //load lại datagridview

                    loadDataBaoHanh();
                    //Load lại 
                    MessageBox.Show("Nhập file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        //Nhập xuất bằng txt ------------------------------------------------------------------------------------
        private void btn_xuat_txt_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Title = "Xuất File txt";
            savefiledialog.Filter = "Text (*.txt)|*.txt";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextWriter writer = new StreamWriter(savefiledialog.FileName);
                    for (int i = 0; i < dataGridViewBH.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewBH.Columns.Count; j++)
                        {
                            if (j == dataGridViewBH.Columns.Count - 1)
                                writer.Write(dataGridViewBH.Rows[i].Cells[j].Value.ToString());
                            else
                                writer.Write(dataGridViewBH.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        writer.WriteLine();
                    }
                    writer.Close();
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        private void btn_nhap_txt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "Nhập File txt";
            openfiledialog.Filter = "Text (*.txt)|*.txt";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                string lenhsql = "BULK INSERT BAOHANH "
                                + "FROM '" + openfiledialog.FileName + "' WITH( FIELDTERMINATOR = '\\t|', "
                                + "ROWTERMINATOR = '\\n', FIRSTROW = 1 )";
                try
                {
                    //nhập vào CSDL 
                    xldl.XuLyTaiKhoan(lenhsql);
                    //load lại datagridview
                    loadDataBaoHanh();
                    MessageBox.Show("Nhập file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {

        }
    }
}
