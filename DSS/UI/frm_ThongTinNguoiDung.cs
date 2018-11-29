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
    public partial class frm_ThongTinNguoiDung : Form
    {
        public frm_ThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DA.tbKHACHHANG model = new DA.tbKHACHHANG();
            model.ho = txtHoTen.Text;
            model.ten = txtNamSinh.Text;
            model.sdt = txtSDT.Text;
            model.diachi = txtDiaChi.Text;
            BL.bl_KhachHang bl = new BL.bl_KhachHang();
            Common.Constants.id_KhachHang = bl.ThemKhachHang(model);
            DA.tbLUACHONTHIETKE luachon = new DA.tbLUACHONTHIETKE();
            luachon.id_khachhang = Common.Constants.id_KhachHang;
            luachon.id_thietke = Common.Constants.id;
            luachon.ngay = DateTime.Now;
            bl.LuaChonThietKe(luachon);
            frm_ThongTinChiTiet frm = new frm_ThongTinChiTiet();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DA.tbKHACHHANG model = new DA.tbKHACHHANG();
            model.ho = txtHoTen.Text;
            model.ten = txtNamSinh.Text;
            model.sdt = txtSDT.Text;
            model.diachi = txtDiaChi.Text;
            BL.bl_KhachHang bl = new BL.bl_KhachHang();
            Common.Constants.id_KhachHang = bl.ThemKhachHang(model);
            frm_ThemLichHen frm = new frm_ThemLichHen();
            frm.Show();
            this.Close();
        }
    }
}
