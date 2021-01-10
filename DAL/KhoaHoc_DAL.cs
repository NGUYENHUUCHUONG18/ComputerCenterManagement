using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaHoc_DAL:dataContext
    {
        KhoaHoc kh = new KhoaHoc();
        public List<KhoaHoc> LoadKH()
        {
            return qltt.KhoaHocs.Select(t => t).ToList<KhoaHoc>();
        }

        public string TaoMa()
        {
            string ma;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma = "KH" + so.ToString();
        }
        public int Them_KH(string m, string t, string nbd, string nkt)
        {
            try
            {
                kh.MaKH = m;
                kh.TenKH = t;
                kh.NgayBD = DateTime.Parse(nbd);
                kh.NgayKT = DateTime.Parse(nkt);
                qltt.KhoaHocs.InsertOnSubmit(kh);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }

        }

        public int Sua_KH(string m, string t, string nbd, string nkt)
        {

            try
            {
                kh = qltt.KhoaHocs.Where(tt => tt.MaKH == m).FirstOrDefault();
                kh.TenKH = t;
                kh.NgayBD = DateTime.Parse(nbd);
                kh.NgayKT = DateTime.Parse(nkt);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa_KH(string m)
        {

            try
            {
                kh = qltt.KhoaHocs.Where(t => t.MaKH == m).FirstOrDefault();
                qltt.KhoaHocs.DeleteOnSubmit(kh);
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
