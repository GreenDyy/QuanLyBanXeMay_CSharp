namespace CONGNGHENET
{
    partial class GiaoTac
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
            this.btn_thucthigiaotac = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_thucthigiaotac
            // 
            this.btn_thucthigiaotac.Location = new System.Drawing.Point(79, 258);
            this.btn_thucthigiaotac.Name = "btn_thucthigiaotac";
            this.btn_thucthigiaotac.Size = new System.Drawing.Size(75, 23);
            this.btn_thucthigiaotac.TabIndex = 0;
            this.btn_thucthigiaotac.Text = "Thực thi";
            this.btn_thucthigiaotac.UseVisualStyleBackColor = true;
            this.btn_thucthigiaotac.Click += new System.EventHandler(this.btn_thucthigiaotac_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(160, 215);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(100, 20);
            this.txt_makh.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã kh:";
            // 
            // GiaoTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_thucthigiaotac);
            this.Name = "GiaoTac";
            this.Text = "GiaoTac";
            this.Load += new System.EventHandler(this.GiaoTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thucthigiaotac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label1;
    }
}