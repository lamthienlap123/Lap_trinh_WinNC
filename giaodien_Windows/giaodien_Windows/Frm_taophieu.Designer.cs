namespace giaodien_Windows
{
    partial class Frm_taophieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_taophieu));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dt_ngaytra = new DevExpress.XtraEditors.DateEdit();
            this.dt_ngaynhan = new DevExpress.XtraEditors.DateEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suaphieu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_taophieu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaphieu = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_madonhang = new System.Windows.Forms.TextBox();
            this.dv_donhang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_kho = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.cbo_nhanvien = new System.Windows.Forms.ComboBox();
            this.cbo_khachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_DV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label13 = new System.Windows.Forms.Label();
            this.num_sl = new System.Windows.Forms.NumericUpDown();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.btn_themcthd = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suactdh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoacthd = new DevExpress.XtraEditors.SimpleButton();
            this.dv_ctdg = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_donhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_ctdg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dt_ngaytra);
            this.groupControl1.Controls.Add(this.dt_ngaynhan);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.txt_madonhang);
            this.groupControl1.Controls.Add(this.dv_donhang);
            this.groupControl1.Controls.Add(this.cbo_kho);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txt_tongtien);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txt_ghichu);
            this.groupControl1.Controls.Add(this.cbo_nhanvien);
            this.groupControl1.Controls.Add(this.cbo_khachhang);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(698, 653);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Đơn hàng";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // dt_ngaytra
            // 
            this.dt_ngaytra.EditValue = new System.DateTime(2019, 12, 9, 0, 50, 17, 0);
            this.dt_ngaytra.Location = new System.Drawing.Point(446, 125);
            this.dt_ngaytra.Name = "dt_ngaytra";
            this.dt_ngaytra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaytra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaytra.Size = new System.Drawing.Size(186, 20);
            this.dt_ngaytra.TabIndex = 22;
            // 
            // dt_ngaynhan
            // 
            this.dt_ngaynhan.EditValue = new System.DateTime(2019, 12, 9, 0, 50, 4, 0);
            this.dt_ngaynhan.Location = new System.Drawing.Point(82, 124);
            this.dt_ngaynhan.Name = "dt_ngaynhan";
            this.dt_ngaynhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaynhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaynhan.Size = new System.Drawing.Size(259, 20);
            this.dt_ngaynhan.TabIndex = 22;
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.btn_in);
            this.groupControl3.Controls.Add(this.btn_suaphieu);
            this.groupControl3.Controls.Add(this.btn_taophieu);
            this.groupControl3.Controls.Add(this.btn_xoaphieu);
            this.groupControl3.Location = new System.Drawing.Point(116, 246);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(476, 126);
            this.groupControl3.TabIndex = 21;
            this.groupControl3.Text = "Xử lý";
            // 
            // btn_in
            // 
            this.btn_in.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.ImageOptions.Image")));
            this.btn_in.Location = new System.Drawing.Point(361, 59);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(90, 40);
            this.btn_in.TabIndex = 23;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_suaphieu
            // 
            this.btn_suaphieu.Enabled = false;
            this.btn_suaphieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suaphieu.ImageOptions.Image")));
            this.btn_suaphieu.Location = new System.Drawing.Point(248, 59);
            this.btn_suaphieu.Name = "btn_suaphieu";
            this.btn_suaphieu.Size = new System.Drawing.Size(90, 40);
            this.btn_suaphieu.TabIndex = 8;
            this.btn_suaphieu.Text = "Sửa phiếu";
            this.btn_suaphieu.Click += new System.EventHandler(this.btn_suaphieu_Click);
            // 
            // btn_taophieu
            // 
            this.btn_taophieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_taophieu.ImageOptions.Image")));
            this.btn_taophieu.Location = new System.Drawing.Point(33, 59);
            this.btn_taophieu.Name = "btn_taophieu";
            this.btn_taophieu.Size = new System.Drawing.Size(90, 40);
            this.btn_taophieu.TabIndex = 8;
            this.btn_taophieu.Text = "Tạo phiếu";
            this.btn_taophieu.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btn_xoaphieu
            // 
            this.btn_xoaphieu.Enabled = false;
            this.btn_xoaphieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaphieu.ImageOptions.Image")));
            this.btn_xoaphieu.Location = new System.Drawing.Point(140, 59);
            this.btn_xoaphieu.Name = "btn_xoaphieu";
            this.btn_xoaphieu.Size = new System.Drawing.Size(90, 40);
            this.btn_xoaphieu.TabIndex = 8;
            this.btn_xoaphieu.Text = "Xóa phiếu";
            this.btn_xoaphieu.Click += new System.EventHandler(this.btn_xoaphieu_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(723, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_madonhang
            // 
            this.txt_madonhang.Enabled = false;
            this.txt_madonhang.Location = new System.Drawing.Point(82, 32);
            this.txt_madonhang.Name = "txt_madonhang";
            this.txt_madonhang.Size = new System.Drawing.Size(259, 21);
            this.txt_madonhang.TabIndex = 19;
            // 
            // dv_donhang
            // 
            this.dv_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_donhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dv_donhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dv_donhang.Location = new System.Drawing.Point(2, 423);
            this.dv_donhang.Name = "dv_donhang";
            this.dv_donhang.Size = new System.Drawing.Size(694, 228);
            this.dv_donhang.TabIndex = 18;
            this.dv_donhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_cellclick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KHACHHANG";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "KHO";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NHANVIEN";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TinhTrang";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // cbo_kho
            // 
            this.cbo_kho.AccessibleDescription = "";
            this.cbo_kho.FormattingEnabled = true;
            this.cbo_kho.Location = new System.Drawing.Point(446, 84);
            this.cbo_kho.Name = "cbo_kho";
            this.cbo_kho.Size = new System.Drawing.Size(186, 21);
            this.cbo_kho.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Kho lưu đồ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tổng Tiền";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(446, 180);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(186, 21);
            this.txt_tongtien.TabIndex = 12;
            this.txt_tongtien.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày Trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Nhận";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(82, 166);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(259, 35);
            this.txt_ghichu.TabIndex = 5;
            // 
            // cbo_nhanvien
            // 
            this.cbo_nhanvien.FormattingEnabled = true;
            this.cbo_nhanvien.Location = new System.Drawing.Point(82, 83);
            this.cbo_nhanvien.Name = "cbo_nhanvien";
            this.cbo_nhanvien.Size = new System.Drawing.Size(259, 21);
            this.cbo_nhanvien.TabIndex = 3;
            // 
            // cbo_khachhang
            // 
            this.cbo_khachhang.FormattingEnabled = true;
            this.cbo_khachhang.Location = new System.Drawing.Point(446, 33);
            this.cbo_khachhang.Name = "cbo_khachhang";
            this.cbo_khachhang.Size = new System.Drawing.Size(186, 21);
            this.cbo_khachhang.TabIndex = 2;
            this.cbo_khachhang.DropDown += new System.EventHandler(this.cbo_khachhang_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // cbo_DV
            // 
            this.cbo_DV.FormattingEnabled = true;
            this.cbo_DV.Location = new System.Drawing.Point(132, 32);
            this.cbo_DV.Name = "cbo_DV";
            this.cbo_DV.Size = new System.Drawing.Size(200, 21);
            this.cbo_DV.TabIndex = 6;
            this.cbo_DV.SelectedValueChanged += new System.EventHandler(this.cbo_DV_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Controls.Add(this.num_sl);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Controls.Add(this.dv_ctdg);
            this.groupControl2.Controls.Add(this.cbo_DV);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.txt_giaban);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(698, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(458, 653);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi tiết đơn hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "KG";
            // 
            // num_sl
            // 
            this.num_sl.Location = new System.Drawing.Point(132, 84);
            this.num_sl.Name = "num_sl";
            this.num_sl.Size = new System.Drawing.Size(43, 21);
            this.num_sl.TabIndex = 11;
            this.num_sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_sl.ValueChanged += new System.EventHandler(this.num_sl_ValueChanged);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.btn_themcthd);
            this.groupControl5.Controls.Add(this.btn_suactdh);
            this.groupControl5.Controls.Add(this.btn_xoacthd);
            this.groupControl5.Location = new System.Drawing.Point(37, 273);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(270, 126);
            this.groupControl5.TabIndex = 10;
            this.groupControl5.Text = "Xử lý";
            // 
            // btn_themcthd
            // 
            this.btn_themcthd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themcthd.ImageOptions.Image")));
            this.btn_themcthd.Location = new System.Drawing.Point(27, 54);
            this.btn_themcthd.Name = "btn_themcthd";
            this.btn_themcthd.Size = new System.Drawing.Size(60, 45);
            this.btn_themcthd.TabIndex = 8;
            this.btn_themcthd.Text = "Thêm";
            this.btn_themcthd.Click += new System.EventHandler(this.btn_themcthd_Click);
            // 
            // btn_suactdh
            // 
            this.btn_suactdh.Enabled = false;
            this.btn_suactdh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suactdh.ImageOptions.Image")));
            this.btn_suactdh.Location = new System.Drawing.Point(184, 54);
            this.btn_suactdh.Name = "btn_suactdh";
            this.btn_suactdh.Size = new System.Drawing.Size(60, 45);
            this.btn_suactdh.TabIndex = 8;
            this.btn_suactdh.Text = "Sửa";
            this.btn_suactdh.Click += new System.EventHandler(this.btn_suacthd_Click);
            // 
            // btn_xoacthd
            // 
            this.btn_xoacthd.Enabled = false;
            this.btn_xoacthd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoacthd.ImageOptions.Image")));
            this.btn_xoacthd.Location = new System.Drawing.Point(104, 54);
            this.btn_xoacthd.Name = "btn_xoacthd";
            this.btn_xoacthd.Size = new System.Drawing.Size(60, 45);
            this.btn_xoacthd.TabIndex = 8;
            this.btn_xoacthd.Text = "Xóa";
            this.btn_xoacthd.Click += new System.EventHandler(this.btn_xoacthd_Click);
            // 
            // dv_ctdg
            // 
            this.dv_ctdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_ctdg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dv_ctdg.Location = new System.Drawing.Point(2, 423);
            this.dv_ctdg.Name = "dv_ctdg";
            this.dv_ctdg.Size = new System.Drawing.Size(454, 228);
            this.dv_ctdg.TabIndex = 7;
            this.dv_ctdg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_cell_click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại dịch vụ";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Enabled = false;
            this.txt_giaban.Location = new System.Drawing.Point(132, 146);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(200, 21);
            this.txt_giaban.TabIndex = 5;
            this.txt_giaban.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Giá bán";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // Frm_taophieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 653);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_taophieu";
            this.Text = "Tạo phiếu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_taophieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_donhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_ctdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_DV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_nhanvien;
        private System.Windows.Forms.ComboBox cbo_khachhang;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.ComboBox cbo_kho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tongtien;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private System.Windows.Forms.TextBox txt_madonhang;
        private System.Windows.Forms.DataGridView dv_donhang;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_xoacthd;
        private DevExpress.XtraEditors.SimpleButton btn_themcthd;
        private System.Windows.Forms.DataGridView dv_ctdg;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_suaphieu;
        private DevExpress.XtraEditors.SimpleButton btn_taophieu;
        private DevExpress.XtraEditors.SimpleButton btn_xoaphieu;
        private DevExpress.XtraEditors.DateEdit dt_ngaytra;
        private DevExpress.XtraEditors.DateEdit dt_ngaynhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_sl;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraEditors.SimpleButton btn_suactdh;
        private System.Windows.Forms.Label label13;
    }
}