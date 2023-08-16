namespace _3_PL.Views
{
    partial class Frm_Billl
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
            label2 = new Label();
            label1 = new Label();
            txt_search = new TextBox();
            txt_mahd = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            dtg_show = new DataGridView();
            label6 = new Label();
            txt_discount = new TextBox();
            label7 = new Label();
            label9 = new Label();
            cbx_customer = new ComboBox();
            dtp_createdate = new DateTimePicker();
            cbx_user = new ComboBox();
            label10 = new Label();
            rdb_dathanhtoan = new RadioButton();
            rdb_chuathanhtoan = new RadioButton();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 9);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 26;
            label2.Text = "Search theo mã bill";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 87);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 25;
            label1.Text = "Mã Hóa Đơn";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(268, 38);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(391, 31);
            txt_search.TabIndex = 24;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // txt_mahd
            // 
            txt_mahd.Location = new Point(79, 144);
            txt_mahd.Name = "txt_mahd";
            txt_mahd.Size = new Size(251, 31);
            txt_mahd.TabIndex = 23;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(1227, 190);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(133, 49);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(1227, 112);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(133, 49);
            btn_update.TabIndex = 21;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(1227, 29);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(133, 49);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(12, 379);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 62;
            dtg_show.RowTemplate.Height = 33;
            dtg_show.Size = new Size(1372, 309);
            dtg_show.TabIndex = 19;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 202);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 34;
            label6.Text = "GIảm giá";
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(76, 235);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(251, 31);
            txt_discount.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(620, 87);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 36;
            label7.Text = "Ngày tạo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 280);
            label9.Name = "label9";
            label9.Size = new Size(134, 25);
            label9.TabIndex = 38;
            label9.Text = "Tên khách hàng";
            // 
            // cbx_customer
            // 
            cbx_customer.FormattingEnabled = true;
            cbx_customer.Location = new Point(76, 328);
            cbx_customer.Name = "cbx_customer";
            cbx_customer.Size = new Size(251, 33);
            cbx_customer.TabIndex = 39;
            // 
            // dtp_createdate
            // 
            dtp_createdate.Location = new Point(704, 130);
            dtp_createdate.Name = "dtp_createdate";
            dtp_createdate.Size = new Size(300, 31);
            dtp_createdate.TabIndex = 40;
            // 
            // cbx_user
            // 
            cbx_user.FormattingEnabled = true;
            cbx_user.Location = new Point(713, 308);
            cbx_user.Name = "cbx_user";
            cbx_user.Size = new Size(306, 33);
            cbx_user.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(636, 280);
            label10.Name = "label10";
            label10.Size = new Size(89, 25);
            label10.TabIndex = 43;
            label10.Text = "username";
            // 
            // rdb_dathanhtoan
            // 
            rdb_dathanhtoan.AutoSize = true;
            rdb_dathanhtoan.Location = new Point(684, 237);
            rdb_dathanhtoan.Name = "rdb_dathanhtoan";
            rdb_dathanhtoan.Size = new Size(150, 29);
            rdb_dathanhtoan.TabIndex = 44;
            rdb_dathanhtoan.TabStop = true;
            rdb_dathanhtoan.Text = "Đã thanh toán";
            rdb_dathanhtoan.UseVisualStyleBackColor = true;
            // 
            // rdb_chuathanhtoan
            // 
            rdb_chuathanhtoan.AutoSize = true;
            rdb_chuathanhtoan.Location = new Point(881, 237);
            rdb_chuathanhtoan.Name = "rdb_chuathanhtoan";
            rdb_chuathanhtoan.Size = new Size(169, 29);
            rdb_chuathanhtoan.TabIndex = 45;
            rdb_chuathanhtoan.TabStop = true;
            rdb_chuathanhtoan.Text = "Chưa thanh toán";
            rdb_chuathanhtoan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(620, 190);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 46;
            label3.Text = "Trạng Thái";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(773, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 31);
            textBox1.TabIndex = 47;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(704, 9);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 48;
            label4.Text = "Search theo Sđt";
            // 
            // button1
            // 
            button1.Location = new Point(1227, 292);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 49;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_Billl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 695);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(rdb_chuathanhtoan);
            Controls.Add(rdb_dathanhtoan);
            Controls.Add(label10);
            Controls.Add(cbx_user);
            Controls.Add(dtp_createdate);
            Controls.Add(cbx_customer);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_discount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_search);
            Controls.Add(txt_mahd);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dtg_show);
            Name = "Frm_Billl";
            Text = "Frm_Billl";
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_search;
        private TextBox txt_mahd;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private DataGridView dtg_show;
        private Label label6;
        private TextBox txt_discount;
        private Label label7;
        private Label label9;
        private ComboBox cbx_customer;
        private DateTimePicker dtp_createdate;
        private ComboBox cbx_user;
        private Label label10;
        private RadioButton rdb_dathanhtoan;
        private RadioButton rdb_chuathanhtoan;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
    }
}