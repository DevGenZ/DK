using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DK
{
    public partial class frmLogin : Form
    {
        private string username;
        private string password;
        public static int priority = 0;
        public static bool statusShow = false;

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.username = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = txtPassword.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblUsername.Focus();

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
                txtUsername.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txtPassword.Focus();
                return;
            }

            try
            {
                this.username = SqlSupportMethods.GetValue(@"SELECT TENDN FROM HETHONG WHERE TENDN = '" + username + "'");
                if (String.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.Compare(password, SqlSupportMethods.GetValue(@"SELECT MATKHAU FROM HETHONG WHERE TENDN = '" + username + "'")) != 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                priority = Int32.Parse(SqlSupportMethods.GetValue(@"SELECT QUYEN FROM HETHONG WHERE TENDN = '" + username + "'"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            frmMain main = new frmMain();            
            this.Hide();
            main.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();

            if (statusShow == false)
            {
                btnShow.BackgroundImage = Properties.Resources.icons8_eye_24;
                txtPassword.UseSystemPasswordChar = false;
                statusShow = true;
            }
            else
            {
                btnShow.BackgroundImage = Properties.Resources.icons8_hide_24;
                txtPassword.UseSystemPasswordChar = true;
                statusShow = false;
            }
        }
    }
}
