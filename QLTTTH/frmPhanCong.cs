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
    public partial class frmPhanCong : DevExpress.XtraEditors.XtraForm
    {
        PhanCong_DAL pc = new PhanCong_DAL();
        public frmPhanCong()
        {
            InitializeComponent();
            dgvL.DataSource = pc.Load_dgvLop();
            dgvGV.DataSource = pc.Load_dgvGV();
            cbxLop.DataSource = pc.Load_cbxLop();
            txtMPC.Text = pc.TaoMa();
        }

        private void dgvL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            cbxLop.Text = dgvL.Rows[n].Cells[0].Value.ToString();
            txtChungChi.Text = dgvL.Rows[n].Cells[1].Value.ToString();
            txtPhong.Text = dgvL.Rows[n].Cells[2].Value.ToString();
            cbxThu.Text = dgvL.Rows[n].Cells[3].Value.ToString();
            
        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            cbxGV.Text = dgvGV.Rows[n].Cells[0].Value.ToString();
            txtTenGV.Text = dgvGV.Rows[n].Cells[1].Value.ToString();
            txtDangDay.Text = dgvGV.Rows[n].Cells[2].Value.ToString();
            
        }

        private void cbxLop_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxLop_TextChanged(object sender, EventArgs e)
        {
            pc.Get_dataLop(cbxLop.SelectedValue.ToString(), txtChungChi, txtPhong);
        }

        private void btPhanCong_Click(object sender, EventArgs e)
        {
            if(pc.PhanCong(txtMPC.Text, cbxGV.SelectedValue.ToString(), cbxLop.SelectedValue.ToString(), txtChungChi.Text, txtPhong.Text, txtDangDay.Text))
            {
                MessageBox.Show("Phân công thành công", "Thông báo");
                dgvGV.DataSource = pc.Load_dgvGV();
                txtMPC.Text = pc.TaoMa();
                txtMPC.Text = pc.TaoMa();
                
            }
        }
    }
}