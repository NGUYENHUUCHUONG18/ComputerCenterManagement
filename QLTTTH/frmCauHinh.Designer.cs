namespace QLTTTH
{
    partial class frmCauHinh
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
            this.cbxDB = new System.Windows.Forms.ComboBox();
            this.cbxSVN = new System.Windows.Forms.ComboBox();
            this.txtUSN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(244, 297);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(115, 32);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Cancel";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(128, 297);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(110, 32);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "Save";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbxDB);
            this.groupControl1.Controls.Add(this.cbxSVN);
            this.groupControl1.Controls.Add(this.txtUSN);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtPass);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 267);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Cấu hình ";
            // 
            // cbxDB
            // 
            this.cbxDB.FormattingEnabled = true;
            this.cbxDB.Location = new System.Drawing.Point(134, 202);
            this.cbxDB.Name = "cbxDB";
            this.cbxDB.Size = new System.Drawing.Size(178, 21);
            this.cbxDB.TabIndex = 4;
            this.cbxDB.DropDown += new System.EventHandler(this.cbxDB_DropDown);
            // 
            // cbxSVN
            // 
            this.cbxSVN.FormattingEnabled = true;
            this.cbxSVN.Location = new System.Drawing.Point(134, 57);
            this.cbxSVN.Name = "cbxSVN";
            this.cbxSVN.Size = new System.Drawing.Size(178, 21);
            this.cbxSVN.TabIndex = 1;
            this.cbxSVN.DropDown += new System.EventHandler(this.cbxSVN_DropDown);
            // 
            // txtUSN
            // 
            this.txtUSN.Location = new System.Drawing.Point(134, 106);
            this.txtUSN.Name = "txtUSN";
            this.txtUSN.Size = new System.Drawing.Size(178, 20);
            this.txtUSN.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password: ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(134, 159);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(178, 20);
            this.txtPass.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 205);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Database:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name:";
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 367);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCauHinh";
            this.Text = "frmCauHinh";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbxDB;
        private System.Windows.Forms.ComboBox cbxSVN;
        private DevExpress.XtraEditors.TextEdit txtUSN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl label1;
    }
}