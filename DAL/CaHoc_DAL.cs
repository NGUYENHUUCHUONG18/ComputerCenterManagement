using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CaHoc_DAL : dataContext
    {
        CaHoc ch = new CaHoc();
        public List<CaHoc> LoadCH()
        {
            return qltt.CaHocs.Select(t => t).ToList<CaHoc>();
        }

        public List<String> Load_cbxPhong()
        {
            return qltt.PhongHocs.Select(t => t.MaPhong).ToList<String>();
        }

        public string TaoMa()
        {
            string ma;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma = "Ca" + so.ToString();
        }
        public int Them_CH(string m, string t, string gio)
        {
            try
            {
                ch.MaCaHoc = m;
                ch.Thu = t;
                ch.Gio = TimeSpan.Parse(gio); 
                qltt.CaHocs.InsertOnSubmit(ch);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }

        }

        public int Sua_CH(string m, string t, string gio)
        {

            try
            {
                ch = qltt.CaHocs.Where(tt => tt.MaCaHoc == m).FirstOrDefault();
                ch.Thu = t;
                ch.Gio = TimeSpan.Parse(gio);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa_CH(string m)
        {

            try
            {
                ch = qltt.CaHocs.Where(t => t.MaCaHoc == m).FirstOrDefault();
                qltt.CaHocs.DeleteOnSubmit(ch);
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
