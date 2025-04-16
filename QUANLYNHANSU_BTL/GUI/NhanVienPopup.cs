using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class NhanVienPopup : Form
    {
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        private string maNV = null;

        public NhanVienPopup(string maNV = null)
        {
            InitializeComponent();
            this.maNV = maNV;

            // Gán sự kiện Load
            this.Load += NhanVienPopup_Load;

            if (maNV != null)
            {
                LoadData();
            }
        }

        private void NhanVienPopup_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu cho cmbLoaiNV (Danh sách tĩnh)
            cmbLoaiNV.Items.Clear();
            cmbLoaiNV.Items.Add("Nhân viên chính thức");
            cmbLoaiNV.Items.Add("Nhân viên hợp đồng");
            cmbLoaiNV.SelectedIndex = 0;

            // Đổ dữ liệu cho cmbPhongBan từ CSDL thông qua `NhanVienBLL`
            cmbPhongBan.Items.Clear();
            List<string> danhSachPhongBan = nhanVienBLL.LayDanhSachPhongBan(); // Gọi từ NhanVienBLL

            cmbPhongBan.Items.AddRange(danhSachPhongBan.ToArray());

            // Chọn mục đầu tiên làm mặc định nếu có dữ liệu
            if (cmbPhongBan.Items.Count > 0)
            {
                cmbPhongBan.SelectedIndex = 0;
            }
        }

        private void LoadData()
        {
            var nv = nhanVienBLL.LayNhanVienTheoMa(maNV);
            if (nv != null)
            {
                txtMaNV.Text = nv.MaNV;
                txtHoTen.Text = nv.HoTen;
                txtCMND_CCCD.Text = nv.CMND_CCCD;
                dtpNgaySinh.Value = nv.NgaySinh;
                txtSDT.Text = nv.SDT;
                cmbGioiTinh.SelectedItem = nv.GioiTinh;

                // Chọn giá trị trong cmbPhongBan nếu có
                if (cmbPhongBan.Items.Contains(nv.PhongBan))
                    cmbPhongBan.SelectedItem = nv.PhongBan;

                // Chọn giá trị trong cmbChucVu nếu có
                if (cmbChucVu.Items.Contains(nv.ChucVu))
                    cmbChucVu.SelectedItem = nv.ChucVu;

                // Chọn giá trị trong cmbLoaiNV nếu có
                if (cmbLoaiNV.Items.Contains(nv.LoaiNV))
                    cmbLoaiNV.SelectedItem = nv.LoaiNV;

                txtHocVan.Text = nv.HocVan;
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            var nv = new NhanVienDTO()
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                CMND_CCCD = txtCMND_CCCD.Text,
                NgaySinh = dtpNgaySinh.Value,
                SDT = txtSDT.Text,
                GioiTinh = cmbGioiTinh.SelectedItem?.ToString(),
                PhongBan = cmbPhongBan.SelectedItem?.ToString(),
                ChucVu = cmbChucVu.SelectedItem?.ToString(),
                LoaiNV = cmbLoaiNV.SelectedItem?.ToString(),
                HocVan = txtHocVan.Text
            };

            if (maNV == null)
            {
                nhanVienBLL.ThemNhanVien(nv);
            }
            else
            {
                nhanVienBLL.CapNhatNhanVien(nv);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
