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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        public string text_userLD;

        public string chuoiketnoi_LD;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
            MDIParent1 f = new MDIParent1();
            f.text_userMDI = text_userLD;
            f.chuoiketnoi_MDI = chuoiketnoi_LD;
            f.Show();
        }
    }
}
