using DSS.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS.BL
{
    class bl_TuVan
    {

        Model1 db;

        public bl_TuVan()
        {
            db = new Model1();
        }

        public List<tbTHIETKE> TruyVan()
        {
            return db.tbTHIETKEs.ToList();
        }

        public List<tbTHIETKE> TruyVan(int dai,int rong,float tien)
        {

            var result = from x in db.tbTHIETKEs
                         from x1 in db.tbCHIPHIs
                         where x.id == x1.id_thietke && x1.uoctinhchiphi <= tien + 20 && x.dai<=dai && x.rong <=rong
                         select x;
            return result.ToList();
        }

        public List<tbTHIETKE> TruyVan(int id_kieu)
        {

            var result = from x in db.tbTHIETKEs
                         where x.id_danhmuc == id_kieu
                         select x;
            return result.ToList();
        }

        public List<tbHINHANHTHIETKE> HinhAnh(int id_thietke)
        {
            return db.tbHINHANHTHIETKEs.Where(x => x.id_thietke == id_thietke).ToList();
        }

        public List<tbCHITIETTHIETKE> ChiTiet(int id_thietket)
        {
            return db.tbCHITIETTHIETKEs.Where(x => x.id_thietke == id_thietket).ToList();
        }

        public List<tbCHIPHI> ChiPhi(int index)
        {
            return db.tbCHIPHIs.Where(x => x.id_thietke == index).ToList();
        }
    }
}
