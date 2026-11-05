using System.Collections.Generic;
using bai6._2.DAL;
using bai6._2.DTO;

namespace bai6._2.BUS
{
    public class NhanVienHRMBUS
    {
        public List<NhanVienHRMDTO> GetAll() => NhanVienHRMDAL.GetAll();
        public List<NhanVienHRMDTO> TimKiem(string kw) => NhanVienHRMDAL.TimKiem(kw);
        public List<PhongBanDTO> GetPhongBan() => NhanVienHRMDAL.GetDanhSachPhongBan();
        public bool Them(NhanVienHRMDTO nv) => NhanVienHRMDAL.Insert(nv);
        public bool Sua(NhanVienHRMDTO nv) => NhanVienHRMDAL.Update(nv);
        public bool Xoa(int maNV) => NhanVienHRMDAL.Delete(maNV);
    }
}