// Đây là nội dung đầy đủ cho file Form1.Designer.cs
// Bạn có thể copy và paste vào file Designer.cs trong project của bạn.
// Nếu không có file này, bạn có thể thêm tất cả code này vào Form1.cs, nhưng tốt nhất dùng Designer.


namespace QuanLyHoDan
{
    partial class Form1
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
            tabControlMain = new TabControl();
            tabHoDan = new TabPage();
            txtTimKiemHoDan = new TextBox();
            btnThemHoDan = new Button();
            dgvHoDan = new DataGridView();
            colSTTHoDan = new DataGridViewTextBoxColumn();
            colMaHoDan = new DataGridViewLinkColumn();
            colTenChuHo = new DataGridViewTextBoxColumn();
            colCCCDHoDan = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colGhiChuHoDan = new DataGridViewTextBoxColumn();
            colActionHoDan = new DataGridViewButtonColumn();
            tabNhanKhau = new TabPage();
            txtTimKiemNhanKhau = new TextBox();
            btnThemNhanKhau = new Button();
            dgvNhanKhau = new DataGridView();
            colSTTNhanKhau = new DataGridViewTextBoxColumn();
            colMaHoDanNhanKhau = new DataGridViewTextBoxColumn();
            colHoVaTen = new DataGridViewTextBoxColumn();
            colNamSinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colCCCDNhanKhau = new DataGridViewLinkColumn();
            colNgheNghiep = new DataGridViewTextBoxColumn();
            colLoaiCuTru = new DataGridViewTextBoxColumn();
            colGhiChuNhanKhau = new DataGridViewTextBoxColumn();
            colActionNhanKhau = new DataGridViewButtonColumn();
            tabTamTru = new TabPage();
            txtTimKiemTamTru = new TextBox();
            btnThemTamTru = new Button();
            dgvTamTru = new DataGridView();
            colSTTTamTru = new DataGridViewTextBoxColumn();
            colHoVaTenTamTru = new DataGridViewTextBoxColumn();
            colCCCDTamTru = new DataGridViewTextBoxColumn();
            colHinhThuc = new DataGridViewTextBoxColumn();
            colNgayBatDau = new DataGridViewTextBoxColumn();
            colNgayKetThuc = new DataGridViewTextBoxColumn();
            colGhiChuTamTru = new DataGridViewTextBoxColumn();
            colActionTamTru = new DataGridViewButtonColumn();
            tabControlMain.SuspendLayout();
            tabHoDan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoDan).BeginInit();
            tabNhanKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanKhau).BeginInit();
            tabTamTru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTamTru).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabHoDan);
            tabControlMain.Controls.Add(tabNhanKhau);
            tabControlMain.Controls.Add(tabTamTru);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(4, 5, 4, 5);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1067, 692);
            tabControlMain.TabIndex = 0;
            // 
            // tabHoDan
            // 
            tabHoDan.Controls.Add(txtTimKiemHoDan);
            tabHoDan.Controls.Add(btnThemHoDan);
            tabHoDan.Controls.Add(dgvHoDan);
            tabHoDan.Location = new Point(4, 29);
            tabHoDan.Margin = new Padding(4, 5, 4, 5);
            tabHoDan.Name = "tabHoDan";
            tabHoDan.Padding = new Padding(4, 5, 4, 5);
            tabHoDan.Size = new Size(1059, 659);
            tabHoDan.TabIndex = 0;
            tabHoDan.Text = "Danh sách hộ dân";
            tabHoDan.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemHoDan
            // 
            txtTimKiemHoDan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiemHoDan.Location = new Point(800, 9);
            txtTimKiemHoDan.Margin = new Padding(4, 5, 4, 5);
            txtTimKiemHoDan.Name = "txtTimKiemHoDan";
            txtTimKiemHoDan.Size = new Size(247, 27);
            txtTimKiemHoDan.TabIndex = 2;
            // 
            // btnThemHoDan
            // 
            btnThemHoDan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemHoDan.Location = new Point(8, 608);
            btnThemHoDan.Margin = new Padding(4, 5, 4, 5);
            btnThemHoDan.Name = "btnThemHoDan";
            btnThemHoDan.Size = new Size(133, 35);
            btnThemHoDan.TabIndex = 1;
            btnThemHoDan.Text = "Thêm hộ dân";
            btnThemHoDan.UseVisualStyleBackColor = true;
            btnThemHoDan.Click += btnThemHoDan_Click;
            // 
            // dgvHoDan
            // 
            dgvHoDan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoDan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoDan.Columns.AddRange(new DataGridViewColumn[] { colSTTHoDan, colMaHoDan, colTenChuHo, colCCCDHoDan, colDiaChi, colSDT, colGhiChuHoDan, colActionHoDan });
            dgvHoDan.Location = new Point(8, 49);
            dgvHoDan.Margin = new Padding(4, 5, 4, 5);
            dgvHoDan.Name = "dgvHoDan";
            dgvHoDan.RowHeadersWidth = 51;
            dgvHoDan.Size = new Size(1040, 549);
            dgvHoDan.TabIndex = 0;
            // 
            // colSTTHoDan
            // 
            colSTTHoDan.DataPropertyName = "STT";
            colSTTHoDan.HeaderText = "STT";
            colSTTHoDan.MinimumWidth = 6;
            colSTTHoDan.Name = "colSTTHoDan";
            colSTTHoDan.Width = 125;
            // 
            // colMaHoDan
            // 
            colMaHoDan.DataPropertyName = "MaHoDan";
            colMaHoDan.HeaderText = "Mã hộ dân";
            colMaHoDan.MinimumWidth = 6;
            colMaHoDan.Name = "colMaHoDan";
            colMaHoDan.Width = 125;
            // 
            // colTenChuHo
            // 
            colTenChuHo.DataPropertyName = "TenChuHo";
            colTenChuHo.HeaderText = "Tên chủ hộ";
            colTenChuHo.MinimumWidth = 6;
            colTenChuHo.Name = "colTenChuHo";
            colTenChuHo.Width = 125;
            // 
            // colCCCDHoDan
            // 
            colCCCDHoDan.DataPropertyName = "CCCD";
            colCCCDHoDan.HeaderText = "CCCD";
            colCCCDHoDan.MinimumWidth = 6;
            colCCCDHoDan.Name = "colCCCDHoDan";
            colCCCDHoDan.Width = 125;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.Width = 125;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SDT";
            colSDT.HeaderText = "SĐT";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.Width = 125;
            // 
            // colGhiChuHoDan
            // 
            colGhiChuHoDan.DataPropertyName = "GhiChu";
            colGhiChuHoDan.HeaderText = "Ghi chú";
            colGhiChuHoDan.MinimumWidth = 6;
            colGhiChuHoDan.Name = "colGhiChuHoDan";
            colGhiChuHoDan.Width = 125;
            // 
            // colActionHoDan
            // 
            colActionHoDan.HeaderText = "...";
            colActionHoDan.MinimumWidth = 6;
            colActionHoDan.Name = "colActionHoDan";
            colActionHoDan.Text = "...";
            colActionHoDan.UseColumnTextForButtonValue = true;
            colActionHoDan.Width = 125;
            // 
            // tabNhanKhau
            // 
            tabNhanKhau.Controls.Add(txtTimKiemNhanKhau);
            tabNhanKhau.Controls.Add(btnThemNhanKhau);
            tabNhanKhau.Controls.Add(dgvNhanKhau);
            tabNhanKhau.Location = new Point(4, 29);
            tabNhanKhau.Margin = new Padding(4, 5, 4, 5);
            tabNhanKhau.Name = "tabNhanKhau";
            tabNhanKhau.Padding = new Padding(4, 5, 4, 5);
            tabNhanKhau.Size = new Size(1059, 659);
            tabNhanKhau.TabIndex = 1;
            tabNhanKhau.Text = "Nhân khẩu chi tiết";
            tabNhanKhau.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemNhanKhau
            // 
            txtTimKiemNhanKhau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiemNhanKhau.Location = new Point(800, 9);
            txtTimKiemNhanKhau.Margin = new Padding(4, 5, 4, 5);
            txtTimKiemNhanKhau.Name = "txtTimKiemNhanKhau";
            txtTimKiemNhanKhau.Size = new Size(247, 27);
            txtTimKiemNhanKhau.TabIndex = 3;
            // 
            // btnThemNhanKhau
            // 
            btnThemNhanKhau.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemNhanKhau.Location = new Point(8, 608);
            btnThemNhanKhau.Margin = new Padding(4, 5, 4, 5);
            btnThemNhanKhau.Name = "btnThemNhanKhau";
            btnThemNhanKhau.Size = new Size(133, 35);
            btnThemNhanKhau.TabIndex = 2;
            btnThemNhanKhau.Text = "Thêm nhân khẩu";
            btnThemNhanKhau.UseVisualStyleBackColor = true;
            btnThemNhanKhau.Click += btnThemNhanKhau_Click;
            // 
            // dgvNhanKhau
            // 
            dgvNhanKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanKhau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanKhau.Columns.AddRange(new DataGridViewColumn[] { colSTTNhanKhau, colMaHoDanNhanKhau, colHoVaTen, colNamSinh, colGioiTinh, colCCCDNhanKhau, colNgheNghiep, colLoaiCuTru, colGhiChuNhanKhau, colActionNhanKhau });
            dgvNhanKhau.Location = new Point(8, 49);
            dgvNhanKhau.Margin = new Padding(4, 5, 4, 5);
            dgvNhanKhau.Name = "dgvNhanKhau";
            dgvNhanKhau.RowHeadersWidth = 51;
            dgvNhanKhau.Size = new Size(1040, 549);
            dgvNhanKhau.TabIndex = 0;
            // 
            // colSTTNhanKhau
            // 
            colSTTNhanKhau.DataPropertyName = "STT";
            colSTTNhanKhau.HeaderText = "STT";
            colSTTNhanKhau.MinimumWidth = 6;
            colSTTNhanKhau.Name = "colSTTNhanKhau";
            colSTTNhanKhau.Width = 125;
            // 
            // colMaHoDanNhanKhau
            // 
            colMaHoDanNhanKhau.DataPropertyName = "MaHoDan";
            colMaHoDanNhanKhau.HeaderText = "Mã hộ dân";
            colMaHoDanNhanKhau.MinimumWidth = 6;
            colMaHoDanNhanKhau.Name = "colMaHoDanNhanKhau";
            colMaHoDanNhanKhau.Width = 125;
            // 
            // colHoVaTen
            // 
            colHoVaTen.DataPropertyName = "HoVaTen";
            colHoVaTen.HeaderText = "Họ và tên";
            colHoVaTen.MinimumWidth = 6;
            colHoVaTen.Name = "colHoVaTen";
            colHoVaTen.Width = 125;
            // 
            // colNamSinh
            // 
            colNamSinh.DataPropertyName = "NamSinh";
            colNamSinh.HeaderText = "Năm sinh";
            colNamSinh.MinimumWidth = 6;
            colNamSinh.Name = "colNamSinh";
            colNamSinh.Width = 125;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.Width = 125;
            // 
            // colCCCDNhanKhau
            // 
            colCCCDNhanKhau.DataPropertyName = "CCCD";
            colCCCDNhanKhau.HeaderText = "CCCD";
            colCCCDNhanKhau.MinimumWidth = 6;
            colCCCDNhanKhau.Name = "colCCCDNhanKhau";
            colCCCDNhanKhau.Width = 125;
            // 
            // colNgheNghiep
            // 
            colNgheNghiep.DataPropertyName = "NgheNghiep";
            colNgheNghiep.HeaderText = "Nghề nghiệp";
            colNgheNghiep.MinimumWidth = 6;
            colNgheNghiep.Name = "colNgheNghiep";
            colNgheNghiep.Width = 125;
            // 
            // colLoaiCuTru
            // 
            colLoaiCuTru.DataPropertyName = "LoaiCuTru";
            colLoaiCuTru.HeaderText = "Loại cư trú";
            colLoaiCuTru.MinimumWidth = 6;
            colLoaiCuTru.Name = "colLoaiCuTru";
            colLoaiCuTru.Width = 125;
            // 
            // colGhiChuNhanKhau
            // 
            colGhiChuNhanKhau.DataPropertyName = "GhiChu";
            colGhiChuNhanKhau.HeaderText = "Ghi chú";
            colGhiChuNhanKhau.MinimumWidth = 6;
            colGhiChuNhanKhau.Name = "colGhiChuNhanKhau";
            colGhiChuNhanKhau.Width = 125;
            // 
            // colActionNhanKhau
            // 
            colActionNhanKhau.HeaderText = "...";
            colActionNhanKhau.MinimumWidth = 6;
            colActionNhanKhau.Name = "colActionNhanKhau";
            colActionNhanKhau.Text = "...";
            colActionNhanKhau.UseColumnTextForButtonValue = true;
            colActionNhanKhau.Width = 125;
            // 
            // tabTamTru
            // 
            tabTamTru.Controls.Add(txtTimKiemTamTru);
            tabTamTru.Controls.Add(btnThemTamTru);
            tabTamTru.Controls.Add(dgvTamTru);
            tabTamTru.Location = new Point(4, 29);
            tabTamTru.Margin = new Padding(4, 5, 4, 5);
            tabTamTru.Name = "tabTamTru";
            tabTamTru.Padding = new Padding(4, 5, 4, 5);
            tabTamTru.Size = new Size(1059, 659);
            tabTamTru.TabIndex = 2;
            tabTamTru.Text = "Tạm trú - Tạm vắng";
            tabTamTru.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemTamTru
            // 
            txtTimKiemTamTru.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiemTamTru.Location = new Point(800, 9);
            txtTimKiemTamTru.Margin = new Padding(4, 5, 4, 5);
            txtTimKiemTamTru.Name = "txtTimKiemTamTru";
            txtTimKiemTamTru.Size = new Size(247, 27);
            txtTimKiemTamTru.TabIndex = 3;
            // 
            // btnThemTamTru
            // 
            btnThemTamTru.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemTamTru.Location = new Point(8, 608);
            btnThemTamTru.Margin = new Padding(4, 5, 4, 5);
            btnThemTamTru.Name = "btnThemTamTru";
            btnThemTamTru.Size = new Size(133, 35);
            btnThemTamTru.TabIndex = 2;
            btnThemTamTru.Text = "Thêm tạm trú";
            btnThemTamTru.UseVisualStyleBackColor = true;
            btnThemTamTru.Click += btnThemTamTru_Click;
            // 
            // dgvTamTru
            // 
            dgvTamTru.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTamTru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTamTru.Columns.AddRange(new DataGridViewColumn[] { colSTTTamTru, colHoVaTenTamTru, colCCCDTamTru, colHinhThuc, colNgayBatDau, colNgayKetThuc, colGhiChuTamTru, colActionTamTru });
            dgvTamTru.Location = new Point(8, 49);
            dgvTamTru.Margin = new Padding(4, 5, 4, 5);
            dgvTamTru.Name = "dgvTamTru";
            dgvTamTru.RowHeadersWidth = 51;
            dgvTamTru.Size = new Size(1040, 549);
            dgvTamTru.TabIndex = 0;
            dgvTamTru.CellContentClick += dgvTamTru_CellContentClick_1;
            // 
            // colSTTTamTru
            // 
            colSTTTamTru.DataPropertyName = "STT";
            colSTTTamTru.HeaderText = "STT";
            colSTTTamTru.MinimumWidth = 6;
            colSTTTamTru.Name = "colSTTTamTru";
            colSTTTamTru.Width = 125;
            // 
            // colHoVaTenTamTru
            // 
            colHoVaTenTamTru.DataPropertyName = "HoVaTen";
            colHoVaTenTamTru.HeaderText = "Họ và tên";
            colHoVaTenTamTru.MinimumWidth = 6;
            colHoVaTenTamTru.Name = "colHoVaTenTamTru";
            colHoVaTenTamTru.Width = 125;
            // 
            // colCCCDTamTru
            // 
            colCCCDTamTru.DataPropertyName = "CCCD";
            colCCCDTamTru.HeaderText = "CCCD";
            colCCCDTamTru.MinimumWidth = 6;
            colCCCDTamTru.Name = "colCCCDTamTru";
            colCCCDTamTru.Width = 125;
            // 
            // colHinhThuc
            // 
            colHinhThuc.DataPropertyName = "HinhThuc";
            colHinhThuc.HeaderText = "Hình thức";
            colHinhThuc.MinimumWidth = 6;
            colHinhThuc.Name = "colHinhThuc";
            colHinhThuc.Width = 125;
            // 
            // colNgayBatDau
            // 
            colNgayBatDau.DataPropertyName = "NgayBatDau";
            colNgayBatDau.HeaderText = "Ngày bắt đầu";
            colNgayBatDau.MinimumWidth = 6;
            colNgayBatDau.Name = "colNgayBatDau";
            colNgayBatDau.Width = 125;
            // 
            // colNgayKetThuc
            // 
            colNgayKetThuc.DataPropertyName = "NgayKetThuc";
            colNgayKetThuc.HeaderText = "Ngày kết thúc";
            colNgayKetThuc.MinimumWidth = 6;
            colNgayKetThuc.Name = "colNgayKetThuc";
            colNgayKetThuc.Width = 125;
            // 
            // colGhiChuTamTru
            // 
            colGhiChuTamTru.DataPropertyName = "GhiChu";
            colGhiChuTamTru.HeaderText = "Ghi chú";
            colGhiChuTamTru.MinimumWidth = 6;
            colGhiChuTamTru.Name = "colGhiChuTamTru";
            colGhiChuTamTru.Width = 125;
            // 
            // colActionTamTru
            // 
            colActionTamTru.HeaderText = "...";
            colActionTamTru.MinimumWidth = 6;
            colActionTamTru.Name = "colActionTamTru";
            colActionTamTru.Text = "...";
            colActionTamTru.UseColumnTextForButtonValue = true;
            colActionTamTru.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(tabControlMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Quản lý hộ dân";
            Load += Form1_Load;
            tabControlMain.ResumeLayout(false);
            tabHoDan.ResumeLayout(false);
            tabHoDan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoDan).EndInit();
            tabNhanKhau.ResumeLayout(false);
            tabNhanKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanKhau).EndInit();
            tabTamTru.ResumeLayout(false);
            tabTamTru.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTamTru).EndInit();
            ResumeLayout(false);

        }

        private void dgvTamTru_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabHoDan;
        private System.Windows.Forms.TabPage tabNhanKhau;
        private System.Windows.Forms.TabPage tabTamTru;
        private System.Windows.Forms.DataGridView dgvHoDan;
        private System.Windows.Forms.Button btnThemHoDan;
        private System.Windows.Forms.TextBox txtTimKiemHoDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTTHoDan;
        private System.Windows.Forms.DataGridViewLinkColumn colMaHoDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCDHoDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChuHoDan;
        private System.Windows.Forms.DataGridViewButtonColumn colActionHoDan;
        private System.Windows.Forms.TextBox txtTimKiemNhanKhau;
        private System.Windows.Forms.Button btnThemNhanKhau;
        private System.Windows.Forms.DataGridView dgvNhanKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTTNhanKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoDanNhanKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewLinkColumn colCCCDNhanKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiCuTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChuNhanKhau;
        private System.Windows.Forms.DataGridViewButtonColumn colActionNhanKhau;
        private System.Windows.Forms.TextBox txtTimKiemTamTru;
        private System.Windows.Forms.Button btnThemTamTru;
        private System.Windows.Forms.DataGridView dgvTamTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTTTamTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTenTamTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCDTamTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChuTamTru;
        private System.Windows.Forms.DataGridViewButtonColumn colActionTamTru;
    }
}
