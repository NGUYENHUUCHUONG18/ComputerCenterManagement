using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangKy_DAL: dataContext
    {
        ChungChi cc = new ChungChi();
        BienLai bl = new BienLai();
        public List<ChungChi> Load_cbxCC()
        {
            return qltt.ChungChis.Select(t => t).ToList<ChungChi>();
        }

        public List<HocVien1> Load_cbxHV()
        {
            return qltt.HocVien1s.Select(t => t).ToList<HocVien1>();
        }

        public List<Lop1> Load_dgvLFLcbxCC (string mcc)
        {
            return qltt.Lop1s.Where(t => t.MaCC == mcc).ToList<Lop1>();
        }

        public void HT_txtSoTien(string mcc, TextEdit st)
        {
            //var sotiens = (from c in qltt.ChungChis select new { c.HocPhi }).ToList();
            var sotiens1 = qltt.ChungChis.Select(t => t).ToList();
            foreach (var p in sotiens1)
            {
                if (p.MaCC.Trim() == mcc.Trim())
                {
                    p.HocPhi = float.Parse(st.Text);
                   
                }


            }
            //return from c in qltt.ChungChis where c.MaCC == mcc select new { c.HocPhi };
        }

        public bool ThemBL(string m, string mhv, string ndk, string l, string tc)
        {
            try
            {
                bl.MaPhieu = m;
                bl.MaHV = mhv;
                bl.NgayLap = DateTime.Parse(ndk);
                bl.MaLop = l;
                bl.TongThu = float.Parse(tc);
                qltt.BienLais.InsertOnSubmit(bl);
                qltt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

       
        

        //public List<HocVien1> Load_cbxHVFLdgvL(int ABC)
        //{
        //    var hocviens =
        //        from l in qltt.Lop1s
        //        from bl in qltt.BienLais
        //        from hv in qltt.HocVien1s
        //        where l.MaLop == bl.MaLop && bl.MaHV == hv.MaHV
        //        select new { hv.MaHV , hv.HoTen};

        //    return hocviens.ToList<string>();
        //}
        public Object getmasv(string malop)
        {
            return from l in qltt.Lop1s
                   from bl in qltt.BienLais
                   from hv in qltt.HocVien1s
                   where l.MaLop == bl.MaLop && bl.MaHV == hv.MaHV && bl.MaLop == malop

                   select new { hv.MaHV, hv.HoTen };
        }

        public void txtTensv(string ml, TextEdit m)
        {
            var kq = qltt.HocVien1s.Select(t => t).ToList();
            foreach(var n in kq)
            {
                if(n.MaHV.Trim() == ml.Trim())
                {
                    n.MaHV = m.Text;
                }
            }
        }

        public string TaoMa()
        {
            string ma;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma = "BL" + so.ToString();
        }

        public void HT_txtHV(string mhv, TextEdit m, TextEdit t, TextEdit p, TextEdit ns, TextEdit dc, TextEdit mail, TextEdit sdt)
        {
            //var hocviens = (from hv in qltt.HocVien1s select new { hv.MaHV, hv.HoTen, hv.GioiTinh, hv.NgaySinh,hv.DiaChi,hv.Mail,hv.SDT }).ToList();
            var hocviens = qltt.HocVien1s.Select(tt => tt).ToList();
            foreach (var h in hocviens)
            {
                if (h.MaHV.Trim() == mhv.Trim())
                {
                    h.MaHV = m.Text;
                    h.HoTen = t.Text;
                    h.GioiTinh = p.Text;
                    h.NgaySinh = DateTime.Parse(ns.Text);
                    h.DiaChi = dc.Text;
                    h.MaHV = mail.Text;
                    h.SDT = int.Parse(sdt.Text);

                }
            }
        }

    }
}
