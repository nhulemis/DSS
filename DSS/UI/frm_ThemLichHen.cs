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
    public partial class frm_ThemLichHen : Form
    {
        public frm_ThemLichHen()
        {
            InitializeComponent();
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DA.tbLICHHEN model = new DA.tbLICHHEN();
            model.id_khachhang = Common.Constants.id_KhachHang;
            model.ngay = dateTimePicker1.Value;
            model.gio = comboBox1.SelectedItem.ToString();
            model.ghichu = textBox1.Text;
            BL.bl_ThemLichHen bl = new BL.bl_ThemLichHen();
            bl.ThemLichHen(model);
           // this.Close();
            frm_Main main = new frm_Main();
            main.load();
           
        }
    }
}
