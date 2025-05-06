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
using System.Data;
using System.Diagnostics;


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
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Bảng lương");

                // ==== 1. TÊN CÔNG TY VÀ TIÊU ĐỀ ====
                ws.Range("A1:M1").Merge().Value = "CÔNG TY TNHH CỔ PHẦN CÔNG NGHỆ ĐNN";
                ws.Range("A1").Style.Font.Bold = true;
                ws.Range("A1").Style.Font.FontSize = 16;
                ws.Range("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                string thangNam = dsHienTai.Count > 0 ? dsHienTai[0].ThangNam.ToString("MM/yyyy") : dtpNgayLoc.Value.ToString("MM/yyyy");
                ws.Range("A2:M2").Merge().Value = $"BẢNG TÍNH LƯƠNG THÁNG {thangNam}";
                ws.Range("A2").Style.Font.Bold = true;
                ws.Range("A2").Style.Font.FontSize = 14;
                ws.Range("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // ==== 2. NGÀY XUẤT & NGƯỜI XUẤT ====
                ws.Cell("A3").Value = $"Ngày xuất: {DateTime.Now:dd/MM/yyyy}";
                ws.Cell("A4").Value = "Người xuất: Admin";
                ws.Cell("A5").Value = "Người làm đơn:................................";

                // ==== 3. LẤY DỮ LIỆU TỪ DataGridView ====
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã NV");
                dt.Columns.Add("Họ tên");
                dt.Columns.Add("Chức vụ");
                dt.Columns.Add("Tháng");
                dt.Columns.Add("Số ngày công");
                dt.Columns.Add("Số ngày OT");
                dt.Columns.Add("Lương cơ bản");
                dt.Columns.Add("Phụ cấp");
                dt.Columns.Add("Tổng lương");

                foreach (var item in dsHienTai)
                {
                    dt.Rows.Add(
                        item.MaNV,
                        item.HoTen,
                        item.ChucVu,
                        item.ThangNam.ToString("MM/yyyy"),
                        item.SoNgayCong,
                        item.SoNgayOT,
                        item.LuongCoBan.ToString("N0"),
                        (item.PhuCapChucVu + item.PhuCapKhac).ToString("N0"),
                        item.TongLuong.ToString("N0")
                    );
                }


                // ==== 4. CHÈN BẢNG DỮ LIỆU ====
                ws.Cell("A7").InsertTable(dt, true);
                var table = ws.Table(0);
                table.Theme = XLTableTheme.TableStyleMedium9;

                // ==== 5. ĐỊNH DẠNG ====
                int lastRow = ws.LastRowUsed().RowNumber();
                table.DataRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                for (int col = 8; col <= 13; col++)
                {
                    ws.Column(col).Style.NumberFormat.Format = "#,##0";
                }

                // ==== 6. CHỮ KÝ CUỐI TRANG ====
                int footerRow = lastRow + 3;
                ws.Cell(footerRow, 3).Value = "Người làm đơn";
                ws.Cell(footerRow, 7).Value = "Kế toán trưởng";
                ws.Cell(footerRow, 11).Value = "Giám đốc";

                ws.Range(footerRow, 3, footerRow, 3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range(footerRow, 7, footerRow, 7).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range(footerRow, 11, footerRow, 11).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // ==== 7. TỰ ĐỘNG CANH CỘT ====
                ws.Columns().AdjustToContents();

                // ==== 8. CHÂN TRANG ====
                ws.PageSetup.Footer.Center.AddText("Công ty TNHH cổ phần công nghệ ĐNN - Bảo mật & sở hữu trí tuệ ©");

                // ==== 9. LƯU FILE & MỞ ====
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Lưu bảng lương",
                    FileName = $"BangLuong_{dtpNgayLoc.Value:MM_yyyy}.xlsx"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        System.Diagnostics.Process.Start("explorer.exe", sfd.FileName);
                    }
                }

            }
        }


        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf", Title = "Lưu bảng lương", FileName = $"BangLuong_{dtpNgayLoc.Value:MM_yyyy}.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4.Rotate(), 20, 20, 20, 20);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Sử dụng font Arial
                    BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font subtitleFont = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font normalFont = new iTextSharp.text.Font(baseFont, 10);
                    iTextSharp.text.Font boldFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);

                    Paragraph companyName = new Paragraph("CÔNG TY TNHH CỔ PHẦN CÔNG NGHỆ ĐNN", titleFont);
                    companyName.Alignment = Element.ALIGN_CENTER;
                    companyName.SpacingAfter = 10;
                    doc.Add(companyName);

                    string thangNam = dsHienTai != null && dsHienTai.Count > 0 ? dsHienTai[0].ThangNam.ToString("MM/yyyy") : dtpNgayLoc.Value.ToString("MM/yyyy");
                    Paragraph title = new Paragraph($"BẢNG TÍNH LƯƠNG THÁNG {thangNam}", subtitleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 10;
                    doc.Add(title);

                    Paragraph exportInfo = new Paragraph($"Ngày xuất: {DateTime.Now:dd/MM/yyyy}\nNgười xuất: Admin\nNgười làm đơn: ................................", normalFont);
                    exportInfo.SpacingAfter = 20;
                    doc.Add(exportInfo);

                    PdfPTable table = new PdfPTable(9);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 10, 20, 15, 10, 10, 10, 15, 15, 15 });

                    string[] headers = { "Mã NV", "Họ tên", "Chức vụ", "Tháng", "Số ngày công", "Số ngày OT", "Lương cơ bản", "Phụ cấp", "Tổng lương" };
                    foreach (string header in headers)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, boldFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.BackgroundColor = new BaseColor(100, 88, 255);
                        cell.Padding = 5;
                        cell.SetLeading(0, 1.2f);
                        table.AddCell(cell);
                    }

                    if (dsHienTai != null)
                    {
                        foreach (var item in dsHienTai)
                        {
                            if (item != null)
                            {
                                table.AddCell(new PdfPCell(new Phrase(item.MaNV.ToString() ?? "", normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_CENTER });
                                table.AddCell(new PdfPCell(new Phrase(item.HoTen ?? "", normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_LEFT });
                                table.AddCell(new PdfPCell(new Phrase(item.ChucVu ?? "", normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_LEFT });
                                table.AddCell(new PdfPCell(new Phrase(item.ThangNam.ToString("MM/yyyy"), normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_CENTER });
                                table.AddCell(new PdfPCell(new Phrase(item.SoNgayCong.ToString(), normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_CENTER });
                                table.AddCell(new PdfPCell(new Phrase(item.SoNgayOT.ToString(), normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_CENTER });
                                table.AddCell(new PdfPCell(new Phrase(item.LuongCoBan.ToString("N0"), normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_RIGHT });
                                table.AddCell(new PdfPCell(new Phrase((item.PhuCapChucVu + item.PhuCapKhac).ToString("N0"), normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_RIGHT });
                                table.AddCell(new PdfPCell(new Phrase(item.TongLuong.ToString("N0"), normalFont)) { Padding = 5, HorizontalAlignment = Element.ALIGN_RIGHT });
                            }
                        }
                    }

                    doc.Add(table);

                    PdfPTable signatureTable = new PdfPTable(3);
                    signatureTable.WidthPercentage = 80;
                    signatureTable.SetWidths(new float[] { 1, 1, 1 });
                    signatureTable.SpacingBefore = 30;

                    string[] signatures = { "Người làm đơn", "Kế toán trưởng", "Giám đốc" };
                    foreach (string signature in signatures)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(signature, boldFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        cell.PaddingBottom = 20;
                        signatureTable.AddCell(cell);
                    }

                    doc.Add(signatureTable);

                    var pageEvent = new PdfPageEventHelperImpl
                    {
                        FooterText = "Công ty TNHH cổ phần công nghệ ĐNN - Bảo mật & sở hữu trí tuệ ©",
                        FooterFont = new iTextSharp.text.Font(baseFont, 8)
                    };
                    writer.PageEvent = pageEvent;

                    doc.Close();
                    MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("explorer.exe", sfd.FileName);
                }
            }
        }

        private class PdfPageEventHelperImpl : iTextSharp.text.pdf.PdfPageEventHelper
        {
            public string? FooterText { get; set; }
            public iTextSharp.text.Font? FooterFont { get; set; }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                if (FooterText == null || FooterFont == null) return;

                PdfPTable footerTable = new PdfPTable(1);
                footerTable.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                PdfPCell cell = new PdfPCell(new Phrase(FooterText, FooterFont));
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                footerTable.AddCell(cell);
                footerTable.WriteSelectedRows(0, -1, document.LeftMargin, document.BottomMargin - 10, writer.DirectContent);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
