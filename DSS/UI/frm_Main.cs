using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS.UI
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void thiếtKếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap();
            frm.Show();
        }

        private void tưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TuVan frm = new frm_TuVan();
            frm.Show();
        }
    }
}
