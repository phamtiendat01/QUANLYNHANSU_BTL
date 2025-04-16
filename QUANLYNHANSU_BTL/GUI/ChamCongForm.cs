using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;
using ClosedXML.Excel;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class ChamCongForm : Form
    {
        private ChamCongBLL chamCongBLL = new ChamCongBLL();
        private List<ChamCong> dsHienTai = new List<ChamCong>();
        private int trangHienTai = 1;
        private int tongSoTrang = 1;
        private int kichThuocTrang = 10;

        public ChamCongForm()
        {
            InitializeComponent();
            StartClock();
            LoadDuLieu(); // Lấy dữ liệu lúc khởi tạo form
        }

        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            dtpNgayLoc.Value = DateTime.Today;  // Đảm bảo mặc định chọn ngày hôm nay
            LoadDuLieu();  // Lấy dữ liệu chấm công theo ngày mặc định
        }

        private void LoadDuLieu()
        {
            // Lấy ngày hiện tại từ DateTimePicker
            DateTime selectedDate = dtpNgayLoc.Value.Date;

            // Lọc dữ liệu chấm công cho ngày đã chọn
            var filteredData = chamCongBLL.LocTheoNgay(selectedDate);

            // Tính lại tổng số trang sau khi lọc
            int tong = filteredData.Count;
            tongSoTrang = (int)Math.Ceiling(tong / (double)kichThuocTrang);
            lblPage.Text = $"Trang {trangHienTai}/{tongSoTrang}";

            // Lấy dữ liệu chấm công theo trang
            var pagedData = filteredData.Skip((trangHienTai - 1) * kichThuocTrang).Take(kichThuocTrang).ToList();

            // Gán lại DataSource sau khi lấy dữ liệu chính xác
            dgvChamCong.DataSource = pagedData;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ChamCongPopup popup = new ChamCongPopup();
            popup.ShowDialog();
            LoadDuLieu();  // Tải lại dữ liệu sau khi thêm
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.SelectedRows.Count > 0)
            {
                int maCC = Convert.ToInt32(dgvChamCong.SelectedRows[0].Cells["MaCC"].Value);
                if (chamCongBLL.Xoa(maCC))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                LoadDuLieu();  // Tải lại dữ liệu sau khi xóa
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.SelectedRows.Count > 0)
            {
                ChamCong cc = (ChamCong)dgvChamCong.SelectedRows[0].DataBoundItem;
                ChamCongPopup popup = new ChamCongPopup(cc);
                popup.ShowDialog();
                LoadDuLieu();  // Tải lại dữ liệu sau khi sửa
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";  // Xóa nội dung tìm kiếm
            dtpNgayLoc.Value = DateTime.Today;  // Đặt lại ngày chọn là ngày hiện tại
            trangHienTai = 1;  // Đặt lại trang hiện tại về 1
            LoadDuLieu();  // Làm mới dữ liệu
        }

        private void dtpLoc_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgayLoc.Value.Date;  // Lấy ngày đã chọn
            var filteredData = chamCongBLL.LocTheoNgay(selectedDate).ToList();  // Lọc theo ngày

            dgvChamCong.DataSource = filteredData;  // Cập nhật DataGridView với dữ liệu đã lọc
            lblPage.Text = $"Lọc theo ngày {selectedDate:dd/MM/yyyy}";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1)
            {
                trangHienTai--;
                LoadDuLieu();  // Tải lại dữ liệu khi chuyển trang
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (trangHienTai < tongSoTrang)
            {
                trangHienTai++;
                LoadDuLieu();  // Tải lại dữ liệu khi chuyển trang
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var wb = new XLWorkbook();
                    var ws = wb.Worksheets.Add("ChamCong");
                    ws.Cell(1, 1).InsertTable(dsHienTai);
                    wb.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất Excel thành công");
                }
            }
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();
                    PdfPTable table = new PdfPTable(5);
                    table.AddCell("Mã NV");
                    table.AddCell("Ngày");
                    table.AddCell("Giờ vào");
                    table.AddCell("Giờ ra");
                    table.AddCell("Trạng thái");

                    foreach (var cc in dsHienTai)
                    {
                        table.AddCell(cc.MaNV);
                        table.AddCell(cc.Ngay.ToShortDateString());
                        table.AddCell(cc.GioVao.ToString());
                        table.AddCell(cc.GioRa.ToString());
                        table.AddCell(cc.TrangThai);
                    }
                    doc.Add(table);
                    doc.Close();
                    MessageBox.Show("Xuất PDF thành công");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string maNV = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(maNV))
            {
                dsHienTai = chamCongBLL.TimTheoMaNV(maNV);  // Lọc theo mã NV
                dgvChamCong.DataSource = dsHienTai;
                lblPage.Text = $"Tìm theo mã NV: {maNV}";
            }
            else
            {
                LoadDuLieu();  // Gõ trống thì load lại tất cả dữ liệu
            }
        }

        private void btnChamCongTuDong_Click(object sender, EventArgs e)
        {
            // Lấy ngày hiện tại từ DateTimePicker
            DateTime today = dtpNgayLoc.Value.Date;

            // Lấy danh sách tất cả nhân viên
            var danhSach = NhanVienBLL.LayDanhSachNhanVienFull();

            // Lọc danh sách các nhân viên đã chấm công hôm nay (sử dụng CSDL để kiểm tra)
            var dsHomNay = chamCongBLL.LocTheoNgay(today).Select(c => c.MaNV).ToList();

            // Kiểm tra các nhân viên chưa chấm công và tiến hành chấm công tự động
            foreach (var cc in danhSach)
            {
                // Nếu nhân viên chưa chấm công trong ngày hôm nay thì tiến hành chấm công tự động
                if (!dsHomNay.Contains(cc.MaNV))
                {
                    ChamCong moi = new ChamCong
                    {
                        MaNV = cc.MaNV,
                        Ngay = today,
                        GioVao = new TimeSpan(8, 0, 0),  // Giờ vào tự động
                        GioRa = new TimeSpan(17, 0, 0),  // Giờ ra tự động
                        MaLoaiCong = "C",  // Loại công "C" (có thể là "Đi làm", "Công việc chính" tùy theo yêu cầu của bạn)
                        TrangThai = "Đúng giờ",  // Trạng thái tự động là đúng giờ
                        TangCa = 0,  // Không có tăng ca
                        GhiChu = "Tự động"  // Ghi chú tự động
                    };

                    // Thêm bản ghi chấm công tự động vào CSDL
                    chamCongBLL.Them(moi);
                }
            }

            // Hiển thị thông báo sau khi chấm công tự động hoàn thành
            MessageBox.Show("Đã chấm công tự động cho các nhân viên chưa có hôm nay.");

            // Tải lại dữ liệu sau khi thực hiện chấm công tự động
            LoadDuLieu();
        }

    }
}
