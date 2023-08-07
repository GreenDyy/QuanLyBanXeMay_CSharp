using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONGNGHENET
{
    public partial class FormBaoCao : Form
    {
        DataTable dt;
        string formname;
        public FormBaoCao(DataTable dt, string formname)
        {
            InitializeComponent();
            this.dt = dt;
            this.formname = formname;
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            if (formname == "CTHD_VIEW")
            {
                CrystalReportCTHD baocaocthd = new CrystalReportCTHD();
                baocaocthd.SetDataSource(dt);
                crystalReportViewerCTHD.ReportSource = baocaocthd;
            }
            else if (formname == "CTHD_HOADONCUOI")
            {
                CrystalReport1 hoadoncuoi = new CrystalReport1();
                hoadoncuoi.SetDataSource(dt);
                crystalReportViewerCTHD.ReportSource = hoadoncuoi;
            }
        }
    }
}
