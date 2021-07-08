namespace DK
{
    partial class frmSql
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
            this.dgvSql = new System.Windows.Forms.DataGridView();
            this.lblMaLoaiTaiSan = new System.Windows.Forms.Label();
            this.lblTenLoaiTaiSan = new System.Windows.Forms.Label();
            this.lblDonViQuanLy = new System.Windows.Forms.Label();
            this.lblChucNang = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtMaLoaiTaiSan = new System.Windows.Forms.TextBox();
            this.txtTenLoaiTaiSan = new System.Windows.Forms.TextBox();
            this.txtChucNang = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbbDonViQuanLy = new System.Windows.Forms.ComboBox();
            this.pnlLuuHuy = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlRefreshThem = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSql)).BeginInit();
            this.pnlLuuHuy.SuspendLayout();
            this.pnlRefreshThem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSql
            // 
            this.dgvSql.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSql.BackgroundColor = System.Drawing.Color.White;
            this.dgvSql.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSql.Location = new System.Drawing.Point(63, 335);
            this.dgvSql.Name = "dgvSql";
            this.dgvSql.ReadOnly = true;
            this.dgvSql.RowTemplate.Height = 24;
            this.dgvSql.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSql.Size = new System.Drawing.Size(1056, 368);
            this.dgvSql.TabIndex = 0;
            // 
            // lblMaLoaiTaiSan
            // 
            this.lblMaLoaiTaiSan.AutoSize = true;
            this.lblMaLoaiTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiTaiSan.Location = new System.Drawing.Point(34, 72);
            this.lblMaLoaiTaiSan.Name = "lblMaLoaiTaiSan";
            this.lblMaLoaiTaiSan.Size = new System.Drawing.Size(152, 26);
            this.lblMaLoaiTaiSan.TabIndex = 1;
            this.lblMaLoaiTaiSan.Text = "Mã loại tài sản";
            // 
            // lblTenLoaiTaiSan
            // 
            this.lblTenLoaiTaiSan.AutoSize = true;
            this.lblTenLoaiTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiTaiSan.Location = new System.Drawing.Point(28, 122);
            this.lblTenLoaiTaiSan.Name = "lblTenLoaiTaiSan";
            this.lblTenLoaiTaiSan.Size = new System.Drawing.Size(158, 26);
            this.lblTenLoaiTaiSan.TabIndex = 1;
            this.lblTenLoaiTaiSan.Text = "Tên loại tài sản";
            // 
            // lblDonViQuanLy
            // 
            this.lblDonViQuanLy.AutoSize = true;
            this.lblDonViQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViQuanLy.Location = new System.Drawing.Point(36, 172);
            this.lblDonViQuanLy.Name = "lblDonViQuanLy";
            this.lblDonViQuanLy.Size = new System.Drawing.Size(150, 26);
            this.lblDonViQuanLy.TabIndex = 1;
            this.lblDonViQuanLy.Text = "Đơn vị quản lý";
            // 
            // lblChucNang
            // 
            this.lblChucNang.AutoSize = true;
            this.lblChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucNang.Location = new System.Drawing.Point(69, 222);
            this.lblChucNang.Name = "lblChucNang";
            this.lblChucNang.Size = new System.Drawing.Size(117, 26);
            this.lblChucNang.TabIndex = 1;
            this.lblChucNang.Text = "Chức năng";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(99, 272);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(87, 26);
            this.lblGhiChu.TabIndex = 1;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtMaLoaiTaiSan
            // 
            this.txtMaLoaiTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiTaiSan.Location = new System.Drawing.Point(192, 69);
            this.txtMaLoaiTaiSan.Name = "txtMaLoaiTaiSan";
            this.txtMaLoaiTaiSan.ReadOnly = true;
            this.txtMaLoaiTaiSan.Size = new System.Drawing.Size(658, 32);
            this.txtMaLoaiTaiSan.TabIndex = 2;
            // 
            // txtTenLoaiTaiSan
            // 
            this.txtTenLoaiTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiTaiSan.Location = new System.Drawing.Point(192, 119);
            this.txtTenLoaiTaiSan.Name = "txtTenLoaiTaiSan";
            this.txtTenLoaiTaiSan.Size = new System.Drawing.Size(658, 32);
            this.txtTenLoaiTaiSan.TabIndex = 2;
            // 
            // txtChucNang
            // 
            this.txtChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucNang.Location = new System.Drawing.Point(192, 219);
            this.txtChucNang.Name = "txtChucNang";
            this.txtChucNang.Size = new System.Drawing.Size(658, 32);
            this.txtChucNang.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(192, 269);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(658, 32);
            this.txtGhiChu.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 60);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(213, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(63, 709);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(192, 709);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 32);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(3, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(213, 32);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(3, 60);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(213, 32);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(444, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản lý Loại tài sản";
            // 
            // cbbDonViQuanLy
            // 
            this.cbbDonViQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDonViQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDonViQuanLy.FormattingEnabled = true;
            this.cbbDonViQuanLy.Location = new System.Drawing.Point(192, 169);
            this.cbbDonViQuanLy.Name = "cbbDonViQuanLy";
            this.cbbDonViQuanLy.Size = new System.Drawing.Size(658, 34);
            this.cbbDonViQuanLy.TabIndex = 4;
            this.cbbDonViQuanLy.DropDown += new System.EventHandler(this.cbbDonViQuanLy_DropDown);
            // 
            // pnlLuuHuy
            // 
            this.pnlLuuHuy.Controls.Add(this.btnLuu);
            this.pnlLuuHuy.Controls.Add(this.btnHuy);
            this.pnlLuuHuy.Location = new System.Drawing.Point(900, 153);
            this.pnlLuuHuy.Name = "pnlLuuHuy";
            this.pnlLuuHuy.Size = new System.Drawing.Size(219, 95);
            this.pnlLuuHuy.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(213, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Tạo mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlRefreshThem
            // 
            this.pnlRefreshThem.Controls.Add(this.btnRefresh);
            this.pnlRefreshThem.Controls.Add(this.btnThem);
            this.pnlRefreshThem.Location = new System.Drawing.Point(900, 153);
            this.pnlRefreshThem.Name = "pnlRefreshThem";
            this.pnlRefreshThem.Size = new System.Drawing.Size(219, 95);
            this.pnlRefreshThem.TabIndex = 6;
            // 
            // frmSql
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.cbbDonViQuanLy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtChucNang);
            this.Controls.Add(this.txtTenLoaiTaiSan);
            this.Controls.Add(this.txtMaLoaiTaiSan);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblChucNang);
            this.Controls.Add(this.lblDonViQuanLy);
            this.Controls.Add(this.lblTenLoaiTaiSan);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaLoaiTaiSan);
            this.Controls.Add(this.dgvSql);
            this.Controls.Add(this.pnlRefreshThem);
            this.Controls.Add(this.pnlLuuHuy);
            this.Name = "frmSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSql";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSql)).EndInit();
            this.pnlLuuHuy.ResumeLayout(false);
            this.pnlLuuHuy.PerformLayout();
            this.pnlRefreshThem.ResumeLayout(false);
            this.pnlRefreshThem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSql;
        private System.Windows.Forms.Label lblMaLoaiTaiSan;
        private System.Windows.Forms.Label lblTenLoaiTaiSan;
        private System.Windows.Forms.Label lblDonViQuanLy;
        private System.Windows.Forms.Label lblChucNang;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtMaLoaiTaiSan;
        private System.Windows.Forms.TextBox txtTenLoaiTaiSan;
        private System.Windows.Forms.TextBox txtChucNang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbbDonViQuanLy;
        private System.Windows.Forms.Panel pnlLuuHuy;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlRefreshThem;
    }
}