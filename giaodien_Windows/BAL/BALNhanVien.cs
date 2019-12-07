using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Linq;
namespace BAL
{
    public class BALNhanVien:Context
    {
        public List<NHANVIEN> LoadNhanVien()
        {
            return qltg.NHANVIENs.Select(t => t).ToList<NHANVIEN>();
        }
        public void ThemNhanVien(string MANV, string hoten, string gioitinh,DateTime ngaysinh,string diachi,string sdt,string email,DateTime ngayvaolam,string cmnd)
        {
            NHANVIEN dv = new NHANVIEN();
            dv.MaNV = MANV;
            dv.HoTen = hoten;
            dv.NgaySinh = ngaysinh;
            dv.DiaChi = diachi;
            dv.SDT = sdt;
            dv.Email = email;
            dv.NgayVaoLam = ngayvaolam;
            dv.CMND = cmnd;
            dv.GioiTinh = gioitinh;
            qltg.NHANVIENs.InsertOnSubmit(dv);
            qltg.SubmitChanges();
        }
        public void XoaNhanVien(string MANV)
        {
            NHANVIEN d = new NHANVIEN();
            d = qltg.NHANVIENs.Where(t => t.MaNV == MANV).FirstOrDefault();
            qltg.NHANVIENs.DeleteOnSubmit(d);
            qltg.SubmitChanges();
        }
        public void SuaNhanVien(string MANV, string hoten, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, DateTime ngayvaolam, string cmnd)
        {
            NHANVIEN dv = new NHANVIEN();
            dv = qltg.NHANVIENs.Where(t => t.MaNV == MANV).FirstOrDefault();
            dv.HoTen = hoten;
            dv.NgaySinh = ngaysinh;
            dv.DiaChi = diachi;
            dv.SDT = sdt;
            dv.GioiTinh = gioitinh;
            dv.Email = email;
            dv.NgayVaoLam = ngayvaolam;
            dv.CMND = cmnd;    
            qltg.SubmitChanges();
        }
    }
}
