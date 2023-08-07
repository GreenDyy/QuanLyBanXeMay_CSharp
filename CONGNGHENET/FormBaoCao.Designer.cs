namespace CONGNGHENET
{
    partial class FormBaoCao
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
            this.crystalReportViewerCTHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerCTHD
            // 
            this.crystalReportViewerCTHD.ActiveViewIndex = -1;
            this.crystalReportViewerCTHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerCTHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerCTHD.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerCTHD.Name = "crystalReportViewerCTHD";
            this.crystalReportViewerCTHD.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerCTHD.TabIndex = 0;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerCTHD);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerCTHD;
    }
}