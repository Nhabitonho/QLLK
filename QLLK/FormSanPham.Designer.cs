namespace QLLK
{
    partial class FormSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.load = new System.Windows.Forms.Button();
            this.nbh = new System.Windows.Forms.DateTimePicker();
            this.nsx = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_huy = new System.Windows.Forms.Button();
            this.tb_luu = new System.Windows.Forms.Button();
            this.tb_them = new System.Windows.Forms.Button();
            this.tb_sua = new System.Windows.Forms.Button();
            this.tb_xoa = new System.Windows.Forms.Button();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_tensanpham = new System.Windows.Forms.TextBox();
            this.tb_masanpham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tennhacungcap = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tennhacungcap);
            this.groupBox1.Controls.Add(this.load);
            this.groupBox1.Controls.Add(this.nbh);
            this.groupBox1.Controls.Add(this.nsx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_huy);
            this.groupBox1.Controls.Add(this.tb_luu);
            this.groupBox1.Controls.Add(this.tb_them);
            this.groupBox1.Controls.Add(this.tb_sua);
            this.groupBox1.Controls.Add(this.tb_xoa);
            this.groupBox1.Controls.Add(this.tb_dongia);
            this.groupBox1.Controls.Add(this.tb_tensanpham);
            this.groupBox1.Controls.Add(this.tb_masanpham);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(49, 151);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 19;
            this.load.Text = "Load dữ liệu";
            this.load.UseVisualStyleBackColor = true;
            // 
            // nbh
            // 
            this.nbh.Cursor = System.Windows.Forms.Cursors.Default;
            this.nbh.CustomFormat = "dd/MM/yyyy";
            this.nbh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nbh.Location = new System.Drawing.Point(541, 59);
            this.nbh.Name = "nbh";
            this.nbh.Size = new System.Drawing.Size(200, 20);
            this.nbh.TabIndex = 18;
            // 
            // nsx
            // 
            this.nsx.Cursor = System.Windows.Forms.Cursors.Cross;
            this.nsx.CustomFormat = "dd/MM/yyyy";
            this.nsx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nsx.Location = new System.Drawing.Point(541, 27);
            this.nsx.Name = "nsx";
            this.nsx.Size = new System.Drawing.Size(200, 20);
            this.nsx.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Thời Gian Bảo Hành :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày Sản Xuất :";
            // 
            // tb_huy
            // 
            this.tb_huy.Location = new System.Drawing.Point(495, 149);
            this.tb_huy.Name = "tb_huy";
            this.tb_huy.Size = new System.Drawing.Size(75, 27);
            this.tb_huy.TabIndex = 14;
            this.tb_huy.Text = "Hủy";
            this.tb_huy.UseVisualStyleBackColor = true;
            // 
            // tb_luu
            // 
            this.tb_luu.Location = new System.Drawing.Point(394, 149);
            this.tb_luu.Name = "tb_luu";
            this.tb_luu.Size = new System.Drawing.Size(75, 27);
            this.tb_luu.TabIndex = 13;
            this.tb_luu.Text = "Lưu";
            this.tb_luu.UseVisualStyleBackColor = true;
            // 
            // tb_them
            // 
            this.tb_them.Location = new System.Drawing.Point(295, 149);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(75, 27);
            this.tb_them.TabIndex = 9;
            this.tb_them.Text = "Thêm";
            this.tb_them.UseVisualStyleBackColor = true;
            // 
            // tb_sua
            // 
            this.tb_sua.Location = new System.Drawing.Point(394, 149);
            this.tb_sua.Name = "tb_sua";
            this.tb_sua.Size = new System.Drawing.Size(75, 27);
            this.tb_sua.TabIndex = 10;
            this.tb_sua.Text = "Sửa";
            this.tb_sua.UseVisualStyleBackColor = true;
            // 
            // tb_xoa
            // 
            this.tb_xoa.Location = new System.Drawing.Point(495, 149);
            this.tb_xoa.Name = "tb_xoa";
            this.tb_xoa.Size = new System.Drawing.Size(75, 27);
            this.tb_xoa.TabIndex = 11;
            this.tb_xoa.Text = "Xóa";
            this.tb_xoa.UseVisualStyleBackColor = true;
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(541, 94);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(121, 20);
            this.tb_dongia.TabIndex = 8;
            // 
            // tb_tensanpham
            // 
            this.tb_tensanpham.Location = new System.Drawing.Point(153, 66);
            this.tb_tensanpham.Name = "tb_tensanpham";
            this.tb_tensanpham.Size = new System.Drawing.Size(150, 20);
            this.tb_tensanpham.TabIndex = 6;
            // 
            // tb_masanpham
            // 
            this.tb_masanpham.Enabled = false;
            this.tb_masanpham.Location = new System.Drawing.Point(153, 32);
            this.tb_masanpham.Name = "tb_masanpham";
            this.tb_masanpham.Size = new System.Drawing.Size(150, 20);
            this.tb_masanpham.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // tb_tennhacungcap
            // 
            this.tb_tennhacungcap.Location = new System.Drawing.Point(153, 104);
            this.tb_tennhacungcap.Name = "tb_tennhacungcap";
            this.tb_tennhacungcap.Size = new System.Drawing.Size(150, 20);
            this.tb_tennhacungcap.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(816, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "masanpham";
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tensanpham";
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Manhacungcap";
            this.Column3.HeaderText = "Mã Nhà Cung Cấp";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nsx";
            this.Column4.HeaderText = "NSX";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nbh";
            this.Column5.HeaderText = "NBH";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DonGia";
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSanPham";
            this.Size = new System.Drawing.Size(816, 489);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_tennhacungcap;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DateTimePicker nbh;
        private System.Windows.Forms.DateTimePicker nsx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tb_huy;
        private System.Windows.Forms.Button tb_luu;
        private System.Windows.Forms.Button tb_them;
        private System.Windows.Forms.Button tb_sua;
        private System.Windows.Forms.Button tb_xoa;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.TextBox tb_tensanpham;
        private System.Windows.Forms.TextBox tb_masanpham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
