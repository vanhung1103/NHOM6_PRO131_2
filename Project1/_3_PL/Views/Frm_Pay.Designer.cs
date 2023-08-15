namespace _3_PL.Views
{
    partial class Frm_Pay
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
            dtg_sanpham = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dtg_giohang = new DataGridView();
            groupBox3 = new GroupBox();
            dtg_hoadoncho = new DataGridView();
            groupBox4 = new GroupBox();
            btn_timvoucher = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txt_searchvoucher = new TextBox();
            txt_giamgia = new TextBox();
            lb_hoantien = new Label();
            lb_tienthua = new Label();
            cbx_user = new ComboBox();
            label8 = new Label();
            cbx_customer = new ComboBox();
            label6 = new Label();
            btn_in = new FontAwesome.Sharp.IconButton();
            btn_thanhtoan = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            txt_khachthanhtoan = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txt_khachtra = new TextBox();
            label3 = new Label();
            txt_tongtien = new TextBox();
            btn_taohoadon = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            dtp_createdate = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_giohang).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadoncho).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_sanpham
            // 
            dtg_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sanpham.Location = new Point(12, 113);
            dtg_sanpham.Name = "dtg_sanpham";
            dtg_sanpham.RowHeadersWidth = 62;
            dtg_sanpham.Size = new Size(1207, 287);
            dtg_sanpham.TabIndex = 1;
            dtg_sanpham.CellContentClick += dtg_sanpham_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_sanpham);
            groupBox1.Location = new Point(12, 352);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1225, 417);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm Mua";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_giohang);
            groupBox2.Location = new Point(18, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(597, 334);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ Hàng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dtg_giohang
            // 
            dtg_giohang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_giohang.Location = new Point(6, 62);
            dtg_giohang.Name = "dtg_giohang";
            dtg_giohang.RowHeadersWidth = 62;
            dtg_giohang.Size = new Size(568, 244);
            dtg_giohang.TabIndex = 1;
            dtg_giohang.CellClick += dtg_giohang_CellClick;
            dtg_giohang.CellContentClick += dtg_giohang_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtg_hoadoncho);
            groupBox3.Location = new Point(621, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(610, 334);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa Đơn Chờ";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dtg_hoadoncho
            // 
            dtg_hoadoncho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hoadoncho.Location = new Point(15, 62);
            dtg_hoadoncho.Name = "dtg_hoadoncho";
            dtg_hoadoncho.RowHeadersWidth = 62;
            dtg_hoadoncho.Size = new Size(589, 241);
            dtg_hoadoncho.TabIndex = 1;
            dtg_hoadoncho.CellClick += dtg_hoadoncho_CellClick;
            dtg_hoadoncho.CellContentClick += dtg_hoadoncho_CellContentClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_timvoucher);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txt_searchvoucher);
            groupBox4.Controls.Add(txt_giamgia);
            groupBox4.Controls.Add(lb_hoantien);
            groupBox4.Controls.Add(lb_tienthua);
            groupBox4.Controls.Add(cbx_user);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(cbx_customer);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(btn_in);
            groupBox4.Controls.Add(btn_thanhtoan);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(txt_khachthanhtoan);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(txt_khachtra);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txt_tongtien);
            groupBox4.Controls.Add(btn_taohoadon);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(dtp_createdate);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(1243, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 749);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thanh toán";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // btn_timvoucher
            // 
            btn_timvoucher.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_timvoucher.IconColor = Color.Black;
            btn_timvoucher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_timvoucher.IconSize = 16;
            btn_timvoucher.Location = new Point(107, 331);
            btn_timvoucher.Name = "btn_timvoucher";
            btn_timvoucher.Size = new Size(94, 38);
            btn_timvoucher.TabIndex = 29;
            btn_timvoucher.Text = "Tìm";
            btn_timvoucher.UseVisualStyleBackColor = true;
            btn_timvoucher.Click += btn_timvoucher_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 265);
            label9.Name = "label9";
            label9.Size = new Size(109, 25);
            label9.TabIndex = 28;
            label9.Text = "Tìm voucher";
            // 
            // txt_searchvoucher
            // 
            txt_searchvoucher.Location = new Point(29, 293);
            txt_searchvoucher.Name = "txt_searchvoucher";
            txt_searchvoucher.Size = new Size(254, 31);
            txt_searchvoucher.TabIndex = 25;
            txt_searchvoucher.TextChanged += txt_searchvoucher_TextChanged;
            // 
            // txt_giamgia
            // 
            txt_giamgia.Location = new Point(29, 391);
            txt_giamgia.Name = "txt_giamgia";
            txt_giamgia.Size = new Size(254, 31);
            txt_giamgia.TabIndex = 24;
            // 
            // lb_hoantien
            // 
            lb_hoantien.AutoSize = true;
            lb_hoantien.Location = new Point(158, 673);
            lb_hoantien.Name = "lb_hoantien";
            lb_hoantien.Size = new Size(118, 25);
            lb_hoantien.TabIndex = 23;
            lb_hoantien.Text = "Tiền Hoàn Lại";
            lb_hoantien.TextChanged += lb_hoantien_TextChanged;
            lb_hoantien.Click += lb_hoantien_Click;
            // 
            // lb_tienthua
            // 
            lb_tienthua.AutoSize = true;
            lb_tienthua.Location = new Point(154, 651);
            lb_tienthua.Name = "lb_tienthua";
            lb_tienthua.Size = new Size(0, 25);
            lb_tienthua.TabIndex = 22;
            lb_tienthua.Click += lb_tienthua_Click;
            // 
            // cbx_user
            // 
            cbx_user.FormattingEnabled = true;
            cbx_user.Location = new Point(29, 119);
            cbx_user.Name = "cbx_user";
            cbx_user.Size = new Size(254, 33);
            cbx_user.TabIndex = 21;
            cbx_user.SelectedIndexChanged += cbx_user_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 363);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 19;
            label8.Text = "Giảm giá";
            label8.Click += label8_Click;
            // 
            // cbx_customer
            // 
            cbx_customer.FormattingEnabled = true;
            cbx_customer.Location = new Point(29, 55);
            cbx_customer.Name = "cbx_customer";
            cbx_customer.Size = new Size(254, 33);
            cbx_customer.TabIndex = 17;
            cbx_customer.SelectedIndexChanged += cbx_customer_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 91);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 16;
            label6.Text = "Tên nhân viên ca này";
            label6.Click += label6_Click;
            // 
            // btn_in
            // 
            btn_in.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_in.IconColor = Color.Black;
            btn_in.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_in.IconSize = 16;
            btn_in.Location = new Point(158, 701);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(125, 42);
            btn_in.TabIndex = 14;
            btn_in.Text = "In";
            btn_in.UseVisualStyleBackColor = true;
            btn_in.Click += btn_in_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_thanhtoan.IconColor = Color.Black;
            btn_thanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_thanhtoan.IconSize = 16;
            btn_thanhtoan.Location = new Point(15, 701);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(125, 42);
            btn_thanhtoan.TabIndex = 13;
            btn_thanhtoan.Text = "Thanh Toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 597);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 10;
            label5.Text = "Khách Thanh Toán";
            label5.Click += label5_Click;
            // 
            // txt_khachthanhtoan
            // 
            txt_khachthanhtoan.Location = new Point(29, 639);
            txt_khachthanhtoan.Name = "txt_khachthanhtoan";
            txt_khachthanhtoan.Size = new Size(254, 31);
            txt_khachthanhtoan.TabIndex = 9;
            txt_khachthanhtoan.TextChanged += txt_khachthanhtoan_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 673);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 8;
            label7.Text = "Tiền Hoàn Lại";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 499);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 8;
            label4.Text = "Khách Cần Trả";
            label4.Click += label4_Click;
            // 
            // txt_khachtra
            // 
            txt_khachtra.Location = new Point(29, 546);
            txt_khachtra.Name = "txt_khachtra";
            txt_khachtra.Size = new Size(254, 31);
            txt_khachtra.TabIndex = 7;
            txt_khachtra.TextChanged += txt_khachtra_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 425);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 6;
            label3.Text = "Tổng Tiền";
            label3.Click += label3_Click;
            // 
            // txt_tongtien
            // 
            txt_tongtien.Location = new Point(29, 465);
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(254, 31);
            txt_tongtien.TabIndex = 5;
            txt_tongtien.TextChanged += txt_tongtien_TextChanged;
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_taohoadon.IconColor = Color.Black;
            btn_taohoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_taohoadon.IconSize = 16;
            btn_taohoadon.Location = new Point(87, 220);
            btn_taohoadon.Name = "btn_taohoadon";
            btn_taohoadon.Size = new Size(125, 42);
            btn_taohoadon.TabIndex = 4;
            btn_taohoadon.Text = "Tạo hóa Đơn";
            btn_taohoadon.UseVisualStyleBackColor = true;
            btn_taohoadon.Click += btn_taohoadon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 155);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 3;
            label2.Text = "Ngày Tạo";
            label2.Click += label2_Click;
            // 
            // dtp_createdate
            // 
            dtp_createdate.Location = new Point(29, 183);
            dtp_createdate.Name = "dtp_createdate";
            dtp_createdate.Size = new Size(254, 31);
            dtp_createdate.TabIndex = 2;
            dtp_createdate.ValueChanged += dtp_createdate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên Khách Hàng";
            label1.Click += label1_Click;
            // 
            // Frm_Pay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 786);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Frm_Pay";
            Text = "Frm_Bill";
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_giohang).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_hoadoncho).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_sanpham;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtg_giohang;
        private GroupBox groupBox3;
        private DataGridView dtg_hoadoncho;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btn_in;
        private FontAwesome.Sharp.IconButton btn_thanhtoan;
        private Label label5;
        private TextBox txt_khachthanhtoan;
        private Label label7;
        private Label label4;
        private TextBox txt_khachtra;
        private Label label3;
        private TextBox txt_tongtien;
        private FontAwesome.Sharp.IconButton btn_taohoadon;
        private Label label2;
        private DateTimePicker dtp_createdate;
        private Label label1;
        private Label label6;
        private ComboBox cbx_customer;
        private Label label8;
        private ComboBox cbx_user;
        private Label lb_tienthua;
        private Label lb_hoantien;
        private TextBox txt_searchvoucher;
        private TextBox txt_giamgia;
        private Label label9;
        private FontAwesome.Sharp.IconButton btn_timvoucher;
    }
}