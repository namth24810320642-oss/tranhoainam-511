using System;

namespace bai6._2.DTO
{
    public class NhanVienHRMDTO
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string CCCD { get; set; } = string.Empty;
        public int MaPB { get; set; }
        public string TenPB { get; set; } = string.Empty;
        public decimal LuongCoBan { get; set; }
        public double HeSoLuong { get; set; }
    }
}