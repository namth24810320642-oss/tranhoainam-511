using System.Data;
using bai6._2.DAL;

namespace bai6._2.BUS
{
    public class BangLuongBUS
    {
        public bool ChotLuong(string thangNam) => BangLuongDAL.ChotLuongThang(thangNam);
        public DataTable GetBangLuong(string thangNam) => BangLuongDAL.GetBangLuongByThang(thangNam);
    }
}