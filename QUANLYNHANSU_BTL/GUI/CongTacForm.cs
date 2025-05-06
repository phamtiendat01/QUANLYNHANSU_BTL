using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;
using ClosedXML.Excel;
using System.Collections.Generic;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class CongTacForm : Form
    {
        private int currentPage = 1;
        private int totalRecords = 0;
        private int pageSize = 15;
        private int totalPages = 0;

        public CongTacForm()
        {
            InitializeComponent();
        }

        private void CongTacForm_Load(object sender, EventArgs e)
        {
            LoadPagination();
        }

        private void LoadPagination()
        {
            var congTacBLL = new CongTacBLL();
            totalRecords = congTacBLL.GetTotalRecords();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            LoadDataByPage(currentPage);
        }

        private void LoadDataByPage(int page)
        {
            var congTacBLL = new CongTacBLL();
            var congTacList = congTacBLL.GetCongTac(page, pageSize);

            if (congTacList == null || congTacList.Count == 0)
            {
                dgvCongTac.DataSource = null;
                lblPageInfo.Text = "Không có dữ liệu.";
                Console.WriteLine("Không có dữ liệu trong congTacList.");
                return;
            }

            DataTable dt = congTacBLL.ConvertListToDataTable(congTacList);
            dgvCongTac.DataSource = dt;
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";

            // Debug: Log column names
            Console.WriteLine("Danh sách cột trong DataGridView:");
            foreach (DataGridViewColumn col in dgvCongTac.Columns)
            {
                Console.WriteLine($"Cột: {col.Name}");
            }
        }

        private void dgvCongTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Console.WriteLine($"CellClick triggered at RowIndex: {e.RowIndex}");

                if (e.RowIndex < 0)
                {
                    Console.WriteLine("Hàng không hợp lệ được chọn.");
                    return;
                }

                if (!dgvCongTac.Columns.Contains("MaNV"))
                {
                    Console.WriteLine("Cột MaNV không tồn tại trong DataGridView.");
                    MessageBox.Show("Cột MaNV không tồn tại trong DataGridView.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedRow = dgvCongTac.Rows[e.RowIndex];
                if (selectedRow.Cells["MaNV"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["MaNV"].Value.ToString()))
                {
                    Console.WriteLine("Giá trị MaNV là null hoặc rỗng.");
                    MessageBox.Show("Giá trị MaNV không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(selectedRow.Cells["MaNV"].Value.ToString(), out int maNV))
                {
                    Console.WriteLine($"Không thể chuyển đổi MaNV: {selectedRow.Cells["MaNV"].Value} thành số nguyên.");
                    MessageBox.Show("Giá trị MaNV không phải là số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Console.WriteLine($"MaNV được chọn: {maNV}");

                var congTacBLL = new CongTacBLL();
                List<CongTacDTO> progressData = congTacBLL.GetCongTac(maNV);
                Console.WriteLine($"Số lượng progressData: {progressData?.Count ?? 0}");

                DisplayProgress(progressData, maNV);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi trong dgvCongTac_CellClick: {ex.Message}");
                MessageBox.Show($"Lỗi khi hiển thị tiến trình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayProgress(List<CongTacDTO> progressData, int maNV)
        {
            flowTienTrinh.Controls.Clear();
            Console.WriteLine("Đã xóa controls trong flowTienTrinh.");

            if (progressData == null || progressData.Count == 0)
            {
                var lbl = new Label
                {
                    Text = $"Không có dữ liệu tiến trình cho nhân viên MaNV: {maNV}.",
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 10),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.Red,
                    BackColor = Color.WhiteSmoke
                };
                flowTienTrinh.Controls.Add(lbl);
                Console.WriteLine($"Hiển thị nhãn: Không có dữ liệu tiến trình cho MaNV: {maNV}");
                return;
            }

            int yPosition = 10;
            foreach (var ct in progressData)
            {
                var lbl = new Label
                {
                    Text = $"{ct.TuNgay:dd/MM/yyyy} - {(ct.DenNgay.HasValue ? ct.DenNgay.Value.ToString("dd/MM/yyyy") : "Hiện tại")}: {ct.MoTa}",
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, yPosition),
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.Black,
                    BackColor = Color.WhiteSmoke
                };
                flowTienTrinh.Controls.Add(lbl);
                yPosition += 30;
                Console.WriteLine($"Đã thêm nhãn: {lbl.Text}");
            }
            Console.WriteLine($"Đã hiển thị {progressData.Count} nhãn trong flowTienTrinh.");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var congTacBLL = new CongTacBLL();
            var result = congTacBLL.SearchCongTac(0, txtSearch.Text);
            dgvCongTac.DataSource = result;
            lblPageInfo.Text = "Kết quả tìm kiếm";
            Console.WriteLine("Đã thực hiện tìm kiếm với từ khóa: " + txtSearch.Text);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var congTacBLL = new CongTacBLL();
            var result = congTacBLL.FilterCongTacByDate(dtpFrom.Value, dtpTo.Value);
            dgvCongTac.DataSource = result;
            lblPageInfo.Text = "Kết quả lọc";
            Console.WriteLine($"Đã lọc dữ liệu từ {dtpFrom.Value:dd/MM/yyyy} đến {dtpTo.Value:dd/MM/yyyy}");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new CongTacPopupForm(0);
            addForm.ShowDialog();
            LoadPagination();
            Console.WriteLine("Đã mở form thêm công tác.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCongTac.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCongTac.SelectedRows[0];
                if (selectedRow.Cells["MaCongTac"].Value == null)
                {
                    MessageBox.Show("Giá trị MaCongTac không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maCongTac = Convert.ToInt32(selectedRow.Cells["MaCongTac"].Value);
                var editForm = new CongTacPopupForm(maCongTac);
                editForm.ShowDialog();
                LoadPagination();
                Console.WriteLine($"Đã mở form sửa công tác với MaCongTac: {maCongTac}");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCongTac.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCongTac.SelectedRows[0];
                if (selectedRow.Cells["MaCongTac"].Value == null)
                {
                    MessageBox.Show("Giá trị MaCongTac không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maCongTac = Convert.ToInt32(selectedRow.Cells["MaCongTac"].Value);
                var congTacBLL = new CongTacBLL();

                if (congTacBLL.DeleteCongTac(maCongTac))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPagination();
                    Console.WriteLine($"Đã xóa công tác với MaCongTac: {maCongTac}");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"Xóa công tác thất bại với MaCongTac: {maCongTac}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            currentPage = 1;
            LoadPagination();
            flowTienTrinh.Controls.Clear();
            Console.WriteLine("Đã làm mới form và xóa flowTienTrinh.");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataByPage(currentPage);
                Console.WriteLine($"Chuyển đến trang trước: {currentPage}");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDataByPage(currentPage);
                Console.WriteLine($"Chuyển đến trang tiếp theo: {currentPage}");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Tiến trình công tác");

                    for (int i = 0; i < dgvCongTac.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgvCongTac.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < dgvCongTac.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvCongTac.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dgvCongTac.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        FileName = "TienTrinhCongTac.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine($"Đã xuất Excel: {saveFileDialog.FileName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Lỗi xuất Excel: {ex.Message}");
            }
        }
    }
}