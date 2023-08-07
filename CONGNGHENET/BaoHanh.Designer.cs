namespace CONGNGHENET
{
    partial class BaoHanh
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
            this.dataGridViewBH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.txt_maXe = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.txt_maBH = new System.Windows.Forms.TextBox();
            this.noidung = new System.Windows.Forms.Label();
            this.ngaybh = new System.Windows.Forms.Label();
            this.makh = new System.Windows.Forms.Label();
            this.manv = new System.Windows.Forms.Label();
            this.maxe = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gb_nhapBH = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_nhap_txt = new System.Windows.Forms.Button();
            this.btn_xuat_txt = new System.Windows.Forms.Button();
            this.btn_nhap_excel = new System.Windows.Forms.Button();
            this.btn_xuat_excel = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.gb_BH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gb_nhapBH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_BH
            // 
            this.gb_BH.Controls.Add(this.dataGridViewBH);
            this.gb_BH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_BH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.gb_BH.Location = new System.Drawing.Point(46, 281);
            this.gb_BH.Name = "gb_BH";
            this.gb_BH.Size = new System.Drawing.Size(930, 221);
            this.gb_BH.TabIndex = 11;
            this.gb_BH.TabStop = false;
            this.gb_BH.Text = "Thông tin bảo hành";
            // 
            // dataGridViewBH
            // 
            this.dataGridViewBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewBH.Location = new System.Drawing.Point(28, 25);
            this.dataGridViewBH.Name = "dataGridViewBH";
            this.dataGridViewBH.RowHeadersWidth = 51;
            this.dataGridViewBH.Size = new System.Drawing.Size(875, 182);
            this.dataGridViewBH.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaBH";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MaXe";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MaNV";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MaKH";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngay";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NoiDung";
            this.Column6.Name = "Column6";
            this.Column6.Width = 205;
            // 
            // txt_noidung
            // 
            this.txt_noidung.Location = new System.Drawing.Point(518, 108);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(201, 41);
            this.txt_noidung.TabIndex = 3;
            // 
            // txt_maXe
            // 
            this.txt_maXe.Location = new System.Drawing.Point(135, 75);
            this.txt_maXe.Name = "txt_maXe";
            this.txt_maXe.Size = new System.Drawing.Size(211, 26);
            this.txt_maXe.TabIndex = 2;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Location = new System.Drawing.Point(135, 117);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(211, 26);
            this.txt_maKH.TabIndex = 4;
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(518, 41);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(201, 26);
            this.txt_maNV.TabIndex = 5;
            // 
            // txt_maBH
            // 
            this.txt_maBH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_maBH.Location = new System.Drawing.Point(135, 36);
            this.txt_maBH.Name = "txt_maBH";
            this.txt_maBH.Size = new System.Drawing.Size(211, 26);
            this.txt_maBH.TabIndex = 1;
            // 
            // noidung
            // 
            this.noidung.AutoSize = true;
            this.noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noidung.Location = new System.Drawing.Point(386, 122);
            this.noidung.Name = "noidung";
            this.noidung.Size = new System.Drawing.Size(71, 18);
            this.noidung.TabIndex = 5;
            this.noidung.Text = "Nội dung:";
            // 
            // ngaybh
            // 
            this.ngaybh.AutoSize = true;
            this.ngaybh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaybh.Location = new System.Drawing.Point(386, 80);
            this.ngaybh.Name = "ngaybh";
            this.ngaybh.Size = new System.Drawing.Size(111, 18);
            this.ngaybh.TabIndex = 4;
            this.ngaybh.Text = "Ngày bảo hành:";
            // 
            // makh
            // 
            this.makh.AutoSize = true;
            this.makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makh.Location = new System.Drawing.Point(34, 124);
            this.makh.Name = "makh";
            this.makh.Size = new System.Drawing.Size(58, 18);
            this.makh.TabIndex = 3;
            this.makh.Text = "Mã KH:";
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manv.Location = new System.Drawing.Point(386, 41);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(57, 18);
            this.manv.TabIndex = 2;
            this.manv.Text = "Mã NV:";
            // 
            // maxe
            // 
            this.maxe.AutoSize = true;
            this.maxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxe.Location = new System.Drawing.Point(34, 80);
            this.maxe.Name = "maxe";
            this.maxe.Size = new System.Drawing.Size(52, 18);
            this.maxe.TabIndex = 1;
            this.maxe.Text = "Mã xe:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bảo hành:";
            // 
            // gb_nhapBH
            // 
            this.gb_nhapBH.Controls.Add(this.dateTimePicker1);
            this.gb_nhapBH.Controls.Add(this.txt_noidung);
            this.gb_nhapBH.Controls.Add(this.txt_maXe);
            this.gb_nhapBH.Controls.Add(this.txt_maKH);
            this.gb_nhapBH.Controls.Add(this.txt_maNV);
            this.gb_nhapBH.Controls.Add(this.txt_maBH);
            this.gb_nhapBH.Controls.Add(this.noidung);
            this.gb_nhapBH.Controls.Add(this.ngaybh);
            this.gb_nhapBH.Controls.Add(this.makh);
            this.gb_nhapBH.Controls.Add(this.manv);
            this.gb_nhapBH.Controls.Add(this.maxe);
            this.gb_nhapBH.Controls.Add(this.label2);
            this.gb_nhapBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_nhapBH.ForeColor = System.Drawing.Color.Black;
            this.gb_nhapBH.Location = new System.Drawing.Point(35, 48);
            this.gb_nhapBH.Name = "gb_nhapBH";
            this.gb_nhapBH.Size = new System.Drawing.Size(753, 168);
            this.gb_nhapBH.TabIndex = 5;
            this.gb_nhapBH.TabStop = false;
            this.gb_nhapBH.Text = "Nhập thông tin bảo hành";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(518, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "CẬP NHẬT THÔNG TIN BẢO HÀNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_xoa.Image = global::CONGNGHENET.Properties.Resources.Delete;
            this.btn_xoa.Location = new System.Drawing.Point(249, 222);
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
            this.btn_sua.Location = new System.Drawing.Point(433, 222);
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
            this.btn_them.Location = new System.Drawing.Point(61, 222);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 53);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "&Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_thoat.Image = global::CONGNGHENET.Properties.Resources.Exit;
            this.btn_thoat.Location = new System.Drawing.Point(305, 496);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(121, 53);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "&Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Image = global::CONGNGHENET.Properties.Resources.Load;
            this.btn_update.Location = new System.Drawing.Point(96, 496);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 53);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.Enabled = false;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_luu.Image = global::CONGNGHENET.Properties.Resources.Save;
            this.btn_luu.Location = new System.Drawing.Point(620, 222);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(150, 53);
            this.btn_luu.TabIndex = 13;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_nhap_txt
            // 
            this.btn_nhap_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_nhap_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nhap_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhap_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_nhap_txt.Image = global::CONGNGHENET.Properties.Resources.txt_file1;
            this.btn_nhap_txt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhap_txt.Location = new System.Drawing.Point(812, 144);
            this.btn_nhap_txt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nhap_txt.Name = "btn_nhap_txt";
            this.btn_nhap_txt.Size = new System.Drawing.Size(182, 53);
            this.btn_nhap_txt.TabIndex = 31;
            this.btn_nhap_txt.Text = " &Nhập file txt";
            this.btn_nhap_txt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhap_txt.UseVisualStyleBackColor = false;
            this.btn_nhap_txt.Click += new System.EventHandler(this.btn_nhap_txt_Click);
            // 
            // btn_xuat_txt
            // 
            this.btn_xuat_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_xuat_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xuat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_xuat_txt.Image = global::CONGNGHENET.Properties.Resources.txt;
            this.btn_xuat_txt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuat_txt.Location = new System.Drawing.Point(812, 201);
            this.btn_xuat_txt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xuat_txt.Name = "btn_xuat_txt";
            this.btn_xuat_txt.Size = new System.Drawing.Size(182, 53);
            this.btn_xuat_txt.TabIndex = 30;
            this.btn_xuat_txt.Text = " &Xuất file txt";
            this.btn_xuat_txt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xuat_txt.UseVisualStyleBackColor = false;
            this.btn_xuat_txt.Click += new System.EventHandler(this.btn_xuat_txt_Click);
            // 
            // btn_nhap_excel
            // 
            this.btn_nhap_excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_nhap_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nhap_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhap_excel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_nhap_excel.Image = global::CONGNGHENET.Properties.Resources.xls;
            this.btn_nhap_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhap_excel.Location = new System.Drawing.Point(812, 30);
            this.btn_nhap_excel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nhap_excel.Name = "btn_nhap_excel";
            this.btn_nhap_excel.Size = new System.Drawing.Size(182, 53);
            this.btn_nhap_excel.TabIndex = 29;
            this.btn_nhap_excel.Text = " &Nhập file Excel";
            this.btn_nhap_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhap_excel.UseVisualStyleBackColor = false;
            this.btn_nhap_excel.Click += new System.EventHandler(this.btn_nhap_excel_Click);
            // 
            // btn_xuat_excel
            // 
            this.btn_xuat_excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_xuat_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xuat_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat_excel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_xuat_excel.Image = global::CONGNGHENET.Properties.Resources.xlsx;
            this.btn_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuat_excel.Location = new System.Drawing.Point(812, 87);
            this.btn_xuat_excel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xuat_excel.Name = "btn_xuat_excel";
            this.btn_xuat_excel.Size = new System.Drawing.Size(182, 53);
            this.btn_xuat_excel.TabIndex = 28;
            this.btn_xuat_excel.Text = " &Xuất file Excel";
            this.btn_xuat_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xuat_excel.UseVisualStyleBackColor = false;
            this.btn_xuat_excel.Click += new System.EventHandler(this.btn_xuat_excel_Click);
            // 
            // btn_test
            // 
            this.btn_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_test.Enabled = false;
            this.btn_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_test.Image = global::CONGNGHENET.Properties.Resources.Save;
            this.btn_test.Location = new System.Drawing.Point(590, 496);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(150, 53);
            this.btn_test.TabIndex = 32;
            this.btn_test.Text = "test";
            this.btn_test.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_test.UseVisualStyleBackColor = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_nhap_txt);
            this.Controls.Add(this.btn_xuat_txt);
            this.Controls.Add(this.btn_nhap_excel);
            this.Controls.Add(this.btn_xuat_excel);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.gb_BH);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.gb_nhapBH);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "BaoHanh";
            this.Text = "Bảo Hành";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoHanh_Load);
            this.gb_BH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gb_nhapBH.ResumeLayout(false);
            this.gb_nhapBH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_BH;
        private System.Windows.Forms.TextBox txt_noidung;
        private System.Windows.Forms.TextBox txt_maXe;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.TextBox txt_maBH;
        private System.Windows.Forms.Label noidung;
        private System.Windows.Forms.Label ngaybh;
        private System.Windows.Forms.Label makh;
        private System.Windows.Forms.Label manv;
        private System.Windows.Forms.Label maxe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox gb_nhapBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBH;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btn_nhap_txt;
        private System.Windows.Forms.Button btn_xuat_txt;
        private System.Windows.Forms.Button btn_nhap_excel;
        private System.Windows.Forms.Button btn_xuat_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_test;
    }
}