namespace bai6._1.GUI
{
    partial class frmBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpSanPham = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemVaoGio = new System.Windows.Forms.Button();

            this.grpGioHang = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTongTienLabel = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();

            this.grpThongKe = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.dgvTop5 = new System.Windows.Forms.DataGridView();

            this.grpSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.grpGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.grpThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5)).BeginInit();
            this.SuspendLayout();

            // grpSanPham
            this.grpSanPham.Controls.Add(this.lblTimKiem);
            this.grpSanPham.Controls.Add(this.txtTimKiem);
            this.grpSanPham.Controls.Add(this.dgvSanPham);
            this.grpSanPham.Controls.Add(this.lblSoLuong);
            this.grpSanPham.Controls.Add(this.nudSoLuong);
            this.grpSanPham.Controls.Add(this.btnThemVaoGio);
            this.grpSanPham.Location = new System.Drawing.Point(12, 12);
            this.grpSanPham.Name = "grpSanPham";
            this.grpSanPham.Size = new System.Drawing.Size(480, 520);
            this.grpSanPham.TabIndex = 0;
            this.grpSanPham.TabStop = false;
            this.grpSanPham.Text = "1. Danh Sách Sản Phẩm (Tra cứu SqlParameter)";

            // lblTimKiem
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(15, 30);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(125, 15);
            this.lblTimKiem.Text = "Tìm theo tên/mã SP:";

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(145, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(320, 23);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // dgvSanPham
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(15, 60);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(450, 390);

            // lblSoLuong
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(15, 472);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 15);
            this.lblSoLuong.Text = "Số lượng:";

            // nudSoLuong
            this.nudSoLuong.Location = new System.Drawing.Point(80, 468);
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(80, 23);
            this.nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // btnThemVaoGio
            this.btnThemVaoGio.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.Location = new System.Drawing.Point(175, 462);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(290, 32);
            this.btnThemVaoGio.Text = "+ Thêm Vào Giỏ Hàng";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);

            // grpGioHang
            this.grpGioHang.Controls.Add(this.dgvGioHang);
            this.grpGioHang.Controls.Add(this.lblMaKH);
            this.grpGioHang.Controls.Add(this.txtMaKH);
            this.grpGioHang.Controls.Add(this.lblTongTienLabel);
            this.grpGioHang.Controls.Add(this.lblTongTien);
            this.grpGioHang.Controls.Add(this.btnThanhToan);
            this.grpGioHang.Location = new System.Drawing.Point(505, 12);
            this.grpGioHang.Name = "grpGioHang";
            this.grpGioHang.Size = new System.Drawing.Size(480, 520);
            this.grpGioHang.TabIndex = 1;
            this.grpGioHang.TabStop = false;
            this.grpGioHang.Text = "2. Giỏ Hàng & Thanh Toán (SqlTransaction)";

            // dgvGioHang
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(15, 27);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.Size = new System.Drawing.Size(450, 340);

            // lblMaKH
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(15, 385);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(120, 15);
            this.lblMaKH.Text = "Mã Khách (để trống nếu lẻ):";

            // txtMaKH
            this.txtMaKH.Location = new System.Drawing.Point(145, 382);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(120, 23);

            // lblTongTienLabel
            this.lblTongTienLabel.AutoSize = true;
            this.lblTongTienLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTienLabel.Location = new System.Drawing.Point(15, 422);
            this.lblTongTienLabel.Name = "lblTongTienLabel";
            this.lblTongTienLabel.Size = new System.Drawing.Size(83, 20);
            this.lblTongTienLabel.Text = "TỔNG TIỀN:";

            // lblTongTien
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(140, 418);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(66, 25);
            this.lblTongTien.Text = "0 VNĐ";

            // btnThanhToan
            this.btnThanhToan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(15, 455);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(450, 45);
            this.btnThanhToan.Text = "THANH TOÁN (COMMIT TRANSACTION)";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // grpThongKe
            this.grpThongKe.Controls.Add(this.btnThongKe);
            this.grpThongKe.Controls.Add(this.lblDoanhThuThang);
            this.grpThongKe.Controls.Add(this.dgvTop5);
            this.grpThongKe.Location = new System.Drawing.Point(998, 12);
            this.grpThongKe.Name = "grpThongKe";
            this.grpThongKe.Size = new System.Drawing.Size(420, 520);
            this.grpThongKe.TabIndex = 2;
            this.grpThongKe.TabStop = false;
            this.grpThongKe.Text = "3. Báo Cáo & Thống Kê";

            // btnThongKe
            this.btnThongKe.Location = new System.Drawing.Point(15, 27);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(390, 30);
            this.btnThongKe.Text = "Tải Báo Cáo Doanh Thu & Top 5 Bán Chạy";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // lblDoanhThuThang
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDoanhThuThang.Location = new System.Drawing.Point(15, 70);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(210, 19);
            this.lblDoanhThuThang.Text = "Doanh thu tháng này: 0 VNĐ";

            // dgvTop5
            this.dgvTop5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop5.Location = new System.Drawing.Point(15, 100);
            this.dgvTop5.Name = "dgvTop5";
            this.dgvTop5.ReadOnly = true;
            this.dgvTop5.Size = new System.Drawing.Size(390, 400);

            // frmBanHang
            this.ClientSize = new System.Drawing.Size(1430, 545);
            this.Controls.Add(this.grpSanPham);
            this.Controls.Add(this.grpGioHang);
            this.Controls.Add(this.grpThongKe);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 6.1: Hệ Thống Quản Lý Bán Hàng & Siêu Thị Mini (3-Tier + SqlTransaction)";
            this.Load += new System.EventHandler(this.frmBanHang_Load);

            this.grpSanPham.ResumeLayout(false);
            this.grpSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.grpGioHang.ResumeLayout(false);
            this.grpGioHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.grpThongKe.ResumeLayout(false);
            this.grpThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSanPham;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;

        private System.Windows.Forms.GroupBox grpGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTongTienLabel;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;

        private System.Windows.Forms.GroupBox grpThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblDoanhThuThang;
        private System.Windows.Forms.DataGridView dgvTop5;
    }
}