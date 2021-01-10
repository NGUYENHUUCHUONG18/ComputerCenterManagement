namespace QLTTTH
{
    partial class frmDSHV
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.number2 = new Control.Number();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.cbxPhai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.Phái = new System.Windows.Forms.Label();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxDC = new System.Windows.Forms.TextBox();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenHV = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHV = new System.Windows.Forms.DataGridView();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViCongTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupBox2);
            this.layoutControl1.Controls.Add(this.groupBox1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1192, 527, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1075, 548);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.number2);
            this.groupBox2.Controls.Add(this.txtDonVi);
            this.groupBox2.Controls.Add(this.cbxPhai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.Phái);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btHuy);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.textBoxDC);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtTenHV);
            this.groupBox2.Controls.Add(this.txtMaHV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(724, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 524);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin học viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Phái";
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(107, 267);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(193, 21);
            this.number2.TabIndex = 50;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(107, 192);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(193, 21);
            this.txtDonVi.TabIndex = 44;
            // 
            // cbxPhai
            // 
            this.cbxPhai.FormattingEnabled = true;
            this.cbxPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxPhai.Location = new System.Drawing.Point(107, 128);
            this.cbxPhai.Name = "cbxPhai";
            this.cbxPhai.Size = new System.Drawing.Size(193, 21);
            this.cbxPhai.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Đơn vị công tác";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "yyyy/MM/dd";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(107, 93);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(193, 21);
            this.dtpNgaySinh.TabIndex = 39;
            // 
            // Phái
            // 
            this.Phái.AutoSize = true;
            this.Phái.Location = new System.Drawing.Point(15, 232);
            this.Phái.Name = "Phái";
            this.Phái.Size = new System.Drawing.Size(31, 13);
            this.Phái.TabIndex = 41;
            this.Phái.Text = "Email";
            // 
            // btSua
            // 
            this.btSua.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_tick;
            this.btSua.Location = new System.Drawing.Point(18, 382);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(131, 59);
            this.btSua.TabIndex = 46;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHuy
            // 
            this.btHuy.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_cancel;
            this.btHuy.Location = new System.Drawing.Point(169, 382);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(131, 59);
            this.btHuy.TabIndex = 47;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_multiply;
            this.btXoa.Location = new System.Drawing.Point(169, 303);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(131, 59);
            this.btXoa.TabIndex = 48;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // textBoxDC
            // 
            this.textBoxDC.Location = new System.Drawing.Point(107, 161);
            this.textBoxDC.Name = "textBoxDC";
            this.textBoxDC.Size = new System.Drawing.Size(193, 21);
            this.textBoxDC.TabIndex = 40;
            // 
            // btThem
            // 
            this.btThem.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_plus;
            this.btThem.Location = new System.Drawing.Point(18, 303);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(131, 59);
            this.btThem.TabIndex = 49;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 21);
            this.txtEmail.TabIndex = 38;
            // 
            // txtTenHV
            // 
            this.txtTenHV.Location = new System.Drawing.Point(107, 63);
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.Size = new System.Drawing.Size(193, 21);
            this.txtTenHV.TabIndex = 37;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(107, 30);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(193, 21);
            this.txtMaHV.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã học viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 524);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học viên";
            // 
            // dgvHV
            // 
            this.dgvHV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.DonViCongTac,
            this.Mail,
            this.SDT});
            this.dgvHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHV.Location = new System.Drawing.Point(3, 17);
            this.dgvHV.Name = "dgvHV";
            this.dgvHV.Size = new System.Drawing.Size(702, 504);
            this.dgvHV.TabIndex = 0;
            this.dgvHV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGV_CellClick);
            // 
            // MaHV
            // 
            this.MaHV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHV.DataPropertyName = "MaHV";
            this.MaHV.HeaderText = "Mã học viên";
            this.MaHV.Name = "MaHV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Phái";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DonViCongTac
            // 
            this.DonViCongTac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonViCongTac.DataPropertyName = "DonViCongTac";
            this.DonViCongTac.HeaderText = "Đơn vị công tác";
            this.DonViCongTac.Name = "DonViCongTac";
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mail.DataPropertyName = "Mail";
            this.Mail.HeaderText = "Email";
            this.Mail.Name = "Mail";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition1.Width = 712D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 343D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(1075, 548);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(712, 528);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupBox2;
            this.layoutControlItem2.Location = new System.Drawing.Point(712, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(343, 528);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "EMail";
            // 
            // frmDSHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 548);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.label6);
            this.Name = "frmDSHV";
            this.Text = "Danh sách học viên";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
       
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private Control.Number number2;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.ComboBox cbxPhai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label Phái;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private System.Windows.Forms.TextBox textBoxDC;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenHV;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViCongTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}