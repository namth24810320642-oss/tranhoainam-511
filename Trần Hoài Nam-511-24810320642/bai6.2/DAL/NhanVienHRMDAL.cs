#pragma warning disable CS0618
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using bai6._2.DTO;

namespace bai6._2.DAL
{
    public class NhanVienHRMDAL
    {
        public static List<NhanVienHRMDTO> GetAll()
        {
            var list = new List<NhanVienHRMDTO>();
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();
            string query = @"SELECT nv.*, pb.TenPB 
                            FROM NhanVien nv 
                            LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new NhanVienHRMDTO
                {
                    MaNV = Convert.ToInt32(reader["MaNV"]),
                    HoTen = reader["HoTen"].ToString() ?? string.Empty,
                    NgaySinh = reader["NgaySinh"] is not DBNull ? Convert.ToDateTime(reader["NgaySinh"]) : DateTime.Now,
                    CCCD = reader["CCCD"].ToString() ?? string.Empty,
                    MaPB = reader["MaPB"] is not DBNull ? Convert.ToInt32(reader["MaPB"]) : 0,
                    TenPB = reader["TenPB"].ToString() ?? string.Empty,
                    LuongCoBan = Convert.ToDecimal(reader["LuongCoBan"]),
                    HeSoLuong = Convert.ToDouble(reader["HeSoLuong"])
                });
            }
            return list;
        }

        public static List<NhanVienHRMDTO> TimKiem(string keyword)
        {
            var list = new List<NhanVienHRMDTO>();
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();
            string query = @"SELECT nv.*, pb.TenPB 
                            FROM NhanVien nv 
                            LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB 
                            WHERE nv.HoTen LIKE @kw OR nv.CCCD LIKE @kw OR pb.TenPB LIKE @kw";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new NhanVienHRMDTO
                {
                    MaNV = Convert.ToInt32(reader["MaNV"]),
                    HoTen = reader["HoTen"].ToString() ?? string.Empty,
                    NgaySinh = reader["NgaySinh"] is not DBNull ? Convert.ToDateTime(reader["NgaySinh"]) : DateTime.Now,
                    CCCD = reader["CCCD"].ToString() ?? string.Empty,
                    MaPB = reader["MaPB"] is not DBNull ? Convert.ToInt32(reader["MaPB"]) : 0,
                    TenPB = reader["TenPB"].ToString() ?? string.Empty,
                    LuongCoBan = Convert.ToDecimal(reader["LuongCoBan"]),
                    HeSoLuong = Convert.ToDouble(reader["HeSoLuong"])
                });
            }
            return list;
        }

        public static bool Insert(NhanVienHRMDTO nv)
        {
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();
            string query = @"INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) 
                            VALUES (@HoTen, @NgaySinh, @CCCD, @MaPB, @LuongCoBan, @HeSoLuong)";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
            cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
            cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
            cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool Update(NhanVienHRMDTO nv)
        {
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();
            string query = @"UPDATE NhanVien 
                            SET HoTen = @HoTen, NgaySinh = @NgaySinh, CCCD = @CCCD, 
                                MaPB = @MaPB, LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong 
                            WHERE MaNV = @MaNV";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
            cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
            cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
            cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool Delete(int maNV)
        {
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaNV", maNV);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static List<PhongBanDTO> GetDanhSachPhongBan()
        {
            var list = new List<PhongBanDTO>();
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();
            string query = "SELECT * FROM PhongBan";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new PhongBanDTO
                {
                    MaPB = Convert.ToInt32(reader["MaPB"]),
                    TenPB = reader["TenPB"].ToString() ?? string.Empty,
                    MoTa = reader["MoTa"].ToString() ?? string.Empty
                });
            }
            return list;
        }
    }
}