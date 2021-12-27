using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLChoThueXe;


namespace GUI_QLChoThueXe
{
    public partial class frmLogin : Form
    {
        BUS_Login busLogin = new BUS_Login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btndn_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (busLogin.getUser(username, password))
            {

                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                this.Hide();
                var f = new frmQLChoThueXe();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void btnHuydn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
