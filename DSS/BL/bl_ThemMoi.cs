using DSS.Common;
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

        public bool ThemMoiBangVe(int dai, int rong, int loai, int tang, int khach, int ngu, int vs, int bep, string truocsau, List<byte[]> hinh)
        {
            try
            {
                tbTHIETKE tk = new tbTHIETKE();
                tk.dai = dai;
                tk.rong = rong;
                tk.id_danhmuc = loai;
                db.tbTHIETKEs.Add(tk);
                db.SaveChanges();
                // var x = tk.id;
                tbCHITIETTHIETKE ct = new tbCHITIETTHIETKE();
                ct.solau = tang;
                ct.tongsophong = khach + ngu + bep;
                ct.sophongkhach = khach;
                ct.sophongngu = ngu;
                ct.sophongvesinh = vs;
                ct.sophongbep = bep;
                ct.santruoc_sau = truocsau;
                ct.id_thietke = tk.id;
                db.tbCHITIETTHIETKEs.Add(ct);
                db.SaveChanges();
                for (int i = 0; i < 3; i++)
                {
                    tbHINHANHTHIETKE hinh1 = new tbHINHANHTHIETKE();
                    hinh1.hinhanh = hinh[i];
                    hinh1.id_thietke = tk.id;
                    db.tbHINHANHTHIETKEs.Add(hinh1);
                    db.SaveChanges();
                }

                tbKIENTRUCTHIETKE kttk = new tbKIENTRUCTHIETKE();
                kttk.id_kientrucsu = Constants.KIENTRUCSU.id;
                kttk.id_thietke = tk.id;
                kttk.ngay = DateTime.Now;
                db.tbKIENTRUCTHIETKEs.Add(kttk);
                db.SaveChanges();
                TinhToanChiTiet(tk.id, dai, rong, tang, khach + ngu + bep);
                return true;
            }
            catch (Exception)
            {
                return false;
            }           
        }

        public bool TinhToanChiTiet(int id,int dai,int rong,int tang,int sophong)
        {
            try
            {
                double x = (((dai + rong) * 2 * 4 * tang) + ((dai + rong) * 2 * 4 * tang) / 3) / (0.2 * 0.5 * 1000);
                tbCHIPHI cp = new tbCHIPHI();
                cp.gach = (int)x+1;
                cp.gachlot = (dai * rong * tang);
                cp.xi = (((dai + rong) * 2 * 4 * tang) + ((dai + rong) * 2 * 4 * tang) / 3) / 4;
                cp.son = ((dai + rong) * 2 * 4 * tang) / 20;
                cp.id_thietke = id;
                cp.uoctinhchiphi = cp.gach * 2.5 + cp.gachlot * 0.4 + cp.son +50*tang+cp.xi/10*0.5;
                db.tbCHIPHIs.Add(cp);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public tbKIENTRUCSU Login(string email, string pass)
        {
            return db.tbKIENTRUCSUs.FirstOrDefault(x => x.email == email && x.pass == pass);
        }
    }
}
