using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Linq;
namespace BAL
{
    public class BALDichVu : Context
    {
        public List<DICHVU> LoadDichVu()
        {
            return qltg.DICHVUs.Select(t => t).ToList<DICHVU>();
        }
        public void ThemDichVu(string MDV, string TDV, float DG)
        {
            DICHVU dv = new DICHVU();
            dv.MaDV = MDV;
            dv.TenDV = TDV;
            dv.DonGia = DG;
            qltg.DICHVUs.InsertOnSubmit(dv);
            qltg.SubmitChanges();
        }
        public void XoaDichVu(string Madv)
        {
            DICHVU d = new DICHVU();
            d = qltg.DICHVUs.Where(t => t.MaDV == Madv).FirstOrDefault();
            qltg.DICHVUs.DeleteOnSubmit(d);
            qltg.SubmitChanges();
        }
        public void SuaDichVu(string MDV, string TDV, float DG)
        {
            DICHVU d = new DICHVU();
            d = qltg.DICHVUs.Where(t => t.MaDV == MDV).FirstOrDefault();
            d.TenDV = TDV;
            d.DonGia = DG;
            qltg.SubmitChanges();
        }
    }
}
