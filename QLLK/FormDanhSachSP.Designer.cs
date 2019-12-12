namespace QLLK
{
    partial class FormDanhSachSP
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcdanhsachsp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsachsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 147);
            this.panel1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Load Danh Sách";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "In Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Danh Sách Sản Phẩm";
            // 
            // gcdanhsachsp
            // 
            this.gcdanhsachsp.Location = new System.Drawing.Point(1, 151);
            this.gcdanhsachsp.MainView = this.gridView1;
            this.gcdanhsachsp.Name = "gcdanhsachsp";
            this.gcdanhsachsp.Size = new System.Drawing.Size(816, 381);
            this.gcdanhsachsp.TabIndex = 18;
            this.gcdanhsachsp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSp,
            this.TenSp,
            this.MaNCC,
            this.NSX,
            this.NBH,
            this.DonGia});
            this.gridView1.GridControl = this.gcdanhsachsp;
            this.gridView1.Name = "gridView1";
            // 
            // MaSp
            // 
            this.MaSp.Caption = "Mã Sản Phẩm";
            this.MaSp.Name = "MaSp";
            this.MaSp.Visible = true;
            this.MaSp.VisibleIndex = 0;
            // 
            // TenSp
            // 
            this.TenSp.Caption = "Tên Sản Phẩm";
            this.TenSp.Name = "TenSp";
            this.TenSp.Visible = true;
            this.TenSp.VisibleIndex = 1;
            // 
            // MaNCC
            // 
            this.MaNCC.Caption = "Mã Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Visible = true;
            this.MaNCC.VisibleIndex = 2;
            // 
            // NSX
            // 
            this.NSX.Caption = "Ngày Sản Xuất";
            this.NSX.Name = "NSX";
            this.NSX.Visible = true;
            this.NSX.VisibleIndex = 3;
            // 
            // NBH
            // 
            this.NBH.Caption = "Thời Gian Bảo Hành";
            this.NBH.Name = "NBH";
            this.NBH.Visible = true;
            this.NBH.VisibleIndex = 4;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 5;
            // 
            // FormDanhSachSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcdanhsachsp);
            this.Controls.Add(this.panel1);
            this.Name = "FormDanhSachSP";
            this.Size = new System.Drawing.Size(816, 528);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsachsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcdanhsachsp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSp;
        private DevExpress.XtraGrid.Columns.GridColumn TenSp;
        private DevExpress.XtraGrid.Columns.GridColumn MaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn NSX;
        private DevExpress.XtraGrid.Columns.GridColumn NBH;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
    }
}
