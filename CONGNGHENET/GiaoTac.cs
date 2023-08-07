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
    public partial class GiaoTac : Form
    {
        public GiaoTac()
        {
            InitializeComponent();
        }
        XULYCSDL xuly = new XULYCSDL();
        DataTable dt;

        private void GiaoTac_Load(object sender, EventArgs e)
        {

        }

        private void btn_thucthigiaotac_Click(object sender, EventArgs e)
        {
            string lenhsql = "EXEC DOCDIACHIKHACH_REPEATABLE '" + txt_makh.Text + "'";
            dt = xuly.LayDuLieu(lenhsql);
            dataGridView1.DataSource = dt;
        }
    }
}
