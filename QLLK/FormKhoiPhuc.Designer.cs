namespace QLLK
{
    partial class FormKhoiPhuc
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
            this.button1 = new System.Windows.Forms.Button();
            this.bt_restore = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.cbb_server = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Chọn File .bak";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_restore
            // 
            this.bt_restore.Location = new System.Drawing.Point(365, 164);
            this.bt_restore.Name = "bt_restore";
            this.bt_restore.Size = new System.Drawing.Size(100, 23);
            this.bt_restore.TabIndex = 21;
            this.bt_restore.Text = "Restore";
            this.bt_restore.UseVisualStyleBackColor = true;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(150, 164);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(197, 20);
            this.tb_path.TabIndex = 20;
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(150, 135);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(197, 20);
            this.tb_mk.TabIndex = 18;
            // 
            // tb_tk
            // 
            this.tb_tk.Location = new System.Drawing.Point(150, 108);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(197, 20);
            this.tb_tk.TabIndex = 16;
            // 
            // cbb_server
            // 
            this.cbb_server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_server.FormattingEnabled = true;
            this.cbb_server.Items.AddRange(new object[] {
            "mysql-1325-0.cloudclusters.net"});
            this.cbb_server.Location = new System.Drawing.Point(150, 80);
            this.cbb_server.Name = "cbb_server";
            this.cbb_server.Size = new System.Drawing.Size(197, 21);
            this.cbb_server.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa chỉ file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pasword:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server Name:";
            // 
            // FormKhoiPhuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_restore);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_tk);
            this.Controls.Add(this.cbb_server);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKhoiPhuc";
            this.Size = new System.Drawing.Size(524, 266);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_restore;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.TextBox tb_tk;
        private System.Windows.Forms.ComboBox cbb_server;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
