using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;

namespace QuanLyHoDan
{
    public partial class Form1 : Form
    {
        private List<HoDan> danhSachHoDan = new List<HoDan>();
        private List<NhanKhau> danhSachNhanKhau = new List<NhanKhau>();
        private List<TamTruTamVang> danhSachTamTru = new List<TamTruTamVang>();

        // Sửa đường dẫn nếu thư mục JSON của bạn khác
        private string pathHoDan = @"D:\KTLT\DanhSachQuanLi\DanhSachHoDan.json";
        private string pathNhanKhau = @"D:\KTLT\DanhSachQuanLi\NhanKhauChiTiet.json";
        private string pathTamTru = @"D:\KTLT\DanhSachQuanLi\TamTruTamVang.json";

        private BindingSource bsHoDan = new BindingSource();
        private BindingSource bsNhanKhau = new BindingSource();
        private BindingSource bsTamTru = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromJson();
            BindDataToGrids();

            dgvHoDan.CellContentClick += dgvHoDan_CellContentClick;
            dgvNhanKhau.CellContentClick += dgvNhanKhau_CellContentClick;
            dgvTamTru.CellContentClick += dgvTamTru_CellContentClick;

            txtTimKiemHoDan.TextChanged += txtTimKiemHoDan_TextChanged;
            txtTimKiemNhanKhau.TextChanged += txtTimKiemNhanKhau_TextChanged;
            txtTimKiemTamTru.TextChanged += txtTimKiemTamTru_TextChanged;
        }

        private void LoadDataFromJson()
        {
            if (File.Exists(pathHoDan))
            {
                string json = File.ReadAllText(pathHoDan);
                danhSachHoDan = JsonSerializer.Deserialize<List<HoDan>>(json) ?? new List<HoDan>();
            }

            if (File.Exists(pathNhanKhau))
            {
                string json = File.ReadAllText(pathNhanKhau);
                danhSachNhanKhau = JsonSerializer.Deserialize<List<NhanKhau>>(json) ?? new List<NhanKhau>();
            }

            if (File.Exists(pathTamTru))
            {
                string json = File.ReadAllText(pathTamTru);
                danhSachTamTru = JsonSerializer.Deserialize<List<TamTruTamVang>>(json) ?? new List<TamTruTamVang>();
            }
        }

        private void BindDataToGrids(string filterMaHoDan = null, string filterCCCD = null)
        {
            bsHoDan.DataSource = danhSachHoDan;
            dgvHoDan.DataSource = bsHoDan;

            if (!string.IsNullOrEmpty(filterMaHoDan))
            {
                bsNhanKhau.DataSource = danhSachNhanKhau.Where(n => n.MaHoDan == filterMaHoDan).ToList();
            }
            else
            {
                bsNhanKhau.DataSource = danhSachNhanKhau;
            }
            dgvNhanKhau.DataSource = bsNhanKhau;

            if (!string.IsNullOrEmpty(filterCCCD))
            {
                bsTamTru.DataSource = danhSachTamTru.Where(t => t.CCCD == filterCCCD).ToList();
            }
            else
            {
                bsTamTru.DataSource = danhSachTamTru;
            }
            dgvTamTru.DataSource = bsTamTru;
        }

