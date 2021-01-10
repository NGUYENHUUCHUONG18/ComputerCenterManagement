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
    public partial class frmChungChi : DevExpress.XtraEditors.XtraForm
    {
        ChungChi_DAL cc = new ChungChi_DAL();
        public frmChungChi()
        {
            InitializeComponent();
            txtMCC.Enabled = false;
            txtMCC.Text = cc.TaoMa();
            dgvCC.DataSource = cc.LoadCC();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chứng chỉ", "Thông báo");
                txtTenCC.Focus();
            }
            else
            {
                if (cc.Them_CC(txtMCC.Text, txtTenCC.Text, txtMoTa.Text, txtHP.Text) == 1)
                {
                    MessageBox.Show("Thêm chứng chỉ thành công", "Thông báo");
                    dgvCC.DataSource = cc.LoadCC();
                    txtMCC.Text = cc.TaoMa();
                    txtTenCC.Clear();
                    txtMoTa.Clear();
                    txtHP.Clear();
                    txtMCC.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm chứng chỉ thất bại", "Thông báo");
                }
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cc.Sua_CC(dgvCC.CurrentRow.Cells[0].Value.ToString(), txtTenCC.Text, txtMoTa.Text, txtHP.Text) == 1)
            {
                MessageBox.Show("Sửa thông tin chứng chỉ thành công", "Thông báo");
                dgvCC.DataSource = cc.LoadCC();
            }
            else
            {
                MessageBox.Show("Sửa thông tin chứng chỉ thất bại", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (cc.Xoa_CC(dgvCC.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa chứng chỉ thành công", "Thông báo");
                    dgvCC.DataSource = cc.LoadCC();
                }
                else
                {
                    MessageBox.Show("Xóa chứng chỉ thất bại", "Thông báo");
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            txtMCC.Text = dgvCC.Rows[n].Cells[0].Value.ToString();
            txtTenCC.Text = dgvCC.Rows[n].Cells[1].Value.ToString();
            txtMoTa.Text = dgvCC.Rows[n].Cells[2].Value.ToString();
            txtHP.Text = dgvCC.Rows[n].Cells[3].Value.ToString();
        }
    }
}