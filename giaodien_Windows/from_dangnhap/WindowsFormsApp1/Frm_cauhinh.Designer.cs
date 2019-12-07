namespace WindowsFormsApp1
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
            this.lbl_sever = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.cbo_sever = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbo_database = new System.Windows.Forms.ComboBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_database = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sever
            // 
            this.lbl_sever.AutoSize = true;
            this.lbl_sever.Location = new System.Drawing.Point(11, 13);
            this.lbl_sever.Name = "lbl_sever";
            this.lbl_sever.Size = new System.Drawing.Size(64, 13);
            this.lbl_sever.TabIndex = 0;
            this.lbl_sever.Text = "Sever name";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(81, 52);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(198, 20);
            this.txt_user.TabIndex = 1;
            // 
            // cbo_sever
            // 
            this.cbo_sever.FormattingEnabled = true;
            this.cbo_sever.Location = new System.Drawing.Point(81, 10);
            this.cbo_sever.Name = "cbo_sever";
            this.cbo_sever.Size = new System.Drawing.Size(198, 21);
            this.cbo_sever.TabIndex = 2;
            this.cbo_sever.DropDown += new System.EventHandler(this.cbo_sever_DropDown);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(81, 176);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbo_database
            // 
            this.cbo_database.FormattingEnabled = true;
            this.cbo_database.Location = new System.Drawing.Point(81, 134);
            this.cbo_database.Name = "cbo_database";
            this.cbo_database.Size = new System.Drawing.Size(198, 21);
            this.cbo_database.TabIndex = 4;
            this.cbo_database.DropDown += new System.EventHandler(this.cbo_database_DropDown);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(81, 94);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(198, 20);
            this.txt_pass.TabIndex = 5;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(11, 55);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(58, 13);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "User name";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 97);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(30, 13);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "Pass";
            // 
            // lbl_database
            // 
            this.lbl_database.AutoSize = true;
            this.lbl_database.Location = new System.Drawing.Point(11, 137);
            this.lbl_database.Name = "lbl_database";
            this.lbl_database.Size = new System.Drawing.Size(53, 13);
            this.lbl_database.TabIndex = 8;
            this.lbl_database.Text = "Database";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(204, 176);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // Frm_cauhinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 211);
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

        private System.Windows.Forms.Label lbl_sever;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.ComboBox cbo_sever;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cbo_database;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_database;
        private System.Windows.Forms.Button btn_thoat;
    }
}