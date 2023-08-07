namespace CONGNGHENET
{
    partial class SaoLuuPhucHoi
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_duongdan1 = new System.Windows.Forms.TextBox();
            this.btn_path_backup = new System.Windows.Forms.Button();
            this.btn_path_restore = new System.Windows.Forms.Button();
            this.txt_duongdan2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_saoluu = new System.Windows.Forms.Button();
            this.btn_phuchoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // txt_duongdan1
            // 
            this.txt_duongdan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duongdan1.Location = new System.Drawing.Point(150, 45);
            this.txt_duongdan1.Name = "txt_duongdan1";
            this.txt_duongdan1.Size = new System.Drawing.Size(307, 22);
            this.txt_duongdan1.TabIndex = 2;
            // 
            // btn_path_backup
            // 
            this.btn_path_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_path_backup.Location = new System.Drawing.Point(15, 42);
            this.btn_path_backup.Name = "btn_path_backup";
            this.btn_path_backup.Size = new System.Drawing.Size(129, 28);
            this.btn_path_backup.TabIndex = 3;
            this.btn_path_backup.Text = "Chọn đường dẫn:";
            this.btn_path_backup.UseVisualStyleBackColor = true;
            this.btn_path_backup.Click += new System.EventHandler(this.btn_path_backup_Click);
            // 
            // btn_path_restore
            // 
            this.btn_path_restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_path_restore.Location = new System.Drawing.Point(15, 45);
            this.btn_path_restore.Name = "btn_path_restore";
            this.btn_path_restore.Size = new System.Drawing.Size(129, 28);
            this.btn_path_restore.TabIndex = 4;
            this.btn_path_restore.Text = "Chọn đường dẫn:";
            this.btn_path_restore.UseVisualStyleBackColor = true;
            this.btn_path_restore.Click += new System.EventHandler(this.btn_path_restore_Click);
            // 
            // txt_duongdan2
            // 
            this.txt_duongdan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duongdan2.Location = new System.Drawing.Point(150, 48);
            this.txt_duongdan2.Name = "txt_duongdan2";
            this.txt_duongdan2.Size = new System.Drawing.Size(307, 22);
            this.txt_duongdan2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "SAO LƯU VÀ PHỤC HỒI CSDL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_duongdan2);
            this.groupBox1.Controls.Add(this.btn_phuchoi);
            this.groupBox1.Controls.Add(this.btn_path_restore);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 157);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phục hồi Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_duongdan1);
            this.groupBox2.Controls.Add(this.btn_saoluu);
            this.groupBox2.Controls.Add(this.btn_path_backup);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sao lưu Database";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_thoat.Image = global::CONGNGHENET.Properties.Resources.power;
            this.btn_thoat.Location = new System.Drawing.Point(60, 426);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(129, 45);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_saoluu
            // 
            this.btn_saoluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_saoluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saoluu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_saoluu.Image = global::CONGNGHENET.Properties.Resources.recovery;
            this.btn_saoluu.Location = new System.Drawing.Point(15, 77);
            this.btn_saoluu.Name = "btn_saoluu";
            this.btn_saoluu.Size = new System.Drawing.Size(129, 41);
            this.btn_saoluu.TabIndex = 0;
            this.btn_saoluu.Text = "Sao lưu";
            this.btn_saoluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_saoluu.UseVisualStyleBackColor = false;
            this.btn_saoluu.Click += new System.EventHandler(this.btn_saoluu_Click);
            // 
            // btn_phuchoi
            // 
            this.btn_phuchoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_phuchoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_phuchoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_phuchoi.Image = global::CONGNGHENET.Properties.Resources.restore;
            this.btn_phuchoi.Location = new System.Drawing.Point(15, 86);
            this.btn_phuchoi.Name = "btn_phuchoi";
            this.btn_phuchoi.Size = new System.Drawing.Size(129, 45);
            this.btn_phuchoi.TabIndex = 5;
            this.btn_phuchoi.Text = "Phục hồi";
            this.btn_phuchoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_phuchoi.UseVisualStyleBackColor = false;
            this.btn_phuchoi.Click += new System.EventHandler(this.btn_phuchoi_Click);
            // 
            // SaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SaoLuuPhucHoi";
            this.Text = "SaoLuuPhucHoi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaoLuuPhucHoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saoluu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_duongdan1;
        private System.Windows.Forms.Button btn_path_backup;
        private System.Windows.Forms.Button btn_path_restore;
        private System.Windows.Forms.Button btn_phuchoi;
        private System.Windows.Forms.TextBox txt_duongdan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_thoat;
    }
}