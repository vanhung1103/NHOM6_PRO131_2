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
            textBox1 = new TextBox();
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
            dtg_sanpham.Size = new Size(924, 287);
            dtg_sanpham.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_sanpham);
            groupBox1.Location = new Point(12, 352);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(975, 417);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm Mua";
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
            // 
            // dtg_giohang
            // 
            dtg_giohang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_giohang.Location = new Point(6, 62);
            dtg_giohang.Name = "dtg_giohang";
            dtg_giohang.RowHeadersWidth = 62;
            dtg_giohang.Size = new Size(568, 244);
            dtg_giohang.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtg_hoadoncho);
            groupBox3.Location = new Point(656, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(459, 334);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa Đơn Chờ";
            // 
            // dtg_hoadoncho
            // 
            dtg_hoadoncho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hoadoncho.Location = new Point(15, 62);
            dtg_hoadoncho.Name = "dtg_hoadoncho";
            dtg_hoadoncho.RowHeadersWidth = 62;
            dtg_hoadoncho.Size = new Size(438, 241);
            dtg_hoadoncho.TabIndex = 1;
            // 
            // groupBox4
            // 
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
            groupBox4.Controls.Add(textBox1);
            groupBox4.Location = new Point(1136, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 649);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thanh toán";
            // 
            // btn_in
            // 
            btn_in.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_in.IconColor = Color.Black;
            btn_in.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_in.IconSize = 16;
            btn_in.Location = new Point(169, 562);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(125, 42);
            btn_in.TabIndex = 14;
            btn_in.Text = "In";
            btn_in.UseVisualStyleBackColor = true;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_thanhtoan.IconColor = Color.Black;
            btn_thanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_thanhtoan.IconSize = 16;
            btn_thanhtoan.Location = new Point(19, 562);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(125, 42);
            btn_thanhtoan.TabIndex = 13;
            btn_thanhtoan.Text = "Thanh Toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 429);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 10;
            label5.Text = "Khách Thanh Toán";
            // 
            // txt_khachthanhtoan
            // 
            txt_khachthanhtoan.Location = new Point(29, 468);
            txt_khachthanhtoan.Name = "txt_khachthanhtoan";
            txt_khachthanhtoan.Size = new Size(254, 31);
            txt_khachthanhtoan.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 512);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 8;
            label7.Text = "Tiền Hoàn Lại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 355);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 8;
            label4.Text = "Khách Cần Trả";
            // 
            // txt_khachtra
            // 
            txt_khachtra.Location = new Point(29, 383);
            txt_khachtra.Name = "txt_khachtra";
            txt_khachtra.Size = new Size(254, 31);
            txt_khachtra.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 266);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 6;
            label3.Text = "Tổng Tiền";
            // 
            // txt_tongtien
            // 
            txt_tongtien.Location = new Point(29, 306);
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(254, 31);
            txt_tongtien.TabIndex = 5;
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_taohoadon.IconColor = Color.Black;
            btn_taohoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_taohoadon.IconSize = 16;
            btn_taohoadon.Location = new Point(86, 205);
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
            label2.Location = new Point(8, 115);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 3;
            label2.Text = "Ngày Tạo";
            // 
            // dtp_createdate
            // 
            dtp_createdate.Location = new Point(29, 143);
            dtp_createdate.Name = "dtp_createdate";
            dtp_createdate.Size = new Size(254, 31);
            dtp_createdate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên Khách Hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 31);
            textBox1.TabIndex = 0;
            // 
            // Frm_Pay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1448, 786);
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
        private TextBox textBox1;
    }
}