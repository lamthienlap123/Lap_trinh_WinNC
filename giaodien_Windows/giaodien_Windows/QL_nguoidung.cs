using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using DevExpress;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Ribbon;
namespace giaodien_Windows
{
    class QL_nguoidung
    {
        public List<string> mamh = new List<string>();
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
            SqlDataAdapter dauser = new SqlDataAdapter("select * from QL_NGUOIDUNG where TenDangNhap = '" + user + "'" + "and MatKhau = '" + matkhau + "'", Properties.Settings.Default.dangnhap);
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

        public List<string> getDatatable(string TenDangNhap)
        {
            string sqlnhom = "select MaNhom from QL_NguoiDung, QL_NguoiDungNhomNguoiDung where QL_NguoiDung.TenDangNhap = '" + TenDangNhap + "' and QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap";
            DataTable dtNhom = new DataTable();
            List<string> ListMaNhom = new List<string>();
            SqlDataAdapter daNhom = new SqlDataAdapter(sqlnhom, Properties.Settings.Default.dangnhap);
            daNhom.Fill(dtNhom);
            foreach (System.Data.DataRow row in dtNhom.Rows)
            {
                foreach (System.Data.DataColumn col in dtNhom.Columns)
                {
                    //MessageBox.Show (row[col].ToString ());
                    ListMaNhom.Add(row[col].ToString());
                }
            }
            DataTable dt = new DataTable();
            List<string> _list = new List<string>();
            try
            {
                foreach (string manhom in ListMaNhom)
                {
                    SqlDataAdapter da = new SqlDataAdapter("select MaManHinh from QL_PhanQuyen, QL_NhomNguoiDung where QL_PhanQuyen.MaNhom = '" + manhom + "' and QL_PhanQuyen.MaNhom= QL_NhomNguoiDung.MaNhom", Properties.Settings.Default.dangnhap);
                    da.Fill(dt);
                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        foreach (System.Data.DataColumn col in dt.Columns)
                        {
                            //MessageBox.Show (row[col].ToString ());
                            _list.Add(row[col].ToString());
                            mamh.Add(row[col].ToString());
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
            return mamh;
        }
        public List<string> getoutMaManHinh()
        {
            return mamh;
        }
        public void resetMaManHinh()
        {
            mamh.Clear();
        }
        List<string> b = new List<string>();
        public void PhanQuyen(RibbonControl a, List<string> b)
        {
            foreach (RibbonPage item in a.Pages)
            {
                foreach (string t in b)
                {
                    string c = t.Trim();
                    if (item.Tag.ToString().CompareTo(c) == 0 && item.Tag != null)
                        item.Visible = true;
                    foreach (RibbonPageGroup item2 in item.Groups)
                    {
                        if (item2.Tag.ToString().CompareTo(c) == 0 && item2.Tag != null)
                            item2.Visible = true;
                        foreach (BarButtonItemLink item3 in item2.ItemLinks)
                        {
                            if (item3.Item.Tag.ToString().CompareTo(c) == 0 && item3.Item.Tag != null)
                                item3.Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        }
                    }
                }
            }
        }
    }
}
