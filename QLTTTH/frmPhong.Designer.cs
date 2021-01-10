namespace QLTTTH
{
    partial class frmPhong
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
            this.number2 = new Control.Number();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
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
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(927, 274, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(879, 535);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.number2);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btHuy);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.txtMaPH);
            this.groupBox2.Controls.Add(this.txtTenPhong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(521, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 511);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng học";
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(90, 133);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(237, 21);
            this.number2.TabIndex = 31;
            // 
            // btSua
            // 
            this.btSua.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_tick;
            this.btSua.Location = new System.Drawing.Point(9, 281);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(131, 59);
            this.btSua.TabIndex = 27;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHuy
            // 
            this.btHuy.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_cancel;
            this.btHuy.Location = new System.Drawing.Point(196, 281);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(131, 59);
            this.btHuy.TabIndex = 28;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btXoa
            // 
            this.btXoa.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_multiply;
            this.btXoa.Location = new System.Drawing.Point(196, 205);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(131, 59);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_plus;
            this.btThem.Location = new System.Drawing.Point(9, 205);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(131, 59);
            this.btThem.TabIndex = 30;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtMaPH
            // 
            this.txtMaPH.Enabled = false;
            this.txtMaPH.Location = new System.Drawing.Point(90, 55);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.Size = new System.Drawing.Size(237, 21);
            this.txtMaPH.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(90, 94);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(237, 21);
            this.txtTenPhong.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng ghế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 511);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng học";
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
            this.dgvP.Size = new System.Drawing.Size(499, 491);
            this.dgvP.TabIndex = 0;
            this.dgvP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvP_CellClick);
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
            columnDefinition1.Width = 509D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 350D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 515D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(879, 535);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(509, 515);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupBox2;
            this.layoutControlItem2.Location = new System.Drawing.Point(509, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 515);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 535);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPhong";
            this.Text = "Phòng học";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label label4;
        private Control.Number number2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
    }
}