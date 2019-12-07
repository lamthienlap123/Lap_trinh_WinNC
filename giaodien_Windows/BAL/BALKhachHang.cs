using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
    public class BALKhachHang:Context
    {
        public List<KHACHHANG> LoadkhachHang()
        {
            return qltg.KHACHHANGs.Select(t => t).ToList<KHACHHANG>();
        }
        public void ThemKhachHang(string MAKH, string Tenkh, string diachi,int sdt,float congno)
        {
            KHACHHANG dv = new KHACHHANG();
            dv.MaKH = MAKH;
            dv.TenKH = Tenkh;
            dv.DiaChi = diachi;
            dv.SDT = sdt;
            dv.CongNo = congno;
            qltg.KHACHHANGs.InsertOnSubmit(dv);
            qltg.SubmitChanges();
        }
        public void XoaKhachHang(string Madv)
        {
            KHACHHANG d = new KHACHHANG();
            d = qltg.KHACHHANGs.Where(t => t.MaKH == Madv).FirstOrDefault();
            qltg.KHACHHANGs.DeleteOnSubmit(d);
            qltg.SubmitChanges();
        }
        public void SuaDichVu(string MAKH, string Tenkh, string diachi, int sdt, float congno)
        {
            KHACHHANG d = new KHACHHANG();
            d = qltg.KHACHHANGs.Where(t => t.MaKH == MAKH).FirstOrDefault();
            d.TenKH = Tenkh;
            d.DiaChi = diachi;
            d.SDT = sdt;
            d.CongNo = congno;
            qltg.KHACHHANGs.InsertOnSubmit(d);
            qltg.SubmitChanges(); ;
        }
    }
}
