namespace giaodien_Windows
{
    partial class Frm_cauhinh
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_database = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.cbo_database = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbo_sever = new System.Windows.Forms.ComboBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_sever = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(201, 203);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 19;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // lbl_database
            // 
            this.lbl_database.AutoSize = true;
            this.lbl_database.Location = new System.Drawing.Point(8, 164);
            this.lbl_database.Name = "lbl_database";
            this.lbl_database.Size = new System.Drawing.Size(53, 13);
            this.lbl_database.TabIndex = 18;
            this.lbl_database.Text = "Database";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(9, 124);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(29, 13);
            this.lbl_pass.TabIndex = 17;
            this.lbl_pass.Text = "Pass";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(8, 82);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(58, 13);
            this.lbl_user.TabIndex = 16;
            this.lbl_user.Text = "User name";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(78, 121);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(198, 21);
            this.txt_pass.TabIndex = 15;
            // 
            // cbo_database
            // 
            this.cbo_database.FormattingEnabled = true;
            this.cbo_database.Location = new System.Drawing.Point(78, 161);
            this.cbo_database.Name = "cbo_database";
            this.cbo_database.Size = new System.Drawing.Size(198, 21);
            this.cbo_database.TabIndex = 14;
            this.cbo_database.Click += new System.EventHandler(this.cbo_database_DropDown);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(78, 203);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbo_sever
            // 
            this.cbo_sever.FormattingEnabled = true;
            this.cbo_sever.Location = new System.Drawing.Point(78, 37);
            this.cbo_sever.Name = "cbo_sever";
            this.cbo_sever.Size = new System.Drawing.Size(198, 21);
            this.cbo_sever.TabIndex = 12;
            this.cbo_sever.Click += new System.EventHandler(this.cbo_sever_DropDown);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(78, 79);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(198, 21);
            this.txt_user.TabIndex = 11;
            // 
            // lbl_sever
            // 
            this.lbl_sever.AutoSize = true;
            this.lbl_sever.Location = new System.Drawing.Point(8, 40);
            this.lbl_sever.Name = "lbl_sever";
            this.lbl_sever.Size = new System.Drawing.Size(64, 13);
            this.lbl_sever.TabIndex = 10;
            this.lbl_sever.Text = "Sever name";
            // 
            // Frm_cauhinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.lbl_database);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.cbo_database);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbo_sever);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_sever);
            this.Name = "Frm_cauhinh";
            this.Text = "Frm_cauhinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_database;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.ComboBox cbo_database;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cbo_sever;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_sever;
    }
}