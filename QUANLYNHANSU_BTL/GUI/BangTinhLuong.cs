using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.BLL;
using QUANLYNHANSU_BTL.DTO;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangTinhLuongControl : UserControl
    {
        private BangTinhLuongBLL bll = new BangTinhLuongBLL();
        private List<BangTinhLuongDTO> dsHienTai = new List<BangTinhLuongDTO>();
        private int trangHienTai = 1;
        private int tongSoTrang = 1;
        private int kichThuocTrang = 10;

        public BangTinhLuongControl()
        {
            InitializeComponent();
        }

        private void BangTinhLuongControl_Load(object sender, EventArgs e)
        {
            dtpNgayLoc.Format = DateTimePickerFormat.Custom;
            dtpNgayLoc.CustomFormat = "MM/yyyy";
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            DateTime selectedMonth = dtpNgayLoc.Value;
            dsHienTai = bll.GetByMonth(selectedMonth);
            tongSoTrang = (int)Math.Ceiling((double)dsHienTai.Count / kichThuocTrang);
            trangHienTai = 1;
            HienThiTrang();
        }

        private void HienThiTrang()
        {
            var dataPage = dsHienTai
                .Skip((trangHienTai - 1) * kichThuocTrang)
                .Take(kichThuocTrang)
                .ToList();

            dgvBangTinhLuong.DataSource = dataPage;
            lblPage.Text = $"Trang {trangHienTai}/{tongSoTrang}";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1)
            {
                trangHienTai--;
                HienThiTrang();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (trangHienTai < tongSoTrang)
            {
                trangHienTai++;
                HienThiTrang();
            }
        }

        private void dtpNgayLoc_ValueChanged(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string maNV = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(maNV))
            {
                dsHienTai = bll.SearchByMaNV(maNV);
                tongSoTrang = (int)Math.Ceiling((double)dsHienTai.Count / kichThuocTrang);
                trangHienTai = 1;
                HienThiTrang();
            }
            else
            {
                LoadDuLieu();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dtpNgayLoc.Value = DateTime.Today;
            LoadDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var popup = new BangTinhLuongPopup();
            popup.StartPosition = FormStartPosition.CenterParent;  // Đặt vị trí của Popup ở giữa form cha
            popup.ShowDialog();
            LoadDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvBangTinhLuong.SelectedRows.Count > 0)
            {
                var selected = (BangTinhLuongDTO)dgvBangTinhLuong.SelectedRows[0].DataBoundItem;
                var popup = new BangTinhLuongPopup(selected);
                popup.StartPosition = FormStartPosition.CenterParent;  // Đặt vị trí của Popup ở giữa form cha
                popup.ShowDialog();
                LoadDuLieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBangTinhLuong.SelectedRows.Count > 0)
            {
                var selected = (BangTinhLuongDTO)dgvBangTinhLuong.SelectedRows[0].DataBoundItem;
                if (bll.Delete(selected.MaTinhLuong))
                {
                    MessageBox.Show("Đã xóa bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var wb = new XLWorkbook();
                    var ws = wb.Worksheets.Add("Luong");
                    ws.Cell(1, 1).InsertTable(dsHienTai);
                    wb.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    PdfPTable table = new PdfPTable(9);
                    table.WidthPercentage = 100;
                    table.AddCell("Mã NV");
                    table.AddCell("Họ tên");
                    table.AddCell("Chức vụ");
                    table.AddCell("Tháng");
                    table.AddCell("Số ngày công");
                    table.AddCell("Số ngày OT");
                    table.AddCell("Lương cơ bản");
                    table.AddCell("Phụ cấp");
                    table.AddCell("Tổng lương");

                    foreach (var item in dsHienTai)
                    {
                        table.AddCell(item.MaNV.ToString());
                        table.AddCell(item.HoTen);
                        table.AddCell(item.ChucVu);
                        table.AddCell(item.ThangNam.ToString("MM/yyyy"));
                        table.AddCell(item.SoNgayCong.ToString());
                        table.AddCell(item.SoNgayOT.ToString());
                        table.AddCell(item.LuongCoBan.ToString("N0"));
                        table.AddCell((item.PhuCapChucVu + item.PhuCapKhac).ToString("N0"));
                        table.AddCell(item.TongLuong.ToString("N0"));
                    }

                    doc.Add(table);
                    doc.Close();
                    MessageBox.Show("Xuất PDF thành công!");
                }
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
