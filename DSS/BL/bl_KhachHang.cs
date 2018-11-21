using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS.BL
{
    class bl_KhachHang
    {
        DA.Model1 db;
        public bl_KhachHang()
        {
            db = new DA.Model1();
        }

        public int ThemKhachHang(DA.tbKHACHHANG model)
        {
            db.tbKHACHHANGs.Add(model);
            db.SaveChanges();
            return model.id;
        }

        public void LuaChonThietKe(DA.tbLUACHONTHIETKE model)
        {
            db.tbLUACHONTHIETKEs.Add(model);
            db.SaveChanges();
        }
    }
}
