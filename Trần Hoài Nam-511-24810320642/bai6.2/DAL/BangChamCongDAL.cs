#pragma warning disable CS0618
using System.Data;
using System.Data.SqlClient;

namespace bai6._2.DAL
{
    public class BangChamCongDAL
    {
        private SqlDataAdapter adapter = new();

        // 1. Khởi tạo bản ghi mặc định cho nhân viên mới và Nạp DataTable ngắt kết nối
        public DataTable LoadBangChamCong(string thangNam)
        {
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();

            // Tự động khởi tạo dòng chấm công cho tất cả nhân viên chưa có trong tháng
            string queryInit = @"INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT)
                                SELECT nv.MaNV, @ThangNam, 0, 0 
                                FROM NhanVien nv 
                                WHERE nv.MaNV NOT IN (SELECT cc.MaNV FROM BangChamCong cc WHERE cc.ThangNam = @ThangNam)";
            using (var cmdInit = new SqlCommand(queryInit, conn))
            {
                cmdInit.Parameters.AddWithValue("@ThangNam", thangNam);
                cmdInit.ExecuteNonQuery();
            }

            // Nạp dữ liệu vào DataTable
            string selectQuery = @"SELECT cc.MaCong, cc.MaNV, nv.HoTen, cc.ThangNam, cc.SoNgayCong, cc.SoGioOT 
                                  FROM BangChamCong cc
                                  JOIN NhanVien nv ON cc.MaNV = nv.MaNV
                                  WHERE cc.ThangNam = @ThangNam";

            adapter = new SqlDataAdapter(selectQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangNam);

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // 2. Đồng bộ toàn bộ thay đổi trên DataTable ngắt kết nối về SQL Server trong 1 thao tác
        public bool LuuBangChamCong(DataTable dt, string thangNam)
        {
            using var conn = HRMDatabaseConnection.GetConnection();
            conn.Open();

            string selectQuery = @"SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT 
                                  FROM BangChamCong 
                                  WHERE ThangNam = @ThangNam";

            adapter = new SqlDataAdapter(selectQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangNam);

            // Tự động sinh lệnh UPDATE/INSERT/DELETE
            using var builder = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            return true;
        }
    }
}