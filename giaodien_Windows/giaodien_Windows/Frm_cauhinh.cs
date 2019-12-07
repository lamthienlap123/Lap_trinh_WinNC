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

namespace giaodien_Windows
{
    public partial class Frm_cauhinh : DevExpress.XtraEditors.XtraForm
    {
        public Frm_cauhinh()
        {
            InitializeComponent();
        }
        QL_nguoidung Cauhinh = new QL_nguoidung();
        private void cbo_sever_DropDown(object sender, EventArgs e)
        {
            DataTable dt = Cauhinh.GetServerName();
            cbo_sever.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn column in dt.Columns)
                {
                    cbo_sever.Items.Add(row[column]);
                }
            }
        }
        private void cbo_database_DropDown(object sender, EventArgs e)
        {
            cbo_database.Items.Clear();
            List<string> _list = Cauhinh.GetDatabaseName(cbo_sever.Text, txt_user.Text, txt_pass.Text);
            if (_list == null)
            {
                MessageBox.Show("Thông tin cấu hình chưa chính xác");
                return;
            }
            foreach (string item in _list)
            {
                cbo_database.Items.Add(item);
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            Cauhinh.ChangeConnectionString(cbo_sever.Text, cbo_database.Text, txt_user.Text, txt_pass.Text);
            this.Close();
        }
    }
}