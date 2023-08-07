using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace CONGNGHENET
{
    public partial class Xe : Form
    {
        public Xe()
        {
            InitializeComponent();
            txt_MaXe.Enabled = false;
            txt_TenXe.Enabled = false;
            cb_loaixe.Enabled = false;
            comboBox1.Enabled = false;
            txt_giaxe.Enabled = false;
            txt_soluong.Enabled= false; 
            btn_Save.Enabled = false;
            btn_themanh.Enabled= false;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 12, FontStyle.Regular);
        }
        XULYCSDL xuly = new XULYCSDL();
        DataColumn[] keyXe = new DataColumn[1];
        DataTable dtXe;
        DataTable dtNCC;

        private void Xe_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadData();
            databiding();
            pictureBox1.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\AnhXe\\Vespa.png");
        }

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
            dataGridView1.Columns[2].DataPropertyName = "LoaiXe";
            dataGridView1.Columns[3].DataPropertyName = "MaNCC";
            dataGridView1.Columns[4].DataPropertyName = "GiaXe";
            dataGridView1.Columns[5].DataPropertyName = "SoLuong";
            dataGridView1.Columns[6].DataPropertyName = "HINH";
            dataGridView1.ReadOnly = true;
        }
        void loadCombobox()
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            dtNCC = xuly.LayDuLieu(sql);
            comboBox1.DataSource = dtNCC;
            comboBox1.DisplayMember = "MaNCC";
            comboBox1.ValueMember = "MaNCC";

            cb_loaixe.Items.Add("Xe tay ga");
            cb_loaixe.Items.Add("Xe số");
        }
        void databiding()
        {
            txt_MaXe.DataBindings.Add("Text", dtXe, "MaXe");
            txt_TenXe.DataBindings.Add("Text", dtXe, "TenXe");
            cb_loaixe.DataBindings.Add("Text", dtXe, "LoaiXe");
            txt_giaxe.DataBindings.Add("Text", dtXe, "GiaXe");
            comboBox1.DataBindings.Add("SelectedValue", dtXe, "MaNCC");
            txt_soluong.DataBindings.Add("Text", dtXe, "SoLuong");
            txt_hinh.DataBindings.Add("Text", dtXe, "HINH");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        bool THEMMOI = true;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            THEMMOI = true;
            txt_MaXe.Enabled = true;
            txt_TenXe.Enabled = true;
            cb_loaixe.Enabled = true;
            comboBox1.Enabled = true;
            btn_Save.Enabled = true;
            txt_giaxe.Enabled = true;
            txt_soluong.Enabled = true;
            btn_themanh.Enabled = true;

            txt_MaXe.Clear();
            txt_TenXe.Clear();
            txt_soluong.Clear();
            txt_giaxe.Clear();  

            txt_MaXe.Focus();

            txt_MaXe.DataBindings.Clear();
            txt_TenXe.DataBindings.Clear();
            cb_loaixe.DataBindings.Clear();
            comboBox1.DataBindings.Clear();
            txt_giaxe.DataBindings.Clear();
            txt_soluong.DataBindings.Clear();
            txt_hinh.DataBindings.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaXe.Text == "")
                {
                    errorProvider1.SetError(txt_MaXe, "Mã Xe Không Được Rỗng");
                }
                else if (txt_TenXe.Text == "")
                {
                    errorProvider1.SetError(txt_TenXe, "Tên Xe Không Được Bỏ Rỗng");
                }
                else if (cb_loaixe.Text == "")
                {
                    errorProvider1.SetError(cb_loaixe, "Loại Xe Không Được Bỏ Rỗng");
                }
                else if (THEMMOI) //LA THEM MOI
                {
                    DataRow newrow = dtXe.NewRow();
                    newrow["MaXe"] = txt_MaXe.Text;
                    newrow["TenXe"] = txt_TenXe.Text;
                    newrow["LoaiXe"] = cb_loaixe.Text;
                    newrow["MaNCC"] = comboBox1.Text;
                    newrow["GiaXe"] = txt_giaxe.Text;
                    newrow["SoLuong"] = txt_soluong.Text;
                    newrow["HINH"] = txt_hinh.Text;
                    btn_Save.Enabled = false;
                    dtXe.Rows.Add(newrow);
                    databiding();
                }
                else
                {
                    btn_Save.Enabled = false;
                    dataGridView1.Refresh();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            THEMMOI = false;
            txt_TenXe.Enabled = true;
            cb_loaixe.Enabled = true;
            comboBox1.Enabled = true;
            txt_MaXe.Enabled = false;
            txt_giaxe.Enabled = true;
            txt_soluong.Enabled = true;
            btn_themanh.Enabled = true;
            txt_TenXe.Focus();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (xuly.CAPNHAT("SELECT * FROM XE", dtXe) > 0)
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Bạn phải nhấn lưu trước mới có thể cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            if (MessageBox.Show("Bạn có chắc không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                THEMMOI = false;
                DataRow delrow = dtXe.Rows.Find(txt_MaXe.Text);
                if (delrow != null) //tim thay
                {
                    delrow.Delete();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).
                Parent.FullName + "\\AnhXe\\" + dataGridView1.Rows[e.RowIndex].Cells[6].Value);
        }

        private void btn_themanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_hinh.Text = Path.GetFileName(dialog.FileName);
                MessageBox.Show(txt_hinh.Text);
            }
        }
        public string chuoiketnoi;
        private void btn_demsoxe_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoiketnoi);
                SqlCommand cmd = new SqlCommand("P_DEMSOLOAIXE", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text);

                SqlParameter output_slx = new SqlParameter();
                output_slx.ParameterName = "@soloaixe";
                output_slx.SqlDbType = System.Data.SqlDbType.Int;
                output_slx.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(output_slx);

                con.Open();
                cmd.ExecuteNonQuery();
                txt_soloaixe.Text = output_slx.Value.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_mancc.Clear();
        }
    }
}
