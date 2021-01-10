using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongHoc_DAL : dataContext
    {
        PhongHoc ph = new PhongHoc();
        public List<PhongHoc> LoadPH()
        {
            return qltt.PhongHocs.Select(t => t).ToList<PhongHoc>();
        }

        public string TaoMa()
        {
            string ma;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma = "PH" + so.ToString();
        }
            public int Them_PH(string m, string t, string sc )
        {
            try
            {
                ph.MaPhong = m;
                ph.TenPhong = t;
                ph.SucChua = int.Parse(sc);
                qltt.PhongHocs.InsertOnSubmit(ph);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }

        }

        public int Sua_PH(string m, string t, string sc)
        {
            
            try
            {
                ph = qltt.PhongHocs.Where(tt => tt.MaPhong == m).FirstOrDefault();
                ph.TenPhong = t;
                ph.SucChua = int.Parse(sc);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa_PH(string m)
        {
            
            try
            {
                ph = qltt.PhongHocs.Where(t => t.MaPhong == m).FirstOrDefault();
                qltt.PhongHocs.DeleteOnSubmit(ph);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
