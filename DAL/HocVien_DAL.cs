using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocVien_DAL : dataContext
    {
        HocVien1 hv = new HocVien1();

        public List<HocVien1> LoadHV()
        {
            return qltt.HocVien1s.Select(t => t).ToList<HocVien1>();
        }

        public string TaoMa()
        {
            string ma;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma = "HV" + so.ToString();
        }

        public int Them_HV(string m, string t, string ns, string p, string dc,string dv, string em, string dt)
        {
            try
            {
                hv.MaHV = m;
                hv.HoTen = t;
                
                hv.NgaySinh = DateTime.Parse(ns);
                hv.GioiTinh = p;
                hv.DiaChi = dc;
                hv.DonViCongTac = dv;
                hv.Mail = em;
                hv.SDT = int.Parse(dt);
                qltt.HocVien1s.InsertOnSubmit(hv);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Sua_HV(string m, string t, string ns, string p, string dc, string dv, string em, string dt)
        {
            try
            {
                hv = qltt.HocVien1s.Where(tt => tt.MaHV == m).FirstOrDefault();
                hv.MaHV = m;
                hv.HoTen = t;

                hv.NgaySinh = DateTime.Parse(ns);
                hv.GioiTinh = p;
                hv.DiaChi = dc;
                hv.DonViCongTac = dv;
                hv.Mail = em;
                hv.SDT = int.Parse(dt);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa_HV(string m)
        {
            try
            {
                hv = qltt.HocVien1s.Where(t => t.MaHV == m).FirstOrDefault();
                qltt.HocVien1s.DeleteOnSubmit(hv);
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
