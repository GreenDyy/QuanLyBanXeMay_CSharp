namespace CONGNGHENET
{
    partial class QuanLyTaiKhoan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoanhomquyen = new System.Windows.Forms.Button();
            this.txt_nhaptenquyen = new System.Windows.Forms.TextBox();
            this.btn_tao_role = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_bang = new System.Windows.Forms.ComboBox();
            this.chk_update = new System.Windows.Forms.CheckBox();
            this.chk_del = new System.Windows.Forms.CheckBox();
            this.chk_insert = new System.Windows.Forms.CheckBox();
            this.chk_select = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_themquyen = new System.Windows.Forms.Button();
            this.btn_thuhoi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_taotkmoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.rdo_addquyenuser = new System.Windows.Forms.RadioButton();
            this.rdo_addquyennhom = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(16, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(304, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN NHÂN VIÊN";
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(101, 185);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(132, 22);
            this.txt_tk.TabIndex = 4;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(17, 111);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(83, 27);
            this.btn_in.TabIndex = 6;
            this.btn_in.Text = "Đưa vào";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(16, 144);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(84, 27);
            this.btn_out.TabIndex = 7;
            this.btn_out.Text = "Rút ra";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // cb_role
            // 
            this.cb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(136, 84);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(171, 24);
            this.cb_role.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_xoanhomquyen);
            this.groupBox1.Controls.Add(this.txt_nhaptenquyen);
            this.groupBox1.Controls.Add(this.btn_tao_role);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_in);
            this.groupBox1.Controls.Add(this.btn_out);
            this.groupBox1.Controls.Add(this.cb_role);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(366, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 353);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đưa nhân viên vào\\ra nhóm quyền";
            // 
            // btn_xoanhomquyen
            // 
            this.btn_xoanhomquyen.Location = new System.Drawing.Point(15, 307);
            this.btn_xoanhomquyen.Name = "btn_xoanhomquyen";
            this.btn_xoanhomquyen.Size = new System.Drawing.Size(147, 23);
            this.btn_xoanhomquyen.TabIndex = 17;
            this.btn_xoanhomquyen.Text = "Xoá nhóm quyền";
            this.btn_xoanhomquyen.UseVisualStyleBackColor = true;
            this.btn_xoanhomquyen.Click += new System.EventHandler(this.btn_xoanhomquyen_Click);
            // 
            // txt_nhaptenquyen
            // 
            this.txt_nhaptenquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhaptenquyen.Location = new System.Drawing.Point(158, 234);
            this.txt_nhaptenquyen.Name = "txt_nhaptenquyen";
            this.txt_nhaptenquyen.Size = new System.Drawing.Size(149, 22);
            this.txt_nhaptenquyen.TabIndex = 16;
            // 
            // btn_tao_role
            // 
            this.btn_tao_role.Location = new System.Drawing.Point(15, 268);
            this.btn_tao_role.Name = "btn_tao_role";
            this.btn_tao_role.Size = new System.Drawing.Size(147, 23);
            this.btn_tao_role.TabIndex = 15;
            this.btn_tao_role.Text = "Tạo nhóm quyền";
            this.btn_tao_role.UseVisualStyleBackColor = true;
            this.btn_tao_role.Click += new System.EventHandler(this.btn_tao_role_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chọn nhóm  quyền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tài khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rdo_addquyennhom);
            this.groupBox2.Controls.Add(this.cb_bang);
            this.groupBox2.Controls.Add(this.rdo_addquyenuser);
            this.groupBox2.Controls.Add(this.chk_update);
            this.groupBox2.Controls.Add(this.chk_del);
            this.groupBox2.Controls.Add(this.chk_insert);
            this.groupBox2.Controls.Add(this.chk_select);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_themquyen);
            this.groupBox2.Controls.Add(this.btn_thuhoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(710, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 353);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm\\Thu hồi quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Chọn bảng:";
            // 
            // cb_bang
            // 
            this.cb_bang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bang.FormattingEnabled = true;
            this.cb_bang.Location = new System.Drawing.Point(95, 89);
            this.cb_bang.Name = "cb_bang";
            this.cb_bang.Size = new System.Drawing.Size(121, 24);
            this.cb_bang.TabIndex = 17;
            // 
            // chk_update
            // 
            this.chk_update.AutoSize = true;
            this.chk_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_update.Location = new System.Drawing.Point(125, 209);
            this.chk_update.Name = "chk_update";
            this.chk_update.Size = new System.Drawing.Size(82, 20);
            this.chk_update.TabIndex = 16;
            this.chk_update.Text = "UPDATE";
            this.chk_update.UseVisualStyleBackColor = true;
            // 
            // chk_del
            // 
            this.chk_del.AutoSize = true;
            this.chk_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_del.Location = new System.Drawing.Point(125, 183);
            this.chk_del.Name = "chk_del";
            this.chk_del.Size = new System.Drawing.Size(79, 20);
            this.chk_del.TabIndex = 15;
            this.chk_del.Text = "DELETE";
            this.chk_del.UseVisualStyleBackColor = true;
            // 
            // chk_insert
            // 
            this.chk_insert.AutoSize = true;
            this.chk_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_insert.Location = new System.Drawing.Point(125, 157);
            this.chk_insert.Name = "chk_insert";
            this.chk_insert.Size = new System.Drawing.Size(76, 20);
            this.chk_insert.TabIndex = 14;
            this.chk_insert.Text = "INSERT";
            this.chk_insert.UseVisualStyleBackColor = true;
            // 
            // chk_select
            // 
            this.chk_select.AutoSize = true;
            this.chk_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_select.Location = new System.Drawing.Point(125, 131);
            this.chk_select.Name = "chk_select";
            this.chk_select.Size = new System.Drawing.Size(78, 20);
            this.chk_select.TabIndex = 13;
            this.chk_select.Text = "SELECT";
            this.chk_select.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chọn quyền:";
            // 
            // btn_themquyen
            // 
            this.btn_themquyen.Location = new System.Drawing.Point(22, 237);
            this.btn_themquyen.Name = "btn_themquyen";
            this.btn_themquyen.Size = new System.Drawing.Size(112, 29);
            this.btn_themquyen.TabIndex = 6;
            this.btn_themquyen.Text = "Thêm quyền";
            this.btn_themquyen.UseVisualStyleBackColor = true;
            this.btn_themquyen.Click += new System.EventHandler(this.btn_themquyen_Click);
            // 
            // btn_thuhoi
            // 
            this.btn_thuhoi.Location = new System.Drawing.Point(22, 281);
            this.btn_thuhoi.Name = "btn_thuhoi";
            this.btn_thuhoi.Size = new System.Drawing.Size(112, 27);
            this.btn_thuhoi.TabIndex = 7;
            this.btn_thuhoi.Text = "Thu hồi quyền";
            this.btn_thuhoi.UseVisualStyleBackColor = true;
            this.btn_thuhoi.Click += new System.EventHandler(this.btn_thuhoi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_tk);
            this.groupBox3.Controls.Add(this.btn_taotkmoi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 353);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách tài khoản";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::CONGNGHENET.Properties.Resources.user__1_;
            this.btn_xoa.Location = new System.Drawing.Point(28, 218);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(147, 49);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xoá tài khoản";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_taotkmoi
            // 
            this.btn_taotkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taotkmoi.Image = global::CONGNGHENET.Properties.Resources.add_friend;
            this.btn_taotkmoi.Location = new System.Drawing.Point(29, 283);
            this.btn_taotkmoi.Name = "btn_taotkmoi";
            this.btn_taotkmoi.Size = new System.Drawing.Size(146, 47);
            this.btn_taotkmoi.TabIndex = 5;
            this.btn_taotkmoi.Text = "Tạo tài khoản ";
            this.btn_taotkmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_taotkmoi.UseVisualStyleBackColor = true;
            this.btn_taotkmoi.Click += new System.EventHandler(this.btn_taotkmoi_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::CONGNGHENET.Properties.Resources.power;
            this.btn_thoat.Location = new System.Drawing.Point(443, 507);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(114, 42);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // rdo_addquyenuser
            // 
            this.rdo_addquyenuser.AutoSize = true;
            this.rdo_addquyenuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_addquyenuser.Location = new System.Drawing.Point(22, 31);
            this.rdo_addquyenuser.Name = "rdo_addquyenuser";
            this.rdo_addquyenuser.Size = new System.Drawing.Size(155, 20);
            this.rdo_addquyenuser.TabIndex = 19;
            this.rdo_addquyenuser.TabStop = true;
            this.rdo_addquyenuser.Text = "Thêm quyền vào user";
            this.rdo_addquyenuser.UseVisualStyleBackColor = true;
            // 
            // rdo_addquyennhom
            // 
            this.rdo_addquyennhom.AutoSize = true;
            this.rdo_addquyennhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_addquyennhom.Location = new System.Drawing.Point(22, 57);
            this.rdo_addquyennhom.Name = "rdo_addquyennhom";
            this.rdo_addquyennhom.Size = new System.Drawing.Size(202, 20);
            this.rdo_addquyennhom.TabIndex = 20;
            this.rdo_addquyennhom.TabStop = true;
            this.rdo_addquyennhom.Text = "Thêm quyền vào nhóm quyền";
            this.rdo_addquyennhom.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nhập tên nhóm quyền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tạo nhóm quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Đưa user vào ra nhóm quyền";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tài khoản ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mật Khẩu";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button btn_taotkmoi;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_themquyen;
        private System.Windows.Forms.Button btn_thuhoi;
        private System.Windows.Forms.CheckBox chk_update;
        private System.Windows.Forms.CheckBox chk_del;
        private System.Windows.Forms.CheckBox chk_insert;
        private System.Windows.Forms.CheckBox chk_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_nhaptenquyen;
        private System.Windows.Forms.Button btn_tao_role;
        private System.Windows.Forms.RadioButton rdo_addquyennhom;
        private System.Windows.Forms.RadioButton rdo_addquyenuser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_bang;
        private System.Windows.Forms.Button btn_xoanhomquyen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}