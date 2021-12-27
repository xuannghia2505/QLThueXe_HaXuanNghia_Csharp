namespace GUI_QLChoThueXe
{
    partial class frmThueXeDap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThueXeDap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnThue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNguoiThue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaSoXe = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPhuongThucThue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvThueXeDap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGiaThue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThueXeDap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Turquoise;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(22, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(59, 70);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnThue
            // 
            this.btnThue.BackColor = System.Drawing.Color.GreenYellow;
            this.btnThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThue.Image = ((System.Drawing.Image)(resources.GetObject("btnThue.Image")));
            this.btnThue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThue.Location = new System.Drawing.Point(309, 254);
            this.btnThue.Name = "btnThue";
            this.btnThue.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btnThue.Size = new System.Drawing.Size(171, 45);
            this.btnThue.TabIndex = 36;
            this.btnThue.Text = "BẮT ĐẦU THUÊ";
            this.btnThue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThue.UseVisualStyleBackColor = false;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Số CMND/CCCD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên người thuê:";
            // 
            // txtTenNguoiThue
            // 
            this.txtTenNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiThue.Location = new System.Drawing.Point(150, 40);
            this.txtTenNguoiThue.Name = "txtTenNguoiThue";
            this.txtTenNguoiThue.Size = new System.Drawing.Size(222, 23);
            this.txtTenNguoiThue.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 24.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(266, -25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 184);
            this.label1.TabIndex = 30;
            this.label1.Text = "Thuê Xe Đạp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaSoXe);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.btnAuto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboPhuongThucThue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenNguoiThue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 142);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // cboMaSoXe
            // 
            this.cboMaSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaSoXe.FormattingEnabled = true;
            this.cboMaSoXe.Location = new System.Drawing.Point(150, 88);
            this.cboMaSoXe.Name = "cboMaSoXe";
            this.cboMaSoXe.Size = new System.Drawing.Size(162, 24);
            this.cboMaSoXe.TabIndex = 42;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(545, 40);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(152, 23);
            this.txtCMND.TabIndex = 41;
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(318, 86);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(54, 29);
            this.btnAuto.TabIndex = 38;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã số xe:";
            // 
            // cboPhuongThucThue
            // 
            this.cboPhuongThucThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhuongThucThue.FormattingEnabled = true;
            this.cboPhuongThucThue.Location = new System.Drawing.Point(545, 88);
            this.cboPhuongThucThue.Name = "cboPhuongThucThue";
            this.cboPhuongThucThue.Size = new System.Drawing.Size(121, 24);
            this.cboPhuongThucThue.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Phương thức thuê:";
            // 
            // dgvThueXeDap
            // 
            this.dgvThueXeDap.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThueXeDap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThueXeDap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThueXeDap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvThueXeDap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThueXeDap.Location = new System.Drawing.Point(0, 315);
            this.dgvThueXeDap.Name = "dgvThueXeDap";
            this.dgvThueXeDap.Size = new System.Drawing.Size(796, 179);
            this.dgvThueXeDap.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoVaTen";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CMND";
            this.Column3.HeaderText = "CMND/CCCD";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaSoXe";
            this.Column4.HeaderText = "Mã số xe";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PTThue";
            this.Column5.HeaderText = "Phương thức thuê";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GioThue";
            this.Column7.HeaderText = "Giờ thuê";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayThue";
            this.Column6.HeaderText = "Ngày thuê";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "id";
            this.Column8.HeaderText = "id";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TGThue";
            this.Column9.HeaderText = "TGThue";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "KieuXe";
            this.Column10.HeaderText = "KieuXe";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // btnGiaThue
            // 
            this.btnGiaThue.BackColor = System.Drawing.Color.Turquoise;
            this.btnGiaThue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGiaThue.FlatAppearance.BorderSize = 0;
            this.btnGiaThue.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnGiaThue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGiaThue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnGiaThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaThue.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaThue.Image")));
            this.btnGiaThue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiaThue.Location = new System.Drawing.Point(87, 20);
            this.btnGiaThue.Name = "btnGiaThue";
            this.btnGiaThue.Size = new System.Drawing.Size(60, 70);
            this.btnGiaThue.TabIndex = 40;
            this.btnGiaThue.Text = "Giá thuê";
            this.btnGiaThue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaThue.UseVisualStyleBackColor = false;
            this.btnGiaThue.Click += new System.EventHandler(this.btnGiaThue_Click);
            this.btnGiaThue.MouseEnter += new System.EventHandler(this.btnGiaThue_MouseEnter);
            this.btnGiaThue.MouseLeave += new System.EventHandler(this.btnGiaThue_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 67);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // frmThueXeDap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(796, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiaThue);
            this.Controls.Add(this.dgvThueXeDap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Name = "frmThueXeDap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThueXeDap";
            this.Load += new System.EventHandler(this.frmThueXeDap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThueXeDap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNguoiThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPhuongThucThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvThueXeDap;
        private System.Windows.Forms.Button btnGiaThue;
        private System.Windows.Forms.ComboBox cboMaSoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}