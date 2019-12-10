using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DevExpress.XtraEditors;
namespace giaodien_Windows
{
    public partial class Frm_LapPhieu : Form
    {
        public Frm_LapPhieu()
        {
            InitializeComponent();
        }
        BALLapPhieu lp = new BALLapPhieu();
        private void Frm_LapPhieu_Load(object sender, EventArgs e)
        {
            cbo_DV.DataSource = lp.loadcbodichvu();
            cbo_DV.ValueMember = "MaDV";
            cbo_DV.DisplayMember = "TenDV";
            cbo_khachhang.DataSource = lp.LoadKhachHang();
            cbo_khachhang.DisplayMember = "TenKH";
            cbo_khachhang.ValueMember = "MaKH";
            cbo_kho.DataSource = lp.LoadKho();
            cbo_kho.DisplayMember = "TenKho";
            cbo_kho.ValueMember = "MaKho";
            cbo_nhanvien.DataSource = lp.LoadNhanVien();
            cbo_nhanvien.DisplayMember = "HoTen";
            cbo_nhanvien.ValueMember = "MaNV";
            dv_donhang.DataSource = lp.loaddonhang();
        }

        private void dv_donhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_suaphieu.Enabled = true;
            btn_xoaphieu.Enabled = true;
            btn_themcthd.Enabled = true;
            int numrow;
            numrow = e.RowIndex;
            txt_madonhang.Text = dv_donhang.Rows[numrow].Cells[0].Value.ToString();
            dt_ngaynhan.Text = dv_donhang.Rows[numrow].Cells[1].Value.ToString();
            dt_ngaytra.Text = dv_donhang.Rows[numrow].Cells[2].Value.ToString();
            txt_tongtien.Text = dv_donhang.Rows[numrow].Cells[5].Value.ToString();
            txt_ghichu.Text = dv_donhang.Rows[numrow].Cells[6].Value.ToString();
            string manv = dv_donhang.Rows[numrow].Cells[7].Value.ToString();
            cbo_nhanvien.DataSource = lp.getNVtheoma(manv);
            string makh = dv_donhang.Rows[numrow].Cells[8].Value.ToString();
            cbo_khachhang.DataSource = lp.getKHtheoma(makh);

            cbo_kho.Text = dv_donhang.Rows[numrow].Cells[9].Value.ToString();
            dv_ctdg.DataSource = lp.loadtheocbo(int.Parse(txt_madonhang.Text));
        }

