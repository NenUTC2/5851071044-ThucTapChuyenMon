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
            this.txtMSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.dtgvDiem = new System.Windows.Forms.DataGridView();
            this.dtgvMon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMSV
            // 
            this.txtMSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSV.DefaultText = "";
            this.txtMSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSV.DisabledState.Parent = this.txtMSV;
            this.txtMSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSV.FocusedState.Parent = this.txtMSV;
            this.txtMSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSV.HoverState.Parent = this.txtMSV;
            this.txtMSV.Location = new System.Drawing.Point(45, 57);
            this.txtMSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.PasswordChar = '\0';
            this.txtMSV.PlaceholderText = "";
            this.txtMSV.SelectedText = "";
            this.txtMSV.ShadowDecoration.Parent = this.txtMSV;
            this.txtMSV.Size = new System.Drawing.Size(267, 44);
            this.txtMSV.TabIndex = 0;
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(40, 133);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(101, 25);
            this.lblTenSV.TabIndex = 2;
            this.lblTenSV.Text = "Họ và tên:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(40, 171);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(96, 25);
            this.lblNamHoc.TabIndex = 4;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // dtgvDiem
            // 
            this.dtgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiem.Location = new System.Drawing.Point(45, 235);
            this.dtgvDiem.Name = "dtgvDiem";
            this.dtgvDiem.RowTemplate.Height = 24;
            this.dtgvDiem.Size = new System.Drawing.Size(672, 448);
            this.dtgvDiem.TabIndex = 5;
            // 
            // dtgvMon
            // 
            this.dtgvMon.BackgroundColor = System.Drawing.Color.White;
            this.dtgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMon.Location = new System.Drawing.Point(746, 235);
            this.dtgvMon.Name = "dtgvMon";
            this.dtgvMon.RowTemplate.Height = 24;
            this.dtgvMon.Size = new System.Drawing.Size(478, 448);
            this.dtgvMon.TabIndex = 6;
            // 
            // formTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 713);
            this.Controls.Add(this.dtgvMon);
            this.Controls.Add(this.dtgvDiem);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.txtMSV);
            this.Name = "formTraCuu";
            this.Text = "formTraCuu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.DataGridView dtgvDiem;
        private System.Windows.Forms.DataGridView dtgvMon;
    }
}