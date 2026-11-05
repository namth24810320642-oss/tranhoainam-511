using System.Collections.Generic;
using bai6._1.DAL;
using bai6._1.DTO;

namespace bai6._1.BUS
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL spDAL = new();

        public List<SanPhamDTO> GetAll() => spDAL.GetAll();

        public List<SanPhamDTO> TimKiem(string keyword) => spDAL.TimKiem(keyword);

        public bool ThemSanPham(SanPhamDTO sp)
        {
            if (string.IsNullOrEmpty(sp.MaSP) || string.IsNullOrEmpty(sp.TenSP))
                return false;
            return spDAL.Insert(sp);
        }
    }
}