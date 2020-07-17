namespace QuanLySinhVien
{
    partial class ucSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDangKyMon = new Guna.UI2.WinForms.Guna2Button();
            this.cbMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThoatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNhapExel = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.cbNganh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSheet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtgvSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvExcel = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoi);
            this.panel1.Controls.Add(this.guna2ImageButton3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnThoatExcel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbSheet);
            this.panel1.Controls.Add(this.dtgvSV);
            this.panel1.Controls.Add(this.dtgvExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 682);
            this.panel1.TabIndex = 0;
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
            this.lblLoi.Location = new System.Drawing.Point(421, 6);
            this.lblLoi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.PasswordChar = '\0';
            this.lblLoi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.lblLoi.PlaceholderText = "";
            this.lblLoi.ReadOnly = true;
            this.lblLoi.SelectedText = "";
            this.lblLoi.ShadowDecoration.Parent = this.lblLoi;
            this.lblLoi.Size = new System.Drawing.Size(393, 38);
            this.lblLoi.TabIndex = 147;
            this.lblLoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblLoi.Visible = false;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::QuanLySinhVien.Properties.Resources.reset_48px;
            this.guna2ImageButton3.Location = new System.Drawing.Point(36, 21);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(63, 28);
            this.guna2ImageButton3.TabIndex = 158;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cbLopHoc);
            this.panel3.Controls.Add(this.btnDangKyMon);
            this.panel3.Controls.Add(this.cbMonHoc);
            this.panel3.Location = new System.Drawing.Point(931, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 267);
            this.panel3.TabIndex = 137;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 33);
            this.panel4.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký môn học";
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbLopHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbLopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLopHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.cbLopHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cbLopHoc.FocusedState.Parent = this.cbLopHoc;
            this.cbLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLopHoc.ForeColor = System.Drawing.Color.White;
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.HoverState.Parent = this.cbLopHoc;
            this.cbLopHoc.ItemHeight = 35;
            this.cbLopHoc.ItemsAppearance.Parent = this.cbLopHoc;
            this.cbLopHoc.Location = new System.Drawing.Point(9, 126);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.ShadowDecoration.Parent = this.cbLopHoc;
            this.cbLopHoc.Size = new System.Drawing.Size(249, 41);
            this.cbLopHoc.TabIndex = 120;
            // 
            // btnDangKyMon
            // 
            this.btnDangKyMon.CheckedState.Parent = this.btnDangKyMon;
            this.btnDangKyMon.CustomImages.Parent = this.btnDangKyMon;
            this.btnDangKyMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnDangKyMon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyMon.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnDangKyMon.HoverState.Parent = this.btnDangKyMon;
            this.btnDangKyMon.Image = global::QuanLySinhVien.Properties.Resources.add_48px;
            this.btnDangKyMon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangKyMon.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDangKyMon.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDangKyMon.Location = new System.Drawing.Point(44, 200);
            this.btnDangKyMon.Name = "btnDangKyMon";
            this.btnDangKyMon.ShadowDecoration.Parent = this.btnDangKyMon;
            this.btnDangKyMon.Size = new System.Drawing.Size(179, 43);
            this.btnDangKyMon.TabIndex = 119;
            this.btnDangKyMon.Text = "Đăng Ký";
            this.btnDangKyMon.TextOffset = new System.Drawing.Point(20, 0);
            this.btnDangKyMon.Click += new System.EventHandler(this.btnDangKyMon_Click);
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbMonHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.cbMonHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cbMonHoc.FocusedState.Parent = this.cbMonHoc;
            this.cbMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMonHoc.ForeColor = System.Drawing.Color.White;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.HoverState.Parent = this.cbMonHoc;
            this.cbMonHoc.ItemHeight = 35;
            this.cbMonHoc.ItemsAppearance.Parent = this.cbMonHoc;
            this.cbMonHoc.Location = new System.Drawing.Point(9, 63);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.ShadowDecoration.Parent = this.cbMonHoc;
            this.cbMonHoc.Size = new System.Drawing.Size(249, 41);
            this.cbMonHoc.TabIndex = 119;
            this.cbMonHoc.SelectedValueChanged += new System.EventHandler(this.cbMonHoc_SelectedValueChanged);
            // 
            // btnThoatExcel
            // 
            this.btnThoatExcel.CheckedState.Parent = this.btnThoatExcel;
            this.btnThoatExcel.CustomImages.Parent = this.btnThoatExcel;
            this.btnThoatExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnThoatExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.btnThoatExcel.HoverState.Parent = this.btnThoatExcel;
            this.btnThoatExcel.Image = global::QuanLySinhVien.Properties.Resources.delete_48px;
            this.btnThoatExcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThoatExcel.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnThoatExcel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThoatExcel.Location = new System.Drawing.Point(1161, 318);
            this.btnThoatExcel.Name = "btnThoatExcel";
            this.btnThoatExcel.ShadowDecoration.Parent = this.btnThoatExcel;
            this.btnThoatExcel.Size = new System.Drawing.Size(35, 35);
            this.btnThoatExcel.TabIndex = 120;
            this.btnThoatExcel.TextOffset = new System.Drawing.Point(20, 0);
            this.btnThoatExcel.Visible = false;
            this.btnThoatExcel.Click += new System.EventHandler(this.btnThoatExcel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.btnNhapExel);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.cbNganh);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtTenSV);
            this.panel2.Controls.Add(this.cbLop);
            this.panel2.Location = new System.Drawing.Point(36, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 267);
            this.panel2.TabIndex = 136;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(456, 74);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(389, 52);
            this.txtEmail.TabIndex = 121;
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
            this.txtSDT.Location = new System.Drawing.Point(34, 136);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.MaxLength = 11;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSDT.PlaceholderText = "SDT";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(385, 52);
            this.txtSDT.TabIndex = 120;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // btnNhapExel
            // 
            this.btnNhapExel.CheckedState.Parent = this.btnNhapExel;
            this.btnNhapExel.CustomImages.Parent = this.btnNhapExel;
            this.btnNhapExel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnNhapExel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapExel.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnNhapExel.HoverState.Parent = this.btnNhapExel;
            this.btnNhapExel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhapExel.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNhapExel.Location = new System.Drawing.Point(240, 210);
            this.btnNhapExel.Name = "btnNhapExel";
            this.btnNhapExel.ShadowDecoration.Parent = this.btnNhapExel;
            this.btnNhapExel.Size = new System.Drawing.Size(179, 43);
            this.btnNhapExel.TabIndex = 119;
            this.btnNhapExel.Text = "Nhập Excel";
            this.btnNhapExel.Click += new System.EventHandler(this.btnNhapExel_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(456, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(179, 43);
            this.btnXoa.TabIndex = 111;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextOffset = new System.Drawing.Point(20, 0);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(666, 210);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(179, 43);
            this.btnSua.TabIndex = 110;
            this.btnSua.Text = "Lưu";
            this.btnSua.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.cbNganh.Location = new System.Drawing.Point(63, 20);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.ShadowDecoration.Parent = this.cbNganh;
            this.cbNganh.Size = new System.Drawing.Size(356, 41);
            this.cbNganh.TabIndex = 118;
            this.cbNganh.SelectedValueChanged += new System.EventHandler(this.cbKhoa_SelectedValueChanged);
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
            this.txtDiaChi.Location = new System.Drawing.Point(456, 136);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiaChi.PlaceholderText = "Địa chỉ";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(389, 52);
            this.txtDiaChi.TabIndex = 117;
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
            this.btnThem.Location = new System.Drawing.Point(34, 210);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(179, 43);
            this.btnThem.TabIndex = 107;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(20, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenSV
            // 
            this.txtTenSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTenSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTenSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSV.DefaultText = "";
            this.txtTenSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSV.DisabledState.Parent = this.txtTenSV;
            this.txtTenSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTenSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSV.FocusedState.Parent = this.txtTenSV;
            this.txtTenSV.ForeColor = System.Drawing.Color.White;
            this.txtTenSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSV.HoverState.Parent = this.txtTenSV;
            this.txtTenSV.Location = new System.Drawing.Point(34, 74);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.PasswordChar = '\0';
            this.txtTenSV.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenSV.PlaceholderText = "Tên Sinh viên";
            this.txtTenSV.SelectedText = "";
            this.txtTenSV.ShadowDecoration.Parent = this.txtTenSV;
            this.txtTenSV.Size = new System.Drawing.Size(385, 52);
            this.txtTenSV.TabIndex = 116;
            // 
            // cbLop
            // 
            this.cbLop.BackColor = System.Drawing.Color.Transparent;
            this.cbLop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.cbLop.FocusedColor = System.Drawing.Color.Empty;
            this.cbLop.FocusedState.Parent = this.cbLop;
            this.cbLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLop.ForeColor = System.Drawing.Color.White;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.HoverState.Parent = this.cbLop;
            this.cbLop.ItemHeight = 35;
            this.cbLop.ItemsAppearance.Parent = this.cbLop;
            this.cbLop.Location = new System.Drawing.Point(456, 20);
            this.cbLop.Name = "cbLop";
            this.cbLop.ShadowDecoration.Parent = this.cbLop;
            this.cbLop.Size = new System.Drawing.Size(356, 41);
            this.cbLop.TabIndex = 115;
            this.cbLop.SelectedValueChanged += new System.EventHandler(this.cbLop_SelectedValueChanged);
            // 
            // cbSheet
            // 
            this.cbSheet.BackColor = System.Drawing.Color.Transparent;
            this.cbSheet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbSheet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSheet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.cbSheet.FocusedColor = System.Drawing.Color.Empty;
            this.cbSheet.FocusedState.Parent = this.cbSheet;
            this.cbSheet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSheet.ForeColor = System.Drawing.Color.White;
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.HoverState.Parent = this.cbSheet;
            this.cbSheet.ItemHeight = 20;
            this.cbSheet.ItemsAppearance.Parent = this.cbSheet;
            this.cbSheet.Location = new System.Drawing.Point(37, 634);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.ShadowDecoration.Parent = this.cbSheet;
            this.cbSheet.Size = new System.Drawing.Size(213, 26);
            this.cbSheet.TabIndex = 120;
            this.cbSheet.Visible = false;
            this.cbSheet.SelectedIndexChanged += new System.EventHandler(this.cbSheet_SelectedIndexChanged);
            // 
            // dtgvSV
            // 
            this.dtgvSV.AllowUserToAddRows = false;
            this.dtgvSV.AllowUserToDeleteRows = false;
            this.dtgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvSV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvSV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.SDT,
            this.Email,
            this.MaLop,
            this.DiaChi,
            this.TichLuy,
            this.SoKy});
            this.dtgvSV.EnableHeadersVisualStyles = false;
            this.dtgvSV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvSV.Location = new System.Drawing.Point(36, 318);
            this.dtgvSV.Name = "dtgvSV";
            this.dtgvSV.ReadOnly = true;
            this.dtgvSV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvSV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvSV.RowTemplate.Height = 40;
            this.dtgvSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSV.Size = new System.Drawing.Size(1160, 348);
            this.dtgvSV.TabIndex = 135;
            this.dtgvSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSV_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh viên";
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên Sinh viên";
            this.TenSV.Name = "TenSV";
            this.TenSV.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // TichLuy
            // 
            this.TichLuy.DataPropertyName = "TichLuy";
            this.TichLuy.HeaderText = "Tích luỹ";
            this.TichLuy.Name = "TichLuy";
            this.TichLuy.ReadOnly = true;
            // 
            // SoKy
            // 
            this.SoKy.DataPropertyName = "SoKy";
            this.SoKy.HeaderText = "Số kỳ";
            this.SoKy.Name = "SoKy";
            this.SoKy.ReadOnly = true;
            // 
            // dtgvExcel
            // 
            this.dtgvExcel.AllowUserToAddRows = false;
            this.dtgvExcel.AllowUserToDeleteRows = false;
            this.dtgvExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvExcel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExcel.EnableHeadersVisualStyles = false;
            this.dtgvExcel.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvExcel.Location = new System.Drawing.Point(36, 318);
            this.dtgvExcel.Name = "dtgvExcel";
            this.dtgvExcel.ReadOnly = true;
            this.dtgvExcel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvExcel.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvExcel.RowTemplate.Height = 40;
            this.dtgvExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvExcel.Size = new System.Drawing.Size(1160, 348);
            this.dtgvExcel.TabIndex = 138;
            this.dtgvExcel.Visible = false;
            this.dtgvExcel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.panel1);
            this.Name = "ucSV";
            this.Size = new System.Drawing.Size(1232, 682);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbLop;
        private System.Windows.Forms.DataGridView dtgvSV;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSV;
        private Guna.UI2.WinForms.Guna2ComboBox cbNganh;
        private Guna.UI2.WinForms.Guna2Button btnDangKyMon;
        private Guna.UI2.WinForms.Guna2ComboBox cbMonHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cbLopHoc;
        private System.Windows.Forms.DataGridView dtgvExcel;
        private Guna.UI2.WinForms.Guna2Button btnNhapExel;
        private Guna.UI2.WinForms.Guna2ComboBox cbSheet;
        private Guna.UI2.WinForms.Guna2Button btnThoatExcel;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox lblLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TichLuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKy;
    }
}
