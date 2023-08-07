
namespace CONGNGHENET
{
    partial class ThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.rd_thang = new System.Windows.Forms.RadioButton();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(188, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(206, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(211, 97);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tổng Doanh Thu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_thoat.Image = global::CONGNGHENET.Properties.Resources.Exit;
            this.btn_thoat.Location = new System.Drawing.Point(17, 230);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(158, 53);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "&Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(221, 49);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(196, 22);
            this.txt_nam.TabIndex = 12;
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(221, 100);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(196, 22);
            this.txt_thang.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(124, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhập năm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nhập tháng:";
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_thongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_thongke.Image = global::CONGNGHENET.Properties.Resources.Bar_Chart;
            this.btn_thongke.Location = new System.Drawing.Point(17, 171);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(158, 53);
            this.btn_thongke.TabIndex = 16;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_thongbao);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.rd_thang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txt_nam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rd_nam);
            this.groupBox1.Controls.Add(this.txt_thang);
            this.groupBox1.Controls.Add(this.btn_thongke);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 337);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongbao.Location = new System.Drawing.Point(202, 139);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(24, 20);
            this.lb_thongbao.TabIndex = 19;
            this.lb_thongbao.Text = "...";
            // 
            // rd_thang
            // 
            this.rd_thang.AutoSize = true;
            this.rd_thang.Location = new System.Drawing.Point(17, 99);
            this.rd_thang.Name = "rd_thang";
            this.rd_thang.Size = new System.Drawing.Size(69, 20);
            this.rd_thang.TabIndex = 18;
            this.rd_thang.TabStop = true;
            this.rd_thang.Text = "Tháng";
            this.rd_thang.UseVisualStyleBackColor = true;
            this.rd_thang.CheckedChanged += new System.EventHandler(this.rd_thang_CheckedChanged);
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.Location = new System.Drawing.Point(17, 49);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(57, 20);
            this.rd_nam.TabIndex = 17;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Năm";
            this.rd_nam.UseVisualStyleBackColor = true;
            this.rd_nam.CheckedChanged += new System.EventHandler(this.rd_nam_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(483, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 337);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân viên trẻ chăm chỉ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(28, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 224);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MaNV";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TenNV";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NgaySinh";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Khach";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhân viên dưới 25 tuổi chăm sóc nhiều khách hàng nhất";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_thang;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
    }
}