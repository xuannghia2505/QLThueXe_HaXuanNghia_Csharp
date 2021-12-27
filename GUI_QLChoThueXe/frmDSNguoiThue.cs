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
using GUI_QLChoThueXeDap;

namespace GUI_QLChoThueXe
{
    public partial class frmDSNguoiThue : Form
    {
        string ten, cmnd, maxe, phuongthuc, kieuxe;
        BUS_DSThue busDS = new BUS_DSThue();
        public frmDSNguoiThue()
        {
            InitializeComponent();
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

        private void btnThanhToan_MouseEnter(object sender, EventArgs e)
        {
            btnThanhToan.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\credit-card-icon.png");
            pboFinger.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\finger4.png");
        }

        private void btnThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btnThanhToan.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\payment.png");
            pboFinger.Image = System.Drawing.Image.FromFile(@"D:\ki1\C#\GUI_QLChoThueXe\static\images\finger3.png");
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

        private void frmDSNguoiThue_Load(object sender, EventArgs e)
        {
            dgvThueXeDap.DataSource = busDS.getDSThueXeDap();
            dgvThueXeMay.DataSource = busDS.getDSThueXeMay();
        }

        private void btnIndsnguoithue_Click(object sender, EventArgs e)
        {
            frmReportNguoiThue x = new frmReportNguoiThue();
            x.Show();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvThueXeDap.DataSource = busDS.getDSThueXeDap();
            dgvThueXeMay.DataSource = busDS.getDSThueXeMay();
            string tk = txtTK.Text.ToLower();
            for(int i = 0; i< dgvThueXeDap.Rows.Count -1; i++)
            {
                if (dgvThueXeDap.Rows[i].Cells[1].Value.ToString().ToLower().IndexOf(tk) != -1)
                {
                    for(int j = 0; j<=9; j++)
                    {
                        dgvThueXeDap.Rows[i].Cells[j].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                    }
                }
                
            }
            for (int i = 0; i < dgvThueXeMay.Rows.Count - 1; i++)
            {
                if (dgvThueXeMay.Rows[i].Cells[1].Value.ToString().ToLower().IndexOf(tk) != -1)
                {
                    for (int j = 0; j <= 11; j++)
                    {
                        dgvThueXeMay.Rows[i].Cells[j].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                    }
                }

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (ten!=null)
            {
                frmThanhToan f = new frmThanhToan(ten, cmnd, maxe, phuongthuc, kieuxe);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đối tượng thanh toán!","Thông báo");
            }
            
        }

        private void dgvThueXeDap_Click(object sender, EventArgs e)
        {
            dgvThueXeMay.DataSource = busDS.getDSThueXeMay();
            int i = dgvThueXeDap.CurrentRow.Index;
            ten = dgvThueXeDap[1, i].Value.ToString();
            cmnd = dgvThueXeDap[2, i].Value.ToString();
            maxe = dgvThueXeDap[3, i].Value.ToString();
            phuongthuc = dgvThueXeDap[4, i].Value.ToString();
            kieuxe = dgvThueXeDap[6, i].Value.ToString();
        }

        private void dgvThueXeMay_Click(object sender, EventArgs e)
        {
            dgvThueXeDap.DataSource = busDS.getDSThueXeDap();
            int i = dgvThueXeMay.CurrentRow.Index;
            ten = dgvThueXeMay[1, i].Value.ToString();
            cmnd = dgvThueXeMay[2, i].Value.ToString();
            maxe = dgvThueXeMay[3, i].Value.ToString();
            phuongthuc = dgvThueXeMay[4, i].Value.ToString();
            kieuxe = dgvThueXeMay[6, i].Value.ToString();
        }
    }
}
