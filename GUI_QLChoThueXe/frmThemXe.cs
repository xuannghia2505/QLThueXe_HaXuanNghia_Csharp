using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_QLChoThueXe.BUS;

namespace GUI_QLChoThueXe
{
    public partial class frmThemXe : Form
    {
        public frmThemXe()
        {
            InitializeComponent();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pbxAnh.Image = image;
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS_ThemXe busTX = new BUS_ThemXe(); //business logic layer class object to access functions.

            if (busTX.ThemXeDap(txtMaSoXe.Text, pbxAnh.Image))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void frmThemXe_Load(object sender, EventArgs e)
        {

        }
    }
}
