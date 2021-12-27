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
    public partial class frmThueXeDap : Form
    {
        BUS_ThueXe busTX = new BUS_ThueXe();
        public frmThueXeDap()
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

        private void frmThueXeDap_Load(object sender, EventArgs e)
        {
            dgvThueXeDap.DataSource = busTX.getDSThueXeDap();
            DataTable dt = busTX.getMaXeDapTonTai();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cboMaSoXe.Items.Add(row["MaSoXe"].ToString());
                    }
                }
            }
            string[] PTThue = new string[2] { "Ngắn hạn", "Dài hạn" };
            for (int i = 0; i < PTThue.Length; i++)
            {
                cboPhuongThucThue.Items.Add(PTThue[i]);
            }
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

        private void btnThue_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboPhuongThucThue.Text);
            //MessageBox.Show(cboPhuongThucThue.SelectedItem.ToString());
            if (txtTenNguoiThue.Text != "" && txtCMND.Text != "" && cboMaSoXe.Text != "" && cboPhuongThucThue.Text != "")
            {
                if (busTX.insertKhachThueXe(txtTenNguoiThue.Text, txtCMND.Text, cboMaSoXe.SelectedItem.ToString(), cboPhuongThucThue.SelectedItem.ToString(),0))
                {
                    MessageBox.Show("Thêm khách thành công.", "Thông báo");
                    dgvThueXeDap.DataSource = busTX.getDSThueXeDap();
                }
                else
                {
                    MessageBox.Show("Thêm khách thất bại!", "Thông báo");
                    txtTenNguoiThue.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thêm đầy đủ thông tin khách thuê xe!", "Thông báo");
                txtTenNguoiThue.Focus();
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (cboMaSoXe.Items.Count >= 1)
            {
                Random rnd = new Random();
                int random = rnd.Next(0, cboMaSoXe.Items.Count);
                cboMaSoXe.SelectedItem = cboMaSoXe.Items[random];
            }
        }
    }
}
