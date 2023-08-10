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
            this.dgv_Voucher = new System.Windows.Forms.DataGridView();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_VoucherPercent = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_ngaybatdau = new System.Windows.Forms.Label();
            this.lb_ngayketthuc = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_VoucherPercent = new System.Windows.Forms.TextBox();
            this.dtp_createDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lb_Search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Voucher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Voucher
            // 
            this.dgv_Voucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Voucher.Location = new System.Drawing.Point(12, 257);
            this.dgv_Voucher.Name = "dgv_Voucher";
            this.dgv_Voucher.RowHeadersWidth = 51;
            this.dgv_Voucher.RowTemplate.Height = 29;
            this.dgv_Voucher.Size = new System.Drawing.Size(784, 195);
            this.dgv_Voucher.TabIndex = 0;
            this.dgv_Voucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Voucher_CellClick);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(35, 39);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(56, 23);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Name";
            // 
            // lb_VoucherPercent
            // 
            this.lb_VoucherPercent.AutoSize = true;
            this.lb_VoucherPercent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_VoucherPercent.Location = new System.Drawing.Point(280, 155);
            this.lb_VoucherPercent.Name = "lb_VoucherPercent";
            this.lb_VoucherPercent.Size = new System.Drawing.Size(137, 23);
            this.lb_VoucherPercent.TabIndex = 2;
            this.lb_VoucherPercent.Text = "Voucher_Percent";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_status.Location = new System.Drawing.Point(280, 91);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(56, 23);
            this.lb_status.TabIndex = 3;
            this.lb_status.Text = "Status";
            // 
            // lb_ngaybatdau
            // 
            this.lb_ngaybatdau.AutoSize = true;
            this.lb_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ngaybatdau.Location = new System.Drawing.Point(35, 103);
            this.lb_ngaybatdau.Name = "lb_ngaybatdau";
            this.lb_ngaybatdau.Size = new System.Drawing.Size(103, 23);
            this.lb_ngaybatdau.TabIndex = 4;
            this.lb_ngaybatdau.Text = "Create_Date";
            // 
            // lb_ngayketthuc
            // 
            this.lb_ngayketthuc.AutoSize = true;
            this.lb_ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ngayketthuc.Location = new System.Drawing.Point(35, 173);
            this.lb_ngayketthuc.Name = "lb_ngayketthuc";
            this.lb_ngayketthuc.Size = new System.Drawing.Size(82, 23);
            this.lb_ngayketthuc.TabIndex = 5;
            this.lb_ngayketthuc.Text = "End_Date";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(46, 62);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(186, 30);
            this.txt_name.TabIndex = 6;
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_status.Location = new System.Drawing.Point(291, 114);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(186, 30);
            this.txt_status.TabIndex = 7;
            // 
            // txt_VoucherPercent
            // 
            this.txt_VoucherPercent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_VoucherPercent.Location = new System.Drawing.Point(291, 178);
            this.txt_VoucherPercent.Name = "txt_VoucherPercent";
            this.txt_VoucherPercent.Size = new System.Drawing.Size(186, 30);
            this.txt_VoucherPercent.TabIndex = 8;
            // 
            // dtp_createDate
            // 
            this.dtp_createDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_createDate.Location = new System.Drawing.Point(46, 134);
            this.dtp_createDate.Name = "dtp_createDate";
            this.dtp_createDate.Size = new System.Drawing.Size(186, 30);
            this.dtp_createDate.TabIndex = 9;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_endDate.Location = new System.Drawing.Point(46, 196);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(186, 30);
            this.dtp_endDate.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(542, 148);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 48);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(603, 202);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(98, 48);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(672, 148);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 48);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Search.Location = new System.Drawing.Point(505, 23);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(61, 23);
            this.lb_Search.TabIndex = 14;
            this.lb_Search.Text = "Search";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.Location = new System.Drawing.Point(523, 49);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(228, 30);
            this.txt_Search.TabIndex = 15;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // Frm_Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 464);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtp_endDate);
            this.Controls.Add(this.dtp_createDate);
            this.Controls.Add(this.txt_VoucherPercent);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_ngayketthuc);
            this.Controls.Add(this.lb_ngaybatdau);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_VoucherPercent);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.dgv_Voucher);
            this.Name = "Frm_Voucher";
            this.Text = "Frm_Voucher";
            this.Load += new System.EventHandler(this.Frm_Voucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Voucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_Voucher;
        private Label lb_name;
        private Label lb_VoucherPercent;
        private Label lb_status;
        private Label lb_ngaybatdau;
        private Label lb_ngayketthuc;
        private TextBox txt_name;
        private TextBox txt_status;
        private TextBox txt_VoucherPercent;
        private DateTimePicker dtp_createDate;
        private DateTimePicker dtp_endDate;
        private Button btn_add;
        private Button btn_Delete;
        private Button btn_Update;
        private Label lb_Search;
        private TextBox txt_Search;
    }
}