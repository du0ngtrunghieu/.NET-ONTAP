namespace ONTAP.Views
{
    partial class FrmAddLHP
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
            this.components = new System.ComponentModel.Container();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtmhp = new MetroFramework.Controls.MetroTextBox();
            this.lopHocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txttenhp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtmin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtmax = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtgv = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.monHocBindingSource;
            this.metroComboBox1.DisplayMember = "TenMonHoc";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(591, 102);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(186, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Id";
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataSource = typeof(ONTAP.Models.MonHoc);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(468, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Tên Môn Học";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mã Lớp Học Phần";
            // 
            // txtmhp
            // 
            // 
            // 
            // 
            this.txtmhp.CustomButton.Image = null;
            this.txtmhp.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtmhp.CustomButton.Name = "";
            this.txtmhp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmhp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmhp.CustomButton.TabIndex = 1;
            this.txtmhp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmhp.CustomButton.UseSelectable = true;
            this.txtmhp.CustomButton.Visible = false;
            this.txtmhp.Lines = new string[0];
            this.txtmhp.Location = new System.Drawing.Point(154, 112);
            this.txtmhp.MaxLength = 32767;
            this.txtmhp.Name = "txtmhp";
            this.txtmhp.PasswordChar = '\0';
            this.txtmhp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmhp.SelectedText = "";
            this.txtmhp.SelectionLength = 0;
            this.txtmhp.SelectionStart = 0;
            this.txtmhp.ShortcutsEnabled = true;
            this.txtmhp.Size = new System.Drawing.Size(212, 23);
            this.txtmhp.TabIndex = 3;
            this.txtmhp.UseSelectable = true;
            this.txtmhp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmhp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lopHocPhanBindingSource
            // 
            this.lopHocPhanBindingSource.DataSource = typeof(ONTAP.Models.LopHocPhan);
            // 
            // txttenhp
            // 
            // 
            // 
            // 
            this.txttenhp.CustomButton.Image = null;
            this.txttenhp.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txttenhp.CustomButton.Name = "";
            this.txttenhp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttenhp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttenhp.CustomButton.TabIndex = 1;
            this.txttenhp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttenhp.CustomButton.UseSelectable = true;
            this.txttenhp.CustomButton.Visible = false;
            this.txttenhp.Lines = new string[0];
            this.txttenhp.Location = new System.Drawing.Point(154, 175);
            this.txttenhp.MaxLength = 32767;
            this.txttenhp.Name = "txttenhp";
            this.txttenhp.PasswordChar = '\0';
            this.txttenhp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttenhp.SelectedText = "";
            this.txttenhp.SelectionLength = 0;
            this.txttenhp.SelectionStart = 0;
            this.txttenhp.ShortcutsEnabled = true;
            this.txttenhp.Size = new System.Drawing.Size(212, 23);
            this.txttenhp.TabIndex = 5;
            this.txttenhp.UseSelectable = true;
            this.txttenhp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttenhp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Tên Lớp Học Phần";
            // 
            // txtmin
            // 
            // 
            // 
            // 
            this.txtmin.CustomButton.Image = null;
            this.txtmin.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtmin.CustomButton.Name = "";
            this.txtmin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmin.CustomButton.TabIndex = 1;
            this.txtmin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmin.CustomButton.UseSelectable = true;
            this.txtmin.CustomButton.Visible = false;
            this.txtmin.Lines = new string[0];
            this.txtmin.Location = new System.Drawing.Point(154, 239);
            this.txtmin.MaxLength = 32767;
            this.txtmin.Name = "txtmin";
            this.txtmin.PasswordChar = '\0';
            this.txtmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmin.SelectedText = "";
            this.txtmin.SelectionLength = 0;
            this.txtmin.SelectionStart = 0;
            this.txtmin.ShortcutsEnabled = true;
            this.txtmin.Size = new System.Drawing.Size(212, 23);
            this.txtmin.TabIndex = 7;
            this.txtmin.UseSelectable = true;
            this.txtmin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 239);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Sinh viên tối thiểu";
            // 
            // txtmax
            // 
            // 
            // 
            // 
            this.txtmax.CustomButton.Image = null;
            this.txtmax.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtmax.CustomButton.Name = "";
            this.txtmax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmax.CustomButton.TabIndex = 1;
            this.txtmax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmax.CustomButton.UseSelectable = true;
            this.txtmax.CustomButton.Visible = false;
            this.txtmax.Lines = new string[0];
            this.txtmax.Location = new System.Drawing.Point(154, 302);
            this.txtmax.MaxLength = 32767;
            this.txtmax.Name = "txtmax";
            this.txtmax.PasswordChar = '\0';
            this.txtmax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmax.SelectedText = "";
            this.txtmax.SelectionLength = 0;
            this.txtmax.SelectionStart = 0;
            this.txtmax.ShortcutsEnabled = true;
            this.txtmax.Size = new System.Drawing.Size(212, 23);
            this.txtmax.TabIndex = 9;
            this.txtmax.UseSelectable = true;
            this.txtmax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 306);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Tối đa sinh viên";
            // 
            // txtgv
            // 
            // 
            // 
            // 
            this.txtgv.CustomButton.Image = null;
            this.txtgv.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtgv.CustomButton.Name = "";
            this.txtgv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtgv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtgv.CustomButton.TabIndex = 1;
            this.txtgv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtgv.CustomButton.UseSelectable = true;
            this.txtgv.CustomButton.Visible = false;
            this.txtgv.Lines = new string[0];
            this.txtgv.Location = new System.Drawing.Point(154, 360);
            this.txtgv.MaxLength = 32767;
            this.txtgv.Name = "txtgv";
            this.txtgv.PasswordChar = '\0';
            this.txtgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtgv.SelectedText = "";
            this.txtgv.SelectionLength = 0;
            this.txtgv.SelectionStart = 0;
            this.txtgv.ShortcutsEnabled = true;
            this.txtgv.Size = new System.Drawing.Size(212, 23);
            this.txtgv.TabIndex = 11;
            this.txtgv.UseSelectable = true;
            this.txtgv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtgv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 364);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Giáo viên";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(625, 375);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(152, 51);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Thêm";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.lopHocPhanBindingSource;
            // 
            // FrmAddLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtgv);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txttenhp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtmhp);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "FrmAddLHP";
            this.Text = "Thêm Lớp Học Phần";
            this.Load += new System.EventHandler(this.FrmAddLHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtmhp;
        private MetroFramework.Controls.MetroTextBox txttenhp;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtmin;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtmax;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtgv;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.BindingSource lopHocPhanBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource monHocBindingSource;
    }
}