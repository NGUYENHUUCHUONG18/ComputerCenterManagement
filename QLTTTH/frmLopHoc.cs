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
    public partial class frmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        Lop_DAL l = new Lop_DAL();
        public frmLopHoc()
        {
            InitializeComponent();
            txtLop.Text = l.TaoMa();
            txtLop.Enabled = false;
            dgvL.DataSource = l.LoadL();
            cbxPH.DataSource = l.Load_cbxPH();
            cbxPH.DisplayMember = "TenPhong";
            cbxPH.ValueMember = "MaPhong";
            cbKhoa.DataSource = l.Load_cbxKH();
            cbKhoa.DisplayMember = "TenKH";
            cbKhoa.ValueMember = "MaKH";
            cbCChi.DataSource = l.Load_cbxCC();
            cbCChi.DisplayMember = "TenCC";
            cbCChi.ValueMember = "MaCC";
            cbCaHoc.DataSource = l.Load_cbxCH();
            cbCaHoc.DisplayMember = "Thu";
            cbCaHoc.ValueMember = "MaCaHoc";
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if (l.Them_L(txtLop.Text, cbxPH.SelectedValue.ToString(), number1.Text, cbKhoa.SelectedValue.ToString(), cbCChi.SelectedValue.ToString(), cbCaHoc.SelectedValue.ToString(), dtpNgayBD.Value.ToString()) == 1)
            {

                MessageBox.Show("Thêm lớp học thành công", "Thông báo");
                dgvL.DataSource = l.LoadL();
            }
            else
            {
                MessageBox.Show("Thêm lớp học thất bại", "Thông báo");
            }


        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (l.Sua_L(dgvL.CurrentRow.Cells[0].Value.ToString(), cbxPH.SelectedItem.ToString(), number1.Text, cbKhoa.SelectedItem.ToString(), cbCChi.SelectedItem.ToString(), cbCaHoc.SelectedItem.ToString(), dtpNgayBD.Value.ToString()) == 1)
            {
                MessageBox.Show("Sửa thông tin lớp học thành công", "Thông báo");
                dgvL.DataSource = l.LoadL();
            }
            else
            {
                MessageBox.Show("Sửa thông tin lớp học thất bại", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa lớp học này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (l.Xoa_L(dgvL.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa lớp học thành công", "Thông báo");
                    dgvL.DataSource = l.LoadL();
                }
                else
                {
                    MessageBox.Show("Xóa lớp học thất bại", "Thông báo");
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

        }

        private void dgvL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            txtLop.Text = dgvL.Rows[n].Cells[0].Value.ToString();
            cbxPH.Text= dgvL.Rows[n].Cells[1].Value.ToString();
            number1.Text = dgvL.Rows[n].Cells[2].Value.ToString();
            cbKhoa.Text = dgvL.Rows[n].Cells[3].Value.ToString();
            cbCChi.Text = dgvL.Rows[n].Cells[4].Value.ToString();
            cbCaHoc.Text = dgvL.Rows[n].Cells[5].Value.ToString();
            dtpNgayBD.Text = dgvL.Rows[n].Cells[6].Value.ToString();
        }

        private void cbxPH_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvP.DataSource = l.Load_dgvPHFLcbxPH(cbxPH.SelectedValue.ToString());
        }

        private void number1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}