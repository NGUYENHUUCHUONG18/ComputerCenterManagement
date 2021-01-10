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
    public partial class frmCaHoc : DevExpress.XtraEditors.XtraForm
    {
        CaHoc_DAL ch = new CaHoc_DAL();
        PhongHoc_DAL p = new PhongHoc_DAL();
        public frmCaHoc()
        {
            InitializeComponent();
            txtMaTGH.Enabled = false;
            txtMaTGH.Text = ch.TaoMa();
            dgvCH.DataSource = ch.LoadCH();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
                if (ch.Them_CH(txtMaTGH.Text, cbThu.SelectedItem.ToString(), txtGio.Text) == 1)
                {
                    MessageBox.Show("Thêm ca học thành công", "Thông báo");
                    dgvCH.DataSource = ch.LoadCH();
                    txtMaTGH.Text = ch.TaoMa();
                txtGio.Clear();
                cbThu.Focus();
            }
                else
                {
                    MessageBox.Show("Thêm ca học thất bại", "Thông báo");
                }
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (ch.Sua_CH(dgvCH.CurrentRow.Cells[0].Value.ToString(), cbThu.SelectedItem.ToString(), txtGio.Text) == 1)
            {
                MessageBox.Show("Sửa thông tin ca học thành công", "Thông báo");
                dgvCH.DataSource = ch.LoadCH();
            }
            else
            {
                MessageBox.Show("Sửa thông tin ca học thất bại", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa ca học này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (ch.Xoa_CH(dgvCH.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa ca học thành công", "Thông báo");
                    dgvCH.DataSource = ch.LoadCH();
                }
                else
                {
                    MessageBox.Show("Xóa ca học thất bại", "Thông báo");
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            txtMaTGH.Text = dgvCH.Rows[n].Cells[0].Value.ToString();
            cbThu.Text = dgvCH.Rows[n].Cells[1].Value.ToString();
            txtGio.Text = dgvCH.Rows[n].Cells[2].Value.ToString();
        }
    }
}