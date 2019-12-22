namespace ONTAP
{
    partial class Form1
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
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tblhp = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopHocPhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopHocPhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minSvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopHocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xuiCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtgv = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtsl = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtmaxlhp = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtminlhp = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtmalhp = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.xuiCustomToolstrip2 = new XanderUI.XUICustomToolstrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblhp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocPhanBindingSource)).BeginInit();
            this.xuiCustomToolstrip1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.xuiCustomToolstrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(87, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(9, 37);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(97, 23);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "Chọn môn học :";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.monHocBindingSource;
            this.metroComboBox1.DisplayMember = "TenMonHoc";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(112, 31);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(135, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Id";
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.MetroComboBox1_SelectedIndexChanged);
            this.metroComboBox1.SelectedValueChanged += new System.EventHandler(this.MetroComboBox1_SelectedValueChanged);
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataSource = typeof(ONTAP.Models.MonHoc);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tblhp);
            this.metroPanel1.Controls.Add(this.xuiCustomToolstrip1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(9, 66);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(338, 397);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tblhp
            // 
            this.tblhp.AutoGenerateColumns = false;
            this.tblhp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblhp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenLopHocPhanDataGridViewTextBoxColumn,
            this.maLopHocPhanDataGridViewTextBoxColumn,
            this.minSvDataGridViewTextBoxColumn,
            this.maxSvDataGridViewTextBoxColumn,
            this.soLuongSvDataGridViewTextBoxColumn,
            this.giaoVienDataGridViewTextBoxColumn});
            this.tblhp.DataSource = this.lopHocPhanBindingSource;
            this.tblhp.Location = new System.Drawing.Point(0, 29);
            this.tblhp.Name = "tblhp";
            this.tblhp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblhp.Size = new System.Drawing.Size(338, 365);
            this.tblhp.TabIndex = 3;
            this.tblhp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tblhp_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenLopHocPhanDataGridViewTextBoxColumn
            // 
            this.tenLopHocPhanDataGridViewTextBoxColumn.DataPropertyName = "TenLopHocPhan";
            this.tenLopHocPhanDataGridViewTextBoxColumn.HeaderText = "Tên Lớp Học Phần";
            this.tenLopHocPhanDataGridViewTextBoxColumn.Name = "tenLopHocPhanDataGridViewTextBoxColumn";
            this.tenLopHocPhanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLopHocPhanDataGridViewTextBoxColumn
            // 
            this.maLopHocPhanDataGridViewTextBoxColumn.DataPropertyName = "MaLopHocPhan";
            this.maLopHocPhanDataGridViewTextBoxColumn.HeaderText = "MaLopHocPhan";
            this.maLopHocPhanDataGridViewTextBoxColumn.Name = "maLopHocPhanDataGridViewTextBoxColumn";
            this.maLopHocPhanDataGridViewTextBoxColumn.Visible = false;
            // 
            // minSvDataGridViewTextBoxColumn
            // 
            this.minSvDataGridViewTextBoxColumn.DataPropertyName = "Min_Sv";
            this.minSvDataGridViewTextBoxColumn.HeaderText = "Min_Sv";
            this.minSvDataGridViewTextBoxColumn.Name = "minSvDataGridViewTextBoxColumn";
            this.minSvDataGridViewTextBoxColumn.Visible = false;
            // 
            // maxSvDataGridViewTextBoxColumn
            // 
            this.maxSvDataGridViewTextBoxColumn.DataPropertyName = "Max_Sv";
            this.maxSvDataGridViewTextBoxColumn.HeaderText = "Max_Sv";
            this.maxSvDataGridViewTextBoxColumn.Name = "maxSvDataGridViewTextBoxColumn";
            this.maxSvDataGridViewTextBoxColumn.Visible = false;
            // 
            // soLuongSvDataGridViewTextBoxColumn
            // 
            this.soLuongSvDataGridViewTextBoxColumn.DataPropertyName = "SoLuongSv";
            this.soLuongSvDataGridViewTextBoxColumn.HeaderText = "SoLuongSv";
            this.soLuongSvDataGridViewTextBoxColumn.Name = "soLuongSvDataGridViewTextBoxColumn";
            this.soLuongSvDataGridViewTextBoxColumn.Visible = false;
            // 
            // giaoVienDataGridViewTextBoxColumn
            // 
            this.giaoVienDataGridViewTextBoxColumn.DataPropertyName = "GiaoVien";
            this.giaoVienDataGridViewTextBoxColumn.HeaderText = "GiaoVien";
            this.giaoVienDataGridViewTextBoxColumn.Name = "giaoVienDataGridViewTextBoxColumn";
            this.giaoVienDataGridViewTextBoxColumn.Visible = false;
            // 
            // lopHocPhanBindingSource
            // 
            this.lopHocPhanBindingSource.DataSource = typeof(ONTAP.Models.LopHocPhan);
            // 
            // xuiCustomToolstrip1
            // 
            this.xuiCustomToolstrip1.BackColor = System.Drawing.Color.White;
            this.xuiCustomToolstrip1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomToolstrip1.ForeColor = System.Drawing.Color.Black;
            this.xuiCustomToolstrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.xuiCustomToolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.xuiCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomToolstrip1.Name = "xuiCustomToolstrip1";
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(338, 25);
            this.xuiCustomToolstrip1.TabIndex = 2;
            this.xuiCustomToolstrip1.Text = "xuiCustomToolstrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::ONTAP.Properties.Resources.add_database_64px;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel1.Text = "Lớp học phần";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::ONTAP.Properties.Resources.edit_file_64px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Sửa";
            this.toolStripButton1.ToolTipText = "Sửa";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::ONTAP.Properties.Resources.cancel_48px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton2.Text = "Xoá";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = global::ONTAP.Properties.Resources.add_48px;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton3.Text = "Thêm";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.txtgv);
            this.metroPanel2.Controls.Add(this.txtsl);
            this.metroPanel2.Controls.Add(this.txtmaxlhp);
            this.metroPanel2.Controls.Add(this.txtminlhp);
            this.metroPanel2.Controls.Add(this.txtmalhp);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(353, 66);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(576, 96);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtgv
            // 
            this.txtgv.AutoScroll = true;
            this.txtgv.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.txtgv.AutoSize = false;
            this.txtgv.BackColor = System.Drawing.SystemColors.Window;
            this.txtgv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocPhanBindingSource, "GiaoVien", true));
            this.txtgv.Location = new System.Drawing.Point(450, 67);
            this.txtgv.Name = "txtgv";
            this.txtgv.Size = new System.Drawing.Size(75, 23);
            this.txtgv.TabIndex = 10;
            // 
            // txtsl
            // 
            this.txtsl.AutoScroll = true;
            this.txtsl.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.txtsl.AutoSize = false;
            this.txtsl.BackColor = System.Drawing.SystemColors.Window;
            this.txtsl.Location = new System.Drawing.Point(196, 67);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(119, 23);
            this.txtsl.TabIndex = 9;
            // 
            // txtmaxlhp
            // 
            this.txtmaxlhp.AutoScroll = true;
            this.txtmaxlhp.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.txtmaxlhp.AutoSize = false;
            this.txtmaxlhp.BackColor = System.Drawing.SystemColors.Window;
            this.txtmaxlhp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocPhanBindingSource, "Max_Sv", true));
            this.txtmaxlhp.Location = new System.Drawing.Point(282, 38);
            this.txtmaxlhp.Name = "txtmaxlhp";
            this.txtmaxlhp.Size = new System.Drawing.Size(54, 23);
            this.txtmaxlhp.TabIndex = 8;
            // 
            // txtminlhp
            // 
            this.txtminlhp.AutoScroll = true;
            this.txtminlhp.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.txtminlhp.AutoSize = false;
            this.txtminlhp.BackColor = System.Drawing.SystemColors.Window;
            this.txtminlhp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocPhanBindingSource, "Min_Sv", true));
            this.txtminlhp.Location = new System.Drawing.Point(202, 38);
            this.txtminlhp.Name = "txtminlhp";
            this.txtminlhp.Size = new System.Drawing.Size(54, 23);
            this.txtminlhp.TabIndex = 7;
            // 
            // txtmalhp
            // 
            this.txtmalhp.AutoScroll = true;
            this.txtmalhp.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.txtmalhp.AutoSize = false;
            this.txtmalhp.BackColor = System.Drawing.SystemColors.Window;
            this.txtmalhp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocPhanBindingSource, "MaLopHocPhan", true));
            this.txtmalhp.Location = new System.Drawing.Point(136, 9);
            this.txtmalhp.Name = "txtmalhp";
            this.txtmalhp.Size = new System.Drawing.Size(434, 23);
            this.txtmalhp.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(322, 67);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Giáo viên phụ trách";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 67);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(172, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Số lượng sinh viên đăng ký :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(178, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Định mức sinh viên(min/max)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Mã lớp học phần:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.xuiCustomToolstrip2);
            this.metroPanel3.Controls.Add(this.dataGridView1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(353, 169);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(576, 294);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // xuiCustomToolstrip2
            // 
            this.xuiCustomToolstrip2.BackColor = System.Drawing.Color.White;
            this.xuiCustomToolstrip2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomToolstrip2.ForeColor = System.Drawing.Color.Black;
            this.xuiCustomToolstrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.xuiCustomToolstrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.xuiCustomToolstrip2.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomToolstrip2.Name = "xuiCustomToolstrip2";
            this.xuiCustomToolstrip2.Size = new System.Drawing.Size(576, 25);
            this.xuiCustomToolstrip2.TabIndex = 3;
            this.xuiCustomToolstrip2.Text = "xuiCustomToolstrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel2.Text = "Danh sách sinh viên";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Image = global::ONTAP.Properties.Resources.edit_file_64px;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton4.Text = "Sửa";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.Image = global::ONTAP.Properties.Resources.cancel_48px;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton5.Text = "Xoá";
            this.toolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.Image = global::ONTAP.Properties.Resources.add_database_64px1;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton6.Text = "Đăng ký vào lớp";
            this.toolStripButton6.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton7.Image = global::ONTAP.Properties.Resources.refresh_32px;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(101, 22);
            this.toolStripButton7.Text = "Hiện thị tất cả";
            this.toolStripButton7.Click += new System.EventHandler(this.ToolStripButton7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.maSvDataGridViewTextBoxColumn,
            this.hoDemDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sinhVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 263);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // maSvDataGridViewTextBoxColumn
            // 
            this.maSvDataGridViewTextBoxColumn.DataPropertyName = "MaSv";
            this.maSvDataGridViewTextBoxColumn.HeaderText = "MaSv";
            this.maSvDataGridViewTextBoxColumn.Name = "maSvDataGridViewTextBoxColumn";
            this.maSvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoDemDataGridViewTextBoxColumn
            // 
            this.hoDemDataGridViewTextBoxColumn.DataPropertyName = "HoDem";
            this.hoDemDataGridViewTextBoxColumn.HeaderText = "HoDem";
            this.hoDemDataGridViewTextBoxColumn.Name = "hoDemDataGridViewTextBoxColumn";
            this.hoDemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            this.queQuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(ONTAP.Models.SinhVien);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 473);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblhp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocPhanBindingSource)).EndInit();
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.xuiCustomToolstrip2.ResumeLayout(false);
            this.xuiCustomToolstrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private MetroFramework.Drawing.Html.HtmlLabel txtgv;
        private MetroFramework.Drawing.Html.HtmlLabel txtsl;
        private MetroFramework.Drawing.Html.HtmlLabel txtmaxlhp;
        private MetroFramework.Drawing.Html.HtmlLabel txtminlhp;
        private MetroFramework.Drawing.Html.HtmlLabel txtmalhp;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private System.Windows.Forms.BindingSource lopHocPhanBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private XanderUI.XUICustomToolstrip xuiCustomToolstrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridView tblhp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHocPhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHocPhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minSvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaoVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
    }
}

