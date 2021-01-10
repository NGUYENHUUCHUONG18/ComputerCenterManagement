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
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        PhongHoc_DAL p = new PhongHoc_DAL();
        public frmPhong()
        {
            InitializeComponent();
            dgvP.DataSource = p.LoadPH();
            txtMaPH.Text = p.TaoMa();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            p.Them_PH(txtMaPH.Text, txtTenPhong.Text, number2.Text);





            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Thông báo");
                txtTenPhong.Focus();
            }
            else
            {
                if (p.Them_PH(txtMaPH.Text, txtTenPhong.Text, number2.Text) == 1)
                {
                    MessageBox.Show("Thêm phòng thành công", "Thông báo");
                    dgvP.DataSource = p.LoadPH();
                    txtMaPH.Text = p.TaoMa();
                    txtTenPhong.Clear();
                    number2.Clear();
                    txtTenPhong.Focus();

                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại", "Thông báo");
                }
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (p.Sua_PH(dgvP.CurrentRow.Cells[0].Value.ToString(), txtTenPhong.Text, number2.Text) == 1)
            {
                MessageBox.Show("Sửa thông tin phòng thành công", "Thông báo");
                dgvP.DataSource = p.LoadPH();
            }
            else
            {
                MessageBox.Show("Sửa thông tin phòng thất bại", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (p.Xoa_PH(dgvP.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa phòng thành công", "Thông báo");
                    dgvP.DataSource = p.LoadPH();
                }
                else
                {
                    MessageBox.Show("Xóa phòng thất bại", "Thông báo");
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMaPH.Text = p.TaoMa();
            txtTenPhong.Clear();
            number2.Clear();
        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            txtMaPH.Text = dgvP.Rows[n].Cells[0].Value.ToString();
            txtTenPhong.Text= dgvP.Rows[n].Cells[1].Value.ToString();
            number2.Text = dgvP.Rows[n].Cells[2].Value.ToString();
        }
    }
}