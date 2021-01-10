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
    public partial class frmDSHV : DevExpress.XtraEditors.XtraForm
    {
        HocVien_DAL hv = new HocVien_DAL();
        public frmDSHV()
        {
            InitializeComponent();
            txtMaHV.Enabled = false;
            txtMaHV.Text = hv.TaoMa();
            dgvHV.DataSource = hv.LoadHV();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenHV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên học viên", "Thông báo");
                txtTenHV.Focus();
            }
            else
            {
                if (hv.Them_HV(txtMaHV.Text, txtTenHV.Text, dtpNgaySinh.Value.ToString(), cbxPhai.SelectedItem.ToString(), textBoxDC.Text,txtDonVi.Text, txtEmail.Text, number2.Text) == 1)
                {
                    MessageBox.Show("Thêm học viên thành công", "Thông báo");
                    dgvHV.DataSource = hv.LoadHV();
                    txtMaHV.Text = hv.TaoMa();
                    txtTenHV.Clear();
                    dtpNgaySinh.ResetText();
                    txtDonVi.Clear();
                    txtEmail.Clear();
                    number2.Clear();
                    textBoxDC.Clear();
                    txtTenHV.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm học viên thất bại", "Thông báo");
                }
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (hv.Sua_HV(dgvHV.CurrentRow.Cells[0].Value.ToString(), txtTenHV.Text, dtpNgaySinh.Value.ToString(), cbxPhai.SelectedItem.ToString(), textBoxDC.Text,txtDonVi.Text, txtEmail.Text, number2.Text) == 1)
            {
                MessageBox.Show("Sửa thông tin học viên thành công", "Thông báo");
                dgvHV.DataSource = hv.LoadHV();
            }
            else
            {
                MessageBox.Show("Sửa thông tin học viên thất bại", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa học viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (hv.Xoa_HV(dgvHV.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa học viên thành công", "Thông báo");
                    dgvHV.DataSource = hv.LoadHV();
                }
                else
                {
                    MessageBox.Show("Xóa học viên thất bại", "Thông báo");
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            txtMaHV.Text = dgvHV.Rows[n].Cells[0].Value.ToString();
            txtTenHV.Text = dgvHV.Rows[n].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvHV.Rows[n].Cells[2].Value.ToString();
            cbxPhai.Text = dgvHV.Rows[n].Cells[3].Value.ToString();
            textBoxDC.Text = dgvHV.Rows[n].Cells[4].Value.ToString();
            txtDonVi.Text= dgvHV.Rows[n].Cells[5].Value.ToString();
            txtEmail.Text = dgvHV.Rows[n].Cells[6].Value.ToString();
            number2.Text = dgvHV.Rows[n].Cells[7].Value.ToString();
        }

        private void btHuy_Click_1(object sender, EventArgs e)
        {
            number2.Clear();
        }
    }
}