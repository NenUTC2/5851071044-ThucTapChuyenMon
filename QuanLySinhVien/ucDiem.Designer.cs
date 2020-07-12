namespace QuanLySinhVien
{
    partial class ucDiem
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
            this.dtgvDiem = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCTMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGiuaKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTxTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblDiemTL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPTDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPTTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPTGK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPTCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuDIem = new Guna.UI2.WinForms.Guna2Button();
            this.cbLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtKT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiuaKy = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtChuyenCan = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDiem
            // 
            this.dtgvDiem.AllowUserToAddRows = false;
            this.dtgvDiem.AllowUserToDeleteRows = false;
            this.dtgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaCTMon,
            this.ChuyenCan,
            this.DiemGiuaKy,
            this.DiemTP,
            this.DiemThi,
            this.DiemKT,
            this.KTxTC});
            this.dtgvDiem.EnableHeadersVisualStyles = false;
            this.dtgvDiem.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvDiem.Location = new System.Drawing.Point(26, 320);
            this.dtgvDiem.Name = "dtgvDiem";
            this.dtgvDiem.ReadOnly = true;
            this.dtgvDiem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvDiem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDiem.RowTemplate.Height = 40;
            this.dtgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDiem.Size = new System.Drawing.Size(1180, 348);
            this.dtgvDiem.TabIndex = 136;
            this.dtgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDiem_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh viên";
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            // 
            // MaCTMon
            // 
            this.MaCTMon.DataPropertyName = "MaCTMon";
            this.MaCTMon.HeaderText = "Mã học phần";
            this.MaCTMon.Name = "MaCTMon";
            this.MaCTMon.ReadOnly = true;
            // 
            // ChuyenCan
            // 
            this.ChuyenCan.DataPropertyName = "ChuyenCan";
            this.ChuyenCan.HeaderText = "Chuyên cần";
            this.ChuyenCan.Name = "ChuyenCan";
            this.ChuyenCan.ReadOnly = true;
            // 
            // DiemGiuaKy
            // 
            this.DiemGiuaKy.DataPropertyName = "DiemGiuaKy";
            this.DiemGiuaKy.HeaderText = "Điểm giữa kì";
            this.DiemGiuaKy.Name = "DiemGiuaKy";
            this.DiemGiuaKy.ReadOnly = true;
            // 
            // DiemTP
            // 
            this.DiemTP.DataPropertyName = "DiemTP";
            this.DiemTP.HeaderText = "Điểm thành phần";
            this.DiemTP.Name = "DiemTP";
            this.DiemTP.ReadOnly = true;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.ReadOnly = true;
            // 
            // DiemKT
            // 
            this.DiemKT.DataPropertyName = "DiemKT";
            this.DiemKT.HeaderText = "Điểm kết thúc";
            this.DiemKT.Name = "DiemKT";
            this.DiemKT.ReadOnly = true;
            // 
            // KTxTC
            // 
            this.KTxTC.DataPropertyName = "KTxTC";
            this.KTxTC.HeaderText = "KTxTC";
            this.KTxTC.Name = "KTxTC";
            this.KTxTC.ReadOnly = true;
            this.KTxTC.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Image = global::QuanLySinhVien.Properties.Resources.reset_48px;
            this.btnReset.Location = new System.Drawing.Point(23, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.PressedState.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(109, 43);
            this.btnReset.TabIndex = 137;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtgvDiem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 682);
            this.panel1.TabIndex = 138;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTenSV);
            this.panel3.Controls.Add(this.lblLop);
            this.panel3.Controls.Add(this.lblDiemTL);
            this.panel3.Location = new System.Drawing.Point(26, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 150);
            this.panel3.TabIndex = 141;
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(34, 21);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(140, 25);
            this.lblTenSV.TabIndex = 139;
            this.lblTenSV.Text = "Tên sinh viên: ";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(34, 64);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(56, 25);
            this.lblLop.TabIndex = 140;
            this.lblLop.Text = "Lớp: ";
            // 
            // lblDiemTL
            // 
            this.lblDiemTL.AutoSize = true;
            this.lblDiemTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTL.Location = new System.Drawing.Point(34, 107);
            this.lblDiemTL.Name = "lblDiemTL";
            this.lblDiemTL.Size = new System.Drawing.Size(133, 25);
            this.lblDiemTL.TabIndex = 138;
            this.lblDiemTL.Text = "Điểm tích luỹ: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPTDT);
            this.panel2.Controls.Add(this.txtPTTP);
            this.panel2.Controls.Add(this.txtPTGK);
            this.panel2.Controls.Add(this.txtPTCC);
            this.panel2.Controls.Add(this.btnLuuDIem);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.cbLop);
            this.panel2.Controls.Add(this.txtKT);
            this.panel2.Controls.Add(this.txtThi);
            this.panel2.Controls.Add(this.txtTP);
            this.panel2.Controls.Add(this.txtGiuaKy);
            this.panel2.Controls.Add(this.txtChuyenCan);
            this.panel2.Location = new System.Drawing.Point(26, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 125);
            this.panel2.TabIndex = 0;
            // 
            // txtPTDT
            // 
            this.txtPTDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtPTDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPTDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPTDT.DefaultText = "70";
            this.txtPTDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPTDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPTDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTDT.DisabledState.Parent = this.txtPTDT;
            this.txtPTDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(88)))));
            this.txtPTDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPTDT.FocusedState.Parent = this.txtPTDT;
            this.txtPTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTDT.ForeColor = System.Drawing.Color.White;
            this.txtPTDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPTDT.HoverState.Parent = this.txtPTDT;
            this.txtPTDT.Location = new System.Drawing.Point(855, 30);
            this.txtPTDT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPTDT.MaxLength = 2;
            this.txtPTDT.Name = "txtPTDT";
            this.txtPTDT.PasswordChar = '\0';
            this.txtPTDT.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPTDT.PlaceholderText = "";
            this.txtPTDT.SelectedText = "";
            this.txtPTDT.ShadowDecoration.Parent = this.txtPTDT;
            this.txtPTDT.Size = new System.Drawing.Size(141, 29);
            this.txtPTDT.TabIndex = 142;
            this.txtPTDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPTDT.TextChanged += new System.EventHandler(this.txtPTDT_TextChanged);
            this.txtPTDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // txtPTTP
            // 
            this.txtPTTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtPTTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPTTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPTTP.DefaultText = "30";
            this.txtPTTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPTTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPTTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTTP.DisabledState.Parent = this.txtPTTP;
            this.txtPTTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(88)))));
            this.txtPTTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPTTP.FocusedState.Parent = this.txtPTTP;
            this.txtPTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTTP.ForeColor = System.Drawing.Color.White;
            this.txtPTTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPTTP.HoverState.Parent = this.txtPTTP;
            this.txtPTTP.Location = new System.Drawing.Point(692, 30);
            this.txtPTTP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPTTP.MaxLength = 2;
            this.txtPTTP.Name = "txtPTTP";
            this.txtPTTP.PasswordChar = '\0';
            this.txtPTTP.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPTTP.PlaceholderText = "";
            this.txtPTTP.SelectedText = "";
            this.txtPTTP.ShadowDecoration.Parent = this.txtPTTP;
            this.txtPTTP.Size = new System.Drawing.Size(141, 29);
            this.txtPTTP.TabIndex = 141;
            this.txtPTTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPTTP.TextChanged += new System.EventHandler(this.txtPTTP_TextChanged);
            this.txtPTTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // txtPTGK
            // 
            this.txtPTGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtPTGK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPTGK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPTGK.DefaultText = "50";
            this.txtPTGK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPTGK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPTGK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTGK.DisabledState.Parent = this.txtPTGK;
            this.txtPTGK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTGK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(88)))));
            this.txtPTGK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPTGK.FocusedState.Parent = this.txtPTGK;
            this.txtPTGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTGK.ForeColor = System.Drawing.Color.White;
            this.txtPTGK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPTGK.HoverState.Parent = this.txtPTGK;
            this.txtPTGK.Location = new System.Drawing.Point(529, 30);
            this.txtPTGK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPTGK.MaxLength = 2;
            this.txtPTGK.Name = "txtPTGK";
            this.txtPTGK.PasswordChar = '\0';
            this.txtPTGK.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPTGK.PlaceholderText = "";
            this.txtPTGK.SelectedText = "";
            this.txtPTGK.ShadowDecoration.Parent = this.txtPTGK;
            this.txtPTGK.Size = new System.Drawing.Size(141, 29);
            this.txtPTGK.TabIndex = 140;
            this.txtPTGK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPTGK.TextChanged += new System.EventHandler(this.txtPTGK_TextChanged);
            this.txtPTGK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // txtPTCC
            // 
            this.txtPTCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtPTCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPTCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPTCC.DefaultText = "50";
            this.txtPTCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPTCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPTCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTCC.DisabledState.Parent = this.txtPTCC;
            this.txtPTCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(88)))));
            this.txtPTCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPTCC.FocusedState.Parent = this.txtPTCC;
            this.txtPTCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTCC.ForeColor = System.Drawing.Color.White;
            this.txtPTCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPTCC.HoverState.Parent = this.txtPTCC;
            this.txtPTCC.Location = new System.Drawing.Point(366, 30);
            this.txtPTCC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPTCC.MaxLength = 2;
            this.txtPTCC.Name = "txtPTCC";
            this.txtPTCC.PasswordChar = '\0';
            this.txtPTCC.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPTCC.PlaceholderText = "";
            this.txtPTCC.SelectedText = "";
            this.txtPTCC.ShadowDecoration.Parent = this.txtPTCC;
            this.txtPTCC.Size = new System.Drawing.Size(141, 29);
            this.txtPTCC.TabIndex = 139;
            this.txtPTCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPTCC.TextChanged += new System.EventHandler(this.txtPTCC_TextChanged);
            this.txtPTCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // btnLuuDIem
            // 
            this.btnLuuDIem.CheckedState.Parent = this.btnLuuDIem;
            this.btnLuuDIem.CustomImages.Parent = this.btnLuuDIem;
            this.btnLuuDIem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnLuuDIem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDIem.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnLuuDIem.HoverState.Parent = this.btnLuuDIem;
            this.btnLuuDIem.Image = global::QuanLySinhVien.Properties.Resources.add_48px;
            this.btnLuuDIem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLuuDIem.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLuuDIem.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLuuDIem.Location = new System.Drawing.Point(157, 67);
            this.btnLuuDIem.Name = "btnLuuDIem";
            this.btnLuuDIem.ShadowDecoration.Parent = this.btnLuuDIem;
            this.btnLuuDIem.Size = new System.Drawing.Size(179, 43);
            this.btnLuuDIem.TabIndex = 138;
            this.btnLuuDIem.Text = "Lưu Điểm";
            this.btnLuuDIem.TextOffset = new System.Drawing.Point(20, 0);
            this.btnLuuDIem.Click += new System.EventHandler(this.btnLuuDIem_Click);
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
            this.cbLop.Location = new System.Drawing.Point(23, 13);
            this.cbLop.Name = "cbLop";
            this.cbLop.ShadowDecoration.Parent = this.cbLop;
            this.cbLop.Size = new System.Drawing.Size(313, 41);
            this.cbLop.TabIndex = 137;
            this.cbLop.SelectedValueChanged += new System.EventHandler(this.cbLop_SelectedValueChanged);
            // 
            // txtKT
            // 
            this.txtKT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtKT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtKT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKT.DefaultText = "";
            this.txtKT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKT.DisabledState.Parent = this.txtKT;
            this.txtKT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtKT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKT.FocusedState.Parent = this.txtKT;
            this.txtKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKT.ForeColor = System.Drawing.Color.White;
            this.txtKT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKT.HoverState.Parent = this.txtKT;
            this.txtKT.Location = new System.Drawing.Point(1018, 58);
            this.txtKT.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtKT.Name = "txtKT";
            this.txtKT.PasswordChar = '\0';
            this.txtKT.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKT.PlaceholderText = "Điểm KT";
            this.txtKT.SelectedText = "";
            this.txtKT.ShadowDecoration.Parent = this.txtKT;
            this.txtKT.Size = new System.Drawing.Size(141, 52);
            this.txtKT.TabIndex = 128;
            this.txtKT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // txtThi
            // 
            this.txtThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtThi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThi.DefaultText = "";
            this.txtThi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThi.DisabledState.Parent = this.txtThi;
            this.txtThi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtThi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThi.FocusedState.Parent = this.txtThi;
            this.txtThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThi.ForeColor = System.Drawing.Color.White;
            this.txtThi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThi.HoverState.Parent = this.txtThi;
            this.txtThi.Location = new System.Drawing.Point(855, 58);
            this.txtThi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtThi.Name = "txtThi";
            this.txtThi.PasswordChar = '\0';
            this.txtThi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtThi.PlaceholderText = "Điểm thi";
            this.txtThi.SelectedText = "";
            this.txtThi.ShadowDecoration.Parent = this.txtThi;
            this.txtThi.Size = new System.Drawing.Size(141, 52);
            this.txtThi.TabIndex = 127;
            this.txtThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThi.TextChanged += new System.EventHandler(this.txtThi_TextChanged);
            this.txtThi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // txtTP
            // 
            this.txtTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTP.DefaultText = "";
            this.txtTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTP.DisabledState.Parent = this.txtTP;
            this.txtTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTP.FocusedState.Parent = this.txtTP;
            this.txtTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTP.ForeColor = System.Drawing.Color.White;
            this.txtTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTP.HoverState.Parent = this.txtTP;
            this.txtTP.Location = new System.Drawing.Point(692, 58);
            this.txtTP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTP.Name = "txtTP";
            this.txtTP.PasswordChar = '\0';
            this.txtTP.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTP.PlaceholderText = "Thành phần";
            this.txtTP.SelectedText = "";
            this.txtTP.ShadowDecoration.Parent = this.txtTP;
            this.txtTP.Size = new System.Drawing.Size(141, 52);
            this.txtTP.TabIndex = 126;
            this.txtTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTP.TextChanged += new System.EventHandler(this.txtTP_TextChanged);
            this.txtTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // txtGiuaKy
            // 
            this.txtGiuaKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtGiuaKy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtGiuaKy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiuaKy.DefaultText = "";
            this.txtGiuaKy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiuaKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiuaKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiuaKy.DisabledState.Parent = this.txtGiuaKy;
            this.txtGiuaKy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiuaKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtGiuaKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiuaKy.FocusedState.Parent = this.txtGiuaKy;
            this.txtGiuaKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiuaKy.ForeColor = System.Drawing.Color.White;
            this.txtGiuaKy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiuaKy.HoverState.Parent = this.txtGiuaKy;
            this.txtGiuaKy.Location = new System.Drawing.Point(529, 58);
            this.txtGiuaKy.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtGiuaKy.Name = "txtGiuaKy";
            this.txtGiuaKy.PasswordChar = '\0';
            this.txtGiuaKy.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGiuaKy.PlaceholderText = "Giữa kỳ";
            this.txtGiuaKy.SelectedText = "";
            this.txtGiuaKy.ShadowDecoration.Parent = this.txtGiuaKy;
            this.txtGiuaKy.Size = new System.Drawing.Size(141, 52);
            this.txtGiuaKy.TabIndex = 125;
            this.txtGiuaKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGiuaKy.TextChanged += new System.EventHandler(this.txtGiuaKy_TextChanged);
            this.txtGiuaKy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // txtChuyenCan
            // 
            this.txtChuyenCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtChuyenCan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtChuyenCan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChuyenCan.DefaultText = "";
            this.txtChuyenCan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChuyenCan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChuyenCan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChuyenCan.DisabledState.Parent = this.txtChuyenCan;
            this.txtChuyenCan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChuyenCan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtChuyenCan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChuyenCan.FocusedState.Parent = this.txtChuyenCan;
            this.txtChuyenCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuyenCan.ForeColor = System.Drawing.Color.White;
            this.txtChuyenCan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChuyenCan.HoverState.Parent = this.txtChuyenCan;
            this.txtChuyenCan.Location = new System.Drawing.Point(366, 58);
            this.txtChuyenCan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtChuyenCan.Name = "txtChuyenCan";
            this.txtChuyenCan.PasswordChar = '\0';
            this.txtChuyenCan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtChuyenCan.PlaceholderText = "Chuyên cần";
            this.txtChuyenCan.SelectedText = "";
            this.txtChuyenCan.ShadowDecoration.Parent = this.txtChuyenCan;
            this.txtChuyenCan.Size = new System.Drawing.Size(141, 52);
            this.txtChuyenCan.TabIndex = 124;
            this.txtChuyenCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChuyenCan.TextChanged += new System.EventHandler(this.txtChuyenCan_TextChanged);
            this.txtChuyenCan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTCC_KeyPress);
            // 
            // ucDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.panel1);
            this.Name = "ucDiem";
            this.Size = new System.Drawing.Size(1232, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDiem;
        private Guna.UI2.WinForms.Guna2ImageButton btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGiuaKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTxTC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtKT;
        private Guna.UI2.WinForms.Guna2TextBox txtThi;
        private Guna.UI2.WinForms.Guna2TextBox txtTP;
        private Guna.UI2.WinForms.Guna2TextBox txtGiuaKy;
        private Guna.UI2.WinForms.Guna2TextBox txtChuyenCan;
        private Guna.UI2.WinForms.Guna2ComboBox cbLop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblDiemTL;
        private Guna.UI2.WinForms.Guna2Button btnLuuDIem;
        private Guna.UI2.WinForms.Guna2TextBox txtPTDT;
        private Guna.UI2.WinForms.Guna2TextBox txtPTTP;
        private Guna.UI2.WinForms.Guna2TextBox txtPTGK;
        private Guna.UI2.WinForms.Guna2TextBox txtPTCC;
    }
}
