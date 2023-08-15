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
            dgv_customer = new DataGridView();
            lb_Gioitinh = new Label();
            lb_name = new Label();
            lb_diachi = new Label();
            lb_sdt = new Label();
            lb_email = new Label();
            lb_LsMua = new Label();
            lb_phanhoi = new Label();
            txt_diachi = new TextBox();
            txt_ten = new TextBox();
            txt_phanhoi = new TextBox();
            txt_lsmua = new TextBox();
            txt_email = new TextBox();
            txt_sdt = new TextBox();
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            txt_search = new TextBox();
            lb_search = new Label();
            cb_gioitinh = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // dgv_customer
            // 
            dgv_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Location = new Point(15, 349);
            dgv_customer.Margin = new Padding(4, 4, 4, 4);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowHeadersWidth = 51;
            dgv_customer.RowTemplate.Height = 29;
            dgv_customer.Size = new Size(1082, 346);
            dgv_customer.TabIndex = 0;
            dgv_customer.CellClick += dgv_customer_CellClick;
            // 
            // lb_Gioitinh
            // 
            lb_Gioitinh.AutoSize = true;
            lb_Gioitinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Gioitinh.Location = new Point(20, 98);
            lb_Gioitinh.Margin = new Padding(4, 0, 4, 0);
            lb_Gioitinh.Name = "lb_Gioitinh";
            lb_Gioitinh.Size = new Size(80, 30);
            lb_Gioitinh.TabIndex = 2;
            lb_Gioitinh.Text = "Gender";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_name.Location = new Point(15, 26);
            lb_name.Margin = new Padding(4, 0, 4, 0);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(69, 30);
            lb_name.TabIndex = 3;
            lb_name.Text = "Name";
            // 
            // lb_diachi
            // 
            lb_diachi.AutoSize = true;
            lb_diachi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_diachi.Location = new Point(29, 172);
            lb_diachi.Margin = new Padding(4, 0, 4, 0);
            lb_diachi.Name = "lb_diachi";
            lb_diachi.Size = new Size(87, 30);
            lb_diachi.TabIndex = 4;
            lb_diachi.Text = "Address";
            // 
            // lb_sdt
            // 
            lb_sdt.AutoSize = true;
            lb_sdt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_sdt.Location = new Point(29, 242);
            lb_sdt.Margin = new Padding(4, 0, 4, 0);
            lb_sdt.Name = "lb_sdt";
            lb_sdt.Size = new Size(72, 30);
            lb_sdt.TabIndex = 5;
            lb_sdt.Text = "Phone";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_email.Location = new Point(358, 26);
            lb_email.Margin = new Padding(4, 0, 4, 0);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(63, 30);
            lb_email.TabIndex = 6;
            lb_email.Text = "Email";
            // 
            // lb_LsMua
            // 
            lb_LsMua.AutoSize = true;
            lb_LsMua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_LsMua.Location = new Point(345, 98);
            lb_LsMua.Margin = new Padding(4, 0, 4, 0);
            lb_LsMua.Name = "lb_LsMua";
            lb_LsMua.Size = new Size(162, 30);
            lb_LsMua.TabIndex = 7;
            lb_LsMua.Text = "PurchaseHistory";
            // 
            // lb_phanhoi
            // 
            lb_phanhoi.AutoSize = true;
            lb_phanhoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_phanhoi.Location = new Point(358, 172);
            lb_phanhoi.Margin = new Padding(4, 0, 4, 0);
            lb_phanhoi.Name = "lb_phanhoi";
            lb_phanhoi.Size = new Size(100, 30);
            lb_phanhoi.TabIndex = 8;
            lb_phanhoi.Text = "Feedback";
            // 
            // txt_diachi
            // 
            txt_diachi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_diachi.Location = new Point(64, 201);
            txt_diachi.Margin = new Padding(4, 4, 4, 4);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(253, 35);
            txt_diachi.TabIndex = 9;
            // 
            // txt_ten
            // 
            txt_ten.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ten.Location = new Point(50, 56);
            txt_ten.Margin = new Padding(4, 4, 4, 4);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(253, 35);
            txt_ten.TabIndex = 11;
            // 
            // txt_phanhoi
            // 
            txt_phanhoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phanhoi.Location = new Point(381, 205);
            txt_phanhoi.Margin = new Padding(4, 4, 4, 4);
            txt_phanhoi.Name = "txt_phanhoi";
            txt_phanhoi.Size = new Size(253, 35);
            txt_phanhoi.TabIndex = 13;
            // 
            // txt_lsmua
            // 
            txt_lsmua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_lsmua.Location = new Point(381, 128);
            txt_lsmua.Margin = new Padding(4, 4, 4, 4);
            txt_lsmua.Name = "txt_lsmua";
            txt_lsmua.Size = new Size(253, 35);
            txt_lsmua.TabIndex = 14;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(381, 56);
            txt_email.Margin = new Padding(4, 4, 4, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(253, 35);
            txt_email.TabIndex = 15;
            // 
            // txt_sdt
            // 
            txt_sdt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sdt.Location = new Point(65, 276);
            txt_sdt.Margin = new Padding(4, 4, 4, 4);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(253, 35);
            txt_sdt.TabIndex = 16;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.Location = new Point(921, 184);
            btn_update.Margin = new Padding(4, 4, 4, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(130, 55);
            btn_update.TabIndex = 17;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(831, 265);
            btn_delete.Margin = new Padding(4, 4, 4, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(130, 55);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Location = new Point(748, 184);
            btn_add.Margin = new Padding(4, 4, 4, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(130, 55);
            btn_add.TabIndex = 19;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(781, 70);
            txt_search.Margin = new Padding(4, 4, 4, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(253, 35);
            txt_search.TabIndex = 20;
            // 
            // lb_search
            // 
            lb_search.AutoSize = true;
            lb_search.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_search.Location = new Point(748, 38);
            lb_search.Margin = new Padding(4, 0, 4, 0);
            lb_search.Name = "lb_search";
            lb_search.Size = new Size(75, 30);
            lb_search.TabIndex = 21;
            lb_search.Text = "Search";
            // 
            // cb_gioitinh
            // 
            cb_gioitinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_gioitinh.FormattingEnabled = true;
            cb_gioitinh.Location = new Point(55, 128);
            cb_gioitinh.Margin = new Padding(4, 4, 4, 4);
            cb_gioitinh.Name = "cb_gioitinh";
            cb_gioitinh.Size = new Size(253, 36);
            cb_gioitinh.TabIndex = 22;
            // 
            // Frm_Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 710);
            Controls.Add(cb_gioitinh);
            Controls.Add(lb_search);
            Controls.Add(txt_search);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(txt_sdt);
            Controls.Add(txt_email);
            Controls.Add(txt_lsmua);
            Controls.Add(txt_phanhoi);
            Controls.Add(txt_ten);
            Controls.Add(txt_diachi);
            Controls.Add(lb_phanhoi);
            Controls.Add(lb_LsMua);
            Controls.Add(lb_email);
            Controls.Add(lb_sdt);
            Controls.Add(lb_diachi);
            Controls.Add(lb_name);
            Controls.Add(lb_Gioitinh);
            Controls.Add(dgv_customer);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Frm_Customer";
            Text = "Frm_Customer";
            Load += Frm_Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}