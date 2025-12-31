namespace QuanLyHoDan
{
    partial class FormThemHoDan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaHoDan = new System.Windows.Forms.Label();
            this.txtMaHoDan = new System.Windows.Forms.TextBox();
            this.lblTenChuHo = new System.Windows.Forms.Label();
            this.txtTenChuHo = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblMaHoDan
            this.lblMaHoDan.AutoSize = true;
            this.lblMaHoDan.Location = new System.Drawing.Point(12, 15);
            this.lblMaHoDan.Name = "lblMaHoDan";
            this.lblMaHoDan.Size = new System.Drawing.Size(65, 13);
            this.lblMaHoDan.TabIndex = 0;
            this.lblMaHoDan.Text = "Mã hộ dân:";
            // txtMaHoDan
            this.txtMaHoDan.Location = new System.Drawing.Point(83, 12);
            this.txtMaHoDan.Name = "txtMaHoDan";
            this.txtMaHoDan.Size = new System.Drawing.Size(200, 20);
            this.txtMaHoDan.TabIndex = 1;
            // lblTenChuHo
            this.lblTenChuHo.AutoSize = true;
            this.lblTenChuHo.Location = new System.Drawing.Point(12, 41);
            this.lblTenChuHo.Name = "lblTenChuHo";
            this.lblTenChuHo.Size = new System.Drawing.Size(70, 13);
            this.lblTenChuHo.TabIndex = 2;
            this.lblTenChuHo.Text = "Tên chủ hộ:";
            // txtTenChuHo
            this.txtTenChuHo.Location = new System.Drawing.Point(83, 38);
            this.txtTenChuHo.Name = "txtTenChuHo";
            this.txtTenChuHo.Size = new System.Drawing.Size(200, 20);
            this.txtTenChuHo.TabIndex = 3;
            // lblCCCD
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(12, 67);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(43, 13);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "CCCD:";
            // txtCCCD
            this.txtCCCD.Location = new System.Drawing.Point(83, 64);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(200, 20);
            this.txtCCCD.TabIndex = 5;
            // lblDiaChi
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 93);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(52, 13);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ:";
            // txtDiaChi
            this.txtDiaChi.Location = new System.Drawing.Point(83, 90);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 7;
            // lblSDT
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(12, 119);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(35, 13);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "SĐT:";
            // txtSDT
            this.txtSDT.Location = new System.Drawing.Point(83, 116);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 20);
            this.txtSDT.TabIndex = 9;
            // lblGhiChu
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(12, 145);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(54, 13);
            this.lblGhiChu.TabIndex = 10;
            this.lblGhiChu.Text = "Ghi chú:";
            // txtGhiChu
            this.txtGhiChu.Location = new System.Drawing.Point(83, 142);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 20);
            this.txtGhiChu.TabIndex = 11;
            // btnOK
            this.btnOK.Location = new System.Drawing.Point(83, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(164, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // FormThemHoDan
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.txtTenChuHo);
            this.Controls.Add(this.lblTenChuHo);
            this.Controls.Add(this.txtMaHoDan);
            this.Controls.Add(this.lblMaHoDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormThemHoDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/Sửa Hộ Dân";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMaHoDan;
        private System.Windows.Forms.TextBox txtMaHoDan;
        private System.Windows.Forms.Label lblTenChuHo;
        private System.Windows.Forms.TextBox txtTenChuHo;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}