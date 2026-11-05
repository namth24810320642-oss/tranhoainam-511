#pragma warning disable CS0618
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using bai6._1.DTO;

namespace bai6._1.DAL
{
    public class HoaDonDAL
    {
        public bool ThanhToanTransaction(HoaDonDTO hd, List<ChiTietHoaDonDTO> dsChiTiet)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var trans = conn.BeginTransaction();
            try
            {
                foreach (var item in dsChiTiet)
                {
                    string queryCheck = "SELECT SoLuongTon FROM SanPham WHERE MaSP = @MaSP";
                    using var cmdCheck = new SqlCommand(queryCheck, conn, trans);
                    cmdCheck.Parameters.AddWithValue("@MaSP", item.MaSP);
                    object? result = cmdCheck.ExecuteScalar();
                    int tonHienTai = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                    if (tonHienTai < item.SoLuong)
                    {
                        trans.Rollback();
                        throw new Exception($"Sản phẩm '{item.TenSP}' (Mã: {item.MaSP}) không đủ tồn kho! (Tồn: {tonHienTai}, Bán: {item.SoLuong})");
                    }
                }

                string queryHD = @"INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien) 
                                   OUTPUT INSERTED.MaHD 
                                   VALUES (@NgayLap, @MaNV, @MaKH, @TongTien)";
                int maHDMoi;
                using (var cmdHD = new SqlCommand(queryHD, conn, trans))
                {
                    cmdHD.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                    cmdHD.Parameters.AddWithValue("@MaNV", hd.MaNV);
                    cmdHD.Parameters.AddWithValue("@MaKH", (object?)hd.MaKH ?? DBNull.Value);
                    cmdHD.Parameters.AddWithValue("@TongTien", hd.TongTien);
                    maHDMoi = (int)cmdHD.ExecuteScalar();
                }

                foreach (var item in dsChiTiet)
                {
                    string queryCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) 
                                       VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                    using (var cmdCT = new SqlCommand(queryCT, conn, trans))
                    {
                        cmdCT.Parameters.AddWithValue("@MaHD", maHDMoi);
                        cmdCT.Parameters.AddWithValue("@MaSP", item.MaSP);
                        cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@DonGia", item.DonGia);
                        cmdCT.ExecuteNonQuery();
                    }

                    string queryUpdateTon = @"UPDATE SanPham 
                                             SET SoLuongTon = SoLuongTon - @SoLuong 
                                             WHERE MaSP = @MaSP";
                    using (var cmdTon = new SqlCommand(queryUpdateTon, conn, trans))
                    {
                        cmdTon.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdTon.Parameters.AddWithValue("@MaSP", item.MaSP);
                        cmdTon.ExecuteNonQuery();
                    }
                }

                if (hd.MaKH.HasValue && hd.MaKH.Value > 0)
                {
                    int diemCong = (int)(hd.TongTien / 100000m);
                    if (diemCong > 0)
                    {
                        string queryDiem = @"UPDATE KhachHang 
                                             SET DiemTichLuy = DiemTichLuy + @Diem 
                                             WHERE MaKH = @MaKH";
                        using var cmdDiem = new SqlCommand(queryDiem, conn, trans);
                        cmdDiem.Parameters.AddWithValue("@Diem", diemCong);
                        cmdDiem.Parameters.AddWithValue("@MaKH", hd.MaKH.Value);
                        cmdDiem.ExecuteNonQuery();
                    }
                }

                trans.Commit();
                return true;
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }

        public decimal TinhDoanhThuThang(int thang, int nam)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"SELECT ISNULL(SUM(TongTien), 0) 
                            FROM HoaDon 
                            WHERE MONTH(NgayLap) = @Thang AND YEAR(NgayLap) = @Nam";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);
            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public DataTable GetTop5SanPham()
        {
            var dt = new DataTable();
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"SELECT TOP 5 sp.MaSP, sp.TenSP, 
                                   SUM(ct.SoLuong) AS TongSoLuongBan, 
                                   SUM(ct.SoLuong * ct.DonGia) AS TongDoanhThu
                            FROM ChiTietHoaDon ct
                            JOIN SanPham sp ON ct.MaSP = sp.MaSP
                            GROUP BY sp.MaSP, sp.TenSP
                            ORDER BY TongSoLuongBan DESC";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }
    }
}