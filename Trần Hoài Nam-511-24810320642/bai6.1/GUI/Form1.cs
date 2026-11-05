using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using bai6._1.BUS;
using bai6._1.DTO;

namespace bai6._1.GUI
{
    public partial class frmBanHang : Form
    {
        private readonly SanPhamBUS spBUS = new();
        private readonly HoaDonBUS hdBUS = new();
        private readonly List<ChiTietHoaDonDTO> gioHang = new();

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
        }

        private void HienThiDanhSachSanPham()
        {
            try
            {
                dgvSanPham.DataSource = spBUS.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            dgvSanPham.DataSource = spBUS.TimKiem(tuKhoa);
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSP = dgvSanPham.CurrentRow.Cells["MaSP"].Value?.ToString() ?? string.Empty;
            string tenSP = dgvSanPham.CurrentRow.Cells["TenSP"].Value?.ToString() ?? string.Empty;
            decimal giaBan = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["GiaBan"].Value);
            int soLuongMuonMua = (int)nudSoLuong.Value;

            var itemInCart = gioHang.Find(x => x.MaSP == maSP);
            if (itemInCart != null)
            {
                itemInCart.SoLuong += soLuongMuonMua;
            }
            else
            {
                gioHang.Add(new ChiTietHoaDonDTO
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    SoLuong = soLuongMuonMua,
                    DonGia = giaBan
                });
            }

            CapNhatHienThiGioHang();
        }

        private void CapNhatHienThiGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang;

            decimal tongTien = 0;
            foreach (var item in gioHang)
            {
                tongTien += item.ThanhTien;
            }

            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn sản phẩm trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal tongTien = 0;
                foreach (var item in gioHang) tongTien += item.ThanhTien;

                HoaDonDTO hd = new()
                {
                    NgayLap = DateTime.Now,
                    MaNV = 1,
                    MaKH = string.IsNullOrWhiteSpace(txtMaKH.Text) ? null : int.Parse(txtMaKH.Text.Trim()),
                    TongTien = tongTien
                };

                bool xacNhan = hdBUS.ThanhToan(hd, gioHang);

                if (xacNhan)
                {
                    MessageBox.Show("THANH TOÁN THÀNH CÔNG!\n- Đã ghi nhận Hóa đơn.\n- Đã tự động trừ số lượng tồn kho.\n- Đã cộng điểm tích lũy cho khách hàng.", "Thành Công (Commit)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gioHang.Clear();
                    txtMaKH.Clear();
                    CapNhatHienThiGioHang();
                    HienThiDanhSachSanPham();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GIAO DỊCH THẤT BẠI (ROLLBACK TRANSACTION)!\n" + ex.Message, "Lỗi An Toàn Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                int thangHienTai = DateTime.Now.Month;
                int namHienTai = DateTime.Now.Year;

                decimal doanhThu = hdBUS.GetDoanhThu(thangHienTai, namHienTai);
                lblDoanhThuThang.Text = $"Doanh thu tháng {thangHienTai}/{namHienTai}: {doanhThu:N0} VNĐ";

                DataTable dtTop5 = hdBUS.GetTop5();
                dgvTop5.DataSource = dtTop5;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}