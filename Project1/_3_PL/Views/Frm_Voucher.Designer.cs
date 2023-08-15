namespace _3_PL.Views
{
    partial class Frm_Voucher
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
            dgv_Voucher = new DataGridView();
            lb_name = new Label();
            lb_VoucherPercent = new Label();
            lb_status = new Label();
            lb_ngaybatdau = new Label();
            lb_ngayketthuc = new Label();
            txt_name = new TextBox();
            txt_VoucherPercent = new TextBox();
            dtp_createDate = new DateTimePicker();
            dtp_endDate = new DateTimePicker();
            btn_add = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            lb_Search = new Label();
            txt_Search = new TextBox();
            txt_minprice = new TextBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgv_Voucher).BeginInit();
            SuspendLayout();
            // 
            // dgv_Voucher
            // 
            dgv_Voucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Voucher.Location = new Point(15, 321);
            dgv_Voucher.Margin = new Padding(4);
            dgv_Voucher.Name = "dgv_Voucher";
            dgv_Voucher.RowHeadersWidth = 51;
            dgv_Voucher.RowTemplate.Height = 29;
            dgv_Voucher.Size = new Size(980, 244);
            dgv_Voucher.TabIndex = 0;
            dgv_Voucher.CellClick += dgv_Voucher_CellClick;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_name.Location = new Point(44, 49);
            lb_name.Margin = new Padding(4, 0, 4, 0);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(69, 30);
            lb_name.TabIndex = 1;
            lb_name.Text = "Name";
            // 
            // lb_VoucherPercent
            // 
            lb_VoucherPercent.AutoSize = true;
            lb_VoucherPercent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_VoucherPercent.Location = new Point(350, 194);
            lb_VoucherPercent.Margin = new Padding(4, 0, 4, 0);
            lb_VoucherPercent.Name = "lb_VoucherPercent";
            lb_VoucherPercent.Size = new Size(167, 30);
            lb_VoucherPercent.TabIndex = 2;
            lb_VoucherPercent.Text = "Voucher_Percent";
            // 
            // lb_status
            // 
            lb_status.AutoSize = true;
            lb_status.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_status.Location = new Point(350, 114);
            lb_status.Margin = new Padding(4, 0, 4, 0);
            lb_status.Name = "lb_status";
            lb_status.Size = new Size(69, 30);
            lb_status.TabIndex = 3;
            lb_status.Text = "Status";
            // 
            // lb_ngaybatdau
            // 
            lb_ngaybatdau.AutoSize = true;
            lb_ngaybatdau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ngaybatdau.Location = new Point(44, 129);
            lb_ngaybatdau.Margin = new Padding(4, 0, 4, 0);
            lb_ngaybatdau.Name = "lb_ngaybatdau";
            lb_ngaybatdau.Size = new Size(126, 30);
            lb_ngaybatdau.TabIndex = 4;
            lb_ngaybatdau.Text = "Create_Date";
            // 
            // lb_ngayketthuc
            // 
            lb_ngayketthuc.AutoSize = true;
            lb_ngayketthuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ngayketthuc.Location = new Point(44, 216);
            lb_ngayketthuc.Margin = new Padding(4, 0, 4, 0);
            lb_ngayketthuc.Name = "lb_ngayketthuc";
            lb_ngayketthuc.Size = new Size(101, 30);
            lb_ngayketthuc.TabIndex = 5;
            lb_ngayketthuc.Text = "End_Date";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(58, 78);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(232, 35);
            txt_name.TabIndex = 6;
            // 
            // txt_VoucherPercent
            // 
            txt_VoucherPercent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_VoucherPercent.Location = new Point(364, 222);
            txt_VoucherPercent.Margin = new Padding(4);
            txt_VoucherPercent.Name = "txt_VoucherPercent";
            txt_VoucherPercent.Size = new Size(232, 35);
            txt_VoucherPercent.TabIndex = 8;
            // 
            // dtp_createDate
            // 
            dtp_createDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_createDate.Location = new Point(58, 168);
            dtp_createDate.Margin = new Padding(4);
            dtp_createDate.Name = "dtp_createDate";
            dtp_createDate.Size = new Size(232, 35);
            dtp_createDate.TabIndex = 9;
            // 
            // dtp_endDate
            // 
            dtp_endDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_endDate.Location = new Point(58, 245);
            dtp_endDate.Margin = new Padding(4);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(232, 35);
            dtp_endDate.TabIndex = 10;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Location = new Point(678, 185);
            btn_add.Margin = new Padding(4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(122, 60);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.Location = new Point(754, 252);
            btn_Delete.Margin = new Padding(4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(122, 60);
            btn_Delete.TabIndex = 12;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(840, 185);
            btn_Update.Margin = new Padding(4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(122, 60);
            btn_Update.TabIndex = 13;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // lb_Search
            // 
            lb_Search.AutoSize = true;
            lb_Search.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Search.Location = new Point(631, 29);
            lb_Search.Margin = new Padding(4, 0, 4, 0);
            lb_Search.Name = "lb_Search";
            lb_Search.Size = new Size(75, 30);
            lb_Search.TabIndex = 14;
            lb_Search.Text = "Search";
            // 
            // txt_Search
            // 
            txt_Search.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Search.Location = new Point(654, 61);
            txt_Search.Margin = new Padding(4);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(284, 35);
            txt_Search.TabIndex = 15;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // txt_minprice
            // 
            txt_minprice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_minprice.Location = new Point(364, 61);
            txt_minprice.Margin = new Padding(4);
            txt_minprice.Name = "txt_minprice";
            txt_minprice.Size = new Size(232, 35);
            txt_minprice.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(350, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 17;
            label1.Text = "giá áp dụng được";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(350, 162);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(108, 29);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Đã Dùng";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(524, 168);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(127, 29);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Chưa Dùng";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Frm_Voucher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 580);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(txt_minprice);
            Controls.Add(txt_Search);
            Controls.Add(lb_Search);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_add);
            Controls.Add(dtp_endDate);
            Controls.Add(dtp_createDate);
            Controls.Add(txt_VoucherPercent);
            Controls.Add(txt_name);
            Controls.Add(lb_ngayketthuc);
            Controls.Add(lb_ngaybatdau);
            Controls.Add(lb_status);
            Controls.Add(lb_VoucherPercent);
            Controls.Add(lb_name);
            Controls.Add(dgv_Voucher);
            Margin = new Padding(4);
            Name = "Frm_Voucher";
            Text = "Frm_Voucher";
            Load += Frm_Voucher_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Voucher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Voucher;
        private Label lb_name;
        private Label lb_VoucherPercent;
        private Label lb_status;
        private Label lb_ngaybatdau;
        private Label lb_ngayketthuc;
        private TextBox txt_name;
        private TextBox txt_VoucherPercent;
        private DateTimePicker dtp_createDate;
        private DateTimePicker dtp_endDate;
        private Button btn_add;
        private Button btn_Delete;
        private Button btn_Update;
        private Label lb_Search;
        private TextBox txt_Search;
        private TextBox txt_minprice;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}