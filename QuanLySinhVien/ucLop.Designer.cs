﻿namespace QuanLySinhVien
{
    partial class ucLop
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSoSV = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNganh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgvLop = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.lblLoi);
            this.panel1.Controls.Add(this.guna2ImageButton3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgvLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 682);
            this.panel1.TabIndex = 1;
            // 
            // lblLoi
            // 
            this.lblLoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.lblLoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblLoi.DefaultText = "Lỗi";
            this.lblLoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblLoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblLoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblLoi.DisabledState.Parent = this.lblLoi;
            this.lblLoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblLoi.FillColor = System.Drawing.Color.OrangeRed;
            this.lblLoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblLoi.FocusedState.Parent = this.lblLoi;
            this.lblLoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoi.ForeColor = System.Drawing.Color.White;
            this.lblLoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblLoi.HoverState.Parent = this.lblLoi;
            this.lblLoi.Location = new System.Drawing.Point(413, 11);
            this.lblLoi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.PasswordChar = '\0';
            this.lblLoi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.lblLoi.PlaceholderText = "";
            this.lblLoi.ReadOnly = true;
            this.lblLoi.SelectedText = "";
            this.lblLoi.ShadowDecoration.Parent = this.lblLoi;
            this.lblLoi.Size = new System.Drawing.Size(393, 38);
            this.lblLoi.TabIndex = 146;
            this.lblLoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblLoi.Visible = false;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::QuanLySinhVien.Properties.Resources.reset_48px;
            this.guna2ImageButton3.Location = new System.Drawing.Point(1138, 31);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(63, 28);
            this.guna2ImageButton3.TabIndex = 137;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(959, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 210);
            this.panel3.TabIndex = 134;
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
            this.btnSua.Location = new System.Drawing.Point(32, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(179, 43);
            this.btnSua.TabIndex = 110;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(32, 140);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(179, 43);
            this.btnXoa.TabIndex = 111;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextOffset = new System.Drawing.Point(20, 0);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThem.Location = new System.Drawing.Point(32, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(179, 43);
            this.btnThem.TabIndex = 107;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(20, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblSoSV);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbNganh);
            this.panel2.Controls.Add(this.cbGV);
            this.panel2.Controls.Add(this.dtpNgayLap);
            this.panel2.Controls.Add(this.txtMaLop);
            this.panel2.Controls.Add(this.txtTenLop);
            this.panel2.Location = new System.Drawing.Point(41, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 210);
            this.panel2.TabIndex = 116;
            // 
            // lblSoSV
            // 
            this.lblSoSV.AutoSize = true;
            this.lblSoSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoSV.Location = new System.Drawing.Point(29, 173);
            this.lblSoSV.Name = "lblSoSV";
            this.lblSoSV.Size = new System.Drawing.Size(143, 24);
            this.lblSoSV.TabIndex = 139;
            this.lblSoSV.Text = "Số sinh viên:  ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(876, 25);
            this.panel4.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin";
            // 
            // cbNganh
            // 
            this.cbNganh.BackColor = System.Drawing.Color.Transparent;
            this.cbNganh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbNganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNganh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.cbNganh.FocusedColor = System.Drawing.Color.Empty;
            this.cbNganh.FocusedState.Parent = this.cbNganh;
            this.cbNganh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNganh.ForeColor = System.Drawing.Color.White;
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.HoverState.Parent = this.cbNganh;
            this.cbNganh.ItemHeight = 35;
            this.cbNganh.ItemsAppearance.Parent = this.cbNganh;
            this.cbNganh.Location = new System.Drawing.Point(33, 44);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.ShadowDecoration.Parent = this.cbNganh;
            this.cbNganh.Size = new System.Drawing.Size(334, 41);
            this.cbNganh.TabIndex = 115;
            this.cbNganh.SelectedValueChanged += new System.EventHandler(this.cbKhoa_SelectedValueChanged);
            // 
            // cbGV
            // 
            this.cbGV.BackColor = System.Drawing.Color.Transparent;
            this.cbGV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbGV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.cbGV.FocusedColor = System.Drawing.Color.Empty;
            this.cbGV.FocusedState.Parent = this.cbGV;
            this.cbGV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGV.ForeColor = System.Drawing.Color.White;
            this.cbGV.FormattingEnabled = true;
            this.cbGV.HoverState.Parent = this.cbGV;
            this.cbGV.ItemHeight = 35;
            this.cbGV.ItemsAppearance.Parent = this.cbGV;
            this.cbGV.Location = new System.Drawing.Point(33, 107);
            this.cbGV.Name = "cbGV";
            this.cbGV.ShadowDecoration.Parent = this.cbGV;
            this.cbGV.Size = new System.Drawing.Size(334, 41);
            this.cbGV.TabIndex = 114;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayLap.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(703, 44);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(133, 27);
            this.dtpNgayLap.TabIndex = 112;
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtMaLop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMaLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLop.DefaultText = "";
            this.txtMaLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLop.DisabledState.Parent = this.txtMaLop;
            this.txtMaLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtMaLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLop.FocusedState.Parent = this.txtMaLop;
            this.txtMaLop.ForeColor = System.Drawing.Color.White;
            this.txtMaLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLop.HoverState.Parent = this.txtMaLop;
            this.txtMaLop.Location = new System.Drawing.Point(406, 43);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.PasswordChar = '\0';
            this.txtMaLop.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaLop.PlaceholderText = "Mã Lớp";
            this.txtMaLop.SelectedText = "";
            this.txtMaLop.ShadowDecoration.Parent = this.txtMaLop;
            this.txtMaLop.Size = new System.Drawing.Size(252, 52);
            this.txtMaLop.TabIndex = 108;
            // 
            // txtTenLop
            // 
            this.txtTenLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTenLop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLop.DefaultText = "";
            this.txtTenLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLop.DisabledState.Parent = this.txtTenLop;
            this.txtTenLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTenLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLop.FocusedState.Parent = this.txtTenLop;
            this.txtTenLop.ForeColor = System.Drawing.Color.White;
            this.txtTenLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLop.HoverState.Parent = this.txtTenLop;
            this.txtTenLop.Location = new System.Drawing.Point(406, 106);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PasswordChar = '\0';
            this.txtTenLop.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenLop.PlaceholderText = "Tên Lớp";
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.ShadowDecoration.Parent = this.txtTenLop;
            this.txtTenLop.Size = new System.Drawing.Size(430, 52);
            this.txtTenLop.TabIndex = 109;
            // 
            // dtgvLop
            // 
            this.dtgvLop.AllowUserToAddRows = false;
            this.dtgvLop.AllowUserToDeleteRows = false;
            this.dtgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvLop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvLop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.NgayLap,
            this.MaGV,
            this.MaNganh});
            this.dtgvLop.EnableHeadersVisualStyles = false;
            this.dtgvLop.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvLop.Location = new System.Drawing.Point(41, 288);
            this.dtgvLop.Name = "dtgvLop";
            this.dtgvLop.ReadOnly = true;
            this.dtgvLop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvLop.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLop.RowTemplate.Height = 40;
            this.dtgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLop.Size = new System.Drawing.Size(1160, 366);
            this.dtgvLop.TabIndex = 113;
            this.dtgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLop_CellClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "GVCN";
            this.MaGV.HeaderText = "GVCN";
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Ngành";
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.ReadOnly = true;
            // 
            // ucLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panel1);
            this.Name = "ucLop";
            this.Size = new System.Drawing.Size(1232, 682);
            this.Load += new System.EventHandler(this.ucLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvLop;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLop;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLop;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbGV;
        private Guna.UI2.WinForms.Guna2ComboBox cbNganh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private System.Windows.Forms.Label lblSoSV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox lblLoi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
    }
}
