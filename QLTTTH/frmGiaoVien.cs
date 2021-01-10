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
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        GiaoVien_DAL gv = new GiaoVien_DAL();
        public frmGiaoVien()
        {
            InitializeComponent();
            dgvGV.DataSource = gv.LoadGV();
            txtMaGV.Enabled = false;
            txtMaGV.Text = gv.TaoMa();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenGV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên giảng viên", "Thông báo");
                txtTenGV.Focus();
            }
            else
            {
                if (gv.Them_GV(txtMaGV.Text, txtTenGV.Text, dtpNgaySinh.Value.ToString(), cbxPhai.SelectedItem.ToString(), txtDC.Text, txtEmail.Text, number1.Text) == 1)
                {
                    MessageBox.Show("Thêm giảng viên thành công", "Thông báo");
                    dgvGV.DataSource = gv.LoadGV();
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên thất bại", "Thông báo");
                }
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (gv.Sua_GV(dgvGV.CurrentRow.Cells[0].Value.ToString(), txtTenGV.Text, dtpNgaySinh.Value.ToString(), cbxPhai.SelectedItem.ToString(), txtDC.Text, txtEmail.Text, number1.Text) == 1)
            {
                MessageBox.Show("Sửa thông tin giảng viên thành công", "Thông báo");
                dgvGV.DataSource = gv.LoadGV();
            }
            else
            {
                MessageBox.Show("Sửa thông tin giảng viên thất bại", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa giảng viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (gv.Xoa_GV(dgvGV.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa giảng viên thành công", "Thông báo");
                    dgvGV.DataSource = gv.LoadGV();
                    Huy();
                }
                else
                {
                    MessageBox.Show("Xóa giảng viên thất bại", "Thông báo");
                }
            }
        }
        private void Huy()
        {
            txtMaGV.Text = gv.TaoMa();
            txtTenGV.Clear();
            txtEmail.Clear();
            txtDC.Clear();
            number1.Clear();
            dtpNgaySinh.ResetText();
            txtTenGV.Focus();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Huy();
        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            txtMaGV.Text = dgvGV.Rows[n].Cells[0].Value.ToString();
            txtTenGV.Text = dgvGV.Rows[n].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvGV.Rows[n].Cells[2].Value.ToString();
            cbxPhai.Text= dgvGV.Rows[n].Cells[3].Value.ToString();
            txtDC.Text = dgvGV.Rows[n].Cells[4].Value.ToString();
            txtEmail.Text= dgvGV.Rows[n].Cells[5].Value.ToString();
            number1.Text= dgvGV.Rows[n].Cells[6].Value.ToString();
        }
    }
}