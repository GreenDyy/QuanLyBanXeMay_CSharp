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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        XULYCSDL xuly = new XULYCSDL();

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void toolStripXe_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM XE";
                xuly.LayDuLieu(sql);
                Xe frm = new Xe();
                frm.MdiParent = this;
                frm.chuoiketnoi = chuoiketnoi_MDI;
                frm.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " đang đăng nhập";
        }
        //lấy user để kt quyền
        public string text_userMDI
        {
            set { label1.Text = value; }
        }
        public string chuoiketnoi_MDI;
        //{
        //    set { con.Text = value; }
        //}

        private void toolStripNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                //test lỗi
                string sql = "SELECT * FROM NHANVIEN";
                xuly.LayDuLieu(sql);
                string sql1 = "SELECT * FROM PHANQUYEN";
                xuly.LayDuLieu(sql1);
                //mở form
                NhanVien frm = new NhanVien();
                frm.MdiParent = this;
                frm.chuoiketnoi = chuoiketnoi_MDI;
                frm.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void toolStripKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM KHACHHANG";
                xuly.LayDuLieu(sql);
                Customer frm = new Customer();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }

        private void toolStripBaoHanh_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "SELECT * FROM BAOHANH";
                xuly.LayDuLieu(sql);
                BaoHanh frm = new BaoHanh();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripNhaCungCap_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "SELECT * FROM NHACUNGCAP";
                xuly.LayDuLieu(sql);
                NhaCungCap frm = new NhaCungCap();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripHoaDon_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "SELECT * FROM HOADON";
                xuly.LayDuLieu(sql);
                HoaDon frm = new HoaDon();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripCTHoaDon_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "SELECT * FROM CHITIETHD";
                xuly.LayDuLieu(sql);
                ChiTietHoaDon frm = new ChiTietHoaDon();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap sigin = new DangNhap();
            sigin.Show();
        }
        //trang chủ
        private void TrangChuToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void trogiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/14maRrX2-YsRS_lhG3erlZ4vPySmiCVYL/view?usp=share_link");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //test kt quyền
                string sql = "SELECT * FROM XE";
                xuly.LayDuLieu(sql);

                BanXe frm = new BanXe();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            try
            {
                //test kt quyền
                string sql = "SELECT * FROM NHANVIEN";
                xuly.LayDuLieu(sql);
                string sql1 = "SELECT * FROM BAOHANH";
                xuly.LayDuLieu(sql1);
                // vì trong bảng thống kê có thủ tục dùng cả NHANVIEN và BẢO hành nên phải cho chạy thử để bắt lỗi

                ThongKe f = new ThongKe();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void taikhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text.StartsWith("admin") || label1.Text.StartsWith("sa"))
            {
                QuanLyTaiKhoan f = new QuanLyTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
            else
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saoLưuPhụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text.StartsWith("admin") || label1.Text.StartsWith("sa"))
            {
                SaoLuuPhucHoi f = new SaoLuuPhucHoi();
                f.MdiParent = this;
                f.chuoiketnoi = chuoiketnoi_MDI;
                f.Show();
            }
            else
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void giaoTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //test kt quyền
                string sql = "SELECT * FROM XE";
                xuly.LayDuLieu(sql);
                GiaoTac f = new GiaoTac();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        
    }
}
