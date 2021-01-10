namespace QLTTTH
{
    partial class frmChungChi
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
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenCC = new System.Windows.Forms.TextBox();
            this.txtMCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCC = new System.Windows.Forms.DataGridView();
            this.MaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCC)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(849, 574);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btHuy);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.txtHP);
            this.groupBox2.Controls.Add(this.txtMoTa);
            this.groupBox2.Controls.Add(this.txtTenCC);
            this.groupBox2.Controls.Add(this.txtMCC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(509, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 550);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chứng chỉ";
            // 
            // btSua
            // 
            this.btSua.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_tick;
            this.btSua.Location = new System.Drawing.Point(18, 283);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(131, 59);
            this.btSua.TabIndex = 27;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHuy
            // 
            this.btHuy.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_cancel;
            this.btHuy.Location = new System.Drawing.Point(183, 283);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(131, 59);
            this.btHuy.TabIndex = 28;
            this.btHuy.Text = "Hủy";
            // 
            // btXoa
            // 
            this.btXoa.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_multiply;
            this.btXoa.Location = new System.Drawing.Point(183, 204);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(131, 59);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_plus;
            this.btThem.Location = new System.Drawing.Point(18, 204);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(131, 59);
            this.btThem.TabIndex = 30;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(95, 160);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(219, 21);
            this.txtHP.TabIndex = 2;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(95, 118);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(219, 21);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtTenCC
            // 
            this.txtTenCC.Location = new System.Drawing.Point(95, 68);
            this.txtTenCC.Name = "txtTenCC";
            this.txtTenCC.Size = new System.Drawing.Size(219, 21);
            this.txtTenCC.TabIndex = 2;
            // 
            // txtMCC
            // 
            this.txtMCC.Location = new System.Drawing.Point(95, 28);
            this.txtMCC.Name = "txtMCC";
            this.txtMCC.Size = new System.Drawing.Size(219, 21);
            this.txtMCC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Học phí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên chứng chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chứng chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 550);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chứng chỉ";
            // 
            // dgvCC
            // 
            this.dgvCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCC,
            this.TenCC,
            this.MoTa,
            this.HocPhi});
            this.dgvCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCC.Location = new System.Drawing.Point(3, 17);
            this.dgvCC.Name = "dgvCC";
            this.dgvCC.Size = new System.Drawing.Size(487, 530);
            this.dgvCC.TabIndex = 0;
            this.dgvCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvP_CellClick);
            // 
            // MaCC
            // 
            this.MaCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCC.DataPropertyName = "MaCC";
            this.MaCC.HeaderText = "Mã chứng chỉ";
            this.MaCC.Name = "MaCC";
            // 
            // TenCC
            // 
            this.TenCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCC.DataPropertyName = "TenCC";
            this.TenCC.HeaderText = "Tên chứng chỉ";
            this.TenCC.Name = "TenCC";
            // 
            // MoTa
            // 
            this.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            // 
            // HocPhi
            // 
            this.HocPhi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HocPhi.DataPropertyName = "HocPhi";
            this.HocPhi.HeaderText = "Học phí";
            this.HocPhi.Name = "HocPhi";
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
            columnDefinition1.Width = 497D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 332D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 554D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(849, 574);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(497, 554);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupBox2;
            this.layoutControlItem2.Location = new System.Drawing.Point(497, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(332, 554);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 574);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmChungChi";
            this.Text = "Danh sách các chứng chỉ";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenCC;
        private System.Windows.Forms.TextBox txtMCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocPhi;
    }
}