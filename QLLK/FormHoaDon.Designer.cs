namespace QLLK
{
    partial class FormHoaDon
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
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_xem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_mahd = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gcthongtinhoadon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcthongtinhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_makh);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.bt_xem);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bt_in);
            this.groupBox1.Controls.Add(this.tb_hoten);
            this.groupBox1.Controls.Add(this.tb_mahd);
            this.groupBox1.Controls.Add(this.tb_manv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // tb_makh
            // 
            this.tb_makh.Location = new System.Drawing.Point(172, 49);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(124, 20);
            this.tb_makh.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(172, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Thanh Toán";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(302, 50);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(62, 21);
            this.bt_tim.TabIndex = 18;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            // 
            // bt_xem
            // 
            this.bt_xem.Location = new System.Drawing.Point(398, 132);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(89, 39);
            this.bt_xem.TabIndex = 17;
            this.bt_xem.Text = "Lập Hóa Đơn";
            this.bt_xem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_in
            // 
            this.bt_in.Location = new System.Drawing.Point(513, 132);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(96, 39);
            this.bt_in.TabIndex = 15;
            this.bt_in.Text = "In Hóa Đơn";
            this.bt_in.UseVisualStyleBackColor = true;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Enabled = false;
            this.tb_hoten.Location = new System.Drawing.Point(172, 76);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(192, 20);
            this.tb_hoten.TabIndex = 13;
            // 
            // tb_mahd
            // 
            this.tb_mahd.Enabled = false;
            this.tb_mahd.Location = new System.Drawing.Point(172, 24);
            this.tb_mahd.Name = "tb_mahd";
            this.tb_mahd.Size = new System.Drawing.Size(192, 20);
            this.tb_mahd.TabIndex = 12;
            // 
            // tb_manv
            // 
            this.tb_manv.Enabled = false;
            this.tb_manv.Location = new System.Drawing.Point(513, 20);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(200, 20);
            this.tb_manv.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Và Tên KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Hóa Đơn";
            // 
            // gcthongtinhoadon
            // 
            this.gcthongtinhoadon.Location = new System.Drawing.Point(0, 188);
            this.gcthongtinhoadon.MainView = this.gridView1;
            this.gcthongtinhoadon.Name = "gcthongtinhoadon";
            this.gcthongtinhoadon.Size = new System.Drawing.Size(800, 262);
            this.gcthongtinhoadon.TabIndex = 3;
            this.gcthongtinhoadon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSp,
            this.TenSP,
            this.soluong,
            this.loai,
            this.dongia});
            this.gridView1.GridControl = this.gcthongtinhoadon;
            this.gridView1.Name = "gridView1";
            // 
            // MaSp
            // 
            this.MaSp.Caption = "Mã Sản Phẩm";
            this.MaSp.Name = "MaSp";
            this.MaSp.Visible = true;
            this.MaSp.VisibleIndex = 0;
            // 
            // TenSP
            // 
            this.TenSP.Caption = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Visible = true;
            this.TenSP.VisibleIndex = 1;
            // 
            // soluong
            // 
            this.soluong.Caption = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.Visible = true;
            this.soluong.VisibleIndex = 2;
            // 
            // loai
            // 
            this.loai.Caption = "Loại";
            this.loai.Name = "loai";
            this.loai.Visible = true;
            this.loai.VisibleIndex = 3;
            // 
            // dongia
            // 
            this.dongia.Caption = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.Visible = true;
            this.dongia.VisibleIndex = 4;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcthongtinhoadon);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHoaDon";
            this.Size = new System.Drawing.Size(816, 489);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcthongtinhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_xem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_mahd;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gcthongtinhoadon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSp;
        private DevExpress.XtraGrid.Columns.GridColumn TenSP;
        private DevExpress.XtraGrid.Columns.GridColumn soluong;
        private DevExpress.XtraGrid.Columns.GridColumn loai;
        private DevExpress.XtraGrid.Columns.GridColumn dongia;
    }
}
