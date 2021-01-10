using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QLTTTH
{
    public partial class frmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        user CauHinh = new user();
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void cbxSVN_DropDown(object sender, EventArgs e)
        {
            DataTable dt = CauHinh.GetServerName();
            cbxSVN.Items.Clear();
            foreach(System.Data.DataRow row in dt.Rows)
            {
                foreach(System.Data.DataColumn col in dt.Columns)
                {
                    cbxSVN.Items.Add(row[col]);
                }
            }
        }

        private void cbxDB_DropDown(object sender, EventArgs e)
        {
            cbxDB.Items.Clear();
            List<String> _list = CauHinh.GetDBName(cbxDB.Text, txtUSN.Text, txtPass.Text);
            if(_list==null)
            {
                MessageBox.Show("Thông tin cấu hình chưa chính xác");
                return;
            }
            foreach(string item in _list)
            {
                cbxDB.Items.Add(item);
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cbxSVN.SelectedItem.ToString(),cbxDB.SelectedItem.ToString(),txtUSN.Text,txtPass.Text);
            this.Close();
        }
    }
}