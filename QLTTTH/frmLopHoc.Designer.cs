namespace QLTTTH
{
    partial class frmLopHoc
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvL = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.number1 = new Control.Number();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.cbxPH = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.cbCaHoc = new System.Windows.Forms.ComboBox();
            this.cbCChi = new System.Windows.Forms.ComboBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupBox2);
            this.layoutControl1.Controls.Add(this.groupBox1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1112, 299, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1064, 560);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvL);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 536);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvP);
            this.groupBox3.Location = new System.Drawing.Point(3, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 262);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng học";
            // 
            // dgvP
            // 
            this.dgvP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.SucChua});
            this.dgvP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvP.Location = new System.Drawing.Point(3, 17);
            this.dgvP.Name = "dgvP";
            this.dgvP.Size = new System.Drawing.Size(654, 242);
            this.dgvP.TabIndex = 1;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // SucChua
            // 
            this.SucChua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SucChua.DataPropertyName = "SucChua";
            this.SucChua.HeaderText = "Sức chứa";
            this.SucChua.Name = "SucChua";
            // 
            // dgvL
            // 
            this.dgvL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.MaPhong1,
            this.SiSo,
            this.MaKhoa,
            this.MaCC,
            this.MaCaHoc,
            this.NgayBD});
            this.dgvL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvL.Location = new System.Drawing.Point(3, 17);
            this.dgvL.Name = "dgvL";
            this.dgvL.Size = new System.Drawing.Size(667, 516);
            this.dgvL.TabIndex = 0;
            this.dgvL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvL_CellClick);
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // MaPhong1
            // 
            this.MaPhong1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong1.DataPropertyName = "MaPhong";
            this.MaPhong1.HeaderText = "Mã phòng";
            this.MaPhong1.Name = "MaPhong1";
            // 
            // SiSo
            // 
            this.SiSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ số";
            this.SiSo.Name = "SiSo";
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khóa học";
            this.MaKhoa.Name = "MaKhoa";
            // 
            // MaCC
            // 
            this.MaCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCC.DataPropertyName = "MaCC";
            this.MaCC.HeaderText = "Mã chứng chỉ";
            this.MaCC.Name = "MaCC";
            // 
            // MaCaHoc
            // 
            this.MaCaHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCaHoc.DataPropertyName = "MaCaHoc";
            this.MaCaHoc.HeaderText = "Mã ca học";
            this.MaCaHoc.Name = "MaCaHoc";
            // 
            // NgayBD
            // 
            this.NgayBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày bắt đầu";
            this.NgayBD.Name = "NgayBD";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.number1);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btHuy);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.dtpNgayBD);
            this.groupBox1.Controls.Add(this.cbxPH);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.cbCaHoc);
            this.groupBox1.Controls.Add(this.cbCChi);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(689, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 536);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Phòng học";
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(151, 110);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(206, 21);
            this.number1.TabIndex = 31;
            this.number1.TextChanged += new System.EventHandler(this.number1_TextChanged);
            // 
            // btSua
            // 
            this.btSua.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_tick;
            this.btSua.Location = new System.Drawing.Point(79, 375);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(131, 63);
            this.btSua.TabIndex = 27;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHuy
            // 
            this.btHuy.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_cancel;
            this.btHuy.Location = new System.Drawing.Point(216, 375);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(141, 63);
            this.btHuy.TabIndex = 28;
            this.btHuy.Text = "Hủy";
            // 
            // btXoa
            // 
            this.btXoa.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_multiply;
            this.btXoa.Location = new System.Drawing.Point(216, 306);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(141, 63);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_plus;
            this.btThem.Location = new System.Drawing.Point(79, 306);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(131, 63);
            this.btThem.TabIndex = 30;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(151, 259);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(206, 21);
            this.dtpNgayBD.TabIndex = 3;
            // 
            // cbxPH
            // 
            this.cbxPH.FormattingEnabled = true;
            this.cbxPH.Location = new System.Drawing.Point(151, 66);
            this.cbxPH.Name = "cbxPH";
            this.cbxPH.Size = new System.Drawing.Size(206, 21);
            this.cbxPH.TabIndex = 2;
            this.cbxPH.SelectedValueChanged += new System.EventHandler(this.cbxPH_SelectedValueChanged);
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(151, 146);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(206, 21);
            this.cbKhoa.TabIndex = 2;
            // 
            // cbCaHoc
            // 
            this.cbCaHoc.FormattingEnabled = true;
            this.cbCaHoc.Location = new System.Drawing.Point(151, 227);
            this.cbCaHoc.Name = "cbCaHoc";
            this.cbCaHoc.Size = new System.Drawing.Size(206, 21);
            this.cbCaHoc.TabIndex = 2;
            // 
            // cbCChi
            // 
            this.cbCChi.FormattingEnabled = true;
            this.cbCChi.Location = new System.Drawing.Point(151, 184);
            this.cbCChi.Name = "cbCChi";
            this.cbCChi.Size = new System.Drawing.Size(206, 21);
            this.cbCChi.TabIndex = 2;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(151, 27);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(206, 21);
            this.txtLop.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ca học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chứng chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sỉ số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition1.Width = 677D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 367D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(1064, 560);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupBox1;
            this.layoutControlItem2.Location = new System.Drawing.Point(677, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(367, 540);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(677, 540);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 560);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmLopHoc";
            this.Text = "Lớp học";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbCaHoc;
        private System.Windows.Forms.ComboBox cbCChi;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private Control.Number number1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxPH;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
    }
}