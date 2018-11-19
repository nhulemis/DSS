using DSS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSS.DA;

namespace DSS.UI
{
    public partial class frm_DangNhap : Form
    {
        BL.bl_ThemMoi bl = new BL.bl_ThemMoi();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login() != null)
            {
                Constants.KIENTRUCSU = Login();
                this.Close();
                frm_ThemMoiThietKe frm = new frm_ThemMoiThietKe();
                frm.Show();
            }
            else
                MessageBox.Show("sai mật khẩu hoặc email");

            
        }

        private tbKIENTRUCSU Login()
        {
            return bl.Login(txtEmail.Text, txtPass.Text);
        }
    }
}
