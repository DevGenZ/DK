using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DK
{
    public partial class frmSql : Form
    {
        public frmSql()
        {
            InitializeComponent();

            txtMaLoaiTaiSan.Text = SqlSupportMethods.CreateUniqueID();

            pnlLuuHuy.Visible = false;

            fillData();
        }

        private void fillData()
        {
            dgvSql.DataSource = SqlSupportMethods.GetData(@"SELECT
                                                                MALOAITS AS [Mã tài sản],
                                                                TENLOAI AS [Tên loại],
                                                                DVIQLY AS [Đơn vị quản lý],
                                                                CHUCNANG AS [Chức năng],
                                                                GHICHU AS [Ghi chú] FROM LOAITAISAN");
        }

        private void cbbDonViQuanLy_DropDown(object sender, EventArgs e)
        {            
            cbbDonViQuanLy.DataSource = SqlSupportMethods.GetData(@"SELECT MADONVI FROM DONVI");
            cbbDonViQuanLy.ValueMember = "MADONVI";
            cbbDonViQuanLy.SelectedIndex = -1;
        }

        private void refresh()
        {
            txtMaLoaiTaiSan.Text = SqlSupportMethods.CreateUniqueID();
            txtTenLoaiTaiSan.Text = "";
            cbbDonViQuanLy.SelectedIndex = -1;
            txtChucNang.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblTitle.Focus();

            refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTitle.Focus();

            if (String.IsNullOrEmpty(txtMaLoaiTaiSan.Text.Trim()))
            {
                MessageBox.Show("Mã loại tài sản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(txtTenLoaiTaiSan.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên loại tài sản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbbDonViQuanLy.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO LOAITAISAN(MALOAITS, TENLOAI, DVIQLY, CHUCNANG, GHICHU)
                                    VALUES(@MALOAITS, @TENLOAI, @DVIQLY, @CHUCNANG, @GHICHU)";
                cmd.Parameters.AddWithValue("@MALOAITS", txtMaLoaiTaiSan.Text);
                cmd.Parameters.AddWithValue("@TENLOAI", txtTenLoaiTaiSan.Text);
                cmd.Parameters.AddWithValue("@DVIQLY", cbbDonViQuanLy.Text);
                cmd.Parameters.AddWithValue("@CHUCNANG", txtChucNang.Text);
                cmd.Parameters.AddWithValue("@GHICHU", txtGhiChu.Text);

                SqlSupportMethods.Execute(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            fillData();

            refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblTitle.Focus();

            foreach (DataGridViewRow row in dgvSql.SelectedRows)
            {
                SqlSupportMethods.Execute(@"DELETE FROM LOAITAISAN WHERE MALOAITS = '" + row.Cells[0].Value.ToString() + "'");
            }

            fillData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            pnlRefreshThem.Visible = false;
            pnlLuuHuy.Visible = true;
            lblTitle.Focus();

        }
    }
}
