namespace bai6._2.GUI
{
    partial class frmHRM
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
            tabControlMain = new TabControl();
            tabNhanVien = new TabPage();
            grpDSNhanVien = new GroupBox();
            dgvNhanVien = new DataGridView();
            grpThongTinNV = new GroupBox();
            lblTimKiemNV = new Label();
            txtTimKiemNV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblPhongBan = new Label();
            cboPhongBan = new ComboBox();
            lblLuongCoBan = new Label();
            txtLuongCoBan = new TextBox();
            lblHeSoLuong = new Label();
            txtHeSoLuong = new TextBox();
            btnThemNV = new Button();
            btnSuaNV = new Button();
            btnXoaNV = new Button();
            tabChamCong = new TabPage();
            lblThangNamCC = new Label();
            txtThangNamCC = new TextBox();
            btnTaiChamCong = new Button();
            btnLuuChamCong = new Button();
            dgvChamCong = new DataGridView();
            tabBangLuong = new TabPage();
            lblThangNamBL = new Label();
            txtThangNamBL = new TextBox();
            btnChotLuong = new Button();
            btnXemBangLuong = new Button();
            dgvBangLuong = new DataGridView();
            tabControlMain.SuspendLayout();
            tabNhanVien.SuspendLayout();
            grpDSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            grpThongTinNV.SuspendLayout();
            tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            tabBangLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabNhanVien);
            tabControlMain.Controls.Add(tabChamCong);
            tabControlMain.Controls.Add(tabBangLuong);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1000, 600);
            tabControlMain.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            tabNhanVien.Controls.Add(grpDSNhanVien);
            tabNhanVien.Controls.Add(grpThongTinNV);
            tabNhanVien.Location = new Point(4, 29);
            tabNhanVien.Name = "tabNhanVien";
            tabNhanVien.Size = new Size(992, 567);
            tabNhanVien.TabIndex = 0;
            tabNhanVien.Text = "1. Quản Lý Hồ Sơ Nhân Sự (3-Tier CRUD)";
            // 
            // grpDSNhanVien
            // 
            grpDSNhanVien.Controls.Add(dgvNhanVien);
            grpDSNhanVien.Location = new Point(360, 10);
            grpDSNhanVien.Name = "grpDSNhanVien";
            grpDSNhanVien.Size = new Size(620, 540);
            grpDSNhanVien.TabIndex = 0;
            grpDSNhanVien.TabStop = false;
            grpDSNhanVien.Text = "Danh Sách Nhân Viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeight = 29;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 23);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(614, 514);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // grpThongTinNV
            // 
            grpThongTinNV.Controls.Add(lblTimKiemNV);
            grpThongTinNV.Controls.Add(txtTimKiemNV);
            grpThongTinNV.Controls.Add(lblHoTen);
            grpThongTinNV.Controls.Add(txtHoTen);
            grpThongTinNV.Controls.Add(lblNgaySinh);
            grpThongTinNV.Controls.Add(dtpNgaySinh);
            grpThongTinNV.Controls.Add(lblCCCD);
            grpThongTinNV.Controls.Add(txtCCCD);
            grpThongTinNV.Controls.Add(lblPhongBan);
            grpThongTinNV.Controls.Add(cboPhongBan);
            grpThongTinNV.Controls.Add(lblLuongCoBan);
            grpThongTinNV.Controls.Add(txtLuongCoBan);
            grpThongTinNV.Controls.Add(lblHeSoLuong);
            grpThongTinNV.Controls.Add(txtHeSoLuong);
            grpThongTinNV.Controls.Add(btnThemNV);
            grpThongTinNV.Controls.Add(btnSuaNV);
            grpThongTinNV.Controls.Add(btnXoaNV);
            grpThongTinNV.Location = new Point(10, 10);
            grpThongTinNV.Name = "grpThongTinNV";
            grpThongTinNV.Size = new Size(340, 540);
            grpThongTinNV.TabIndex = 1;
            grpThongTinNV.TabStop = false;
            grpThongTinNV.Text = "Thông Tin Nhân Viên";
            // 
            // lblTimKiemNV
            // 
            lblTimKiemNV.Location = new Point(10, 25);
            lblTimKiemNV.Name = "lblTimKiemNV";
            lblTimKiemNV.Size = new Size(100, 23);
            lblTimKiemNV.TabIndex = 0;
            lblTimKiemNV.Text = "Tìm kiếm:";
            // 
            // txtTimKiemNV
            // 
            txtTimKiemNV.Location = new Point(113, 23);
            txtTimKiemNV.Name = "txtTimKiemNV";
            txtTimKiemNV.Size = new Size(220, 27);
            txtTimKiemNV.TabIndex = 1;
            txtTimKiemNV.TextChanged += txtTimKiemNV_TextChanged;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(10, 65);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ và Tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(113, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(220, 27);
            txtHoTen.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(10, 105);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 23);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(113, 101);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(220, 27);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblCCCD
            // 
            lblCCCD.Location = new Point(10, 145);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(100, 23);
            lblCCCD.TabIndex = 6;
            lblCCCD.Text = "CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(113, 142);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(220, 27);
            txtCCCD.TabIndex = 7;
            // 
            // lblPhongBan
            // 
            lblPhongBan.Location = new Point(10, 185);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(100, 23);
            lblPhongBan.TabIndex = 8;
            lblPhongBan.Text = "Phòng Ban:";
            // 
            // cboPhongBan
            // 
            cboPhongBan.Location = new Point(113, 182);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(220, 28);
            cboPhongBan.TabIndex = 9;
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.Location = new Point(10, 225);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(100, 23);
            lblLuongCoBan.TabIndex = 10;
            lblLuongCoBan.Text = "Lương CB:";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(113, 222);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(220, 27);
            txtLuongCoBan.TabIndex = 11;
            // 
            // lblHeSoLuong
            // 
            lblHeSoLuong.Location = new Point(10, 265);
            lblHeSoLuong.Name = "lblHeSoLuong";
            lblHeSoLuong.Size = new Size(100, 23);
            lblHeSoLuong.TabIndex = 12;
            lblHeSoLuong.Text = "Hệ Số Lương:";
            // 
            // txtHeSoLuong
            // 
            txtHeSoLuong.Location = new Point(113, 262);
            txtHeSoLuong.Name = "txtHeSoLuong";
            txtHeSoLuong.Size = new Size(220, 27);
            txtHeSoLuong.TabIndex = 13;
            // 
            // btnThemNV
            // 
            btnThemNV.Location = new Point(10, 310);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(95, 35);
            btnThemNV.TabIndex = 14;
            btnThemNV.Text = "Thêm";
            btnThemNV.Click += btnThemNV_Click;
            // 
            // btnSuaNV
            // 
            btnSuaNV.Location = new Point(120, 310);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(95, 35);
            btnSuaNV.TabIndex = 15;
            btnSuaNV.Text = "Sửa";
            btnSuaNV.Click += btnSuaNV_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.Location = new Point(230, 310);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(90, 35);
            btnXoaNV.TabIndex = 16;
            btnXoaNV.Text = "Xóa";
            btnXoaNV.Click += btnXoaNV_Click;
            // 
            // tabChamCong
            // 
            tabChamCong.Controls.Add(lblThangNamCC);
            tabChamCong.Controls.Add(txtThangNamCC);
            tabChamCong.Controls.Add(btnTaiChamCong);
            tabChamCong.Controls.Add(btnLuuChamCong);
            tabChamCong.Controls.Add(dgvChamCong);
            tabChamCong.Location = new Point(4, 29);
            tabChamCong.Name = "tabChamCong";
            tabChamCong.Size = new Size(992, 567);
            tabChamCong.TabIndex = 1;
            tabChamCong.Text = "2. Chấm Công (Disconnected Model)";
            // 
            // lblThangNamCC
            // 
            lblThangNamCC.AutoSize = true;
            lblThangNamCC.Location = new Point(20, 20);
            lblThangNamCC.Name = "lblThangNamCC";
            lblThangNamCC.Size = new Size(165, 20);
            lblThangNamCC.TabIndex = 0;
            lblThangNamCC.Text = "Tháng/Năm (MM/yyyy):";
            // 
            // txtThangNamCC
            // 
            txtThangNamCC.Location = new Point(160, 17);
            txtThangNamCC.Name = "txtThangNamCC";
            txtThangNamCC.Size = new Size(100, 27);
            txtThangNamCC.TabIndex = 1;
            txtThangNamCC.Text = "11/2026";
            // 
            // btnTaiChamCong
            // 
            btnTaiChamCong.Location = new Point(280, 15);
            btnTaiChamCong.Name = "btnTaiChamCong";
            btnTaiChamCong.Size = new Size(180, 28);
            btnTaiChamCong.TabIndex = 2;
            btnTaiChamCong.Text = "Nạp Bảng Chấm Công";
            btnTaiChamCong.Click += btnTaiChamCong_Click;
            // 
            // btnLuuChamCong
            // 
            btnLuuChamCong.BackColor = Color.LightSkyBlue;
            btnLuuChamCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuuChamCong.Location = new Point(470, 15);
            btnLuuChamCong.Name = "btnLuuChamCong";
            btnLuuChamCong.Size = new Size(220, 28);
            btnLuuChamCong.TabIndex = 3;
            btnLuuChamCong.Text = "LƯU CHẤM CÔNG (DATAADAPTER)";
            btnLuuChamCong.UseVisualStyleBackColor = false;
            btnLuuChamCong.Click += btnLuuChamCong_Click;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.ColumnHeadersHeight = 29;
            dgvChamCong.Location = new Point(20, 55);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.Size = new Size(950, 490);
            dgvChamCong.TabIndex = 4;
            // 
            // tabBangLuong
            // 
            tabBangLuong.Controls.Add(lblThangNamBL);
            tabBangLuong.Controls.Add(txtThangNamBL);
            tabBangLuong.Controls.Add(btnChotLuong);
            tabBangLuong.Controls.Add(btnXemBangLuong);
            tabBangLuong.Controls.Add(dgvBangLuong);
            tabBangLuong.Location = new Point(4, 29);
            tabBangLuong.Name = "tabBangLuong";
            tabBangLuong.Size = new Size(992, 567);
            tabBangLuong.TabIndex = 2;
            tabBangLuong.Text = "3. Tính & Chốt Lương (SqlTransaction)";
            // 
            // lblThangNamBL
            // 
            lblThangNamBL.AutoSize = true;
            lblThangNamBL.Location = new Point(20, 20);
            lblThangNamBL.Name = "lblThangNamBL";
            lblThangNamBL.Size = new Size(165, 20);
            lblThangNamBL.TabIndex = 0;
            lblThangNamBL.Text = "Tháng/Năm (MM/yyyy):";
            // 
            // txtThangNamBL
            // 
            txtThangNamBL.Location = new Point(160, 17);
            txtThangNamBL.Name = "txtThangNamBL";
            txtThangNamBL.Size = new Size(100, 27);
            txtThangNamBL.TabIndex = 1;
            txtThangNamBL.Text = "11/2026";
            // 
            // btnChotLuong
            // 
            btnChotLuong.BackColor = Color.LimeGreen;
            btnChotLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChotLuong.ForeColor = Color.White;
            btnChotLuong.Location = new Point(280, 14);
            btnChotLuong.Name = "btnChotLuong";
            btnChotLuong.Size = new Size(250, 30);
            btnChotLuong.TabIndex = 2;
            btnChotLuong.Text = "CHỐT LƯƠNG (SQLTRANSACTION)";
            btnChotLuong.UseVisualStyleBackColor = false;
            btnChotLuong.Click += btnChotLuong_Click;
            // 
            // btnXemBangLuong
            // 
            btnXemBangLuong.Location = new Point(540, 14);
            btnXemBangLuong.Name = "btnXemBangLuong";
            btnXemBangLuong.Size = new Size(180, 30);
            btnXemBangLuong.TabIndex = 3;
            btnXemBangLuong.Text = "Xem Bảng Lương Đã Chốt";
            btnXemBangLuong.Click += btnXemBangLuong_Click;
            // 
            // dgvBangLuong
            // 
            dgvBangLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBangLuong.ColumnHeadersHeight = 29;
            dgvBangLuong.Location = new Point(20, 55);
            dgvBangLuong.Name = "dgvBangLuong";
            dgvBangLuong.ReadOnly = true;
            dgvBangLuong.RowHeadersWidth = 51;
            dgvBangLuong.Size = new Size(950, 490);
            dgvBangLuong.TabIndex = 4;
            // 
            // frmHRM
            // 
            ClientSize = new Size(1000, 600);
            Controls.Add(tabControlMain);
            Name = "frmHRM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 6.2: Hệ Thống Quản Lý Nhân Sự & Tính Lương (HRM & Payroll System)";
            Load += frmHRM_Load;
            tabControlMain.ResumeLayout(false);
            tabNhanVien.ResumeLayout(false);
            grpDSNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            grpThongTinNV.ResumeLayout(false);
            grpThongTinNV.PerformLayout();
            tabChamCong.ResumeLayout(false);
            tabChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            tabBangLuong.ResumeLayout(false);
            tabBangLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.GroupBox grpDSNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox grpThongTinNV;
        private System.Windows.Forms.Label lblTimKiemNV;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.Label lblHeSoLuong;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;

        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.Label lblThangNamCC;
        private System.Windows.Forms.TextBox txtThangNamCC;
        private System.Windows.Forms.Button btnTaiChamCong;
        private System.Windows.Forms.Button btnLuuChamCong;
        private System.Windows.Forms.DataGridView dgvChamCong;

        private System.Windows.Forms.TabPage tabBangLuong;
        private System.Windows.Forms.Label lblThangNamBL;
        private System.Windows.Forms.TextBox txtThangNamBL;
        private System.Windows.Forms.Button btnChotLuong;
        private System.Windows.Forms.Button btnXemBangLuong;
        private System.Windows.Forms.DataGridView dgvBangLuong;
    }
}