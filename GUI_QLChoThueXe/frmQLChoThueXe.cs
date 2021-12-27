using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLChoThueXe
{
    public partial class frmQLChoThueXe : Form
    {
        public frmQLChoThueXe()
        {
            InitializeComponent();
        }
        #region Hover
        private void btnThueXeDap_MouseEnter(object sender, EventArgs e)
        {
            btnThueXeDap.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\bicycle2.png");
        }

        private void btnThueXeDap_MouseLeave(object sender, EventArgs e)
        {
            btnThueXeDap.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\bicycle.png");
        }

        private void btnGiaThue_MouseEnter(object sender, EventArgs e)
        {
            btnGiaThue.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\editprice2.png");
        }

        private void btnGiaThue_MouseLeave(object sender, EventArgs e)
        {
            btnGiaThue.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\editprice.png");
        }

        private void btnThanhToan_MouseEnter(object sender, EventArgs e)
        {
            btnThanhToan.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\money2.png");
        }

        private void btnThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btnThanhToan.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\money.png");
        }

        private void btnThongTinXe_MouseEnter(object sender, EventArgs e)
        {
            btnThongTinXe.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\info2.png");
        }

        private void btnThongTinXe_MouseLeave(object sender, EventArgs e)
        {
            btnThongTinXe.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\info.png");
        }

        private void btnThueXeMay_MouseEnter(object sender, EventArgs e)
        {
            btnThueXeMay.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\motor2.png");
        }

        private void btnThueXeMay_MouseLeave(object sender, EventArgs e)
        {
            btnThueXeMay.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\motor.png");
        }
        #endregion

        #region Button Click
        private void btnThueXeDap_Click(object sender, EventArgs e)
        {
            frmThueXeDap f = new frmThueXeDap();
            f.Show();
            this.Hide();
        }

        private void btnThueXeMay_Click(object sender, EventArgs e)
        {
            frmThueXeMay f = new frmThueXeMay();
            f.Show();
            this.Hide();
        }

        private void btnThongTinXe_Click(object sender, EventArgs e)
        {
            frmThongTinXe f = new frmThongTinXe();
            f.Show();
            this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmDSNguoiThue f = new frmDSNguoiThue();
            f.Show();
            this.Hide();
        }

        private void btnGiaThue_Click(object sender, EventArgs e)
        {
            frmCaiDatGia f = new frmCaiDatGia();
            f.Show();
            this.Hide();
        }
        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            var f = new frmLogin();
            f.Show();
        }
    }
}
