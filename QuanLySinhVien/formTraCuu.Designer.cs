namespace QuanLySinhVien
{
    partial class formTraCuu
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
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.dtgvDiem = new System.Windows.Forms.DataGridView();
            this.dtgvMon = new System.Windows.Forms.DataGridView();
            this.txtMSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.BackColor = System.Drawing.Color.Transparent;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(40, 132);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(101, 25);
            this.lblTenSV.TabIndex = 2;
            this.lblTenSV.Text = "Họ và tên:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(40, 170);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(96, 25);
            this.lblNamHoc.TabIndex = 4;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // dtgvDiem
            // 
            this.dtgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiem.Location = new System.Drawing.Point(45, 215);
            this.dtgvDiem.Name = "dtgvDiem";
            this.dtgvDiem.RowTemplate.Height = 24;
            this.dtgvDiem.Size = new System.Drawing.Size(672, 448);
            this.dtgvDiem.TabIndex = 5;
            // 
            // dtgvMon
            // 
            this.dtgvMon.BackgroundColor = System.Drawing.Color.White;
            this.dtgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMon.Location = new System.Drawing.Point(746, 215);
            this.dtgvMon.Name = "dtgvMon";
            this.dtgvMon.RowTemplate.Height = 24;
            this.dtgvMon.Size = new System.Drawing.Size(478, 448);
            this.dtgvMon.TabIndex = 6;
            // 
            // txtMSV
            // 
            this.txtMSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtMSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSV.DefaultText = "";
            this.txtMSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSV.DisabledState.Parent = this.txtMSV;
            this.txtMSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.txtMSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSV.FocusedState.Parent = this.txtMSV;
            this.txtMSV.ForeColor = System.Drawing.Color.White;
            this.txtMSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSV.HoverState.Parent = this.txtMSV;
            this.txtMSV.Location = new System.Drawing.Point(45, 49);
            this.txtMSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.PasswordChar = '\0';
            this.txtMSV.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMSV.PlaceholderText = "Mã Sinh Viên";
            this.txtMSV.SelectedText = "";
            this.txtMSV.ShadowDecoration.Parent = this.txtMSV;
            this.txtMSV.Size = new System.Drawing.Size(252, 52);
            this.txtMSV.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "Điểm tích luỹ trung bình";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTenSV);
            this.panel1.Controls.Add(this.lblNamHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 676);
            this.panel1.TabIndex = 111;
            // 
            // formTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 676);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.dtgvMon);
            this.Controls.Add(this.dtgvDiem);
            this.Controls.Add(this.panel1);
            this.Name = "formTraCuu";
            this.Text = "formTraCuu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.DataGridView dtgvDiem;
        private System.Windows.Forms.DataGridView dtgvMon;
        private Guna.UI2.WinForms.Guna2TextBox txtMSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}