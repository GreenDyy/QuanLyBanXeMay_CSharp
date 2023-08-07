namespace CONGNGHENET
{
    partial class NhanVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbx_MaQuyen = new System.Windows.Forms.ComboBox();
            this.lbMaQuyen = new System.Windows.Forms.Label();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.text_SDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.text_MaNV = new System.Windows.Forms.TextBox();
            this.lbMNV = new System.Windows.Forms.Label();
            this.text_TenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_check_chucvu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_check_chucvu = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Fix = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.groupBox2.Location = new System.Drawing.Point(17, 291);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(982, 232);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.Email,
            this.SDT,
            this.Column1,
            this.NgaySinh,
            this.MaQuyen});
            this.dataGridView1.Location = new System.Drawing.Point(4, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "TenNV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 160;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 130;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "GioiTinh";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 140;
            // 
            // MaQuyen
            // 
            this.MaQuyen.HeaderText = "MaQuyen";
            this.MaQuyen.MinimumWidth = 6;
            this.MaQuyen.Name = "MaQuyen";
            this.MaQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaQuyen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbx_MaQuyen);
            this.groupBox1.Controls.Add(this.lbMaQuyen);
            this.groupBox1.Controls.Add(this.text_Email);
            this.groupBox1.Controls.Add(this.lbMail);
            this.groupBox1.Controls.Add(this.lbNgaySinh);
            this.groupBox1.Controls.Add(this.text_SDT);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.lbGioiTinh);
            this.groupBox1.Controls.Add(this.lbTenNV);
            this.groupBox1.Controls.Add(this.text_MaNV);
            this.groupBox1.Controls.Add(this.lbMNV);
            this.groupBox1.Controls.Add(this.text_TenNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(17, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(679, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin NV";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(535, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(443, 79);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 26);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cbx_MaQuyen
            // 
            this.cbx_MaQuyen.FormattingEnabled = true;
            this.cbx_MaQuyen.Location = new System.Drawing.Point(92, 119);
            this.cbx_MaQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_MaQuyen.Name = "cbx_MaQuyen";
            this.cbx_MaQuyen.Size = new System.Drawing.Size(211, 28);
            this.cbx_MaQuyen.TabIndex = 16;
            // 
            // lbMaQuyen
            // 
            this.lbMaQuyen.AutoSize = true;
            this.lbMaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaQuyen.Location = new System.Drawing.Point(11, 119);
            this.lbMaQuyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaQuyen.Name = "lbMaQuyen";
            this.lbMaQuyen.Size = new System.Drawing.Size(80, 18);
            this.lbMaQuyen.TabIndex = 14;
            this.lbMaQuyen.Text = "Mã Quyền:";
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(65, 79);
            this.text_Email.Margin = new System.Windows.Forms.Padding(2);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(238, 26);
            this.text_Email.TabIndex = 1;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(14, 85);
            this.lbMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(49, 18);
            this.lbMail.TabIndex = 6;
            this.lbMail.Text = "Email:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(352, 84);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(77, 18);
            this.lbNgaySinh.TabIndex = 10;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // text_SDT
            // 
            this.text_SDT.Location = new System.Drawing.Point(411, 119);
            this.text_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.text_SDT.Name = "text_SDT";
            this.text_SDT.Size = new System.Drawing.Size(247, 26);
            this.text_SDT.TabIndex = 8;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(352, 124);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(42, 18);
            this.lbSDT.TabIndex = 8;
            this.lbSDT.Text = "SĐT:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(464, 41);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(66, 18);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(211, 41);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(61, 18);
            this.lbTenNV.TabIndex = 2;
            this.lbTenNV.Text = "Tên NV:";
            // 
            // text_MaNV
            // 
            this.text_MaNV.Location = new System.Drawing.Point(72, 36);
            this.text_MaNV.Margin = new System.Windows.Forms.Padding(2);
            this.text_MaNV.Name = "text_MaNV";
            this.text_MaNV.Size = new System.Drawing.Size(128, 26);
            this.text_MaNV.TabIndex = 0;
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNV.Location = new System.Drawing.Point(11, 41);
            this.lbMNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(57, 18);
            this.lbMNV.TabIndex = 0;
            this.lbMNV.Text = "Mã NV:";
            // 
            // text_TenNV
            // 
            this.text_TenNV.Location = new System.Drawing.Point(274, 36);
            this.text_TenNV.Margin = new System.Windows.Forms.Padding(2);
            this.text_TenNV.Name = "text_TenNV";
            this.text_TenNV.Size = new System.Drawing.Size(182, 26);
            this.text_TenNV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(103, -88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cập Nhập Thông Tin Khách Hàng";
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbNameForm.Location = new System.Drawing.Point(160, 9);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(383, 29);
            this.lbNameForm.TabIndex = 16;
            this.lbNameForm.Text = "Cập Nhập Thông Tin Nhân Viên";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nhập mã NV:";
            // 
            // txt_check_chucvu
            // 
            this.txt_check_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_check_chucvu.Location = new System.Drawing.Point(128, 12);
            this.txt_check_chucvu.Name = "txt_check_chucvu";
            this.txt_check_chucvu.Size = new System.Drawing.Size(100, 22);
            this.txt_check_chucvu.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_check_chucvu);
            this.groupBox3.Controls.Add(this.txt_check_chucvu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(725, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 158);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // btn_check_chucvu
            // 
            this.btn_check_chucvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_check_chucvu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_check_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check_chucvu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_check_chucvu.Image = global::CONGNGHENET.Properties.Resources.Search;
            this.btn_check_chucvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_check_chucvu.Location = new System.Drawing.Point(39, 39);
            this.btn_check_chucvu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_check_chucvu.Name = "btn_check_chucvu";
            this.btn_check_chucvu.Size = new System.Drawing.Size(189, 53);
            this.btn_check_chucvu.TabIndex = 28;
            this.btn_check_chucvu.Text = " &Tìm chức vụ";
            this.btn_check_chucvu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_check_chucvu.UseVisualStyleBackColor = false;
            this.btn_check_chucvu.Click += new System.EventHandler(this.btn_check_chucvu_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.Image = global::CONGNGHENET.Properties.Resources.Load;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(62, 221);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 53);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = " &Lưu";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.Image = global::CONGNGHENET.Properties.Resources.Save;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(59, 538);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(157, 53);
            this.btn_Update.TabIndex = 22;
            this.btn_Update.Text = " &Cập Nhật";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Exit.Image = global::CONGNGHENET.Properties.Resources.Exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(278, 538);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 53);
            this.btn_Exit.TabIndex = 21;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.Image = global::CONGNGHENET.Properties.Resources.Delete;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(512, 221);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 53);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = " &Xoá";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Fix
            // 
            this.btn_Fix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Fix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Fix.Image = global::CONGNGHENET.Properties.Resources.Modify;
            this.btn_Fix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fix.Location = new System.Drawing.Point(362, 221);
            this.btn_Fix.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(120, 53);
            this.btn_Fix.TabIndex = 19;
            this.btn_Fix.Text = " &Sửa";
            this.btn_Fix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Fix.UseVisualStyleBackColor = false;
            this.btn_Fix.Click += new System.EventHandler(this.btn_Fix_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Image = global::CONGNGHENET.Properties.Resources.Add;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(213, 221);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 53);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = " &Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 628);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Fix);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbNameForm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhanVien";
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox text_SDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.TextBox text_MaNV;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_TenNV;
        private System.Windows.Forms.Label lbNameForm;
        private System.Windows.Forms.Label lbMaQuyen;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Fix;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbx_MaQuyen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyen;
        private System.Windows.Forms.TextBox txt_check_chucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_check_chucvu;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}