using System;
using System.Collections.Generic;
using System.Data;
using bai6._1.DAL;
using bai6._1.DTO;

namespace bai6._1.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL hdDAL = new();

        public bool ThanhToan(HoaDonDTO hd, List<ChiTietHoaDonDTO> dsChiTiet)
        {
            if (dsChiTiet == null || dsChiTiet.Count == 0)
                throw new Exception("Giỏ hàng đang trống, không thể thanh toán!");

            return hdDAL.ThanhToanTransaction(hd, dsChiTiet);
        }

        public decimal GetDoanhThu(int thang, int nam) => hdDAL.TinhDoanhThuThang(thang, nam);

        public DataTable GetTop5() => hdDAL.GetTop5SanPham();
    }
}