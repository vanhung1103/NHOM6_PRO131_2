namespace _3_PL.Views
{
    partial class Frm_Customer
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
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.lb_Gioitinh = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_LsMua = new System.Windows.Forms.Label();
            this.lb_phanhoi = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_phanhoi = new System.Windows.Forms.TextBox();
            this.txt_lsmua = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lb_search = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.cb_voucher = new System.Windows.Forms.ComboBox();
            this.lb_voucher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Location = new System.Drawing.Point(12, 279);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.RowTemplate.Height = 29;
            this.dgv_customer.Size = new System.Drawing.Size(866, 277);
            this.dgv_customer.TabIndex = 0;
            this.dgv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellClick);
            // 
            // lb_Gioitinh
            // 
            this.lb_Gioitinh.AutoSize = true;
            this.lb_Gioitinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Gioitinh.Location = new System.Drawing.Point(16, 78);
            this.lb_Gioitinh.Name = "lb_Gioitinh";
            this.lb_Gioitinh.Size = new System.Drawing.Size(66, 23);
            this.lb_Gioitinh.TabIndex = 2;
            this.lb_Gioitinh.Text = "Gender";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(12, 21);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(56, 23);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Name";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_diachi.Location = new System.Drawing.Point(23, 138);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(70, 23);
            this.lb_diachi.TabIndex = 4;
            this.lb_diachi.Text = "Address";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sdt.Location = new System.Drawing.Point(23, 194);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(59, 23);
            this.lb_sdt.TabIndex = 5;
            this.lb_sdt.Text = "Phone";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(286, 21);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(51, 23);
            this.lb_email.TabIndex = 6;
            this.lb_email.Text = "Email";
            // 
            // lb_LsMua
            // 
            this.lb_LsMua.AutoSize = true;
            this.lb_LsMua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_LsMua.Location = new System.Drawing.Point(276, 78);
            this.lb_LsMua.Name = "lb_LsMua";
            this.lb_LsMua.Size = new System.Drawing.Size(132, 23);
            this.lb_LsMua.TabIndex = 7;
            this.lb_LsMua.Text = "PurchaseHistory";
            // 
            // lb_phanhoi
            // 
            this.lb_phanhoi.AutoSize = true;
            this.lb_phanhoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_phanhoi.Location = new System.Drawing.Point(286, 138);
            this.lb_phanhoi.Name = "lb_phanhoi";
            this.lb_phanhoi.Size = new System.Drawing.Size(81, 23);
            this.lb_phanhoi.TabIndex = 8;
            this.lb_phanhoi.Text = "Feedback";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_diachi.Location = new System.Drawing.Point(51, 161);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(203, 30);
            this.txt_diachi.TabIndex = 9;
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ten.Location = new System.Drawing.Point(40, 45);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(203, 30);
            this.txt_ten.TabIndex = 11;
            // 
            // txt_phanhoi
            // 
            this.txt_phanhoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phanhoi.Location = new System.Drawing.Point(305, 164);
            this.txt_phanhoi.Name = "txt_phanhoi";
            this.txt_phanhoi.Size = new System.Drawing.Size(203, 30);
            this.txt_phanhoi.TabIndex = 13;
            // 
            // txt_lsmua
            // 
            this.txt_lsmua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lsmua.Location = new System.Drawing.Point(305, 102);
            this.txt_lsmua.Name = "txt_lsmua";
            this.txt_lsmua.Size = new System.Drawing.Size(203, 30);
            this.txt_lsmua.TabIndex = 14;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(305, 45);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(203, 30);
            this.txt_email.TabIndex = 15;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sdt.Location = new System.Drawing.Point(52, 221);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(203, 30);
            this.txt_sdt.TabIndex = 16;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update.Location = new System.Drawing.Point(737, 147);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(104, 44);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(665, 212);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 44);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(598, 147);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 44);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(625, 56);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(203, 30);
            this.txt_search.TabIndex = 20;
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_search.Location = new System.Drawing.Point(598, 30);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(61, 23);
            this.lb_search.TabIndex = 21;
            this.lb_search.Text = "Search";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Location = new System.Drawing.Point(44, 102);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(203, 31);
            this.cb_gioitinh.TabIndex = 22;
            // 
            // cb_voucher
            // 
            this.cb_voucher.FormattingEnabled = true;
            this.cb_voucher.Location = new System.Drawing.Point(305, 228);
            this.cb_voucher.Name = "cb_voucher";
            this.cb_voucher.Size = new System.Drawing.Size(203, 28);
            this.cb_voucher.TabIndex = 23;
            // 
            // lb_voucher
            // 
            this.lb_voucher.AutoSize = true;
            this.lb_voucher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_voucher.Location = new System.Drawing.Point(286, 194);
            this.lb_voucher.Name = "lb_voucher";
            this.lb_voucher.Size = new System.Drawing.Size(73, 23);
            this.lb_voucher.TabIndex = 24;
            this.lb_voucher.Text = "Voucher";
            // 
            // Frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 568);
            this.Controls.Add(this.lb_voucher);
            this.Controls.Add(this.cb_voucher);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lsmua);
            this.Controls.Add(this.txt_phanhoi);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.lb_phanhoi);
            this.Controls.Add(this.lb_LsMua);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_diachi);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_Gioitinh);
            this.Controls.Add(this.dgv_customer);
            this.Name = "Frm_Customer";
            this.Text = "Frm_Customer";
            this.Load += new System.EventHandler(this.Frm_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_customer;
        private Label lb_Gioitinh;
        private Label lb_name;
        private Label lb_diachi;
        private Label lb_sdt;
        private Label lb_email;
        private Label lb_LsMua;
        private Label lb_phanhoi;
        private TextBox txt_diachi;
        private TextBox txt_ten;
        private TextBox txt_phanhoi;
        private TextBox txt_lsmua;
        private TextBox txt_email;
        private TextBox txt_sdt;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_add;
        private TextBox txt_search;
        private Label lb_search;
        private ComboBox cb_gioitinh;
        private ComboBox cb_voucher;
        private Label lb_voucher;
    }
}