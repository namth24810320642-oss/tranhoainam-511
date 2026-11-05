using System.Data;
using bai6._2.DAL;

namespace bai6._2.BUS
{
    public class BangChamCongBUS
    {
        private readonly BangChamCongDAL ccDAL = new();

        public DataTable LoadChamCong(string thangNam) => ccDAL.LoadBangChamCong(thangNam);
        public bool LuuChamCong(DataTable dt, string thangNam) => ccDAL.LuuBangChamCong(dt, thangNam);
    }
}