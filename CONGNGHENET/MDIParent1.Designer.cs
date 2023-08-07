
namespace CONGNGHENET
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TrangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taikhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuPhụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trogiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripXe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripNhanVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripKhachHang = new System.Windows.Forms.ToolStripButton();
            this.toolStripBaoHanh = new System.Windows.Forms.ToolStripButton();
            this.toolStripNhaCungCap = new System.Windows.Forms.ToolStripButton();
            this.toolStripHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripCTHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolStripThoat = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 689);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1167, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrangChuToolStripMenuItem,
            this.xeToolStripMenuItem1,
            this.trogiupToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1167, 54);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TrangChuToolStripMenuItem
            // 
            this.TrangChuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TrangChuToolStripMenuItem.Image = global::CONGNGHENET.Properties.Resources.house;
            this.TrangChuToolStripMenuItem.Name = "TrangChuToolStripMenuItem";
            this.TrangChuToolStripMenuItem.Size = new System.Drawing.Size(99, 50);
            this.TrangChuToolStripMenuItem.Text = "&Trang Chủ";
            this.TrangChuToolStripMenuItem.Click += new System.EventHandler(this.TrangChuToolStripMenuItem_Click);
            // 
            // xeToolStripMenuItem1
            // 
            this.xeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taikhoanToolStripMenuItem,
            this.saoLưuPhụcHồiToolStripMenuItem,
            this.giaoTácToolStripMenuItem});
            this.xeToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xeToolStripMenuItem1.Image = global::CONGNGHENET.Properties.Resources.manager;
            this.xeToolStripMenuItem1.Name = "xeToolStripMenuItem1";
            this.xeToolStripMenuItem1.Size = new System.Drawing.Size(86, 50);
            this.xeToolStripMenuItem1.Text = "&Quản Lý";
            // 
            // taikhoanToolStripMenuItem
            // 
            this.taikhoanToolStripMenuItem.Image = global::CONGNGHENET.Properties.Resources.teamwork;
            this.taikhoanToolStripMenuItem.Name = "taikhoanToolStripMenuItem";
            this.taikhoanToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.taikhoanToolStripMenuItem.Text = "&Tài Khoản";
            this.taikhoanToolStripMenuItem.Click += new System.EventHandler(this.taikhoanToolStripMenuItem_Click);
            // 
            // saoLưuPhụcHồiToolStripMenuItem
            // 
            this.saoLưuPhụcHồiToolStripMenuItem.Image = global::CONGNGHENET.Properties.Resources.data_recovery;
            this.saoLưuPhụcHồiToolStripMenuItem.Name = "saoLưuPhụcHồiToolStripMenuItem";
            this.saoLưuPhụcHồiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saoLưuPhụcHồiToolStripMenuItem.Text = "Sao lưu và Phục hồi";
            this.saoLưuPhụcHồiToolStripMenuItem.Click += new System.EventHandler(this.saoLưuPhụcHồiToolStripMenuItem_Click);
            // 
            // giaoTácToolStripMenuItem
            // 
            this.giaoTácToolStripMenuItem.Image = global::CONGNGHENET.Properties.Resources.transaction;
            this.giaoTácToolStripMenuItem.Name = "giaoTácToolStripMenuItem";
            this.giaoTácToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.giaoTácToolStripMenuItem.Text = "Giao Tác";
            this.giaoTácToolStripMenuItem.Click += new System.EventHandler(this.giaoTácToolStripMenuItem_Click);
            // 
            // trogiupToolStripMenuItem
            // 
            this.trogiupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.trogiupToolStripMenuItem.Image = global::CONGNGHENET.Properties.Resources.help_desk;
            this.trogiupToolStripMenuItem.Name = "trogiupToolStripMenuItem";
            this.trogiupToolStripMenuItem.Size = new System.Drawing.Size(90, 50);
            this.trogiupToolStripMenuItem.Text = "&Trợ Giúp";
            this.trogiupToolStripMenuItem.Click += new System.EventHandler(this.trogiupToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.Image = global::CONGNGHENET.Properties.Resources.log_out;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(101, 50);
            this.đăngXuấtToolStripMenuItem.Text = "&Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripXe,
            this.toolStripButton1,
            this.toolStripNhanVien,
            this.toolStripKhachHang,
            this.toolStripBaoHanh,
            this.toolStripNhaCungCap,
            this.toolStripHoaDon,
            this.toolStripButton2,
            this.toolStripCTHoaDon,
            this.toolStripThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 54);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(142, 635);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripXe
            // 
            this.toolStripXe.AutoSize = false;
            this.toolStripXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripXe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripXe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripXe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripXe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripXe.Name = "toolStripXe";
            this.toolStripXe.Size = new System.Drawing.Size(150, 55);
            this.toolStripXe.Text = "Xe";
            this.toolStripXe.Click += new System.EventHandler(this.toolStripXe_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(150, 55);
            this.toolStripButton1.Text = "Bán Xe";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripNhanVien
            // 
            this.toolStripNhanVien.AutoSize = false;
            this.toolStripNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripNhanVien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNhanVien.Name = "toolStripNhanVien";
            this.toolStripNhanVien.Size = new System.Drawing.Size(150, 55);
            this.toolStripNhanVien.Text = "Nhân Viên";
            this.toolStripNhanVien.Click += new System.EventHandler(this.toolStripNhanVien_Click);
            // 
            // toolStripKhachHang
            // 
            this.toolStripKhachHang.AutoSize = false;
            this.toolStripKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripKhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripKhachHang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripKhachHang.Name = "toolStripKhachHang";
            this.toolStripKhachHang.Size = new System.Drawing.Size(150, 55);
            this.toolStripKhachHang.Text = "Khách Hàng";
            this.toolStripKhachHang.Click += new System.EventHandler(this.toolStripKhachHang_Click);
            // 
            // toolStripBaoHanh
            // 
            this.toolStripBaoHanh.AutoSize = false;
            this.toolStripBaoHanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripBaoHanh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBaoHanh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBaoHanh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBaoHanh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBaoHanh.Name = "toolStripBaoHanh";
            this.toolStripBaoHanh.Size = new System.Drawing.Size(150, 55);
            this.toolStripBaoHanh.Text = "Bảo Hành";
            this.toolStripBaoHanh.Click += new System.EventHandler(this.toolStripBaoHanh_Click);
            // 
            // toolStripNhaCungCap
            // 
            this.toolStripNhaCungCap.AutoSize = false;
            this.toolStripNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripNhaCungCap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripNhaCungCap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripNhaCungCap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNhaCungCap.Name = "toolStripNhaCungCap";
            this.toolStripNhaCungCap.Size = new System.Drawing.Size(150, 55);
            this.toolStripNhaCungCap.Text = "Nhà Cung Cấp";
            this.toolStripNhaCungCap.Click += new System.EventHandler(this.toolStripNhaCungCap_Click);
            // 
            // toolStripHoaDon
            // 
            this.toolStripHoaDon.AutoSize = false;
            this.toolStripHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripHoaDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHoaDon.Name = "toolStripHoaDon";
            this.toolStripHoaDon.Size = new System.Drawing.Size(150, 55);
            this.toolStripHoaDon.Text = "Hoá Đơn";
            this.toolStripHoaDon.Click += new System.EventHandler(this.toolStripHoaDon_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(150, 55);
            this.toolStripButton2.Text = "Thống Kê";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripCTHoaDon
            // 
            this.toolStripCTHoaDon.AutoSize = false;
            this.toolStripCTHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripCTHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCTHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCTHoaDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripCTHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCTHoaDon.Name = "toolStripCTHoaDon";
            this.toolStripCTHoaDon.Size = new System.Drawing.Size(150, 55);
            this.toolStripCTHoaDon.Text = "Chi Tiết HĐ";
            this.toolStripCTHoaDon.Click += new System.EventHandler(this.toolStripCTHoaDon_Click);
            // 
            // toolStripThoat
            // 
            this.toolStripThoat.AutoSize = false;
            this.toolStripThoat.BackColor = System.Drawing.Color.Firebrick;
            this.toolStripThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripThoat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripThoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripThoat.Name = "toolStripThoat";
            this.toolStripThoat.Size = new System.Drawing.Size(150, 55);
            this.toolStripThoat.Text = "Thoát";
            this.toolStripThoat.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CONGNGHENET.Properties.Resources.user1;
            this.pictureBox2.Location = new System.Drawing.Point(389, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CONGNGHENET.Properties.Resources.xe_walpaper2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1167, 711);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoFast";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripXe;
        private System.Windows.Forms.ToolStripButton toolStripNhanVien;
        private System.Windows.Forms.ToolStripButton toolStripKhachHang;
        private System.Windows.Forms.ToolStripButton toolStripNhaCungCap;
        private System.Windows.Forms.ToolStripButton toolStripHoaDon;
        private System.Windows.Forms.ToolStripButton toolStripThoat;
        private System.Windows.Forms.ToolStripMenuItem trogiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xeToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem taikhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripCTHoaDon;
        private System.Windows.Forms.ToolStripButton toolStripBaoHanh;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem saoLưuPhụcHồiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem giaoTácToolStripMenuItem;
    }
}



