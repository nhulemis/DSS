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
    public partial class frm_ThemMoiThietKe : Form
    {
        public frm_ThemMoiThietKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<byte[]> list = new List<byte[]>();
            list.Add(ImageToByteArray(pictureBox1.Image));
            list.Add(ImageToByteArray(pictureBox2.Image));
            list.Add(ImageToByteArray(pictureBox3.Image));
          var x =  bl.ThemMoiBangVe(int.Parse(txtDai.Text), int.Parse(txtRong.Text),int.Parse(comboBox1.SelectedValue.ToString())
                ,ConvertInt(txtTang.Text), ConvertInt(txtPhongKhach.Text),ConvertInt(txtPhongNgu.Text), ConvertInt(txtVeSinh.Text),
                ConvertInt(txtBep.Text),cboTruocSau.SelectedItem.ToString(),list
                );
            if (x == true)
            {
                this.Close();
                MessageBox.Show("thành công");
                frm_ThemMoiThietKe frm = new frm_ThemMoiThietKe();
                frm.Show();
            }else
            {
                this.Close();
                MessageBox.Show("thất bại");                
            }
        }

        private int ConvertInt(string text)
        {
            return int.Parse(text);
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        bl_ThemMoi bl;
        private void frm_ThemMoiThietKe_Load(object sender, EventArgs e)
        {
            bl = new bl_ThemMoi();
            comboBox1.DataSource = bl.GetDanhMuc();
            comboBox1.DisplayMember = "ten";
            comboBox1.ValueMember = "id";
            open.Filter = "Image|*jpg;*jpeg;*git;*bmp";
        }

        OpenFileDialog open = new OpenFileDialog();
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(open.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(open.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
