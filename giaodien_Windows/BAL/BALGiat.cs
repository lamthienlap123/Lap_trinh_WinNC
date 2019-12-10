using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;
using System.Data;

namespace BAL
{
    public class BALGiat:Context
    {
        //private Button btn;

        //public Button LoadMAyGiat()
        //{
        //    foreach(MayGiat mg in qltg.MayGiats)
        //    {
        //        Button btn = new Button();
        //        btn.Text = mg.TenMay;
        //        btn.Name = mg.MaMG;
        //    }
        //    return btn;
        //}
        public string LayTrinhTrang(string MaMay)
        {
            string a = "";
            var ma = from x in qltg.MayGiats
                     where x.MaMG == MaMay
                     select new
                     {
                         x.TrangThai
                     };
            foreach (var r in ma)
            {
                a = r.TrangThai.ToString();
            }
            return a;
        }
        public DataTable LoadDonHangChuaGiat()
        {
            var x = from y in qltg.DONHANGs
                    
                    where y.TinhTrang == "Chưa giặt"
                    select new
                    {
                        y.MaDH,
                        y.NgayNhan,
                        y.NgayTra,
                        y.ThanhTien,
                    };
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDH");
            dt.Columns.Add("NgayNhan");
            dt.Columns.Add("NgayTra");
            dt.Columns.Add("ThanhTien");
            foreach (var c in x)
            {
                dt.Rows.Add(c.MaDH, c.NgayNhan, c.NgayTra,c.ThanhTien);
            }
            return dt;
        }
        public void CapNhatPhieuGiat(int Phieu,string MaMay)
        {
            DONHANG dh = new DONHANG();
            dh = qltg.DONHANGs.Where(t => t.MaDH == Phieu).FirstOrDefault();
            dh.TinhTrang = "Đang giặt";
            dh.MaMG = MaMay;
            qltg.SubmitChanges();

        }
        public void CapNhatTinhTrangGiatDangSD(string pMaMay,bool trinhtrang)
        {
            MayGiat mg = new MayGiat();
            mg = qltg.MayGiats.Where(t => t.MaMG == pMaMay).FirstOrDefault();
            mg.TrangThai = trinhtrang;
            qltg.SubmitChanges();
        }
        public DataTable LoadDonHangDangGiat(string MaMay)
        {
            var x = from y in qltg.DONHANGs
                    join z in qltg.MayGiats on y.MaMG equals z.MaMG
                    where y.TinhTrang == "Đang giặt" && z.MaMG==MaMay
                    select new
                    {
                        y.MaDH,
                        y.NgayNhan,
                        y.NgayTra,
                        y.ThanhTien,
                        z.TenMay
                    };
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDH");
            dt.Columns.Add("NgayNhan");
            dt.Columns.Add("NgayTra");
            dt.Columns.Add("ThanhTien");
            dt.Columns.Add("Máy Đang Giặt");
            foreach (var c in x)
            {
                dt.Rows.Add(c.MaDH, c.NgayNhan, c.NgayTra, c.ThanhTien,c.TenMay);
            }
            return dt;
        }
        public void CapNhatPhieuGiatDaGiat(int Phieu)
        {
            DONHANG dh = new DONHANG();
            dh = qltg.DONHANGs.Where(t => t.MaDH == Phieu).FirstOrDefault();
            dh.TinhTrang = "Đã giặt";
            qltg.SubmitChanges();

        }
    }
}
