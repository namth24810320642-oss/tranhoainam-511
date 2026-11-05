# BÁO CÁO BÀI TẬP / ĐỒ ÁN

## THÔNG TIN SINH VIÊN
- Họ và tên:Trần Hoài Nam
- Mã số sinh viên:24810320642
- Lớp:D19QTANM1
- Tên môn học:Lập trình C# / Windows Forms
- Tên bài tập:ÔN TẬP WINDOW FORM

## CÔNG NGHỆ SỬ DỤNG

* **Ngôn ngữ & Nền tảng:** C# (.NET Framework / .NET Core), WinForms (Windows Desktop Application).
* **Cơ sở dữ liệu:** Microsoft SQL Server (SalesDB & HRMDB).
* **Mô hình Kiến trúc:** Kiến trúc 3 tầng chuẩn (**3-Tier Architecture**):
  * **DTO (Data Transfer Object):** Ánh xạ dữ liệu các bảng thành đối tượng C#.
  * **DAL (Data Access Layer):** Truy vấn dữ liệu ADO.NET an toàn.
  * **BUS (Business Logic Layer):** Xử lý quy tắc nghiệp vụ và ràng buộc dữ liệu.
  * **GUI (Graphical User Interface):** Giao diện WinForms tương tác người dùng.
* **Kỹ thuật ADO.NET & An toàn dữ liệu:**
  * **SqlParameter:** Phòng chống 100% lỗ hổng bảo mật **SQL Injection** trong toàn bộ câu lệnh truy vấn và tìm kiếm wildcard `%`.
  * **SqlTransaction:** Đảm bảo tính toàn vẹn dữ liệu **ACID** cho giao dịch lập hóa đơn, trừ tồn kho, cộng điểm tích lũy và chốt lương.
  * **Disconnected Model (Mô hình ngắt kết nối):** Sử dụng `DataSet`, `DataTable`, `SqlDataAdapter` và `SqlCommandBuilder` để nạp, chỉnh sửa trực tiếp trên GridView và đồng bộ bảng chấm công về CSDL trong 1 thao tác.
  * **ExecuteScalar & SqlDataReader:** Tối ưu hiệu năng cho truy vấn tính tổng doanh thu và hiển thị Top 5 sản phẩm bán chạy.

---

## BẢNG YÊU CẦU ĐÃ THỰC HIỆN

### 1. Bài 6.1: Hệ Thống Quản Lý Bán Hàng & Siêu Thị Mini (SalesDB)
| STT | Yêu cầu nghiệp vụ / Chức năng | Trạng thái | Giải pháp kỹ thuật đã áp dụng |
| :---: | :--- | :---: | :--- |
| **1** | Thiết kế CSDL SalesDB (5 bảng có khóa ngoại) | **Hoàn thành** | Tạo đúng cấu trúc `NhanVien`, `KhachHang`, `SanPham`, `HoaDon`, `ChiTietHoaDon` với đầy đủ Constraint. |
| **2** | Quản lý Danh mục (CRUD 3-Tier) | **Hoàn thành** | Thực thi Thêm/Sửa/Xóa Sản phẩm, Khách hàng, Nhân viên qua mô hình 3-Tier. |
| **3** | Tìm kiếm sản phẩm theo tên / mã vạch | **Hoàn thành** | Dùng `SqlParameter` kết hợp ký tự đại diện `%` phòng chống SQL Injection. |
| **4** | Lập hóa đơn & Giỏ hàng DataGridView | **Hoàn thành** | Cho phép chọn/quét mã sản phẩm, nhập số lượng, tự động tính tổng tiền mặt. |
| **5** | Giao dịch Thanh toán `SqlTransaction` | **Hoàn thành** | Mở transaction đồng thời Insert `HoaDon`, `ChiTietHoaDon`, Update `SoLuongTon` và `DiemTichLuy`. |
| **6** | Cơ chế an toàn Rollback | **Hoàn thành** | Bắt ngoại lệ nếu `SoLuongTon < SoLuongBán` $\rightarrow$ Tự động gọi `trans.Rollback()` và thông báo lỗi. |
| **7** | Tích điểm tự động cho khách hàng | **Hoàn thành** | Tự động cộng điểm tích lũy: `DiemTichLuy += TongTien / 100000`. |
| **8** | Báo cáo doanh thu | **Hoàn thành** | Dùng `ExecuteScalar` tính tổng doanh thu theo tháng/năm. |
| **9** | Thống kê Top 5 sản phẩm bán chạy | **Hoàn thành** | Dùng `SqlDataReader` đọc và nạp danh sách Top 5 sản phẩm bán chạy nhất. |

