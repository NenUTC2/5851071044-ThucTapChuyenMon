namespace QuanLySinhVien
{
    partial class ucGV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvGV = new System.Windows.Forms.DataGridView();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgayDay = new System.Windows.Forms.DateTimePicker();
            this.txtTenGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.pn1 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnLuuQR = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGV)).BeginInit();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.pn2);
            this.panel1.Controls.Add(this.pn1);
            this.panel1.Controls.Add(this.dtgvGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 682);
            this.panel1.TabIndex = 2;
            // 
            // dtgvGV
            // 
            this.dtgvGV.AllowUserToAddRows = false;
            this.dtgvGV.AllowUserToDeleteRows = false;
            this.dtgvGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAGV,
            this.TenGV,
            this.SDT,
            this.Khoa,
            this.DiaChi,
            this.NgayDay});
            this.dtgvGV.EnableHeadersVisualStyles = false;
            this.dtgvGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvGV.Location = new System.Drawing.Point(41, 298);
            this.dtgvGV.Name = "dtgvGV";
            this.dtgvGV.ReadOnly = true;
            this.dtgvGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvGV.RowTemplate.Height = 24;
            this.dtgvGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGV.Size = new System.Drawing.Size(1150, 348);
            this.dtgvGV.TabIndex = 125;
            this.dtgvGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGV_CellClick);
            // 
            // MAGV
            // 
            this.MAGV.DataPropertyName = "MaGV";
            this.MAGV.HeaderText = "Mã Giảng viên";
            this.MAGV.Name = "MAGV";
            this.MAGV.ReadOnly = true;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giảng viên";
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "MaKhoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgayDay
            // 
            this.NgayDay.DataPropertyName = "NgayDay";
            this.NgayDay.HeaderText = "Ngày dạy";
            this.NgayDay.Name = "NgayDay";
            this.NgayDay.ReadOnly = true;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.ForeColor = System.Drawing.Color.White;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(40, 78);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSDT.PlaceholderText = "Số điện thoại";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(337, 52);
            this.txtSDT.TabIndex = 135;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.ForeColor = System.Drawing.Color.White;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(40, 143);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiaChi.PlaceholderText = "Địa chỉ";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(337, 52);
            this.txtDiaChi.TabIndex = 136;
            // 
            // cbKhoa
            // 
            this.cbKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cbKhoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.cbKhoa.FocusedColor = System.Drawing.Color.Empty;
            this.cbKhoa.FocusedState.Parent = this.cbKhoa;
            this.cbKhoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.ForeColor = System.Drawing.Color.White;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.HoverState.Parent = this.cbKhoa;
            this.cbKhoa.ItemHeight = 30;
            this.cbKhoa.ItemsAppearance.Parent = this.cbKhoa;
            this.cbKhoa.Location = new System.Drawing.Point(439, 13);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.ShadowDecoration.Parent = this.cbKhoa;
            this.cbKhoa.Size = new System.Drawing.Size(360, 36);
            this.cbKhoa.TabIndex = 134;
            // 
            // dtpNgayDay
            // 
            this.dtpNgayDay.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayDay.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            this.dtpNgayDay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDay.Location = new System.Drawing.Point(439, 55);
            this.dtpNgayDay.Name = "dtpNgayDay";
            this.dtpNgayDay.Size = new System.Drawing.Size(360, 30);
            this.dtpNgayDay.TabIndex = 133;
            // 
            // txtTenGV
            // 
            this.txtTenGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTenGV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenGV.DefaultText = "";
            this.txtTenGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenGV.DisabledState.Parent = this.txtTenGV;
            this.txtTenGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTenGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenGV.FocusedState.Parent = this.txtTenGV;
            this.txtTenGV.ForeColor = System.Drawing.Color.White;
            this.txtTenGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenGV.HoverState.Parent = this.txtTenGV;
            this.txtTenGV.Location = new System.Drawing.Point(40, 13);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.PasswordChar = '\0';
            this.txtTenGV.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenGV.PlaceholderText = "Tên Giảng viên";
            this.txtTenGV.SelectedText = "";
            this.txtTenGV.ShadowDecoration.Parent = this.txtTenGV;
            this.txtTenGV.Size = new System.Drawing.Size(337, 52);
            this.txtTenGV.TabIndex = 132;
            // 
            // btnSua
            // 
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = global::QuanLySinhVien.Properties.Resources.edit_48px;
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSua.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSua.Location = new System.Drawing.Point(50, 80);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(191, 55);
            this.btnSua.TabIndex = 131;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.add_48px;
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnThem.ImageSize = new System.Drawing.Size(35, 35);
            this.btnThem.Location = new System.Drawing.Point(50, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(191, 55);
            this.btnThem.TabIndex = 130;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(20, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::QuanLySinhVien.Properties.Resources.delete_48px;
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnXoa.ImageSize = new System.Drawing.Size(35, 35);
            this.btnXoa.Location = new System.Drawing.Point(50, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(191, 55);
            this.btnXoa.TabIndex = 132;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextOffset = new System.Drawing.Point(20, 0);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.White;
            this.pn1.Controls.Add(this.btnLuuQR);
            this.pn1.Controls.Add(this.picQR);
            this.pn1.Controls.Add(this.txtSDT);
            this.pn1.Controls.Add(this.dtpNgayDay);
            this.pn1.Controls.Add(this.txtDiaChi);
            this.pn1.Controls.Add(this.cbKhoa);
            this.pn1.Controls.Add(this.txtTenGV);
            this.pn1.Location = new System.Drawing.Point(41, 71);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(836, 211);
            this.pn1.TabIndex = 135;
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.White;
            this.pn2.Controls.Add(this.btnSua);
            this.pn2.Controls.Add(this.btnThem);
            this.pn2.Controls.Add(this.btnXoa);
            this.pn2.Location = new System.Drawing.Point(894, 71);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(297, 211);
            this.pn2.TabIndex = 136;
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(439, 91);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(123, 108);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 137;
            this.picQR.TabStop = false;
            // 
            // btnLuuQR
            // 
            this.btnLuuQR.CheckedState.Parent = this.btnLuuQR;
            this.btnLuuQR.CustomImages.Parent = this.btnLuuQR;
            this.btnLuuQR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnLuuQR.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuQR.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnLuuQR.HoverState.Parent = this.btnLuuQR;
            this.btnLuuQR.Image = global::QuanLySinhVien.Properties.Resources.add_48px;
            this.btnLuuQR.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLuuQR.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLuuQR.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLuuQR.Location = new System.Drawing.Point(595, 121);
            this.btnLuuQR.Name = "btnLuuQR";
            this.btnLuuQR.ShadowDecoration.Parent = this.btnLuuQR;
            this.btnLuuQR.Size = new System.Drawing.Size(191, 55);
            this.btnLuuQR.TabIndex = 133;
            this.btnLuuQR.Text = "Thêm";
            this.btnLuuQR.TextOffset = new System.Drawing.Point(20, 0);
            this.btnLuuQR.Click += new System.EventHandler(this.btnLuuQR_Click);
            // 
            // ucGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panel1);
            this.Name = "ucGV";
            this.Size = new System.Drawing.Size(1232, 682);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGV)).EndInit();
            this.pn1.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDay;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2ComboBox cbKhoa;
        private System.Windows.Forms.DateTimePicker dtpNgayDay;
        private Guna.UI2.WinForms.Guna2TextBox txtTenGV;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Panel pn1;
        private Guna.UI2.WinForms.Guna2Button btnLuuQR;
        private System.Windows.Forms.PictureBox picQR;
    }
}
