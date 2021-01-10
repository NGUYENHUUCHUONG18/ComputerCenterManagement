using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace DAL
{
    public class PhanCong_DAL: dataContext
    {
        _PhanCong pc = new _PhanCong();
        public Object Load_dgvLop()
        {
            return from l in qltt.Lop1s
                   from c in qltt.CaHocs
                   where l.MaCaHoc == c.MaCaHoc

                   select new { l.MaLop, l.MaCC, l.MaPhong, c.Thu };
        }
        public Object Load_PhanCong()
        {
            return from pc in qltt._PhanCongs select new { pc.MaGV, pc.MaLop, pc.MaPhong, pc.Thu };
        }
        public Object Load_dgvGV()
        {
            //return qltt.GiangVien1s.Select(t => t).ToList<GiangVien1>();
            return from gv in qltt.GiangVien1s
                   from pc in qltt._PhanCongs
                   where gv.MaGV==pc.MaGV
                   select new { gv.MaGV, gv.HoTen, pc.MaLop };
        }

        public void Get_dataLop(string ml, TextEdit cc, TextEdit p)
        {
            var lops = qltt.Lop1s.Select(t => t).ToList();
            foreach(var n in lops)
            {
                if(n.MaLop.Trim() == ml.Trim())
                {
                    n.MaCC = cc.Text;
                    n.MaPhong = p.Text;
                }
            }
        }

        public string TaoMa()
        {
            string ma1;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma1 = "MPC" + so.ToString();
        }

        public List<String> Load_cbxLop()
        {
            return qltt.Lop1s.Select(t => t.MaLop).ToList<String>();
        }

        public bool PhanCong(string mpc, string mgv, string ml, string mcc, string mp, string t)
        {
            try
            {
                pc.MaPhanCong = mpc;
                pc.MaGV = mgv;
                pc.MaLop = ml;
                pc.MaCC = mcc;
                pc.MaPhong = mp;
                pc.Thu = t;
                qltt._PhanCongs.InsertOnSubmit(pc);
                qltt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhat(string mpc, string mgv, string ml, string mcc, string mp, string t)
        {
            try
            {
                pc = qltt._PhanCongs.Where(tt => tt.MaPhanCong == mpc).FirstOrDefault();
                pc.MaGV = mgv;
                pc.MaLop = ml;
                pc.MaCC = mcc;
                pc.MaPhong = mp;
                pc.Thu = t;
                qltt.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
