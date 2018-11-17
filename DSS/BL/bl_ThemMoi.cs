using DSS.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS.BL
{
    class bl_ThemMoi
    {
        Model1 db;

        public bl_ThemMoi()
        {
            db = new Model1();
        }

        public List<tbDANHMUCTHIETKE> GetDanhMuc()
        {
            return db.tbDANHMUCTHIETKEs.ToList();
        }

        public bool ThemMoiBangVe(int dai,int rong)//,int tang,int khach,int ngu,int vs,int bep,string truocsau,byte[] hinh1, byte[] hinh2, byte[] hinh3)
        {
            tbTHIETKE tk = new tbTHIETKE();
            tk.dai = dai;
            tk.rong = rong;           
            db.SaveChanges();
            var x = tk.id;
            tbCHITIETTHIETKE ct = new tbCHITIETTHIETKE();
            //ct.solau = tang;
            //ct.sophongkhach = khach;
            //ct.sophongngu = ngu;
            //ct.sophongvesinh = vs;
            //ct.sophongbep = bep;
            //ct.santruoc_sau = truocsau;
            //ct.id_thietke = tk.id;
            return false;
        }
    }
}
