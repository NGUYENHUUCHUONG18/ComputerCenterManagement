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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        DangKy_DAL dk = new DangKy_DAL();
        
        public frmDangKy()
        {
            InitializeComponent();
            //groupBox1.Enabled = false;
            txtMaPhieu.Enabled = false;
            cbxMaCC.DataSource = dk.Load_cbxCC();
            cbxMaCC.DisplayMember = "TenCC";
            cbxMaCC.ValueMember = "MaCC";
            //cbHV.DataSource = dk.Load_cbxHV();
            //cbHV.DisplayMember = "HoTen";
            //cbHV.ValueMember = "MaHV";
            txtSoTien.Enabled = false;
            txtTong.Enabled = false;
            cbHV.Enabled = false;
            txtMaHV.Enabled = txtTenHV.Enabled = txtNS.Enabled = txtDC.Enabled = txtMail.Enabled=txtSDT.Enabled= txtPhai.Enabled = false;
            cbxMaCC.Enabled = false;
            txtMaPhieu.Text = dk.TaoMa();
        }

        private void btHocLai_Click(object sender, EventArgs e)
        {
            cbHV.Enabled = true;
            cbxMaCC.Enabled = true;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            cbxMaCC.Enabled = true;
            frmDSHV frmhv = new frmDSHV();
            frmhv.ShowDialog();
        }

        private void cbxMaCC_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvL.DataSource = dk.Load_dgvLFLcbxCC(cbxMaCC.SelectedValue.ToString());
            //dk.HT_txtSoTien(cbxMaCC.SelectedValue.ToString(), txtSoTien);
        }

        private void dgvL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbHV.DataSource = dk.getmasv(dgvL.CurrentRow.Cells[0].Value.ToString());
            cbHV.DisplayMember = "HoTen";
            cbHV.ValueMember = "MaHV";
            txtLop.Text = dgvL.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {
            dk.HT_txtSoTien(cbxMaCC.SelectedValue.ToString(), txtSoTien);
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbHV_SelectedValueChanged(object sender, EventArgs e)
        {
            dk.HT_txtHV(cbxMaCC.SelectedValue.ToString(), txtMaHV, txtTenHV, txtPhai, txtNS, txtDC, txtMail, txtSDT);
            txtHV.Text = cbHV.SelectedValue.ToString();
        }

        private void cbHV_TextChanged(object sender, EventArgs e)
        {
            dk.HT_txtHV(cbxMaCC.SelectedValue.ToString(), txtMaHV, txtTenHV, txtPhai, txtNS, txtDC, txtMail, txtSDT);
        }

        private void cbxMaCC_TextChanged(object sender, EventArgs e)
        {
            //dk.HT_txtSoTien(cbxMaCC.SelectedValue.ToString(), txtSoTien);
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            txtSoTien.Text = txtTong.Text;
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            if (dk.ThemBL(txtMaPhieu.Text, txtMaHV.Text,dateTimePicker1.Value.ToString(),txtLop.Text,txtTong.Text))
            {
                MessageBox.Show("Tạo biên lại thành công");
                
            }
        }
    }
}