namespace QuanLySinhVien
{
    partial class DiemDanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDiemDanh = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGV = new System.Windows.Forms.Label();
            this.lblSVCo = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.btnDiemDanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoDD = new Guna.UI2.WinForms.Guna2Button();
            this.cbNgayDD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemDanh)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDiemDanh
            // 
            this.dtgvDiemDanh.AllowUserToAddRows = false;
            this.dtgvDiemDanh.AllowUserToDeleteRows = false;
            this.dtgvDiemDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDiemDanh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDiemDanh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDiemDanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDiemDanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.MaSV,
            this.TenSV,
            this.Co});
            this.dtgvDiemDanh.EnableHeadersVisualStyles = false;
            this.dtgvDiemDanh.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvDiemDanh.Location = new System.Drawing.Point(0, 272);
            this.dtgvDiemDanh.Name = "dtgvDiemDanh";
            this.dtgvDiemDanh.ReadOnly = true;
            this.dtgvDiemDanh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvDiemDanh.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvDiemDanh.RowTemplate.Height = 40;
            this.dtgvDiemDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDiemDanh.Size = new System.Drawing.Size(881, 414);
            this.dtgvDiemDanh.TabIndex = 137;
            this.dtgvDiemDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDiem_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblGV);
            this.panel3.Controls.Add(this.lblSVCo);
            this.panel3.Controls.Add(this.lblMaHP);
            this.panel3.Controls.Add(this.lblTenMon);
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 151);
            this.panel3.TabIndex = 143;
            // 
            // lblGV
            // 
            this.lblGV.AutoSize = true;
            this.lblGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGV.Location = new System.Drawing.Point(409, 30);
            this.lblGV.Name = "lblGV";
            this.lblGV.Size = new System.Drawing.Size(92, 25);
            this.lblGV.TabIndex = 142;
            this.lblGV.Text = "Tên GV: ";
            // 
            // lblSVCo
            // 
            this.lblSVCo.AutoSize = true;
            this.lblSVCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSVCo.Location = new System.Drawing.Point(34, 110);
            this.lblSVCo.Name = "lblSVCo";
            this.lblSVCo.Size = new System.Drawing.Size(30, 25);
            this.lblSVCo.TabIndex = 141;
            this.lblSVCo.Text = "...";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHP.Location = new System.Drawing.Point(34, 30);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(132, 25);
            this.lblMaHP.TabIndex = 139;
            this.lblMaHP.Text = "Mã học phần:";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(34, 65);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(102, 25);
            this.lblTenMon.TabIndex = 140;
            this.lblTenMon.Text = "Học phần:";
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.CheckedState.Parent = this.btnDiemDanh;
            this.btnDiemDanh.CustomImages.Parent = this.btnDiemDanh;
            this.btnDiemDanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnDiemDanh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemDanh.ForeColor = System.Drawing.Color.Lime;
            this.btnDiemDanh.HoverState.Parent = this.btnDiemDanh;
            this.btnDiemDanh.Image = global::QuanLySinhVien.Properties.Resources.checked_checkbox_60px;
            this.btnDiemDanh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiemDanh.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnDiemDanh.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDiemDanh.Location = new System.Drawing.Point(0, 687);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.ShadowDecoration.Parent = this.btnDiemDanh;
            this.btnDiemDanh.Size = new System.Drawing.Size(459, 53);
            this.btnDiemDanh.TabIndex = 145;
            this.btnDiemDanh.Text = "Hoàn tất";
            this.btnDiemDanh.TextOffset = new System.Drawing.Point(21, 0);
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.CheckedState.Parent = this.btnHuy;
            this.btnHuy.CustomImages.Parent = this.btnHuy;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnHuy.HoverState.Parent = this.btnHuy;
            this.btnHuy.Image = global::QuanLySinhVien.Properties.Resources.close_red;
            this.btnHuy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuy.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnHuy.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHuy.Location = new System.Drawing.Point(465, 687);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.Parent = this.btnHuy;
            this.btnHuy.Size = new System.Drawing.Size(416, 53);
            this.btnHuy.TabIndex = 146;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextOffset = new System.Drawing.Point(21, 0);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::QuanLySinhVien.Properties.Resources.close_nonbrg;
            this.guna2ImageButton1.Location = new System.Drawing.Point(818, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(60, 43);
            this.guna2ImageButton1.TabIndex = 117;
            this.guna2ImageButton1.TabStop = false;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 46);
            this.panel1.TabIndex = 147;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(400, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm Danh";
            // 
            // btnTaoDD
            // 
            this.btnTaoDD.CheckedState.Parent = this.btnTaoDD;
            this.btnTaoDD.CustomImages.Parent = this.btnTaoDD;
            this.btnTaoDD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnTaoDD.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDD.ForeColor = System.Drawing.Color.Lime;
            this.btnTaoDD.HoverState.Parent = this.btnTaoDD;
            this.btnTaoDD.Image = global::QuanLySinhVien.Properties.Resources.checked_checkbox_60px;
            this.btnTaoDD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaoDD.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnTaoDD.ImageSize = new System.Drawing.Size(35, 35);
            this.btnTaoDD.Location = new System.Drawing.Point(535, 209);
            this.btnTaoDD.Name = "btnTaoDD";
            this.btnTaoDD.ShadowDecoration.Parent = this.btnTaoDD;
            this.btnTaoDD.Size = new System.Drawing.Size(261, 53);
            this.btnTaoDD.TabIndex = 148;
            this.btnTaoDD.Text = "Điểm danh mới";
            this.btnTaoDD.TextOffset = new System.Drawing.Point(21, 0);
            this.btnTaoDD.Click += new System.EventHandler(this.btnTaoDD_Click);
            // 
            // cbNgayDD
            // 
            this.cbNgayDD.BackColor = System.Drawing.Color.Transparent;
            this.cbNgayDD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbNgayDD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNgayDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgayDD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.cbNgayDD.FocusedColor = System.Drawing.Color.Empty;
            this.cbNgayDD.FocusedState.Parent = this.cbNgayDD;
            this.cbNgayDD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNgayDD.ForeColor = System.Drawing.Color.White;
            this.cbNgayDD.FormattingEnabled = true;
            this.cbNgayDD.HoverState.Parent = this.cbNgayDD;
            this.cbNgayDD.ItemHeight = 35;
            this.cbNgayDD.ItemsAppearance.Parent = this.cbNgayDD;
            this.cbNgayDD.Location = new System.Drawing.Point(57, 209);
            this.cbNgayDD.Name = "cbNgayDD";
            this.cbNgayDD.ShadowDecoration.Parent = this.cbNgayDD;
            this.cbNgayDD.Size = new System.Drawing.Size(356, 41);
            this.cbNgayDD.TabIndex = 149;
            this.cbNgayDD.SelectedValueChanged += new System.EventHandler(this.cbNgayDD_SelectedValueChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            this.TenSV.HeaderText = "Tên ";
            this.TenSV.Name = "TenSV";
            this.TenSV.ReadOnly = true;
            // 
            // Co
            // 
            this.Co.DataPropertyName = "DiemDanh";
            this.Co.HeaderText = "Có Mặt";
            this.Co.Name = "Co";
            this.Co.ReadOnly = true;
            // 
            // DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(881, 740);
            this.Controls.Add(this.cbNgayDD);
            this.Controls.Add(this.btnTaoDD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDiemDanh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgvDiemDanh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiemDanh";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemDanh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDiemDanh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.Label lblSVCo;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label lblTenMon;
        private Guna.UI2.WinForms.Guna2Button btnDiemDanh;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnTaoDD;
        private Guna.UI2.WinForms.Guna2ComboBox cbNgayDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co;
    }
}