using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
namespace WindowsFormsApp1
{
    class QL_nguoidung
    {
       
        public int check_congif()
        {
            if (Properties.Settings.Default.dangnhap == string.Empty)
                return 1;
            SqlConnection ketnoi = new SqlConnection(Properties.Settings.Default.dangnhap);
            try
            {
                if (ketnoi.State == System.Data.ConnectionState.Closed)
                    ketnoi.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public int check_user(string user, string matkhau)
        {
            SqlDataAdapter dauser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap = '" + user + "'" + "and MatKhau = '" + matkhau + "'", Properties.Settings.Default.dangnhap);
            DataTable dt = new DataTable();
            dauser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0;//user không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "0")
            {
                return 1; // Không hoạt động
            }
            return 2;// Đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            System.Data.Sql.SqlDataSourceEnumerator instance = System.Data.Sql.SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases", "Data Source = " + pServerName + "; Initial Catalog = " + "master" + "; User ID = " + pUser + "; pwd = " + pPass + "");
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    foreach (System.Data.DataColumn col in dt.Columns)
                    {
                        _list.Add(row[col].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return _list;
        }
        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
           Properties.Settings.Default.dangnhap = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd = " + pPass + "";
            Properties.Settings.Default.Save();
        }
    }
    
}
