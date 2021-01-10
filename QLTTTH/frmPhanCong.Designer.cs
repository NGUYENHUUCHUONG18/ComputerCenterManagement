namespace QLTTTH
{
    partial class frmPhanCong
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
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxGV = new System.Windows.Forms.ComboBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btPhanCong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDangDay = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtMPC = new DevExpress.XtraEditors.TextEdit();
            this.txtChungChi = new DevExpress.XtraEditors.TextEdit();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.cbxThu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvL = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMPC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChungChi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupBox4);
            this.layoutControl1.Controls.Add(this.groupBox3);
            this.layoutControl1.Controls.Add(this.groupBox2);
            this.layoutControl1.Controls.Add(this.groupBox1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1397, 684);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvGV);
            this.groupBox4.Location = new System.Drawing.Point(700, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 398);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn giáo viên";
            // 
            // dgvGV
            // 
            this.dgvGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTen,
            this.MaLop1});
            this.dgvGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGV.Location = new System.Drawing.Point(3, 17);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.Size = new System.Drawing.Size(679, 378);
            this.dgvGV.TabIndex = 1;
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
            // MaLop1
            // 
            this.MaLop1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLop1.DataPropertyName = "MaLop";
            this.MaLop1.HeaderText = "Mã lớp";
            this.MaLop1.Name = "MaLop1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxGV);
            this.groupBox3.Controls.Add(this.btCapNhat);
            this.groupBox3.Controls.Add(this.btPhanCong);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDangDay);
            this.groupBox3.Controls.Add(this.txtTenGV);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1373, 164);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giáo viên";
            // 
            // cbxGV
            // 
            this.cbxGV.FormattingEnabled = true;
            this.cbxGV.Location = new System.Drawing.Point(142, 35);
            this.cbxGV.Name = "cbxGV";
            this.cbxGV.Size = new System.Drawing.Size(188, 21);
            this.cbxGV.TabIndex = 2;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Image = global::QLTTTH.Properties.Resources.Badge_tick;
            this.btCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCapNhat.Location = new System.Drawing.Point(1007, 35);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(116, 55);
            this.btCapNhat.TabIndex = 2;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCapNhat.UseVisualStyleBackColor = true;
            // 
            // btPhanCong
            // 
            this.btPhanCong.Image = global::QLTTTH.Properties.Resources.Applications;
            this.btPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPhanCong.Location = new System.Drawing.Point(829, 35);
            this.btPhanCong.Name = "btPhanCong";
            this.btPhanCong.Size = new System.Drawing.Size(128, 55);
            this.btPhanCong.TabIndex = 2;
            this.btPhanCong.Text = "Phân công";
            this.btPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPhanCong.UseVisualStyleBackColor = true;
            this.btPhanCong.Click += new System.EventHandler(this.btPhanCong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên giáo viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã giáo viên";
            // 
            // txtDangDay
            // 
            this.txtDangDay.Location = new System.Drawing.Point(503, 35);
            this.txtDangDay.Multiline = true;
            this.txtDangDay.Name = "txtDangDay";
            this.txtDangDay.Size = new System.Drawing.Size(254, 123);
            this.txtDangDay.TabIndex = 1;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(142, 89);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(188, 21);
            this.txtTenGV.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lớp đang dạy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhong);
            this.groupBox2.Controls.Add(this.txtMPC);
            this.groupBox2.Controls.Add(this.txtChungChi);
            this.groupBox2.Controls.Add(this.cbxLop);
            this.groupBox2.Controls.Add(this.cbxThu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1373, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(829, 42);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(187, 20);
            this.txtPhong.TabIndex = 3;
            // 
            // txtMPC
            // 
            this.txtMPC.Enabled = false;
            this.txtMPC.Location = new System.Drawing.Point(82, 44);
            this.txtMPC.Name = "txtMPC";
            this.txtMPC.Size = new System.Drawing.Size(141, 20);
            this.txtMPC.TabIndex = 3;
            // 
            // txtChungChi
            // 
            this.txtChungChi.Location = new System.Drawing.Point(547, 43);
            this.txtChungChi.Name = "txtChungChi";
            this.txtChungChi.Size = new System.Drawing.Size(187, 20);
            this.txtChungChi.TabIndex = 3;
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(285, 43);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(159, 21);
            this.cbxLop.TabIndex = 2;
            this.cbxLop.SelectedValueChanged += new System.EventHandler(this.cbxLop_SelectedValueChanged);
            this.cbxLop.TextChanged += new System.EventHandler(this.cbxLop_TextChanged);
            // 
            // cbxThu
            // 
            this.cbxThu.FormattingEnabled = true;
            this.cbxThu.Items.AddRange(new object[] {
            "2, 4, 6",
            "3, 5, 7"});
            this.cbxThu.Location = new System.Drawing.Point(1115, 38);
            this.cbxThu.Name = "cbxThu";
            this.cbxThu.Size = new System.Drawing.Size(227, 21);
            this.cbxThu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1069, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thứ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã phân công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chứng chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 398);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // dgvL
            // 
            this.dgvL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.MaCC,
            this.MaPhong,
            this.Thu});
            this.dgvL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvL.Location = new System.Drawing.Point(3, 17);
            this.dgvL.Name = "dgvL";
            this.dgvL.Size = new System.Drawing.Size(678, 378);
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
            // MaCC
            // 
            this.MaCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCC.DataPropertyName = "MaCC";
            this.MaCC.HeaderText = " Mã chứng chỉ";
            this.MaCC.Name = "MaCC";
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // Thu
            // 
            this.Thu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thứ";
            this.Thu.Name = "Thu";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 402D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition2.Height = 94D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 168D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.Root.Size = new System.Drawing.Size(1397, 684);
            this.Root.Text = "4";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(688, 402);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupBox2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 402);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(1377, 94);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.groupBox3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 496);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(1377, 168);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.groupBox4;
            this.layoutControlItem4.Location = new System.Drawing.Point(688, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(689, 402);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 684);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPhanCong";
            this.Text = "Phân Công";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMPC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChungChi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvL;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btPhanCong;
        private System.Windows.Forms.TextBox txtDangDay;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop1;
        private System.Windows.Forms.ComboBox cbxGV;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.ComboBox cbxThu;
        private DevExpress.XtraEditors.TextEdit txtPhong;
        private DevExpress.XtraEditors.TextEdit txtChungChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private DevExpress.XtraEditors.TextEdit txtMPC;
        private System.Windows.Forms.Label label8;
    }
}