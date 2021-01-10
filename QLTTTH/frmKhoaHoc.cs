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
    public partial class frmKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        KhoaHoc_DAL kh = new KhoaHoc_DAL();
        public frmKhoaHoc()
        {
            InitializeComponent();
            txtMaKH.Enabled = false;
            txtMaKH.Text = kh.TaoMa();
            dgvKH.DataSource = kh.LoadKH();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khóa học", "Thông báo");
                txtTenKH.Focus();
            }
            else if(dtpNgayBD.Value.Date> dtpNgayKT.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu phải bé hơn ngày kết thúc");
            }
            else
            {
                if (kh.Them_KH(txtMaKH.Text, txtTenKH.Text, dtpNgayBD.Value.ToString(), dtpNgayKT.Value.ToString()) == 1)
                {
                    MessageBox.Show("Thêm khóa học thành công", "Thông báo");
                    dgvKH.DataSource = kh.LoadKH();
                    Huy();
                }
                else
                {
                    MessageBox.Show("Thêm khóa học thất bại", "Thông báo");
                }
            }

        }

        private void Huy()
        {
            txtMaKH.Text = kh.TaoMa();
            txtTenKH.Clear();
            dtpNgayBD.ResetText();
            dtpNgayKT.ResetText();
            txtTenKH.Focus();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (kh.Sua_KH(dgvKH.CurrentRow.Cells[0].Value.ToString(), txtTenKH.Text, dtpNgayBD.Value.ToString(), dtpNgayKT.Value.ToString()) == 1)
            {
                MessageBox.Show("Sửa thông tin khóa học thành công", "Thông báo");
                dgvKH.DataSource = kh.LoadKH();
            }
            else
            {
                MessageBox.Show("Sửa thông tin khóa học thất bại", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (kh.Xoa_KH(dgvKH.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa khóa học thành công", "Thông báo");
                    dgvKH.DataSource = kh.LoadKH();
                }
                else
                {
                    MessageBox.Show("Xóa khóa học thất bại", "Thông báo");
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Huy();
        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            txtMaKH.Text = dgvKH.Rows[n].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKH.Rows[n].Cells[1].Value.ToString();
            dtpNgayBD.Text = dgvKH.Rows[n].Cells[2].Value.ToString();
            dtpNgayKT.Text = dgvKH.Rows[n].Cells[3].Value.ToString();
        }
    }
}