        private void SaveHoDanToJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(danhSachHoDan, options);
            File.WriteAllText(pathHoDan, json);
        }

        private void SaveNhanKhauToJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(danhSachNhanKhau, options);
            File.WriteAllText(pathNhanKhau, json);
        }

        private void SaveTamTruToJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(danhSachTamTru, options);
            File.WriteAllText(pathTamTru, json);
        }

        private void btnThemHoDan_Click(object sender, EventArgs e)
        {
            FormThemHoDan form = new FormThemHoDan();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newHo = new HoDan
                {
                    STT = (danhSachHoDan.Count + 1).ToString(),
                    MaHoDan = form.MaHoDan,
                    TenChuHo = form.TenChuHo,
                    CCCD = form.CCCD,
                    DiaChi = form.DiaChi,
                    SDT = form.SDT,
                    GhiChu = form.GhiChu
                };
                danhSachHoDan.Add(newHo);
                SaveHoDanToJson();
                BindDataToGrids();
            }
        }

        private void btnThemNhanKhau_Click(object sender, EventArgs e)
        {
            FormThemNhanKhau form = new FormThemNhanKhau();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newNk = new NhanKhau
                {
                    STT = (danhSachNhanKhau.Count + 1).ToString(),
                    MaHoDan = form.MaHoDan,
                    HoVaTen = form.HoVaTen,
                    NamSinh = form.NamSinh.ToString(),
                    GioiTinh = form.GioiTinh,
                    CCCD = form.CCCD,
                    NgheNghiep = form.NgheNghiep,
                    LoaiCuTru = form.LoaiCuTru,
                    GhiChu = form.GhiChu
                };
                danhSachNhanKhau.Add(newNk);
                SaveNhanKhauToJson();
                BindDataToGrids();
            }
        }

        private void btnThemTamTru_Click(object sender, EventArgs e)
        {
            FormThemTamTru form = new FormThemTamTru();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newTt = new TamTruTamVang
                {
                    STT = (danhSachTamTru.Count + 1).ToString(),
                    HoVaTen = form.HoVaTen,
                    CCCD = form.CCCD,
                    HinhThuc = form.HinhThuc,
                    NgayBatDau = form.NgayBatDau,
                    NgayKetThuc = form.NgayKetThuc,
                    GhiChu = form.GhiChu
                };
                danhSachTamTru.Add(newTt);
                SaveTamTruToJson();
                BindDataToGrids();
            }
        }

        private void dgvHoDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvHoDan.Columns[e.ColumnIndex].Name == "colActionHoDan")
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int rowIndex = e.RowIndex;
                menu.Items.Add("Sửa").Click += (s, ev) =>
                {
                    FormThemHoDan form = new FormThemHoDan(danhSachHoDan[rowIndex]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        danhSachHoDan[rowIndex].MaHoDan = form.MaHoDan;
                        danhSachHoDan[rowIndex].TenChuHo = form.TenChuHo;
                        danhSachHoDan[rowIndex].CCCD = form.CCCD;
                        danhSachHoDan[rowIndex].DiaChi = form.DiaChi;
                        danhSachHoDan[rowIndex].SDT = form.SDT;
                        danhSachHoDan[rowIndex].GhiChu = form.GhiChu;
                        SaveHoDanToJson();
                        BindDataToGrids();
                    }
                };
                menu.Items.Add("Xóa").Click += (s, ev) =>
                {
                    danhSachHoDan.RemoveAt(rowIndex);
                    for (int i = 0; i < danhSachHoDan.Count; i++)
                    {
                        danhSachHoDan[i].STT = (i + 1).ToString();
                    }
                    SaveHoDanToJson();
                    BindDataToGrids();
                };
                menu.Show(Cursor.Position);
            }
            else if (dgvHoDan.Columns[e.ColumnIndex].Name == "colMaHoDan")
            {
                string ma = dgvHoDan.Rows[e.RowIndex].Cells["colMaHoDan"].Value.ToString();
                tabControlMain.SelectedTab = tabNhanKhau;
                BindDataToGrids(ma);
            }
        }

        private void dgvNhanKhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvNhanKhau.Columns[e.ColumnIndex].Name == "colActionNhanKhau")
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int rowIndex = e.RowIndex;
                menu.Items.Add("Sửa").Click += (s, ev) =>
                {
                    FormThemNhanKhau form = new FormThemNhanKhau(danhSachNhanKhau[rowIndex]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        danhSachNhanKhau[rowIndex].MaHoDan = form.MaHoDan;
                        danhSachNhanKhau[rowIndex].HoVaTen = form.HoVaTen;
                        danhSachNhanKhau[rowIndex].NamSinh = form.NamSinh.ToString();
                        danhSachNhanKhau[rowIndex].GioiTinh = form.GioiTinh;
                        danhSachNhanKhau[rowIndex].CCCD = form.CCCD;
                        danhSachNhanKhau[rowIndex].NgheNghiep = form.NgheNghiep;
                        danhSachNhanKhau[rowIndex].LoaiCuTru = form.LoaiCuTru;
                        danhSachNhanKhau[rowIndex].GhiChu = form.GhiChu;
                        SaveNhanKhauToJson();
                        BindDataToGrids();
                    }
                };
                menu.Items.Add("Xóa").Click += (s, ev) =>
                {
                    danhSachNhanKhau.RemoveAt(rowIndex);
                    for (int i = 0; i < danhSachNhanKhau.Count; i++)
                    {
                        danhSachNhanKhau[i].STT = (i + 1).ToString();
                    }
                    SaveNhanKhauToJson();
                    BindDataToGrids();
                };
                menu.Show(Cursor.Position);
            }
            else if (dgvNhanKhau.Columns[e.ColumnIndex].Name == "colCCCDNhanKhau" &&
                     dgvNhanKhau.Rows[e.RowIndex].Cells["colLoaiCuTru"].Value?.ToString() == "Tạm trú")
            {
                string cccd = dgvNhanKhau.Rows[e.RowIndex].Cells["colCCCDNhanKhau"].Value?.ToString();
                tabControlMain.SelectedTab = tabTamTru;
                BindDataToGrids(null, cccd);
            }
        }

        private void dgvTamTru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTamTru.Columns[e.ColumnIndex].Name == "colActionTamTru")
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int rowIndex = e.RowIndex;
                menu.Items.Add("Sửa").Click += (s, ev) =>
                {
                    FormThemTamTru form = new FormThemTamTru(danhSachTamTru[rowIndex]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        danhSachTamTru[rowIndex].HoVaTen = form.HoVaTen;
                        danhSachTamTru[rowIndex].CCCD = form.CCCD;
                        danhSachTamTru[rowIndex].HinhThuc = form.HinhThuc;
                        danhSachTamTru[rowIndex].NgayBatDau = form.NgayBatDau;
                        danhSachTamTru[rowIndex].NgayKetThuc = form.NgayKetThuc;
                        danhSachTamTru[rowIndex].GhiChu = form.GhiChu;
                        SaveTamTruToJson();
                        BindDataToGrids();
                    }
                };
                menu.Items.Add("Xóa").Click += (s, ev) =>
                {
                    danhSachTamTru.RemoveAt(rowIndex);
                    for (int i = 0; i < danhSachTamTru.Count; i++)
                    {
                        danhSachTamTru[i].STT = (i + 1).ToString();
                    }
                    SaveTamTruToJson();
                    BindDataToGrids();
                };
                menu.Show(Cursor.Position);
            }
        }

        private void txtTimKiemHoDan_TextChanged(object sender, EventArgs e)
        {
            string filter = txtTimKiemHoDan.Text.ToLower();
            bsHoDan.Filter = string.Format("MaHoDan LIKE '%{0}%' OR TenChuHo LIKE '%{0}%' OR CCCD LIKE '%{0}%' OR DiaChi LIKE '%{0}%' OR SDT LIKE '%{0}%' OR GhiChu LIKE '%{0}%'", filter);
        }

        private void txtTimKiemNhanKhau_TextChanged(object sender, EventArgs e)
        {
            string filter = txtTimKiemNhanKhau.Text.ToLower();
            bsNhanKhau.Filter = string.Format("MaHoDan LIKE '%{0}%' OR HoVaTen LIKE '%{0}%' OR CCCD LIKE '%{0}%' OR NgheNghiep LIKE '%{0}%' OR LoaiCuTru LIKE '%{0}%' OR GhiChu LIKE '%{0}%'", filter);
        }

        private void txtTimKiemTamTru_TextChanged(object sender, EventArgs e)
        {
            string filter = txtTimKiemTamTru.Text.ToLower();
            bsTamTru.Filter = string.Format("HoVaTen LIKE '%{0}%' OR CCCD LIKE '%{0}%' OR HinhThuc LIKE '%{0}%' OR GhiChu LIKE '%{0}%'", filter);
        }
    }
}
