using ClosedXML.Excel;
using QUANLYNHANSU_BTL.BLL;
using System;
using System.Data;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangLuongControl : UserControl
    {
        private int currentPage = 1;
        private int pageSize = 10;

        public BangLuongControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvBangLuong.DataSource = BangLuongBLL.GetBangLuong(currentPage, pageSize);
            lblPage.Text = $"Page {currentPage} of {Math.Ceiling((double)BangLuongBLL.GetTotalRows() / pageSize)}";
            //object dt = null;
            //dgvBangLuong.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Mở Popup "Thêm" (mã nhân viên chưa được điền)
            BangLuongPopupForm addForm = new BangLuongPopupForm();
            addForm.StartPosition = FormStartPosition.CenterParent;  // Đặt vị trí của Popup ở giữa form cha
            addForm.ShowDialog();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvBangLuong.SelectedRows.Count > 0)
            {
                // Lấy mã nhân viên của dòng đã chọn
                DataGridViewRow selectedRow = dgvBangLuong.SelectedRows[0];
                string maNV = selectedRow.Cells["MaNV"].Value.ToString();

                // Mở popup sửa với thông tin nhân viên
                BangLuongPopupForm editForm = new BangLuongPopupForm(maNV);
                editForm.StartPosition = FormStartPosition.CenterParent;  // Đặt vị trí của Popup ở giữa form cha
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvBangLuong.CurrentRow;
            if (selectedRow != null)
            {
                string maNV = selectedRow.Cells["MaNV"].Value.ToString();
                BangLuongBLL.DeleteBangLuong(maNV);
                LoadData();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            currentPage = 1;
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            dgvBangLuong.DataSource = BangLuongBLL.SearchByMaNV(searchValue);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)BangLuongBLL.GetTotalRows() / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        // Export data to Excel
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Create a new Excel workbook
            using (var workbook = new XLWorkbook())
            {
                // Add a worksheet
                var worksheet = workbook.AddWorksheet("Bảng Lương");

                // Get the data from the DataGridView
                var dt = (DataTable)dgvBangLuong.DataSource;

                // Write column headers to the first row of the Excel file
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = dt.Columns[col].ColumnName;
                    worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                    worksheet.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.FromArgb(0x9c, 0x9c, 0x9c);  // Light gray
                }

                // Write data to the worksheet starting from the second row
                for (int row = 0; row < dt.Rows.Count && row < 1048576; row++) // Giới hạn số dòng
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        worksheet.Cell(row + 2, col + 1).Value = Convert.ToString(dt.Rows[row][col]); // Lưu dữ liệu vào Excel
                        worksheet.Cell(row + 2, col + 1).Style.Font.Bold = true;
                        worksheet.Cell(row + 2, col + 1).Style.Fill.BackgroundColor = XLColor.FromArgb(0x9c, 0x9c, 0x9c); // Màu nền
                    }
                }


                // Save the Excel file to a memory stream
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the file
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Export successful!");
                }
            }
        }

        private void BangLuongControl_Load(object sender, EventArgs e)
        {

        }
    }
}
