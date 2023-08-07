namespace CONGNGHENET
{
    partial class ChiTietHoaDon
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
            this.gb_BH = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.dongia = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.Label();
            this.maxe = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_maxe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_nhapBH = new System.Windows.Forms.GroupBox();
            this.cb_mahd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_update_tien = new System.Windows.Forms.Button();
            this.btn_inhoadon = new System.Windows.Forms.Button();
            this.gb_BH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            this.gb_nhapBH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_BH
            // 
            this.gb_BH.Controls.Add(this.dataGridViewCTHD);
            this.gb_BH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_BH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.gb_BH.Location = new System.Drawing.Point(21, 304);
            this.gb_BH.Name = "gb_BH";
            this.gb_BH.Size = new System.Drawing.Size(977, 238);
            this.gb_BH.TabIndex = 19;
            this.gb_BH.TabStop = false;
            this.gb_BH.Text = "Thông tin chi tiết hoá đơn";
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewCTHD.Location = new System.Drawing.Point(23, 25);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.RowHeadersWidth = 51;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(934, 193);
            this.dataGridViewCTHD.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã HD";
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Xe";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.Name = "Column5";
            this.Column5.Width = 182;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(406, 51);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(165, 26);
            this.txt_soluong.TabIndex = 4;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(616, 129);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(129, 26);
            this.txt_thanhtien.TabIndex = 5;
            this.txt_thanhtien.Visible = false;
            // 
            // dongia
            // 
            this.dongia.AutoSize = true;
            this.dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongia.Location = new System.Drawing.Point(30, 135);
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(63, 18);
            this.dongia.TabIndex = 5;
            this.dongia.Text = "Đơn giá:";
            // 
            // soluong
            // 
            this.soluong.AutoSize = true;
            this.soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.Location = new System.Drawing.Point(325, 51);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(71, 18);
            this.soluong.TabIndex = 3;
            this.soluong.Text = "Số lượng:";
            // 
            // maxe
            // 
            this.maxe.AutoSize = true;
            this.maxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxe.Location = new System.Drawing.Point(30, 93);
            this.maxe.Name = "maxe";
            this.maxe.Size = new System.Drawing.Size(52, 18);
            this.maxe.TabIndex = 1;
            this.maxe.Text = "Mã xe:";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(132, 129);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(165, 26);
            this.txt_dongia.TabIndex = 3;
            // 
            // txt_maxe
            // 
            this.txt_maxe.Location = new System.Drawing.Point(132, 90);
            this.txt_maxe.Name = "txt_maxe";
            this.txt_maxe.Size = new System.Drawing.Size(165, 26);
            this.txt_maxe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hoá đơn:";
            // 
            // gb_nhapBH
            // 
            this.gb_nhapBH.Controls.Add(this.btn_update_tien);
            this.gb_nhapBH.Controls.Add(this.btn_inhoadon);
            this.gb_nhapBH.Controls.Add(this.cb_mahd);
            this.gb_nhapBH.Controls.Add(this.txt_dongia);
            this.gb_nhapBH.Controls.Add(this.txt_maxe);
            this.gb_nhapBH.Controls.Add(this.txt_soluong);
            this.gb_nhapBH.Controls.Add(this.txt_thanhtien);
            this.gb_nhapBH.Controls.Add(this.dongia);
            this.gb_nhapBH.Controls.Add(this.soluong);
            this.gb_nhapBH.Controls.Add(this.maxe);
            this.gb_nhapBH.Controls.Add(this.label2);
            this.gb_nhapBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_nhapBH.ForeColor = System.Drawing.Color.Black;
            this.gb_nhapBH.Location = new System.Drawing.Point(21, 63);
            this.gb_nhapBH.Name = "gb_nhapBH";
            this.gb_nhapBH.Size = new System.Drawing.Size(781, 175);
            this.gb_nhapBH.TabIndex = 13;
            this.gb_nhapBH.TabStop = false;
            this.gb_nhapBH.Text = "Nhập thông tin chi tiết hoá đơn ";
            // 
            // cb_mahd
            // 
            this.cb_mahd.FormattingEnabled = true;
            this.cb_mahd.Location = new System.Drawing.Point(132, 51);
            this.cb_mahd.Name = "cb_mahd";
            this.cb_mahd.Size = new System.Drawing.Size(165, 28);
            this.cb_mahd.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "CẬP NHẬT THÔNG TIN CHI TIẾT HOÁ ĐƠN";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.Enabled = false;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_luu.Image = global::CONGNGHENET.Properties.Resources.Save;
            this.btn_luu.Location = new System.Drawing.Point(595, 245);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(150, 53);
            this.btn_luu.TabIndex = 21;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Image = global::CONGNGHENET.Properties.Resources.Load;
            this.btn_update.Location = new System.Drawing.Point(839, 87);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 53);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_in
            // 
            this.btn_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_in.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_in.Image = global::CONGNGHENET.Properties.Resources.Line_Chart;
            this.btn_in.Location = new System.Drawing.Point(774, 245);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(215, 53);
            this.btn_in.TabIndex = 22;
            this.btn_in.Text = "Thống kê hoá đơn";
            this.btn_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_in.UseVisualStyleBackColor = false;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_thoat.Image = global::CONGNGHENET.Properties.Resources.Exit;
            this.btn_thoat.Location = new System.Drawing.Point(839, 165);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(150, 53);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "&Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_xoa.Image = global::CONGNGHENET.Properties.Resources.Delete;
            this.btn_xoa.Location = new System.Drawing.Point(227, 245);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_xoa.Size = new System.Drawing.Size(150, 53);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = " &Xoá";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sua.Image = global::CONGNGHENET.Properties.Resources.Modify;
            this.btn_sua.Location = new System.Drawing.Point(416, 245);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(150, 53);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = " &Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_them.Image = global::CONGNGHENET.Properties.Resources.Add;
            this.btn_them.Location = new System.Drawing.Point(53, 245);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 53);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = " &Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_update_tien
            // 
            this.btn_update_tien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_update_tien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_update_tien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update_tien.Image = global::CONGNGHENET.Properties.Resources.refresh;
            this.btn_update_tien.Location = new System.Drawing.Point(360, 93);
            this.btn_update_tien.Name = "btn_update_tien";
            this.btn_update_tien.Size = new System.Drawing.Size(211, 52);
            this.btn_update_tien.TabIndex = 25;
            this.btn_update_tien.Text = "Cập nhật thành tiền";
            this.btn_update_tien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update_tien.UseVisualStyleBackColor = false;
            this.btn_update_tien.Click += new System.EventHandler(this.btn_update_tien_Click);
            // 
            // btn_inhoadon
            // 
            this.btn_inhoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_inhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_inhoadon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_inhoadon.Image = global::CONGNGHENET.Properties.Resources.Print;
            this.btn_inhoadon.Location = new System.Drawing.Point(599, 70);
            this.btn_inhoadon.Name = "btn_inhoadon";
            this.btn_inhoadon.Size = new System.Drawing.Size(162, 53);
            this.btn_inhoadon.TabIndex = 24;
            this.btn_inhoadon.Text = "In Hoá Đơn";
            this.btn_inhoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inhoadon.UseVisualStyleBackColor = false;
            this.btn_inhoadon.Click += new System.EventHandler(this.btn_inhoadon_Click);
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.gb_BH);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.gb_nhapBH);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietHoaDon";
            this.Text = "Chi Tiết Hoá Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            this.gb_BH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            this.gb_nhapBH.ResumeLayout(false);
            this.gb_nhapBH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_BH;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label dongia;
        private System.Windows.Forms.Label soluong;
        private System.Windows.Forms.Label maxe;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_maxe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_nhapBH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cb_mahd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_inhoadon;
        private System.Windows.Forms.Button btn_update_tien;
    }
}