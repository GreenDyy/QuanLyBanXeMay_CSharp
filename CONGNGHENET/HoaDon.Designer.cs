namespace CONGNGHENET
{
    partial class HoaDon
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
            this.lbNameForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMKH = new System.Windows.Forms.Label();
            this.text_MaHD = new System.Windows.Forms.TextBox();
            this.lbMHD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbx_MaKH = new System.Windows.Forms.ComboBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.text_Tien = new System.Windows.Forms.TextBox();
            this.lbThanhToan = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_cthd = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Fix = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbNameForm.Location = new System.Drawing.Point(171, 18);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(364, 29);
            this.lbNameForm.TabIndex = 25;
            this.lbNameForm.Text = "Cập Nhập Thông Tin Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(56, -88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cập Nhập Thông Tin Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.groupBox2.Location = new System.Drawing.Point(55, 277);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(598, 223);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.Ngay,
            this.MaKh,
            this.TongTien});
            this.dataGridView1.Location = new System.Drawing.Point(2, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(587, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 125;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 125;
            // 
            // MaKh
            // 
            this.MaKh.HeaderText = "Khách Hàng";
            this.MaKh.MinimumWidth = 6;
            this.MaKh.Name = "MaKh";
            this.MaKh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaKh.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 175;
            // 
            // lbMKH
            // 
            this.lbMKH.AutoSize = true;
            this.lbMKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMKH.Location = new System.Drawing.Point(28, 88);
            this.lbMKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMKH.Name = "lbMKH";
            this.lbMKH.Size = new System.Drawing.Size(118, 18);
            this.lbMKH.TabIndex = 2;
            this.lbMKH.Text = "Mã Khách Hàng:";
            // 
            // text_MaHD
            // 
            this.text_MaHD.Location = new System.Drawing.Point(152, 32);
            this.text_MaHD.Margin = new System.Windows.Forms.Padding(2);
            this.text_MaHD.Name = "text_MaHD";
            this.text_MaHD.Size = new System.Drawing.Size(150, 26);
            this.text_MaHD.TabIndex = 1;
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMHD.Location = new System.Drawing.Point(28, 37);
            this.lbMHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(97, 18);
            this.lbMHD.TabIndex = 0;
            this.lbMHD.Text = "Mã Hóa Đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbx_MaKH);
            this.groupBox1.Controls.Add(this.lbMKH);
            this.groupBox1.Controls.Add(this.lbNgay);
            this.groupBox1.Controls.Add(this.text_Tien);
            this.groupBox1.Controls.Add(this.lbThanhToan);
            this.groupBox1.Controls.Add(this.text_MaHD);
            this.groupBox1.Controls.Add(this.lbMHD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(56, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(588, 126);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin Hóa Đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(414, 32);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cbx_MaKH
            // 
            this.cbx_MaKH.FormattingEnabled = true;
            this.cbx_MaKH.Location = new System.Drawing.Point(152, 84);
            this.cbx_MaKH.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_MaKH.Name = "cbx_MaKH";
            this.cbx_MaKH.Size = new System.Drawing.Size(150, 28);
            this.cbx_MaKH.TabIndex = 4;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(331, 36);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(46, 18);
            this.lbNgay.TabIndex = 0;
            this.lbNgay.Text = "Ngày:";
            // 
            // text_Tien
            // 
            this.text_Tien.Location = new System.Drawing.Point(414, 88);
            this.text_Tien.Margin = new System.Windows.Forms.Padding(2);
            this.text_Tien.Name = "text_Tien";
            this.text_Tien.Size = new System.Drawing.Size(155, 26);
            this.text_Tien.TabIndex = 0;
            this.text_Tien.TabStop = false;
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhToan.Location = new System.Drawing.Point(332, 88);
            this.lbThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(78, 18);
            this.lbThanhToan.TabIndex = 0;
            this.lbThanhToan.Text = "Tổng Tiền:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(830, 73);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(101, 20);
            this.txt_tim.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tìm hoá đơn theo mã KH:";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.Image = global::CONGNGHENET.Properties.Resources.Back;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(664, 93);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(146, 46);
            this.btn_refresh.TabIndex = 30;
            this.btn_refresh.Text = " &Refresh";
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_tim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tim.Image = global::CONGNGHENET.Properties.Resources.Search;
            this.btn_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim.Location = new System.Drawing.Point(830, 93);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(101, 46);
            this.btn_tim.TabIndex = 29;
            this.btn_tim.Text = " &Tìm";
            this.btn_tim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_cthd
            // 
            this.btn_cthd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_cthd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cthd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cthd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cthd.Image = global::CONGNGHENET.Properties.Resources.invoice;
            this.btn_cthd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cthd.Location = new System.Drawing.Point(285, 507);
            this.btn_cthd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cthd.Name = "btn_cthd";
            this.btn_cthd.Size = new System.Drawing.Size(164, 50);
            this.btn_cthd.TabIndex = 28;
            this.btn_cthd.Text = "Chi tiết HD";
            this.btn_cthd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cthd.UseVisualStyleBackColor = false;
            this.btn_cthd.Click += new System.EventHandler(this.btn_cthd_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Image = global::CONGNGHENET.Properties.Resources.Load;
            this.btn_update.Location = new System.Drawing.Point(96, 505);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 53);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.Image = global::CONGNGHENET.Properties.Resources.Save;
            this.btn_Save.Location = new System.Drawing.Point(87, 201);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 53);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Exit.Image = global::CONGNGHENET.Properties.Resources.Exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(488, 504);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 53);
            this.btn_Exit.TabIndex = 8;
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
            this.btn_Delete.Location = new System.Drawing.Point(514, 201);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 53);
            this.btn_Delete.TabIndex = 7;
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
            this.btn_Fix.Location = new System.Drawing.Point(371, 201);
            this.btn_Fix.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(120, 53);
            this.btn_Fix.TabIndex = 6;
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
            this.btn_Add.Location = new System.Drawing.Point(226, 201);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 53);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = " &Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cthd);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Fix);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbNameForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HoaDon";
            this.Text = "Hoá Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbMKH;
        private System.Windows.Forms.TextBox text_MaHD;
        private System.Windows.Forms.Label lbMHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.TextBox text_Tien;
        private System.Windows.Forms.Label lbThanhToan;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Fix;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cbx_MaKH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_cthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_refresh;
    }
}