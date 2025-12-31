using System;
using System.Windows.Forms;

namespace QuanLyHoDan
{
    public partial class FormThemHoDan : Form
    {
        public string MaHoDan { get { return txtMaHoDan.Text; } }
        public string TenChuHo { get { return txtTenChuHo.Text; } }
        public string CCCD { get { return txtCCCD.Text; } }
        public string DiaChi { get { return txtDiaChi.Text; } }
        public string SDT { get { return txtSDT.Text; } }
        public string GhiChu { get { return txtGhiChu.Text; } }

        public FormThemHoDan()
        {
            InitializeComponent();
        }

        public FormThemHoDan(HoDan ho) : this()
        {
            txtMaHoDan.Text = ho.MaHoDan ?? "";
            txtTenChuHo.Text = ho.TenChuHo ?? "";
            txtCCCD.Text = ho.CCCD ?? "";
            txtDiaChi.Text = ho.DiaChi ?? "";
            txtSDT.Text = ho.SDT ?? "";
            txtGhiChu.Text = ho.GhiChu ?? "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoDan.Text) || string.IsNullOrEmpty(txtTenChuHo.Text))
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