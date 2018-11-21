using DSS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            bl_ThemMoi bl1 = new bl_ThemMoi();
            cboKieu.DataSource = bl1.GetDanhMuc();
            cboKieu.DisplayMember = "ten";
            cboKieu.ValueMember = "id";
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            
            if (txtDai!=null && txtRong != null && txtChiPhi !=null)
            {
                gv_Result.DataSource = bl.TruyVan(int.Parse(txtDai.Text), int.Parse(txtRong.Text), float.Parse(txtChiPhi.Text));

            }
            
               
            
        }

        private void gv_Result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index =(int) gv_Result.Rows[e.RowIndex].Cells[0].Value;
            Common.Constants.id = index;
            var ImageA = bl.HinhAnh(index);
            pictureBox1.Image = byteArrayToImage(ImageA[0].hinhanh);
            pictureBox2.Image = byteArrayToImage(ImageA[1].hinhanh);
            pictureBox3.Image = byteArrayToImage(ImageA[2].hinhanh);

            var chiTiet = bl.ChiPhi(index);
            lblGach.Text = chiTiet[0].gach.ToString()+" thiên";
            lblGachOp.Text = chiTiet[0].gachlot.ToString() + " thùng";
            lblSon.Text = chiTiet[0].son.ToString() + " thùng";
            lblXi.Text = chiTiet[0].xi.ToString() + " bao";
            lblChiPhi.Text = chiTiet[0].uoctinhchiphi.ToString() + "triệu đồng";


        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            frm_ThongTinNguoiDung frm = new frm_ThongTinNguoiDung();
            frm.Show();
        }
    }
}
