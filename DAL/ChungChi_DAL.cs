using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class ChungChi_DAL: dataContext
    {
        ChungChi cc = new ChungChi();
        public List<ChungChi> LoadCC()
        {
            return qltt.ChungChis.Select(t => t).ToList<ChungChi>();
        }

        public string TaoMa()
        {
            string ma;
            Random ran = new Random();
            int so = ran.Next(0, 999);
            return ma = "CC" + so.ToString();
        }
        public int Them_CC(string m, string t, string mt, string hp)
        {
            try
            {
                cc.MaCC = m;
                cc.TenCC = t;
                cc.MoTa = mt;
                cc.HocPhi =float.Parse(hp);
                qltt.ChungChis.InsertOnSubmit(cc);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }

        }

        public int Sua_CC(string m, string t, string mt, string hp)
        {

            try
            {
                cc = qltt.ChungChis.Where(tt => tt.MaCC == m).FirstOrDefault();
                cc.TenCC = t;
                cc.MoTa = mt;
                cc.HocPhi = float.Parse(hp);
                qltt.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa_CC(string m)
        {

            try
            {
                cc = qltt.ChungChis.Where(t => t.MaCC == m).FirstOrDefault();
                qltt.ChungChis.DeleteOnSubmit(cc);
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
