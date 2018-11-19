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
    public partial class frm_TuVan : Form
    {
        BL.bl_TuVan bl;
        public frm_TuVan()
        {
            InitializeComponent();
            bl = new BL.bl_TuVan();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            if (txtDai!=null && txtRong != null && txtChiPhi !=null)
            {
                gv_Result.DataSource = bl.TruyVan(int.Parse(txtDai.Text), int.Parse(txtRong.Text), float.Parse(txtChiPhi.Text));
              
            }
        }

        private void gv_Result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gv_Result_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
