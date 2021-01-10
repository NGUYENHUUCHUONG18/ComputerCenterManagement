using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class Lop_DAL : dataContext
    {
        Lop1 l = new Lop1();
        public List<Lop1> LoadL()
        {
            return qltt.Lop1s.Select(t => t).ToList<Lop1>();
        }

        public List<PhongHoc> Load_cbxPH()
        {
            return qltt.PhongHocs.Select(t1 => t1).ToList<PhongHoc>();
        }

        public List<KhoaHoc> Load_cbxKH()
        {
            return qltt.KhoaHocs.Select(t2 => t2).ToList<KhoaHoc>();
        }

        public List<ChungChi> Load_cbxCC()
        {
            return qltt.ChungChis.Select(t3 => t3).ToList<ChungChi>();
        }

        public List<CaHoc> Load_cbxCH()
        {
            return qltt.CaHocs.Select(t => t).ToList<CaHoc>();
        }

        public string TaoMa()
        {
            string ma1;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma1 = "L" + so.ToString();
        }

        public int Them_L(string ml, string mp, string ss, string mk, string mcc, string mch, string nbd)
        {
            try
            {
                l.MaLop = ml;
                l.MaPhong = mp;
                l.SiSo = int.Parse(ss);
                l.MaKhoa = mk;
                l.MaCC = mcc;
                l.MaCaHoc = mch;
                l.NgayBD = DateTime.Parse(nbd);
                qltt.Lop1s.InsertOnSubmit(l);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }

        }

        public int Sua_L(string ml,string mp, string ss, string mk, string mcc, string mch, string nbd)
        {

            try
            {
                l = qltt.Lop1s.Where(tt => tt.MaLop == ml).FirstOrDefault();
                l.MaPhong = mp;
                l.SiSo = int.Parse(ss);
                l.MaKhoa = mk;
                l.MaCC = mcc;
                l.MaCaHoc = mch;
                l.NgayBD = DateTime.Parse(nbd);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa_L(string m)
        {

            try
            {
                l = qltt.Lop1s.Where(t => t.MaLop == m).FirstOrDefault();
                qltt.Lop1s.DeleteOnSubmit(l);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public List<PhongHoc> Load_dgvPHFLcbxPH(string mph)
        {
            return qltt.PhongHocs.Where(t => t.MaPhong == mph).ToList<PhongHoc>();
        }
    }
}
