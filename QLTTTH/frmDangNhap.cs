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

namespace QLTTTH
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        user CauHinh = new user();
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        public void ProcessLogin()
        {
            LoginResult result;
            result = CauHinh.Check_User(txtTenDN.Text, txtMatKhau.Text);
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai" + label1.Text + "hoặc" + label2.Text);
                return;
            }
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.mainfrm == null || Program.mainfrm.IsDisposed)
            {
                Program.mainfrm = new frmMain();
            }
            this.Visible = false;
            Program.mainfrm.Show();
        }

        public void ProcessConfig()
        {
            Program.cauhinhfrm = new frmCauHinh();
            Program.cauhinhfrm.Show();
        }

        void DangNhap()
        {
            if (string.IsNullOrEmpty(txtTenDN.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống" );
                this.txtTenDN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống " );
                this.txtMatKhau.Focus();
                return;
            }
            int kq = CauHinh.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Program.cauhinhfrm = new frmCauHinh();
            Program.cauhinhfrm.ShowDialog();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void frmDangNhap_Enter(object sender, EventArgs e)
        {
            DangNhap();
            btOK.Focus();
        }
    }
}