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
using System.Globalization;

namespace GUI_QLChoThueXe
{
    public partial class frmThanhToan : Form
    {
        DateTime tgthue, tgtra;
        double gio;
        int kieuxe1, phut1;
        BUS_ThanhToan busTT = new BUS_ThanhToan();
        BUS_GiaThue busGT = new BUS_GiaThue();
        public frmThanhToan()
        {
            InitializeComponent();
        }
        public frmThanhToan(string ten, string cmnd, string maxe, string phuongthuc, string kieuxe)
        {
            InitializeComponent();
            txtTenNguoiThue.Text = ten;
            txtCMND.Text = cmnd;
            txtMaSoXe.Text = maxe;
            if(phuongthuc=="Ngắn hạn")
            {
                rdoNganHan.Checked = true;
            }
            else
            {
                rdoDaiHan.Checked = true;
            }
            string ngaythue = busTT.getThongTin(ten, cmnd, maxe);
            txtNgayThue.Text = ngaythue;
            DataTable dt = busGT.getGiaThue();
            string giamgia, tienthue;
            if (kieuxe == "0")
            {
                tienthue= txtTienThue.Text = dt.Rows[0]["TienThue"].ToString();
                giamgia = dt.Rows[0]["GiamGia24h"].ToString();
                kieuxe1 = 0;
            }
            else
            {
                tienthue= txtTienThue.Text = dt.Rows[1]["TienThue"].ToString();
                giamgia = dt.Rows[1]["GiamGia24h"].ToString();
                kieuxe1 = 1;
            }
            tgthue = DateTime.ParseExact(ngaythue, @"hh:mm tt - dd/MM/yyyy", new CultureInfo("en-US"));
            tgtra = DateTime.Now;
            double dif = (tgtra - tgthue).TotalHours;
            //MessageBox.Show(dif.ToString());
            string ngaytra = tgtra.ToString(@"hh:mm tt - dd/MM/yyyy", new CultureInfo("en-US"));
            double phut = dif % 1 * 60;
            phut1 = (int)phut;
            gio = dif / 1 - (dif % 1);
            //MessageBox.Show(phut1.ToString());
            txtGio.Text = gio.ToString();
            txtPhut.Text = phut1.ToString();
            txtNgayTra.Text = ngaytra;
            double tienthue1 = double.Parse(tienthue);
            double giamgia1 = double.Parse(giamgia);
            double tong;
            if(gio < 24)
            {
                tong = gio * tienthue1 + tienthue1 / 60 * phut1;
            }
            else
            {
                tong = gio* tienthue1 + tienthue1 / 60 * phut1 - (24 * tienthue1 * giamgia1 / 100);
               
            }
            Math.Round(tong);
            txtTongTien.Text = tong.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmQLChoThueXe f = new frmQLChoThueXe();
            f.Show();
            this.Hide();
        }

        private void btnGiaThue_Click(object sender, EventArgs e)
        {
            frmCaiDatGia f = new frmCaiDatGia();
            f.Show();
            this.Hide();
        }

        private void btnGiaThue_MouseEnter(object sender, EventArgs e)
        {
            btnGiaThue.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
        }

        private void btnGiaThue_MouseLeave(object sender, EventArgs e)
        {
            btnGiaThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmQLChoThueXe f = new frmQLChoThueXe();
            f.Show();
            this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            double sophut = gio * 60 + phut1;
            if (busTT.insertHoaDon(txtTenNguoiThue.Text, txtMaSoXe.Text, tgthue.ToString(), tgtra.ToString(), sophut.ToString(), txtTongTien.Text, kieuxe1)
                && busTT.updateDaThanhToan(txtTenNguoiThue.Text, txtCMND.Text, txtMaSoXe.Text))
            {
                MessageBox.Show("Thanh toán thành công!\n Cám ơn quý khách.", "Thông báo");
                this.Hide();
                var f = new frmDSNguoiThue();
                f.Show();
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công!","Thông báo");
            }
        }
    }
}
