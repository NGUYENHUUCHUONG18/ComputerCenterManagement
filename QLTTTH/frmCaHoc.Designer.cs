namespace QLTTTH
{
    partial class frmCaHoc
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
            this.txtGio = new System.Windows.Forms.MaskedTextBox();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.cbThu = new System.Windows.Forms.ComboBox();
            this.txtMaTGH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCH = new System.Windows.Forms.DataGridView();
            this.MaCaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCH)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(787, 517);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGio);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btHuy);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.cbThu);
            this.groupBox2.Controls.Add(this.txtMaTGH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(440, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 493);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý danh mục ca học";
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(80, 156);
            this.txtGio.Mask = "00:00:00";
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(207, 21);
            this.txtGio.TabIndex = 26;
            // 
            // btSua
            // 
            this.btSua.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_tick;
            this.btSua.Location = new System.Drawing.Point(9, 288);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(131, 59);
            this.btSua.TabIndex = 22;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHuy
            // 
            this.btHuy.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_cancel;
            this.btHuy.Location = new System.Drawing.Point(183, 288);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(131, 59);
            this.btHuy.TabIndex = 23;
            this.btHuy.Text = "Hủy";
            // 
            // btXoa
            // 
            this.btXoa.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_multiply;
            this.btXoa.Location = new System.Drawing.Point(183, 209);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(131, 59);
            this.btXoa.TabIndex = 24;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.ImageOptions.Image = global::QLTTTH.Properties.Resources.Badge_plus;
            this.btThem.Location = new System.Drawing.Point(9, 209);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(131, 59);
            this.btThem.TabIndex = 25;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // cbThu
            // 
            this.cbThu.FormattingEnabled = true;
            this.cbThu.Items.AddRange(new object[] {
            "2, 4, 6",
            "3, 5, 7"});
            this.cbThu.Location = new System.Drawing.Point(80, 113);
            this.cbThu.Name = "cbThu";
            this.cbThu.Size = new System.Drawing.Size(207, 21);
            this.cbThu.TabIndex = 2;
            // 
            // txtMaTGH
            // 
            this.txtMaTGH.Location = new System.Drawing.Point(80, 81);
            this.txtMaTGH.Name = "txtMaTGH";
            this.txtMaTGH.Size = new System.Drawing.Size(207, 21);
            this.txtMaTGH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thứ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã TGH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 493);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các ca học";
            // 
            // dgvCH
            // 
            this.dgvCH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCaHoc,
            this.Thu,
            this.Gio});
            this.dgvCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCH.Location = new System.Drawing.Point(3, 17);
            this.dgvCH.Name = "dgvCH";
            this.dgvCH.Size = new System.Drawing.Size(418, 473);
            this.dgvCH.TabIndex = 0;
            this.dgvCH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvP_CellClick);
            // 
            // MaCaHoc
            // 
            this.MaCaHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCaHoc.DataPropertyName = "MaCaHoc";
            this.MaCaHoc.HeaderText = "Mã ca học";
            this.MaCaHoc.Name = "MaCaHoc";
            // 
            // Thu
            // 
            this.Thu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thứ";
            this.Thu.Name = "Thu";
            // 
            // Gio
            // 
            this.Gio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gio.DataPropertyName = "Gio";
            this.Gio.HeaderText = "Giờ";
            this.Gio.Name = "Gio";
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
            columnDefinition1.Width = 428D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 339D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(787, 517);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(428, 497);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupBox2;
            this.layoutControlItem2.Location = new System.Drawing.Point(428, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(339, 497);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmCaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 517);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmCaHoc";
            this.Text = "Thời gian học";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbThu;
        private System.Windows.Forms.TextBox txtMaTGH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private System.Windows.Forms.MaskedTextBox txtGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gio;
    }
}