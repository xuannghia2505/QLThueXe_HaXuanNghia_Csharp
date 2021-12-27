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
    public partial class frmCaiDatGia : Form
    {
        BUS_GiaThue busGT = new BUS_GiaThue();
        public frmCaiDatGia()
        {
            InitializeComponent();
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmQLChoThueXe f = new frmQLChoThueXe();
            f.Show();
            this.Hide();
        }

        private void frmCaiDatGia_Load(object sender, EventArgs e)
        {
            string[] GiamGia = new string[11] {"0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50" };
            for (int i = 0; i < GiamGia.Length; i++)
            {
                btnGiamXeDap.Items.Add(GiamGia[i]);
                btnGiamXeMay.Items.Add(GiamGia[i]);
            }
            DataTable dt = busGT.getGiaThue();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (i == 0)
                    {
                        btnGiaXeDap.Text = row["TienThue"].ToString();
                        btnGiamXeDap.Text = row["GiamGia24h"].ToString();
                    }
                    else
                    {
                        btnGiaXeMay.Text = row["TienThue"].ToString();
                        btnGiamXeMay.Text = row["GiamGia24h"].ToString();
                    }

                    i += 1;
                }
            }
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            if(busGT.updateGiaThue("0", btnGiaXeDap.Text, int.Parse(btnGiamXeDap.Text))==true && busGT.updateGiaThue("1", btnGiaXeMay.Text, int.Parse(btnGiamXeMay.Text))==true)
            {
                MessageBox.Show("Đã cập nhật thành công!","Thông báo");
            }
        }
    }
}
