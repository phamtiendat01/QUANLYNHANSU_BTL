using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;
using System.IO;
using ClosedXML.Excel;
using System.Drawing;
using System.Data;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BoPhanForm : Form
    {
        private BoPhanBLL boPhanBLL = new BoPhanBLL();
        private int pageSize = 10; // Số dòng trên mỗi trang
        private int currentPage = 1; // Trang hiện tại
        private int totalPages = 1; // Tổng số trang

        public BoPhanForm()
        {
            InitializeComponent();
            LoadDanhSachBoPhan();
         

        }

        // ✅ Load danh sách phòng ban (có phân trang)
        private void LoadDanhSachBoPhan()
        {
            int totalRecords = boPhanBLL.DemTongSoBoPhan();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            List<BoPhanDTO> danhSach = boPhanBLL.LayDanhSachPhanTrang(currentPage, pageSize);
            dgvBoPhan.DataSource = danhSach;

            // ✅ Cập nhật hiển thị số trang
            lblTrang.Text = $"Trang {currentPage} / {totalPages}";
            // ✅ Vô hiệu hóa nút nếu cần
            btnTruoc.Enabled = (currentPage > 1);
            btnSau.Enabled = (currentPage < totalPages);
        }

        // ✅ Nút "Trước"
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDanhSachBoPhan();
            }
        }

        // ✅ Nút "Sau"
        private void btnSau_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDanhSachBoPhan();
            }
        }

        // ✅ Nút "Làm mới"
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadDanhSachBoPhan();
        }

        // ✅ Nút "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            BoPhanPopup popup = new BoPhanPopup();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachBoPhan();
            }
        }

        // ✅ Nút "Sửa"
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvBoPhan.SelectedRows.Count > 0)
            {
                string maPB = dgvBoPhan.SelectedRows[0].Cells["MaPB"].Value.ToString();

                // Gọi trực tiếp LayBoPhanTheoMa mà không cần ép kiểu int
                DataRow row = boPhanBLL.LayBoPhanTheoMa(maPB);

                if (row != null) // Kiểm tra nếu row có dữ liệu
                {
                    BoPhanDTO boPhan = new BoPhanDTO
                    {
                        MaPB = row["MaPB"].ToString(),
                        TenPB = row["TenPB"].ToString()
                    };

                    BoPhanPopup popup = new BoPhanPopup(boPhan);
                    if (popup.ShowDialog() == DialogResult.OK)
                    {
                        LoadDanhSachBoPhan();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bộ phận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bộ phận để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        // ✅ Nút "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBoPhan.SelectedRows.Count > 0)
            {
                string maPB = dgvBoPhan.SelectedRows[0].Cells["MaPB"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bộ phận này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    boPhanBLL.XoaBoPhan(maPB);
                    LoadDanhSachBoPhan();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bộ phận để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ✅ Nút "Tìm kiếm"
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            string keyword = txtTimKiem.Text.Trim();
            List<BoPhanDTO> danhSach = boPhanBLL.TimBoPhan(keyword);

            dgvBoPhan.DataSource = null;
            dgvBoPhan.DataSource = danhSach;
        }


        // ✅ Nút "Xuất Excel"
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Chọn nơi lưu file Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Danh Sách Bộ Phận");

                    // ✅ Tiêu đề cột
                    worksheet.Cell(1, 1).Value = "Mã PB";
                    worksheet.Cell(1, 2).Value = "Tên PB";

                    // ✅ Định dạng tiêu đề
                    var titleRange = worksheet.Range("A1:B1");
                    titleRange.Style.Font.Bold = true;
                    titleRange.Style.Font.FontSize = 12;
                    titleRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    titleRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // ✅ Lấy dữ liệu từ DataGridView
                    int row = 2;
                    foreach (DataGridViewRow dgvRow in dgvBoPhan.Rows)
                    {
                        if (!dgvRow.IsNewRow) // Bỏ qua dòng trống cuối cùng
                        {
                            worksheet.Cell(row, 1).Value = dgvRow.Cells["MaPB"].Value?.ToString();
                            worksheet.Cell(row, 2).Value = dgvRow.Cells["TenPB"].Value?.ToString();
                            row++;
                        }
                    }

                    // ✅ Auto fit columns
                    worksheet.Columns().AdjustToContents();

                    // ✅ Lưu file Excel
                    workbook.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BoPhanForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
