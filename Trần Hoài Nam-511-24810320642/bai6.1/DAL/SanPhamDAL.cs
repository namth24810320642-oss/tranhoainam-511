#pragma warning disable CS0618
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using bai6._1.DTO;

namespace bai6._1.DAL
{
    public class SanPhamDAL
    {
        public List<SanPhamDTO> GetAll()
        {
            var list = new List<SanPhamDTO>();
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new SanPhamDTO
                {
                    MaSP = reader["MaSP"].ToString() ?? string.Empty,
                    TenSP = reader["TenSP"].ToString() ?? string.Empty,
                    GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                    SoLuongTon = Convert.ToInt32(reader["SoLuongTon"])
                });
            }
            return list;
        }

        public List<SanPhamDTO> TimKiem(string keyword)
        {
            var list = new List<SanPhamDTO>();
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"SELECT MaSP, TenSP, GiaBan, SoLuongTon 
                            FROM SanPham 
                            WHERE MaSP LIKE @kw OR TenSP LIKE @kw";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new SanPhamDTO
                {
                    MaSP = reader["MaSP"].ToString() ?? string.Empty,
                    TenSP = reader["TenSP"].ToString() ?? string.Empty,
                    GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                    SoLuongTon = Convert.ToInt32(reader["SoLuongTon"])
                });
            }
            return list;
        }

        public bool Insert(SanPhamDTO sp)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = "INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES (@MaSP, @TenSP, @GiaBan, @SoLuongTon)";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
            cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}