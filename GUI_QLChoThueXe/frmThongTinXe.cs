using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLChoThueXe;

namespace GUI_QLChoThueXe
{
    public partial class frmThongTinXe : Form
    {
        BUS_TTXe busTT = new BUS_TTXe();
        int sttXM = 1;
        int sttXD = 1;

        public frmThongTinXe()
        {
            InitializeComponent();
        }

        private void frmThongTinXe_Load(object sender, EventArgs e)
        {
            DataTable dtXD = busTT.getXeDap();
            DataTable dtXM = busTT.getXeMay();
            if (dtXD!=null)
            {
                int i = 0;
                foreach (DataRow row in dtXD.Rows)
                {
                    if (i == 1)
                    {
                        break;
                    }
                    MemoryStream ms = new MemoryStream((byte[])row["Anh"]);
                    pboXeDap.Image = new Bitmap(ms);
                    lblMaXeDap.Text = row["MaSoXe"].ToString();
                    if (row["TinhTrang"].ToString() == "1")
                    {
                        btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                    }
                    else
                    {
                        btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    }
                    i+=1;
                }
            }
            if (dtXM != null)
            {
                int j = 0;
                foreach (DataRow row in dtXM.Rows)
                {
                    if (j == 1)
                    {
                        break;
                    }
                    MemoryStream ms = new MemoryStream((byte[])row["Anh"]);
                    pboXeMay.Image = new Bitmap(ms);
                    lblMaXeMay.Text = row["MaSoXe"].ToString();
                    lblBienSo.Text = row["BienSo"].ToString();
                    lblLoaiXe.Text = row["LoaiXe"].ToString();
                    if (row["TinhTrang"].ToString() == "1")
                    {
                        btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                    }
                    else
                    {
                        btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    }
                    j += 1;
                }
            }
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

        private void btnNextXD_Click(object sender, EventArgs e)
        {
            DataTable dtXD = busTT.getXeDap();
            sttXD += 1;
            if (dtXD != null)
            {
                int i = 0;
                foreach (DataRow row in dtXD.Rows)
                {
                    if (i == sttXD)
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["Anh"]);
                        pboXeDap.Image = new Bitmap(ms);
                        lblMaXeDap.Text = row["MaSoXe"].ToString();
                        if (row["TinhTrang"].ToString() == "1")
                        {
                            btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                        }
                        else
                        {
                            btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        }
                        break;
                    }
                    
                    i += 1;
                }
            }
        }

        private void btnPrevXD_Click(object sender, EventArgs e)
        {
            DataTable dtXD = busTT.getXeDap();
            sttXD -= 1;
            if (dtXD != null)
            {
                int i = 0;
                foreach (DataRow row in dtXD.Rows)
                {
                    if (i == sttXD)
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["Anh"]);
                        pboXeDap.Image = new Bitmap(ms);
                        lblMaXeDap.Text = row["MaSoXe"].ToString();
                        if (row["TinhTrang"].ToString() == "1")
                        {
                            btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                        }
                        else
                        {
                            btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        }
                        break;
                    }

                    i += 1;
                }
            }
        }

        private void btnNextXM_Click(object sender, EventArgs e)
        {
            DataTable dtXM = busTT.getXeMay();
            sttXM += 1;
            if (dtXM != null)
            {
                int j = 0;
                foreach (DataRow row in dtXM.Rows)
                {
                    if (j == sttXM)
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["Anh"]);
                        pboXeMay.Image = new Bitmap(ms);
                        lblMaXeMay.Text = row["MaSoXe"].ToString();
                        lblBienSo.Text = row["BienSo"].ToString();
                        lblLoaiXe.Text = row["LoaiXe"].ToString();
                        if (row["TinhTrang"].ToString() == "1")
                        {
                            btnTinhTrangXM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                        }
                        else
                        {
                            btnTinhTrangXM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        }
                        break;
                    }
                    
                    j += 1;
                }
            }
        }

        private void btnPrevXM_Click(object sender, EventArgs e)
        {
            DataTable dtXM = busTT.getXeMay();
            sttXM -= 1;
            if (dtXM != null)
            {
                int j = 0;
                foreach (DataRow row in dtXM.Rows)
                {
                    if (j == sttXM)
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["Anh"]);
                        pboXeMay.Image = new Bitmap(ms);
                        lblMaXeMay.Text = row["MaSoXe"].ToString();
                        lblBienSo.Text = row["BienSo"].ToString();
                        lblLoaiXe.Text = row["LoaiXe"].ToString();
                        if (row["TinhTrang"].ToString() == "1")
                        {
                            btnTinhTrangXM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                        }
                        else
                        {
                            btnTinhTrangXM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        }
                        break;
                    }

                    j += 1;
                }
            }
        }

        private void btnTKXD_Click(object sender, EventArgs e)
        {
            DataTable dtXD = busTT.getXeDap();
            string tk = txtTKXD.Text.ToLower();
            if (dtXD != null)
            {
                foreach (DataRow row in dtXD.Rows)
                {
                    if (row["MaSoXe"].ToString().ToLower().Contains(tk))
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["Anh"]);
                        pboXeDap.Image = new Bitmap(ms);
                        lblMaXeDap.Text = row["MaSoXe"].ToString();
                        if (row["TinhTrang"].ToString() == "1")
                        {
                            btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                        }
                        else
                        {
                            btnTinhTrangXD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        }
                        break;
                    }
                }
            }
        }

        private void btnTKXM_Click(object sender, EventArgs e)
        {
            DataTable dtXM = busTT.getXeMay();
            string tk = txtTKXM.Text.ToLower();
            if (dtXM != null)
            {
                foreach (DataRow row in dtXM.Rows)
                {
                    if (row["MaSoXe"].ToString().ToLower().Contains(tk))
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["Anh"]);
                        pboXeMay.Image = new Bitmap(ms);
                        lblMaXeMay.Text = row["MaSoXe"].ToString();
                        lblBienSo.Text = row["BienSo"].ToString();
                        lblLoaiXe.Text = row["LoaiXe"].ToString();
                        if (row["TinhTrang"].ToString() == "1")
                        {
                            btnTinhTrangXM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                        }
                        else
                        {
                            btnTinhTrangXM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        }
                        break;
                    }
                }
            }
        }
    }
}
