using System;
using System.Windows.Forms;
using QUANLYNHANSU_BTL.DTO;
using QUANLYNHANSU_BTL.BLL;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class BangTinhLuongPopup : Form
    {
        private BangTinhLuongDTO selectedRow;
        private readonly BangTinhLuongBLL bll = new();
        private readonly NhanVienBLL nhanVienBLL = new();
        private readonly BangLuongBLL bangLuongBLL = new();

        private float heSoOT = 1.5f;
        private float mucPhat = 50000f;

        public BangTinhLuongPopup(BangTinhLuongDTO dto = null)
        {
            InitializeComponent();
            this.selectedRow = dto;

            if (dto != null)
                LoadDuLieuSua(dto);

            // Sự kiện
            txtMaNV.KeyDown += TxtMaNV_KeyDown;
            txtSoNgayCong.TextChanged += (_, __) => TinhTongLuong();
            txtSoNgayOT.TextChanged += (_, __) => TinhTongLuong();
            txtTienPhat.TextChanged += (_, __) => TinhTongLuong();
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (_, __) => this.Close();
        }

        private void TxtMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(txtMaNV.Text.Trim(), out int maNV))
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nhanVien = nhanVienBLL.GetNhanVienByMa(maNV);
                var luong = bangLuongBLL.GetBangLuongByMaNV(maNV);

                if (nhanVien == null || luong == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên hoặc bảng lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtHoTen.Text = nhanVien.HoTen;
                txtChucVu.Text = nhanVien.ChucVu;
                txtLuongCoBan.Text = luong.LuongCoBan.ToString("0");
                txtPhuCapChucVu.Text = luong.PhuCapChucVu.ToString("0");
                txtPhuCapKhac.Text = luong.PhuCapKhac.ToString("0");

                TinhTongLuong();
            }
        }

        private void LoadDuLieuSua(BangTinhLuongDTO dto)
        {
            txtMaNV.Text = dto.MaNV.ToString();
            txtHoTen.Text = dto.HoTen;
            txtChucVu.Text = dto.ChucVu;
            txtLuongCoBan.Text = dto.LuongCoBan.ToString("0");
            txtPhuCapChucVu.Text = dto.PhuCapChucVu.ToString("0");
            txtPhuCapKhac.Text = dto.PhuCapKhac.ToString("0");
            txtSoNgayCong.Text = dto.SoNgayCong.ToString();
            txtSoNgayOT.Text = dto.SoNgayOT.ToString();
            txtTienLuongOT.Text = dto.TienLuongOT.ToString("0");
            txtTienPhat.Text = dto.TienPhat.ToString("0");
            txtTongLuong.Text = dto.TongLuong.ToString("0");
            dtpThangNam.Value = dto.ThangNam;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var dto = new BangTinhLuongDTO
                {
                    MaTinhLuong = selectedRow?.MaTinhLuong ?? "TL" + DateTime.Now.ToString("MMyyHHmmss"),
                    MaNV = int.Parse(txtMaNV.Text),
                    HoTen = txtHoTen.Text,
                    ChucVu = txtChucVu.Text,
                    ThangNam = dtpThangNam.Value,
                    SoNgayCong = int.Parse(txtSoNgayCong.Text),
                    SoNgayOT = int.Parse(txtSoNgayOT.Text),
                    LuongCoBan = float.Parse(txtLuongCoBan.Text),
                    PhuCapChucVu = float.Parse(txtPhuCapChucVu.Text),
                    PhuCapKhac = float.Parse(txtPhuCapKhac.Text),
                    TienLuongOT = float.Parse(txtTienLuongOT.Text),
                    TienPhat = float.Parse(txtTienPhat.Text),
                    TongLuong = float.Parse(txtTongLuong.Text)
                };

                bool success = selectedRow == null ? bll.Insert(dto) : bll.Update(dto);

                if (success)
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                string.IsNullOrWhiteSpace(txtSoNgayCong.Text) ||
                string.IsNullOrWhiteSpace(txtLuongCoBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string[] fieldsToCheck = {
                txtMaNV.Text, txtSoNgayCong.Text, txtSoNgayOT.Text,
                txtLuongCoBan.Text, txtPhuCapChucVu.Text,
                txtPhuCapKhac.Text, txtTienPhat.Text, txtTienLuongOT.Text, txtTongLuong.Text
            };

            foreach (var field in fieldsToCheck)
            {
                if (!float.TryParse(field, out _))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void TinhTongLuong()
        {
            float.TryParse(txtLuongCoBan.Text, out float luongCB);
            float.TryParse(txtPhuCapChucVu.Text, out float pccv);
            float.TryParse(txtPhuCapKhac.Text, out float pck);
            int.TryParse(txtSoNgayCong.Text, out int soNgayCong);
            int.TryParse(txtSoNgayOT.Text, out int soNgayOT);
            int.TryParse(txtTienPhat.Text, out int soNgayPhat);

            float tienOT = (luongCB / 26f) * heSoOT * soNgayOT;
            float tienPhatFinal = soNgayPhat * mucPhat;

            txtTienLuongOT.Text = tienOT.ToString("0");
            txtTienPhat.Text = tienPhatFinal.ToString("0");

            float tong = ((luongCB / 26) * soNgayCong) + tienOT + pccv + pck - tienPhatFinal;
            txtTongLuong.Text = tong.ToString("0");
        }

        private void BangTinhLuongPopup_Load(object sender, EventArgs e)
        {

        }

        private void txtSoNgayCong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoNgayOT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienPhat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
