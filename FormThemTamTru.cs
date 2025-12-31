using System;
using System.Windows.Forms;

namespace QuanLyHoDan
{
    public partial class FormThemTamTru : Form
    {
        public string HoVaTen { get { return txtHoVaTen.Text; } }
        public string CCCD { get { return txtCCCD.Text; } }
        public string HinhThuc { get { return txtHinhThuc.Text; } }
        public DateTime NgayBatDau { get { return dtpNgayBatDau.Value; } }
        public DateTime NgayKetThuc { get { return dtpNgayKetThuc.Value; } }
        public string GhiChu { get { return txtGhiChu.Text; } }

        public FormThemTamTru()
        {
            InitializeComponent();
        }

        public FormThemTamTru(TamTruTamVang tt) : this()
        {
            txtHoVaTen.Text = tt.HoVaTen ?? "";
            txtCCCD.Text = tt.CCCD ?? "";
            txtHinhThuc.Text = tt.HinhThuc ?? "";
            dtpNgayBatDau.Value = tt.NgayBatDau != DateTime.MinValue ? tt.NgayBatDau : DateTime.Now;
            dtpNgayKetThuc.Value = tt.NgayKetThuc != DateTime.MinValue ? tt.NgayKetThuc : DateTime.Now;
            txtGhiChu.Text = tt.GhiChu ?? "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoVaTen.Text) || string.IsNullOrEmpty(txtCCCD.Text) || NgayBatDau > NgayKetThuc)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kiểm tra ngày tháng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}