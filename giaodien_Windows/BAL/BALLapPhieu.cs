using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
    public class BALLapPhieu:Context
    {
        public List<CTDONHANG> loadtheocbo(int mahd)
        {
            return qltg.CTDONHANGs.Where(t => t.MaDH == mahd).ToList<CTDONHANG>();
        }
        public List<NHANVIEN> LoadNhanVien()
        {
            return qltg.NHANVIENs.Select(t => t).ToList<NHANVIEN>();
        }
        public List<KHO> LoadKho()
        {
            return qltg.KHOs.Select(t => t).ToList<KHO>();
        }
        public List<KHACHHANG> LoadKhachHang()
        {
            return qltg.KHACHHANGs.Select(t => t).ToList<KHACHHANG>();
        }
        public List<DONHANG> loaddonhang()
        {
            return qltg.DONHANGs.Where(t => t.TinhTrang=="Chưa giặt").ToList<DONHANG>();
        }
        public void themdonhang(DateTime ngaynhan,DateTime ngaytra,string tinhtrang,float thanhtien,string ghichu,string manv,string makh,string makho)
        {
            DONHANG dh = new DONHANG();
            dh.NgayNhan = ngaynhan;
            dh.NgayTra = ngaytra;
            dh.TinhTrang = tinhtrang;
            dh.ThanhTien = thanhtien;
            dh.GhiChu = ghichu;
            dh.MaNV = manv;
            dh.MaKH = makh;
            dh.MaKho = makho;
            qltg.DONHANGs.InsertOnSubmit(dh);
            qltg.SubmitChanges();
        }
        public void XoaDonHang(int madh)
        {
            DONHANG dh = new DONHANG();
            dh = qltg.DONHANGs.Where(t => t.MaDH == madh).FirstOrDefault();
            qltg.DONHANGs.DeleteOnSubmit(dh);
            qltg.SubmitChanges();
        }
        public void SuaDonHang(int madh, DateTime ngaynhan, DateTime ngaytra, string tinhtrang, float thanhtien, string ghichu, string manv, string makh, string makho)
        {
            DONHANG dh = new DONHANG();
            dh = qltg.DONHANGs.Where(t => t.MaDH == madh).FirstOrDefault();
            dh.MaDH = madh;
            dh.NgayNhan = ngaynhan;
            dh.NgayTra = ngaytra;
            dh.TinhTrang = tinhtrang;
            dh.ThanhTien = thanhtien;
            dh.GhiChu = ghichu;
            dh.MaNV = manv;
            dh.MaKH = makh;
            dh.MaKho = makho;
            qltg.SubmitChanges();
        }
        public void themchitietdonhang(int soluong,int mahd,string madv,float thanhtien)
        {
            CTDONHANG ctdh = new CTDONHANG();
            ctdh.SoLuong = soluong;
            ctdh.MaDH = mahd;
            ctdh.MaDV = madv;
            ctdh.ThanhTien = thanhtien;
            qltg.CTDONHANGs.InsertOnSubmit(ctdh);
            qltg.SubmitChanges();
        }
        public void XoaCTDH(int madh,string madv)
        {
            CTDONHANG ctdh = new CTDONHANG();
            ctdh = qltg.CTDONHANGs.Where(t => t.MaDH == madh && t.MaDV==madv).FirstOrDefault();
            qltg.CTDONHANGs.DeleteOnSubmit(ctdh);
            qltg.SubmitChanges();
        }
        public void SuaCTDH(int sl,int madh, string madv,float thanhtien)
        {
            CTDONHANG ctdh = new CTDONHANG();
            ctdh = qltg.CTDONHANGs.Where(t => t.MaDH == madh && t.MaDV == madv).FirstOrDefault();
            ctdh.SoLuong =sl;
            ctdh.ThanhTien = thanhtien;
            qltg.SubmitChanges();
        }
        public List<CTDONHANG> loadchitietdonhang()
        {
            return qltg.CTDONHANGs.Select(t => t).ToList<CTDONHANG>();
        }
        public List<DICHVU> loadcbodichvu()
        {
            return qltg.DICHVUs.Select(t => t).ToList<DICHVU>();
        }
        public List<KHACHHANG> getKHtheoma(string pmakh)
        {
            return qltg.KHACHHANGs.Where(t => t.MaKH == pmakh).ToList<KHACHHANG>();
        }
        public string LayTenDV(string MaDV)
        {
            string a = "";
            var ma = from x in qltg.DICHVUs
                     where x.MaDV == MaDV
                     select new
                     {
                         x.TenDV
                     };
            foreach (var r in ma)
            {
                a = r.TenDV;

            }
            return a;
        }
        public List<NHANVIEN> getNVtheoma(string pmanv)
        {
            return qltg.NHANVIENs.Where(t => t.MaNV == pmanv).ToList<NHANVIEN>();
        }
        public string LayGiaBan(string Mdv)
        {
            string a = "";
            var ma = from x in qltg.DICHVUs
                     where x.MaDV == Mdv
                     select new
                     {
                         x.DonGia
                     };
            foreach (var r in ma)
            {
                a = r.DonGia.ToString();
                
            }
            return a;
        }
        public void capnhattongtien(int madh, float tt)
        {
            DONHANG dh = new DONHANG();
            dh = qltg.DONHANGs.Where(t => t.MaDH == madh).FirstOrDefault();
            dh.ThanhTien = tt;
            qltg.SubmitChanges();
        }
    }
}
