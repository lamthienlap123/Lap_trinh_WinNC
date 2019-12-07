using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BAL;
using DAL;
namespace giaodien_Windows
{
    public partial class Frm_giat : DevExpress.XtraEditors.XtraForm
    {
        public Frm_giat()
        {
            InitializeComponent();
        }
        QuanLyTiemGiacLaDataContext ql = new QuanLyTiemGiacLaDataContext();
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_giat_Load(object sender, EventArgs e)
        {
            
            foreach(var item in ql.MayGiats)
            {

            }
        }
    }
}