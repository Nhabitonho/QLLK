namespace QLLK
{
    partial class FormBaoCaoNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpk = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcbaocaonhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NgNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcbaocaonhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 44);
            this.panel1.TabIndex = 4;
            // 
            // dtpk
            // 
            this.dtpk.CustomFormat = "MM/yyyy";
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk.Location = new System.Drawing.Point(111, 12);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(200, 20);
            this.dtpk.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn tháng";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "In Báo Cáo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcbaocaonhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 510);
            this.panel2.TabIndex = 5;
            // 
            // gcbaocaonhap
            // 
            this.gcbaocaonhap.Location = new System.Drawing.Point(0, 50);
            this.gcbaocaonhap.MainView = this.gridView1;
            this.gcbaocaonhap.Name = "gcbaocaonhap";
            this.gcbaocaonhap.Size = new System.Drawing.Size(816, 400);
            this.gcbaocaonhap.TabIndex = 0;
            this.gcbaocaonhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NgNhap,
            this.MaSP,
            this.TenSP,
            this.MaNCC,
            this.loai,
            this.soluong,
            this.dongia});
            this.gridView1.GridControl = this.gcbaocaonhap;
            this.gridView1.Name = "gridView1";
            // 
            // NgNhap
            // 
            this.NgNhap.Caption = "Ngày Nhập";
            this.NgNhap.Name = "NgNhap";
            this.NgNhap.Visible = true;
            this.NgNhap.VisibleIndex = 0;
            // 
            // MaSP
            // 
            this.MaSP.Caption = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.Visible = true;
            this.MaSP.VisibleIndex = 1;
            // 
            // TenSP
            // 
            this.TenSP.Caption = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Visible = true;
            this.TenSP.VisibleIndex = 2;
            // 
            // MaNCC
            // 
            this.MaNCC.Caption = "Mã Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Visible = true;
            this.MaNCC.VisibleIndex = 3;
            // 
            // loai
            // 
            this.loai.Caption = "Loại";
            this.loai.Name = "loai";
            this.loai.Visible = true;
            this.loai.VisibleIndex = 4;
            // 
            // soluong
            // 
            this.soluong.Caption = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.Visible = true;
            this.soluong.VisibleIndex = 5;
            // 
            // dongia
            // 
            this.dongia.Caption = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.Visible = true;
            this.dongia.VisibleIndex = 6;
            // 
            // FormBaoCaoNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormBaoCaoNhap";
            this.Size = new System.Drawing.Size(816, 510);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcbaocaonhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcbaocaonhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NgNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaSP;
        private DevExpress.XtraGrid.Columns.GridColumn TenSP;
        private DevExpress.XtraGrid.Columns.GridColumn MaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn loai;
        private DevExpress.XtraGrid.Columns.GridColumn soluong;
        private DevExpress.XtraGrid.Columns.GridColumn dongia;
    }
}