### 2. Bài 6.2: Hệ Thống Quản Lý Nhân Sự & Tính Lương (HRMDB)
| STT | Yêu cầu nghiệp vụ / Chức năng | Trạng thái | Giải pháp kỹ thuật đã áp dụng |
| :---: | :--- | :---: | :--- |
| **1** | Thiết kế CSDL HRMDB (4 bảng chính) | **Hoàn thành** | Tạo cấu trúc `PhongBan`, `NhanVien`, `BangChamCong`, `BangLuong`. |
| **2** | Quản lý Hồ sơ Nhân sự (CRUD 3-Tier) | **Hoàn thành** | Thêm, sửa, xóa, chuyển phòng ban cho nhân viên theo mô hình 3-Tier. |
| **3** | Tìm kiếm nhân viên an toàn | **Hoàn thành** | Tìm kiếm theo Tên, Phòng ban, CCCD bằng `SqlParameter`. |
| **4** | Chấm công ngắt kết nối (Disconnected) | **Hoàn thành** | Nạp dữ liệu vào `DataTable` qua `SqlDataAdapter`, cho phép nhập ngày công/OT trực tiếp trên DataGridView. |
| **5** | Lưu chấm công đồng bộ 1 thao tác | **Hoàn thành** | Sử dụng `SqlCommandBuilder` và `adapter.Update(dt)` để đẩy toàn bộ thay đổi về SQL Server. |
| **6** | Công thức tính lương tự động | **Hoàn thành** | `ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)`. |
| **7** | Chốt lương tháng bằng `SqlTransaction` | **Hoàn thành** | Mở Transaction tính toán và chốt bảng lương hàng tháng cho toàn bộ nhân viên, khóa dữ liệu an toàn. |

---
## KẾT QUẢ THỰC HÀNH

# bai6.1

<img width="1786" height="719" alt="bai6 1" src="https://github.com/user-attachments/assets/72d66779-11ab-44c1-abca-c36fea0afb14" />

# bai6.2

<img width="1245" height="786" alt="bai6 2-3" src="https://github.com/user-attachments/assets/885bf8e5-d358-46f5-aab1-a53781d82fa1" />

<img width="1249" height="792" alt="bai6 2-2" src="https://github.com/user-attachments/assets/ba7822e0-997c-4464-8c38-f192154cccba" />

<img width="1253" height="791" alt="bai6 2" src="https://github.com/user-attachments/assets/c5da1dc5-b2d3-4bfb-9a79-1c87ea4674d1" />

## CẤU TRÚC THƯ MỤC SOLUTION

```text
├── Database/
│   ├── ScriptDB_Sales.sql      # Script khởi tạo CSDL SalesDB (Bài 6.1)
│   └── ScriptDB_HRM.sql        # Script khởi tạo CSDL HRMDB (Bài 6.2)
├── bai6.1/                     # Project BÁN HÀNG (Retail Sales System)
│   ├── DTO/                    # Data Transfer Objects
│   ├── DAL/                    # Data Access Layer (SqlTransaction, SqlParameter)
│   ├── BUS/                    # Business Logic Layer
│   ├── GUI/                    # WinForms UI (frmBanHang.cs)
│   ├── App.config
│   └── Program.cs
├── bai6.2/                     # Project NHÂN SỰ & TÍNH LƯƠNG (HRM System)
│   ├── DTO/                    # Data Transfer Objects
│   ├── DAL/                    # Data Access Layer (Disconnected Model: SqlDataAdapter)
│   ├── BUS/                    # Business Logic Layer
│   ├── GUI/                    # WinForms UI (frmHRM.cs)
│   ├── App.config
│   └── Program.cs
├── images/                     # Chứa hình ảnh báo cáo Markdown
│   ├── bai6.1.png
│   ├── bai6.2.png
│   ├── bai6.2-2.png
│   └── bai6.2-3.png
├── README.md                   # File báo cáo GitHub
└── SolutionName.sln
