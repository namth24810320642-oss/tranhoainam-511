#pragma warning disable IDE1006
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Data;
using System.Windows.Forms;
using bai6._2.BUS;
using bai6._2.DTO;

namespace bai6._2.GUI
{
    public partial class frmHRM : Form
    {
        private readonly NhanVienHRMBUS nvBUS = new();
        private readonly BangChamCongBUS ccBUS = new();
        private readonly BangLuongBUS blBUS = new();

        private DataTable? dtChamCong;
        private int selectedMaNV = 0;

        public frmHRM()
        {
            InitializeComponent();
        }

        private void frmHRM_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            LoadComboboxPhongBan();
        }

        private void LoadDanhSachNhanVien()
        {
            dgvNhanVien.DataSource = nvBUS.GetAll();
        }

        private void LoadComboboxPhongBan()
        {
            cboPhongBan.DataSource = nvBUS.GetPhongBan();
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvBUS.TimKiem(txtTimKiemNV.Text.Trim());
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNhanVien.CurrentRow is null) return;

            var row = dgvNhanVien.CurrentRow;
            selectedMaNV = Convert.ToInt32(row.Cells["MaNV"].Value ?? 0);
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? string.Empty;

            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ns))
            {
                dtpNgaySinh.Value = ns;
            }

            txtCCCD.Text = row.Cells["CCCD"].Value?.ToString() ?? string.Empty;

            if (row.Cells["MaPB"].Value is not null and not DBNull)
            {
                cboPhongBan.SelectedValue = Convert.ToInt32(row.Cells["MaPB"].Value);
            }

            txtLuongCoBan.Text = row.Cells["LuongCoBan"].Value?.ToString() ?? "0";
            txtHeSoLuong.Text = row.Cells["HeSoLuong"].Value?.ToString() ?? "1.0";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienHRMDTO nv = new()
                {
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    CCCD = txtCCCD.Text.Trim(),
                    MaPB = Convert.ToInt32(cboPhongBan.SelectedValue ?? 0),
                    LuongCoBan = decimal.Parse(txtLuongCoBan.Text.Trim()),
                    HeSoLuong = double.Parse(txtHeSoLuong.Text.Trim())
                };

                if (nvBUS.Them(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (selectedMaNV <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NhanVienHRMDTO nv = new()
                {
                    MaNV = selectedMaNV,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    CCCD = txtCCCD.Text.Trim(),
                    MaPB = Convert.ToInt32(cboPhongBan.SelectedValue ?? 0),
                    LuongCoBan = decimal.Parse(txtLuongCoBan.Text.Trim()),
                    HeSoLuong = double.Parse(txtHeSoLuong.Text.Trim())
                };

                if (nvBUS.Sua(nv))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (selectedMaNV <= 0) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (nvBUS.Xoa(selectedMaNV))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNhanVien();
                        selectedMaNV = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaiChamCong_Click(object sender, EventArgs e)
        {
            string thangNam = txtThangNamCC.Text.Trim();
            dtChamCong = ccBUS.LoadChamCong(thangNam);
            dgvChamCong.DataSource = dtChamCong;

            if (dgvChamCong.Columns["MaCong"] is not null) dgvChamCong.Columns["MaCong"].ReadOnly = true;
            if (dgvChamCong.Columns["MaNV"] is not null) dgvChamCong.Columns["MaNV"].ReadOnly = true;
            if (dgvChamCong.Columns["HoTen"] is not null) dgvChamCong.Columns["HoTen"].ReadOnly = true;
            if (dgvChamCong.Columns["ThangNam"] is not null) dgvChamCong.Columns["ThangNam"].ReadOnly = true;
        }

        private void btnLuuChamCong_Click(object sender, EventArgs e)
        {
            if (dtChamCong is null)
            {
                MessageBox.Show("Vui lòng tải bảng chấm công trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool res = ccBUS.LuuChamCong(dtChamCong, txtThangNamCC.Text.Trim());
                if (res)
                {
                    MessageBox.Show("ĐÃ ĐỒNG BỘ CHẤM CÔNG VỀ SQL SERVER THÀNH CÔNG!\n(Sử dụng SqlCommandBuilder & SqlDataAdapter.Update)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đồng bộ dữ liệu: " + ex.Message, "Lỗi DataAdapter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChotLuong_Click(object sender, EventArgs e)
        {
            string thangNam = txtThangNamBL.Text.Trim();

            if (MessageBox.Show($"Bạn có chắc muốn CHỐT LƯƠNG cho tháng {thangNam}?\nCông thức: ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)", "Xác Nhận Chốt Lương", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool res = blBUS.ChotLuong(thangNam);
                    if (res)
                    {
                        MessageBox.Show($"CHỐT LƯƠNG THÁNG {thangNam} THÀNH CÔNG!\nGiao dịch SqlTransaction đã Commit dữ liệu an toàn.", "Thành Công (Commit)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvBangLuong.DataSource = blBUS.GetBangLuong(thangNam);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"CHỐT LƯƠNG THẤT BẠI! Lỗi SqlTransaction Rollback: {ex.Message}", "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            string thangNam = txtThangNamBL.Text.Trim();
            dgvBangLuong.DataSource = blBUS.GetBangLuong(thangNam);
        }
    }
}