        private void dv_ctdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_suactdh.Enabled = true;
            btn_xoacthd.Enabled = true;
            int numrow;
            numrow = e.RowIndex;
            num_sl.Text = dv_ctdg.Rows[numrow].Cells[0].Value.ToString();
            string madv = dv_ctdg.Rows[numrow].Cells[2].Value.ToString();
            cbo_DV.Text = lp.LayTenDV(madv);
        }

        private void btn_taophieu_Click(object sender, EventArgs e)
        {
            try
            {
                lp.themdonhang(DateTime.Parse(dt_ngaynhan.DateTime.ToString()), DateTime.Parse(dt_ngaytra.DateTime.ToString()), "Chưa Giặt", float.Parse(txt_tongtien.Text), txt_ghichu.Text, cbo_nhanvien.SelectedValue.ToString(), cbo_khachhang.SelectedValue.ToString(), cbo_kho.SelectedValue.ToString());
                dv_donhang.DataSource = lp.loaddonhang();
                XtraMessageBox.Show("Thêm phiếu thành công");
            }
            catch
            {
                XtraMessageBox.Show("Thêm phiếu thất bại");
            }
        }

        private void btn_xoaphieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có chắc muốn xóa phiếu?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dv_ctdg.Rows.Count - 1 == 0)
                    {
                        XtraMessageBox.Show("Tồn tại dịch vụ trong phiếu!! vui lòng hủy dịch vụ tồn tại và thử lại");
                    }
                    else
                    {
                        lp.XoaDonHang(int.Parse(txt_madonhang.Text));
                        dv_donhang.DataSource = lp.loaddonhang();
                        XtraMessageBox.Show("Xóa phiếu thành công");
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("Xóa phiếu thất bại");
            }
        }

        private void btn_suaphieu_Click(object sender, EventArgs e)
        {
            try
            {
                lp.SuaDonHang(int.Parse(txt_madonhang.Text), DateTime.Parse(dt_ngaynhan.DateTime.ToString()), DateTime.Parse(dt_ngaytra.DateTime.ToString()), "Chưa Giặt", float.Parse(txt_tongtien.Text), txt_ghichu.Text, cbo_nhanvien.SelectedValue.ToString(), cbo_khachhang.SelectedValue.ToString(), cbo_kho.SelectedValue.ToString());
                dv_donhang.DataSource = lp.loaddonhang();
                Frm_LapPhieu_Load(sender, e);
                XtraMessageBox.Show("Sửa phiếu thành công");
            }
            catch
            {
                XtraMessageBox.Show("Sửa phiếu thất bại");
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XuatExcel(sfd.FileName);
            }
        }

        private void XuatExcel(string file)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Bán hàng";
                Microsoft.Office.Interop.Excel.Range head = worksheet.Range["A1", "I1"];
                head.MergeCells = true;
                head.Value2 = "PHIẾU GIẶT";
                head.Font.Bold = true;
                head.Font.Size = 20;
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                //from
                Microsoft.Office.Interop.Excel.Range fromDate = worksheet.Range["A3", "C3"];
                fromDate.MergeCells = true;
                fromDate.Value2 = "Ngày nhận: " + dt_ngaynhan.Text;
                fromDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //to
                Microsoft.Office.Interop.Excel.Range toDate = worksheet.Range["A4", "C3"];
                toDate.MergeCells = true;
                toDate.Value2 = "ngày ngày trả: " + dt_ngaytra.Text;
                toDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                // storing header part in Excel  
                for (int i = 1; i < dv_ctdg.Columns.Count; i++)
                {
                    worksheet.Cells[5, i] = dv_ctdg.Columns[i - 1].HeaderText;
                }
                worksheet.Range["A5", "I5"].Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dv_ctdg.Rows.Count; i++)
                {
                    for (int j = 0; j < dv_ctdg.Columns.Count - 3; j++)
                    {
                        worksheet.Cells[i + 6, j + 1] = dv_ctdg.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs(file);

                // see the excel sheet behind the program  
                if (MessageBox.Show("Xuất tệp excel thành công!") == DialogResult.OK)
                    app.Visible = true;
            }
            catch
            {
                MessageBox.Show("Xuất tệp excel thất bại!");
            }
        }

        private void btn_themcthd_Click(object sender, EventArgs e)
        {
            bool bien = true;
            for (int i = 0; i < dv_ctdg.Rows.Count; i++)
            {
                string masp = dv_ctdg.Rows[i].Cells[2].Value.ToString();
                if (masp.Equals(cbo_DV.SelectedValue.ToString()))
                {
                    bien = false;
                    break;
                }
                else
                {
                    bien = true;
                }
            }
            if (bien)
            {
                lp.themchitietdonhang(int.Parse(num_sl.Text), int.Parse(txt_madonhang.Text), cbo_DV.SelectedValue.ToString(), int.Parse(num_sl.Text) * float.Parse(txt_giaban.Text));
                dv_ctdg.DataSource = lp.loadtheocbo(int.Parse(txt_madonhang.Text));
                float tong = 0;
                for (int i = 0; i < dv_ctdg.RowCount; i++)
                {
                    tong += float.Parse(dv_ctdg.Rows[i].Cells[3].Value.ToString());
                }
                txt_tongtien.Text = tong.ToString();
                lp.capnhattongtien(int.Parse(txt_madonhang.Text), float.Parse(txt_tongtien.Text));
                dv_donhang.DataSource = lp.loaddonhang();
            }
            else
            {
                XtraMessageBox.Show("dịch vụ đã tồn tại");
            }
        }

        private void btn_xoacthd_Click(object sender, EventArgs e)
        {
            lp.XoaCTDH(int.Parse(txt_madonhang.Text), cbo_DV.SelectedValue.ToString());
            dv_ctdg.DataSource = lp.loadtheocbo(int.Parse(txt_madonhang.Text));
            float tong = 0;
            for (int i = 0; i < dv_ctdg.RowCount; i++)
            {
                tong += float.Parse(dv_ctdg.Rows[i].Cells[3].Value.ToString());
            }
            txt_tongtien.Text = tong.ToString();
            lp.capnhattongtien(int.Parse(txt_madonhang.Text), float.Parse(txt_tongtien.Text));
            dv_donhang.DataSource = lp.loaddonhang();
        }

        private void btn_suactdh_Click(object sender, EventArgs e)
        {
            try
            {
                lp.SuaCTDH(int.Parse(num_sl.Text), int.Parse(txt_madonhang.Text), cbo_DV.SelectedValue.ToString(), int.Parse(num_sl.Text) * float.Parse(txt_giaban.Text));
                dv_ctdg.DataSource = lp.loadtheocbo(int.Parse(txt_madonhang.Text));
                float tong = 0;
                for (int i = 0; i < dv_ctdg.RowCount; i++)
                {
                    tong += float.Parse(dv_ctdg.Rows[i].Cells[3].Value.ToString());
                }
                txt_tongtien.Text = tong.ToString();
                lp.capnhattongtien(int.Parse(txt_madonhang.Text), float.Parse(txt_tongtien.Text));
                dv_donhang.DataSource = lp.loaddonhang();
            }
            catch
            {

            }
        }

        private void cbo_DV_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_giaban.Text = lp.LayGiaBan(cbo_DV.SelectedValue.ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_khachhang forms = new Frm_khachhang();
            forms.Show();
        }

        private void cbo_khachhang_DropDown(object sender, EventArgs e)
        {
            this.Refresh();
            Frm_LapPhieu_Load(sender, e);
        }
    }
}