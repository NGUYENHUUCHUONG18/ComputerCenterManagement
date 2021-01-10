using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiaoVien_DAL : dataContext
    {
        GiangVien1 gv = new GiangVien1();
        public List<GiangVien1> LoadGV()
        {
            return qltt.GiangVien1s.Select(t => t).ToList<GiangVien1>();
        }

        public string TaoMa()
        {
            string ma;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma = "GV" + so.ToString();
        }

        public int Them_GV(string m, string t, string ns, string p, string dc, string em, string dt)
        {
            try
            {
                gv.MaGV = m;
                gv.HoTen = t;
                gv.NgaySinh = DateTime.Parse(ns);
                gv.Phai = p;
                gv.DiaChi = dc;
                gv.SDT = int.Parse(dt);
                gv.Mail = em;

                qltt.GiangVien1s.InsertOnSubmit(gv);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
            
        }

        public int Sua_GV(string m, string t, string ns, string p, string dc, string em, string dt)
        {

            
            try
            {
                gv = qltt.GiangVien1s.Where(tt => tt.MaGV == m).FirstOrDefault();

                gv.HoTen = t;
                gv.NgaySinh = DateTime.Parse(ns);
                gv.Phai = p;
                gv.DiaChi = dc;
                gv.SDT = int.Parse(dt);
                gv.Mail = em;

                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa_GV(string m)
        {


            try
            {
                gv = qltt.GiangVien1s.Where(tt => tt.MaGV == m).FirstOrDefault();

                qltt.GiangVien1s.DeleteOnSubmit(gv);

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
