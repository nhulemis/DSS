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
    public partial class frm_ThongTinChiTiet : Form
    {
        public frm_ThongTinChiTiet()
        {
            InitializeComponent();
        }

        private void frm_ThongTinChiTiet_Load(object sender, EventArgs e)
        {
            BL.bl_ThongTinChiTiet bl = new BL.bl_ThongTinChiTiet();
            var model = bl.GetKhachHang(Common.Constants.id_KhachHang);
            lblHoTen.Text = model.ho;
            lblDiaChi.Text = model.diachi;
            lblSDT.Text = model.sdt;
            lblDiaChi.Text = model.diachi;
            lblNamSinh.Text = model.ten;

            var modelDetails = bl.GetChiTiet(Common.Constants.id);
            lblSoPhong.Text = modelDetails.tongsophong.ToString();
            lblSoTang.Text = modelDetails.solau.ToString();
            lblKhach.Text = modelDetails.sophongkhach.ToString();
            lblNgu.Text = modelDetails.sophongngu.ToString();
            lblVS.Text = modelDetails.sophongvesinh.ToString();
            lblBep.Text = modelDetails.sophongbep.ToString();

            var x =new  BL.bl_TuVan();
            var ImageA = x.HinhAnh(Common.Constants.id);
            pictureBox1.Image = byteArrayToImage(ImageA[0].hinhanh);
            pictureBox2.Image = byteArrayToImage(ImageA[1].hinhanh);
            pictureBox3.Image = byteArrayToImage(ImageA[2].hinhanh);
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }
    }
}
