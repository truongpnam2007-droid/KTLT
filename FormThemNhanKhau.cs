using System;
using System.Windows.Forms;

namespace QuanLyHoDan
{
    public partial class FormThemNhanKhau : Form
    {
        public string MaHoDan { get { return txtMaHoDan.Text; } }
        public string HoVaTen { get { return txtHoVaTen.Text; } }
        public int NamSinh { get { if (int.TryParse(txtNamSinh.Text, out int ns)) return ns; else return 0; } }
        public string GioiTinh { get { return txtGioiTinh.Text; } }
        public string CCCD { get { return txtCCCD.Text; } }
        public string NgheNghiep { get { return txtNgheNghiep.Text; } }
        public string LoaiCuTru { get { return txtLoaiCuTru.Text; } }
        public string GhiChu { get { return txtGhiChu.Text; } }

        public FormThemNhanKhau()
        {
            InitializeComponent();
        }

        public FormThemNhanKhau(NhanKhau nk) : this()
        {
            txtMaHoDan.Text = nk.MaHoDan ?? "";
            txtHoVaTen.Text = nk.HoVaTen ?? "";
            txtNamSinh.Text = nk.NamSinh.ToString();
            txtGioiTinh.Text = nk.GioiTinh ?? "";
            txtCCCD.Text = nk.CCCD ?? "";
            txtNgheNghiep.Text = nk.NgheNghiep ?? "";
            txtLoaiCuTru.Text = nk.LoaiCuTru ?? "";
            txtGhiChu.Text = nk.GhiChu ?? "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoDan.Text) || string.IsNullOrEmpty(txtHoVaTen.Text) || string.IsNullOrEmpty(txtNamSinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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