using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BAL
{
     public class BALKho:Context
    {
        public List<KHO> LoadKho()
        {
            return qltg.KHOs.Select(t => t).ToList<KHO>();
        }
        public void ThemKho(String MAKHO,string tenkho)
        {
            KHO dv = new KHO();
            dv.MaKho = MAKHO;
            dv.TenKho = tenkho;
            qltg.KHOs.InsertOnSubmit(dv);
            qltg.SubmitChanges();
        }
        public void XoaKho(string Madv)
        {
            KHO d = new KHO();
            d = qltg.KHOs.Where(t => t.MaKho == Madv).FirstOrDefault();
            qltg.KHOs.DeleteOnSubmit(d);
            qltg.SubmitChanges();
        }
        public void SuaKho(String MAKHO, string tenkho)
        {
            KHO d = new KHO();
            d = qltg.KHOs.Where(t => t.MaKho == MAKHO).FirstOrDefault();
            d.TenKho = tenkho;
            qltg.SubmitChanges();
        }
    }
}
