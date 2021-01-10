using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace QLTTTH
{
    public class user
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.TT_TinHocConnectionString == string.Empty)
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.TT_TinHocConnectionString);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }

        public LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='" + pUser + "'and MatKhau ='" + pPass + "'", Properties.Settings.Default.TT_TinHocConnectionString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "false")
            {
                return LoginResult.Disabled;
            }
            return LoginResult.Success;
        }

        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public List<String> GetDBName(string pServer, string pUser, string pPass)
        {
            List<String> _list = new List<string>();
            
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + ";");
                da.Fill(dt);
                foreach(System.Data.DataRow row in  dt.Rows)
                {
                    foreach(System.Data.DataColumn col in dt.Columns)
                    {
                        _list.Add(row[col].ToString());
                    }
                }
            }
            catch { return null; }
            return _list;
            
        }


        public void SaveConfig(string pServer, string pUser, string pPass, string pDBName)
        {
            //QLTTTH.Properties.Settings.Default.TT_TinHocConnectionString = "Datasource" + pServer + ";Initial Catalog=" + pDBName + ";User ID=" + pUser + ";pwd=" + pPass + "";
            QLTTTH.Properties.Settings.Default.Save();
        }

        
    }
}
