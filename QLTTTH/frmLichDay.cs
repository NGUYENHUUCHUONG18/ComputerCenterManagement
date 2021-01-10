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
using DAL;

namespace QLTTTH
{
    public partial class frmLichDay : DevExpress.XtraEditors.XtraForm
    {
        PhanCong_DAL pc = new PhanCong_DAL();
        public frmLichDay()
        {
            InitializeComponent();
            dataGridView1.DataSource = pc.Load_PhanCong();
        }


    }
}