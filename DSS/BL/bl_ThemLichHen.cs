using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS.BL
{
    class lichhen
    {
        public String ten { get; set; }
        public String gio { get; set; }
        public String ghichu { get; set; }
    }

    class bl_ThemLichHen
    {
        DA.Model1 db;
        public bl_ThemLichHen()
        {
            db = new DA.Model1();
        }

        public void ThemLichHen(DA.tbLICHHEN model)
        {
            db.tbLICHHENs.Add(model);
            db.SaveChanges();
        }

        public DataTable GetLichHen(DateTime date)
        {
            var x = from lichhen in db.tbLICHHENs
                    from ho in db.tbKHACHHANGs
                    where lichhen.id_khachhang == ho.id && lichhen.ngay == date
                    orderby lichhen.gio ascending
                    select new
                    {
                        ten = ho.ho,
                        gio = lichhen.gio,
                       
                    };
            int i = x.Count();
            DataTable dt = new DataTable();
            dt.Columns.Add(
            new DataColumn()
            {
                DataType = System.Type.GetType("System.String"),//or other type
                ColumnName = "ten"      //or other column name
            }
                );
            dt.Columns.Add(
            new DataColumn()
            {
                DataType = System.Type.GetType("System.String"),//or other type
                ColumnName = "gio"      //or other column name
            }
                );
           
            foreach (var item in x)
            {
                DataRow row = dt.NewRow();
                row["ten"] = item.ten;
                row["gio"] = item.gio;
              
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
