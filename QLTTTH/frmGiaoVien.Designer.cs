namespace QLTTTH
{
    partial class frmGiaoVien
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
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbxPhai = new System.Windows.Forms.ComboBox();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.number1 = new Control.Number();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
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
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1047, 542);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.cbxPhai);
            this.groupBox2.Controls.Add(this.btLuu);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btHuy);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.number1);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtDC);
            this.groupBox2.Controls.Add(this.txtTenGV);
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(683, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 518);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giáo viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "yyyy/MM/dd";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(137, 92);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(193, 21);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // cbxPhai
            // 
            this.cbxPhai.FormattingEnabled = true;
            this.cbxPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxPhai.Location = new System.Drawing.Point(137, 129);
            this.cbxPhai.Name = "cbxPhai";
            this.cbxPhai.Size = new System.Drawing.Size(193, 21);
            this.cbxPhai.TabIndex = 21;
            // 
            // btLuu
            // 
            this.btLuu.ImageOptions.Image = global::QLTTTH.Properties.Resources.Disquette;
            this.btLuu.Location = new System.Drawing.Point(25, 444);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(131, 59);
            this.btLuu.TabIndex = 20;
            this.btLuu.Text = "Lưu";
            // 
            // btSua
            // 
            this.btSua.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_tick;
            this.btSua.Location = new System.Drawing.Point(25, 362);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(131, 59);
            this.btSua.TabIndex = 20;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHuy
            // 
            this.btHuy.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_cancel;
            this.btHuy.Location = new System.Drawing.Point(199, 362);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(131, 59);
            this.btHuy.TabIndex = 20;
            this.btHuy.Text = "Hủy";
            // 
            // btXoa
            // 
            this.btXoa.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_multiply;
            this.btXoa.Location = new System.Drawing.Point(199, 283);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(131, 59);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_plus;
            this.btThem.Location = new System.Drawing.Point(25, 283);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(131, 59);
            this.btThem.TabIndex = 20;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(137, 243);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(193, 21);
            this.number1.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 206);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 21);
            this.txtEmail.TabIndex = 14;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(137, 160);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(193, 21);
            this.txtDC.TabIndex = 15;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(137, 61);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(193, 21);
            this.txtTenGV.TabIndex = 1;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(137, 20);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(193, 21);
            this.txtMaGV.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "EMail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã giáo viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 518);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // dgvGV
            // 
            this.dgvGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTen,
            this.NgaySinh,
            this.Phai,
            this.DiaChi,
            this.Mail,
            this.SDT});
            this.dgvGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGV.Location = new System.Drawing.Point(3, 17);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.Size = new System.Drawing.Size(661, 498);
            this.dgvGV.TabIndex = 0;
            this.dgvGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGV_CellClick);
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã giảng viên";
            this.MaGV.Name = "MaGV";
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
            // Phai
            // 
            this.Phai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phai.DataPropertyName = "Phai";
            this.Phai.HeaderText = "Phái";
            this.Phai.Name = "Phai";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
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
            columnDefinition1.Width = 671D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 356D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(1047, 542);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(671, 522);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupBox2;
            this.layoutControlItem2.Location = new System.Drawing.Point(671, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(356, 522);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 542);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmGiaoVien";
            this.Text = "Danh sách giảng viên";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGV;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Control.Number number1;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private System.Windows.Forms.ComboBox cbxPhai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}