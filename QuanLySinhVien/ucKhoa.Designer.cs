namespace QuanLySinhVien
{
    partial class ucKhoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTenKhoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaKhoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgvKhoa = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayLap.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Location = new System.Drawing.Point(51, 251);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(311, 30);
            this.dtpNgayLap.TabIndex = 8;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTenKhoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTenKhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhoa.DefaultText = "";
            this.txtTenKhoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhoa.DisabledState.Parent = this.txtTenKhoa;
            this.txtTenKhoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtTenKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhoa.FocusedState.Parent = this.txtTenKhoa;
            this.txtTenKhoa.ForeColor = System.Drawing.Color.White;
            this.txtTenKhoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhoa.HoverState.Parent = this.txtTenKhoa;
            this.txtTenKhoa.Location = new System.Drawing.Point(80, 162);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.PasswordChar = '\0';
            this.txtTenKhoa.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenKhoa.PlaceholderText = "Tên khoa";
            this.txtTenKhoa.SelectedText = "";
            this.txtTenKhoa.ShadowDecoration.Parent = this.txtTenKhoa;
            this.txtTenKhoa.Size = new System.Drawing.Size(252, 52);
            this.txtTenKhoa.TabIndex = 2;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtMaKhoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMaKhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKhoa.DefaultText = "";
            this.txtMaKhoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKhoa.DisabledState.Parent = this.txtMaKhoa;
            this.txtMaKhoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKhoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtMaKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKhoa.FocusedState.Parent = this.txtMaKhoa;
            this.txtMaKhoa.ForeColor = System.Drawing.Color.White;
            this.txtMaKhoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKhoa.HoverState.Parent = this.txtMaKhoa;
            this.txtMaKhoa.Location = new System.Drawing.Point(80, 91);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.PasswordChar = '\0';
            this.txtMaKhoa.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaKhoa.PlaceholderText = "Mã khoa";
            this.txtMaKhoa.SelectedText = "";
            this.txtMaKhoa.ShadowDecoration.Parent = this.txtMaKhoa;
            this.txtMaKhoa.Size = new System.Drawing.Size(252, 52);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // dtgvKhoa
            // 
            this.dtgvKhoa.AllowUserToAddRows = false;
            this.dtgvKhoa.AllowUserToDeleteRows = false;
            this.dtgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvKhoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvKhoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.KichThuoc,
            this.idCuaHang});
            this.dtgvKhoa.EnableHeadersVisualStyles = false;
            this.dtgvKhoa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvKhoa.Location = new System.Drawing.Point(382, 86);
            this.dtgvKhoa.Name = "dtgvKhoa";
            this.dtgvKhoa.ReadOnly = true;
            this.dtgvKhoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvKhoa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvKhoa.RowTemplate.Height = 24;
            this.dtgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKhoa.Size = new System.Drawing.Size(819, 520);
            this.dtgvKhoa.TabIndex = 98;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "Masp";
            this.MaSP.HeaderText = "Mã Khoa";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // KichThuoc
            // 
            this.KichThuoc.DataPropertyName = "Makt";
            this.KichThuoc.HeaderText = "Tên Khoa";
            this.KichThuoc.Name = "KichThuoc";
            this.KichThuoc.ReadOnly = true;
            // 
            // idCuaHang
            // 
            this.idCuaHang.DataPropertyName = "IdCH";
            this.idCuaHang.HeaderText = "Ngày Lập";
            this.idCuaHang.Name = "idCuaHang";
            this.idCuaHang.ReadOnly = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Aquamarine;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::QuanLySinhVien.Properties.Resources.edit_48px;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button2.Location = new System.Drawing.Point(111, 447);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(191, 75);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Sửa";
            this.guna2Button2.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Aquamarine;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::QuanLySinhVien.Properties.Resources.add_48px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button1.Location = new System.Drawing.Point(111, 360);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(191, 75);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Thêm";
            this.guna2Button1.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::QuanLySinhVien.Properties.Resources.delete_48px;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button3.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button3.Location = new System.Drawing.Point(111, 531);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(191, 75);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "Xoá";
            this.guna2Button3.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 682);
            this.panel1.TabIndex = 99;
            // 
            // ucKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgvKhoa);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.panel1);
            this.Name = "ucKhoa";
            this.Size = new System.Drawing.Size(1232, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhoa;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKhoa;
        private System.Windows.Forms.DataGridView dtgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuaHang;
        private System.Windows.Forms.Panel panel1;
    }
}
