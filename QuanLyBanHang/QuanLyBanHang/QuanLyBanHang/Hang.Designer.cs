﻿namespace QuanLyBanHang
{
    partial class frmHang
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
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.grbHang = new System.Windows.Forms.GroupBox();
            this.cmbTenNCCHang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.cmbTenLoaiHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.grbHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(701, 404);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 46);
            this.btnXem.TabIndex = 14;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(485, 404);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 46);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(263, 404);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 46);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(65, 404);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 46);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Location = new System.Drawing.Point(11, 481);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Size = new System.Drawing.Size(1023, 185);
            this.dgvDanhMuc.TabIndex = 10;
            this.dgvDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhMuc_CellMouseClick);
            // 
            // grbHang
            // 
            this.grbHang.Controls.Add(this.cmbTenNCCHang);
            this.grbHang.Controls.Add(this.label7);
            this.grbHang.Controls.Add(this.label8);
            this.grbHang.Controls.Add(this.txtDVT);
            this.grbHang.Controls.Add(this.cmbTenLoaiHang);
            this.grbHang.Controls.Add(this.label6);
            this.grbHang.Controls.Add(this.label4);
            this.grbHang.Controls.Add(this.txtDonGia);
            this.grbHang.Controls.Add(this.label5);
            this.grbHang.Controls.Add(this.txtSoLuong);
            this.grbHang.Controls.Add(this.label2);
            this.grbHang.Controls.Add(this.txtTensp);
            this.grbHang.Controls.Add(this.label3);
            this.grbHang.Controls.Add(this.txtMaHang);
            this.grbHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHang.Location = new System.Drawing.Point(16, 68);
            this.grbHang.Margin = new System.Windows.Forms.Padding(4);
            this.grbHang.Name = "grbHang";
            this.grbHang.Padding = new System.Windows.Forms.Padding(4);
            this.grbHang.Size = new System.Drawing.Size(1023, 208);
            this.grbHang.TabIndex = 17;
            this.grbHang.TabStop = false;
            this.grbHang.Text = "Hàng";
            // 
            // cmbTenNCCHang
            // 
            this.cmbTenNCCHang.FormattingEnabled = true;
            this.cmbTenNCCHang.Location = new System.Drawing.Point(825, 76);
            this.cmbTenNCCHang.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenNCCHang.Name = "cmbTenNCCHang";
            this.cmbTenNCCHang.Size = new System.Drawing.Size(160, 28);
            this.cmbTenNCCHang.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tên NCC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "DonViTinh";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(825, 132);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(160, 26);
            this.txtDVT.TabIndex = 36;
            // 
            // cmbTenLoaiHang
            // 
            this.cmbTenLoaiHang.FormattingEnabled = true;
            this.cmbTenLoaiHang.Location = new System.Drawing.Point(825, 39);
            this.cmbTenLoaiHang.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenLoaiHang.Name = "cmbTenLoaiHang";
            this.cmbTenLoaiHang.Size = new System.Drawing.Size(160, 28);
            this.cmbTenLoaiHang.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Loại Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(469, 132);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(132, 26);
            this.txtDonGia.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(469, 42);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(132, 26);
            this.txtSoLuong.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(172, 135);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(132, 26);
            this.txtTensp.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(172, 42);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(132, 26);
            this.txtMaHang.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbHang);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhMuc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHang";
            this.Text = "Hang";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.grbHang.ResumeLayout(false);
            this.grbHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.GroupBox grbHang;
        private System.Windows.Forms.ComboBox cmbTenNCCHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.ComboBox cmbTenLoaiHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Button button1;
    }
}