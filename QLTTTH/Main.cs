using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLTTTH
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "iMaginary";
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btDMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            foreach (Form item in MdiChildren)
            {
                if(item.Name == dmk.Name)
                {
                    dmk.Activate();
                    IsActiv = true;
                }
            }
            if(!IsActiv)
            {
                dmk.MdiParent = this;
                dmk.Show();
            }         
        }

        private void btDSHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmDSHV DSHV = new frmDSHV();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == DSHV.Name)
                {
                    DSHV.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                DSHV.MdiParent = this;
                DSHV.Show();
            }
        }

        private void btDSGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmGiaoVien GV = new frmGiaoVien();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == GV.Name)
                {
                    GV.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                GV.MdiParent = this;
                GV.Show();
            }
        }

        private void btLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmLopHoc lh = new frmLopHoc();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == lh.Name)
                {
                    lh.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                lh.MdiParent = this;
                lh.Show();
            }
        }

        private void btPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmPhong ph = new frmPhong();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == ph.Name)
                {
                    ph.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                ph.MdiParent = this;
                ph.Show();
            }
        }

        private void btChungChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmChungChi cc = new frmChungChi();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == cc.Name)
                {
                    cc.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                cc.MdiParent = this;
                cc.Show();
            }
        }

        private void btPhanCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmPhanCong pc = new frmPhanCong();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == pc.Name)
                {
                    pc.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                pc.MdiParent = this;
                pc.Show();
            }
        }

        private void btLichDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmLichDay ld = new frmLichDay();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == ld.Name)
                {
                    ld.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                ld.MdiParent = this;
                ld.Show();
            }
        }

        private void btKhoaHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmKhoaHoc kh = new frmKhoaHoc();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == kh.Name)
                {
                    kh.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                kh.MdiParent = this;
                kh.Show();
            }
        }

        private void btThoiGianHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmCaHoc ch = new frmCaHoc();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == ch.Name)
                {
                    ch.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                ch.MdiParent = this;
                ch.Show();
            }
        }

        private void btDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmQLDiem ql = new frmQLDiem();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == ql.Name)
                {
                    ql.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                ql.MdiParent = this;
                ql.Show();
            }
        }

        private void btDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            frmDangKy dk = new frmDangKy();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == dk.Name)
                {
                    dk.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                dk.MdiParent = this;
                dk.Show();
            }
        }
    }
}