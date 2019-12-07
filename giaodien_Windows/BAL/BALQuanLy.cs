using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
    public class BALQuanLy:Context
    {
        public DataTable loadgiacdo()
        {
            var x = from y in qltg.DONHANGs
                    join t in qltg.KHACHHANGs on y.MaKH equals t.MaKH
                    select new
                    {
                        y.MaKho,
                        y.MaDH,
                        y.NgayNhan,
                        y.NgayTra,
                        y.TinhTrang,
                        y.ThanhTien,
                        t.TenKH,
                        t.CongNo
                    };
            var c = from a in x
                    join b in qltg.KHOs on a.MaKho equals b.MaKho
                    select new
                    {
                        a.MaDH,
                        a.NgayNhan,
                        a.NgayTra,
                        a.TinhTrang,
                        a.ThanhTien,
                        a.TenKH,
                        a.CongNo,
                        b.TenKho
                    };
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDH");
            dt.Columns.Add("NgayNhan");
            dt.Columns.Add("NgayTra");
            dt.Columns.Add("TinhTrang");
            dt.Columns.Add("ThanhTien");
            dt.Columns.Add("TenKH");
            dt.Columns.Add("CongNo");
            dt.Columns.Add("TenKho");
            foreach (var v in c)
            {
                dt.Rows.Add(v.MaDH, v.NgayNhan, v.NgayTra, v.TinhTrang, v.ThanhTien, v.TenKH, v.CongNo, v.TenKho);
            }
            return dt;
        }
        public void updatett(String mahd)
        {
            //DONHANG d = new DONHANG();
            //d = qltg.DONHANGs.Where(t => t.MaDH == mahd).FirstOrDefault();
            //d.TinhTrang = true;
            //qltg.SubmitChanges();
        }
    }
}
