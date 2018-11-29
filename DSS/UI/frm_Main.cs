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

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.Close();
            frm_ThongTinNguoiDung frm = new frm_ThongTinNguoiDung();
            this.Hide();
            frm.Show();
           
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            groupBox_LichHen.Text = "Lịch hẹn ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
            BL.bl_ThemLichHen bl = new BL.bl_ThemLichHen();
            gv_LichHen.DataSource = bl.GetLichHen(DateTime.Now.Date);
        }
        public void load()
        {
            //groupBox_LichHen.Text = "Lịch hẹn ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
            this.Close();
            BL.bl_ThemLichHen bl = new BL.bl_ThemLichHen();
            gv_LichHen.DataSource = bl.GetLichHen(DateTime.Now.Date);
            frm_Main m = new frm_Main();
            m.Show();
           // this.Show();
        }
    }
}
