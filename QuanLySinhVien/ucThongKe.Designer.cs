namespace QuanLySinhVien
{
    partial class ucThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSVKem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSVGioi = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chrDiemHK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrDiemHK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.guna2ImageButton3);
            this.panel1.Controls.Add(this.btnSVKem);
            this.panel1.Controls.Add(this.btnSVGioi);
            this.panel1.Controls.Add(this.dtgvSV);
            this.panel1.Controls.Add(this.cbKhoa);
            this.panel1.Controls.Add(this.cbLop);
            this.panel1.Controls.Add(this.chrDiemHK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 682);
            this.panel1.TabIndex = 0;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::QuanLySinhVien.Properties.Resources.reset_48px;
            this.guna2ImageButton3.Location = new System.Drawing.Point(23, 155);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(63, 28);
            this.guna2ImageButton3.TabIndex = 157;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // btnSVKem
            // 
            this.btnSVKem.CheckedState.Parent = this.btnSVKem;
            this.btnSVKem.CustomImages.Parent = this.btnSVKem;
            this.btnSVKem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnSVKem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVKem.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSVKem.HoverState.Parent = this.btnSVKem;
            this.btnSVKem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSVKem.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSVKem.Location = new System.Drawing.Point(401, 90);
            this.btnSVKem.Name = "btnSVKem";
            this.btnSVKem.ShadowDecoration.Parent = this.btnSVKem;
            this.btnSVKem.Size = new System.Drawing.Size(236, 52);
            this.btnSVKem.TabIndex = 156;
            this.btnSVKem.Text = "Sinh viên học lực yếu";
            this.btnSVKem.Click += new System.EventHandler(this.btnSVKem_Click);
            // 
            // btnSVGioi
            // 
            this.btnSVGioi.CheckedState.Parent = this.btnSVGioi;
            this.btnSVGioi.CustomImages.Parent = this.btnSVGioi;
            this.btnSVGioi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnSVGioi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVGioi.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSVGioi.HoverState.Parent = this.btnSVGioi;
            this.btnSVGioi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSVGioi.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSVGioi.Location = new System.Drawing.Point(401, 21);
            this.btnSVGioi.Name = "btnSVGioi";
            this.btnSVGioi.ShadowDecoration.Parent = this.btnSVGioi;
            this.btnSVGioi.Size = new System.Drawing.Size(236, 52);
            this.btnSVGioi.TabIndex = 155;
            this.btnSVGioi.Text = "Sinh viên học lực tốt";
            this.btnSVGioi.Click += new System.EventHandler(this.btnSVGioi_Click);
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
            this.TichLuy});
            this.dtgvSV.EnableHeadersVisualStyles = false;
            this.dtgvSV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvSV.Location = new System.Drawing.Point(23, 184);
            this.dtgvSV.Name = "dtgvSV";
            this.dtgvSV.ReadOnly = true;
            this.dtgvSV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvSV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvSV.RowTemplate.Height = 40;
            this.dtgvSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSV.Size = new System.Drawing.Size(624, 471);
            this.dtgvSV.TabIndex = 154;
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
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TenSV.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.SDT.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
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
            this.DiaChi.Visible = false;
            // 
            // TichLuy
            // 
            this.TichLuy.DataPropertyName = "TichLuy";
            this.TichLuy.HeaderText = "Tích luỹ";
            this.TichLuy.Name = "TichLuy";
            this.TichLuy.ReadOnly = true;
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
            this.cbKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKhoa.ForeColor = System.Drawing.Color.White;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.HoverState.Parent = this.cbKhoa;
            this.cbKhoa.ItemHeight = 35;
            this.cbKhoa.ItemsAppearance.Parent = this.cbKhoa;
            this.cbKhoa.Location = new System.Drawing.Point(23, 21);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.ShadowDecoration.Parent = this.cbKhoa;
            this.cbKhoa.Size = new System.Drawing.Size(356, 41);
            this.cbKhoa.TabIndex = 153;
            this.cbKhoa.SelectedValueChanged += new System.EventHandler(this.cbKhoa_SelectedValueChanged);
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
            this.cbLop.Location = new System.Drawing.Point(23, 90);
            this.cbLop.Name = "cbLop";
            this.cbLop.ShadowDecoration.Parent = this.cbLop;
            this.cbLop.Size = new System.Drawing.Size(356, 41);
            this.cbLop.TabIndex = 152;
            this.cbLop.SelectedValueChanged += new System.EventHandler(this.cbLop_SelectedValueChanged);
            // 
            // chrDiemHK
            // 
            this.chrDiemHK.BackColor = System.Drawing.Color.Transparent;
            this.chrDiemHK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chrDiemHK.BorderlineColor = System.Drawing.Color.Transparent;
            this.chrDiemHK.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chrDiemHK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrDiemHK.Legends.Add(legend1);
            this.chrDiemHK.Location = new System.Drawing.Point(653, 40);
            this.chrDiemHK.Name = "chrDiemHK";
            this.chrDiemHK.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Điểm tích luỹ kỳ";
            this.chrDiemHK.Series.Add(series1);
            this.chrDiemHK.Size = new System.Drawing.Size(565, 615);
            this.chrDiemHK.TabIndex = 151;
            this.chrDiemHK.Text = "Biểu đồ điểm số qua các kỳ";
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1232, 682);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrDiemHK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrDiemHK;
        private Guna.UI2.WinForms.Guna2ComboBox cbKhoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbLop;
        private System.Windows.Forms.DataGridView dtgvSV;
        private Guna.UI2.WinForms.Guna2Button btnSVKem;
        private Guna.UI2.WinForms.Guna2Button btnSVGioi;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TichLuy;
    }
}
