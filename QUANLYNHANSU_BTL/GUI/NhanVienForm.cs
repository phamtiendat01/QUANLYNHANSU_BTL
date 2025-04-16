using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;
using ClosedXML.Excel;
using System.IO;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class NhanVienForm : Form
    {
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        private int currentPage = 1;
        private int totalPages = 1;
        private const int pageSize = 10; // Số nhân viên hiển thị trên mỗi trang

        public NhanVienForm()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();
        }

        // ✅ Load danh sách nhân viên có phân trang
        private void LoadDanhSachNhanVien()
        {
            List<NhanVienDTO> danhSach = nhanVienBLL.LayDanhSachPhanTrang(currentPage, pageSize);
            dgvNhanVien.DataSource = danhSach;

            int totalNhanVien = nhanVienBLL.DemTongSoNhanVien();
            totalPages = (int)Math.Ceiling((double)totalNhanVien / pageSize);

            // ✅ Cập nhật giao diện phân trang
            lblPage.Text = $"Trang {currentPage}/{totalPages}";
            btnPrev.Enabled = (currentPage > 1);
            btnNext.Enabled = (currentPage < totalPages);
        }

        // ✅ Phân trang: Trang trước
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDanhSachNhanVien();
            }
        }

        // ✅ Phân trang: Trang sau
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDanhSachNhanVien();
            }
        }

        // ✅ Tìm kiếm nhân viên
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            dgvNhanVien.DataSource = nhanVienBLL.TimKiemNhanVien(keyword);
        }

        // ✅ Lọc theo phòng ban
        private void LoadDanhSachPhongBan()
        {
            List<string> danhSachPhongBan = nhanVienBLL.LayDanhSachPhongBan();

            cmbFilter.Items.Clear(); // Xóa dữ liệu cũ
            cmbFilter.Items.Add("Tất cả"); // Thêm tùy chọn "Tất cả" để hiển thị toàn bộ nhân viên

            foreach (string phongBan in danhSachPhongBan)
            {
                cmbFilter.Items.Add(phongBan);
            }

            cmbFilter.SelectedIndex = 0; // Mặc định chọn "Tất cả"
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhongBan(); // Gọi khi form mở
            dgvNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien(); // Hiển thị danh sách nhân viên ban đầu
        }


        // ✅ Thêm nhân viên
        private void BtnThem_Click(object sender, EventArgs e)
        {
            using (NhanVienPopup popup = new NhanVienPopup())
            {
                popup.StartPosition = FormStartPosition.CenterParent;

                if (popup.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachNhanVien();
                }
            }
        }

        // ✅ Sửa nhân viên
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                string maNV = dgvNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();
                using (NhanVienPopup popup = new NhanVienPopup(maNV))
                {
                    popup.StartPosition = FormStartPosition.CenterParent;
                    if (popup.ShowDialog() == DialogResult.OK)
                    {
                        LoadDanhSachNhanVien();
                    }
                }
            }
        }

        // ✅ Xóa nhân viên
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                string maNV = dgvNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa {maNV}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    nhanVienBLL.XoaNhanVien(maNV);
                    LoadDanhSachNhanVien();
                }
            }
        }
        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilter.SelectedIndex = -1; // Bỏ chọn lọc phòng ban
            currentPage = 1;
            LoadDanhSachNhanVien();
        }

        // ✅ Xuất Excel
        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", Title = "Lưu file Excel" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        List<NhanVienDTO> danhSach = NhanVienBLL.LayDanhSachNhanVienFull();
                        DataTable dt = nhanVienBLL.ConvertListToDataTable(danhSach);
                        wb.Worksheets.Add(dt, "NhanVien");
                        wb.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string phongBan = cmbFilter.SelectedItem.ToString();

            if (phongBan == "Tất cả")
            {
                dgvNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            }
            else
            {
                dgvNhanVien.DataSource = nhanVienBLL.LocNhanVienTheoPhongBan(phongBan);
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
