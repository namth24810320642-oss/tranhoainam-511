#pragma warning disable CS0618
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace bai6._2.DAL
{
    public class BangLuongDAL
    {
        public static bool ChotLuongThang(string thangNam)
        {
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();
            using var trans = conn.BeginTransaction();

            try
            {
                string querySelect = @"SELECT nv.MaNV, nv.LuongCoBan, nv.HeSoLuong, cc.SoNgayCong, cc.SoGioOT
                                       FROM NhanVien nv
                                       JOIN BangChamCong cc ON nv.MaNV = cc.MaNV
                                       WHERE cc.ThangNam = @ThangNam";

                var dsCalculated = new List<(int MaNV, decimal ThucLinh)>();

                using (var cmdSelect = new SqlCommand(querySelect, conn, trans))
                {
                    cmdSelect.Parameters.AddWithValue("@ThangNam", thangNam);
                    using var reader = cmdSelect.ExecuteReader();
                    while (reader.Read())
                    {
                        int maNV = Convert.ToInt32(reader["MaNV"]);
                        decimal luongCoBan = Convert.ToDecimal(reader["LuongCoBan"]);
                        double heSoLuong = Convert.ToDouble(reader["HeSoLuong"]);
                        double soNgayCong = Convert.ToDouble(reader["SoNgayCong"]);
                        double soGioOT = Convert.ToDouble(reader["SoGioOT"]);

                        decimal thucLinh = ((luongCoBan * (decimal)heSoLuong) / 22m) * (decimal)soNgayCong + ((decimal)soGioOT * 50000m);
                        dsCalculated.Add((maNV, thucLinh));
                    }
                }

                foreach (var (maNV, thucLinh) in dsCalculated)
                {
                    string querySave = @"IF EXISTS (SELECT 1 FROM BangLuong WHERE MaNV = @MaNV AND ThangNam = @ThangNam)
                                            UPDATE BangLuong SET ThucLinh = @ThucLinh WHERE MaNV = @MaNV AND ThangNam = @ThangNam
                                        ELSE
                                            INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh) VALUES (@MaNV, @ThangNam, @ThucLinh)";

                    using var cmdSave = new SqlCommand(querySave, conn, trans);
                    cmdSave.Parameters.AddWithValue("@MaNV", maNV);
                    cmdSave.Parameters.AddWithValue("@ThangNam", thangNam);
                    cmdSave.Parameters.AddWithValue("@ThucLinh", thucLinh);
                    cmdSave.ExecuteNonQuery();
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

        public static DataTable GetBangLuongByThang(string thangNam)
        {
            var dt = new DataTable();
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();
            string query = @"SELECT bl.MaLuong, bl.MaNV, nv.HoTen, pb.TenPB, bl.ThangNam, bl.ThucLinh
                            FROM BangLuong bl
                            JOIN NhanVien nv ON bl.MaNV = nv.MaNV
                            LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                            WHERE bl.ThangNam = @ThangNam";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ThangNam", thangNam);
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }
    }
}