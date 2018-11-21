using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS.BL
{
    class bl_ThongTinChiTiet
    {
        DA.Model1 db;
        
        public bl_ThongTinChiTiet()
        {
            db = new DA.Model1();

        }

        public DA.tbKHACHHANG GetKhachHang(int id)
        {
            return db.tbKHACHHANGs.Find(id);
        }
        
        public DA.tbCHITIETTHIETKE GetChiTiet(int id)
        {
            return db.tbCHITIETTHIETKEs.FirstOrDefault(x => x.id_thietke == id);
        }

        
    }
}
