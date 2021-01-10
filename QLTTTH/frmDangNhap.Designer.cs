namespace QLTTTH
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMatKhau = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtTenDN);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(23, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(430, 173);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(140, 101);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(246, 21);
            this.txtMatKhau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(140, 54);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(246, 20);
            this.txtTenDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(222, 208);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(110, 32);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "Đăng nhập";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(338, 208);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(115, 32);
            this.btHuy.TabIndex = 1;
            this.btHuy.Text = "Cancel";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(23, 208);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 32);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Tùy chọn";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 264);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Enter += new System.EventHandler(this.frmDangNhap_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.MaskedTextBox txtMatKhau;
    }
}