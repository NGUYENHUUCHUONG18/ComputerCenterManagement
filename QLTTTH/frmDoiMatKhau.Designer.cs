namespace QLTTTH
{
    partial class frmDoiMatKhau
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
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtXacNhan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMKM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMKHT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTDN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKHT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(352, 294);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(78, 32);
            this.btHuy.TabIndex = 7;
            this.btHuy.Text = "Cancel";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(170, 294);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(78, 32);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtXacNhan);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtMKM);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMKHT);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtTDN);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(63, 72);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(478, 202);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thay đổi mật khẩu";
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Location = new System.Drawing.Point(171, 131);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Size = new System.Drawing.Size(246, 20);
            this.txtXacNhan.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(38, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Xác nhận mật khẩu:";
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(171, 105);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Size = new System.Drawing.Size(246, 20);
            this.txtMKM.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mật khẩu mới :";
            // 
            // txtMKHT
            // 
            this.txtMKHT.Location = new System.Drawing.Point(171, 79);
            this.txtMKHT.Name = "txtMKHT";
            this.txtMKHT.Size = new System.Drawing.Size(246, 20);
            this.txtMKHT.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu hiện tại:";
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(171, 53);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(246, 20);
            this.txtTDN.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 399);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKHT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtMKHT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTDN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtXacNhan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMKM;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}