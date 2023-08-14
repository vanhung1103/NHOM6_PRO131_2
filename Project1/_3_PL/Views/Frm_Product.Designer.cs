namespace _3_PL.Views
{
    partial class Frm_Product
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
            txt_name = new TextBox();
            dtg_view = new DataGridView();
            txt_des = new TextBox();
            txt_price = new TextBox();
            txt_quantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            cbx_color = new ComboBox();
            cbx_size = new ComboBox();
            cbx_cate = new ComboBox();
            cbx_suplplier = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_timkiem = new TextBox();
            label11 = new Label();
            txt_Ma = new TextBox();
            label5 = new Label();
            rbtn_ConHang = new RadioButton();
            rbtn_HetHang = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dtg_view).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(89, 35);
            txt_name.Margin = new Padding(2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(163, 27);
            txt_name.TabIndex = 0;
            // 
            // dtg_view
            // 
            dtg_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view.Location = new Point(10, 277);
            dtg_view.Margin = new Padding(2);
            dtg_view.Name = "dtg_view";
            dtg_view.RowHeadersWidth = 62;
            dtg_view.RowTemplate.Height = 33;
            dtg_view.Size = new Size(634, 235);
            dtg_view.TabIndex = 1;
            dtg_view.CellClick += dtg_view_CellClick;
            // 
            // txt_des
            // 
            txt_des.Location = new Point(350, 94);
            txt_des.Margin = new Padding(2);
            txt_des.Name = "txt_des";
            txt_des.Size = new Size(180, 27);
            txt_des.TabIndex = 4;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(89, 145);
            txt_price.Margin = new Padding(2);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(163, 27);
            txt_price.TabIndex = 5;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(89, 94);
            txt_quantity.Margin = new Padding(2);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(163, 27);
            txt_quantity.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 9;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 143);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 10;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 97);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 11;
            label4.Text = "Desscription";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 145);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 13;
            label6.Text = "Status";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(699, 321);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 27);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(699, 393);
            btn_update.Margin = new Padding(2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(90, 27);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(699, 443);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(90, 27);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // cbx_color
            // 
            cbx_color.FormattingEnabled = true;
            cbx_color.Location = new Point(643, 31);
            cbx_color.Margin = new Padding(2);
            cbx_color.Name = "cbx_color";
            cbx_color.Size = new Size(146, 28);
            cbx_color.TabIndex = 17;
            // 
            // cbx_size
            // 
            cbx_size.FormattingEnabled = true;
            cbx_size.Location = new Point(643, 76);
            cbx_size.Margin = new Padding(2);
            cbx_size.Name = "cbx_size";
            cbx_size.Size = new Size(146, 28);
            cbx_size.TabIndex = 18;
            // 
            // cbx_cate
            // 
            cbx_cate.FormattingEnabled = true;
            cbx_cate.Location = new Point(643, 114);
            cbx_cate.Margin = new Padding(2);
            cbx_cate.Name = "cbx_cate";
            cbx_cate.Size = new Size(146, 28);
            cbx_cate.TabIndex = 19;
            // 
            // cbx_suplplier
            // 
            cbx_suplplier.FormattingEnabled = true;
            cbx_suplplier.Location = new Point(643, 158);
            cbx_suplplier.Margin = new Padding(2);
            cbx_suplplier.Name = "cbx_suplplier";
            cbx_suplplier.Size = new Size(146, 28);
            cbx_suplplier.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(566, 35);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 21;
            label7.Text = "Color";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(566, 82);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 22;
            label8.Text = "Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(566, 121);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 23;
            label9.Text = "Category";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(566, 164);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 24;
            label10.Text = "Supplier";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(153, 231);
            txt_timkiem.Margin = new Padding(2);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(354, 27);
            txt_timkiem.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 236);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 26;
            label11.Text = "Tìm Kiếm";
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(350, 35);
            txt_Ma.Margin = new Padding(2);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(180, 27);
            txt_Ma.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 42);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 29;
            label5.Text = "Ma";
            // 
            // rbtn_ConHang
            // 
            rbtn_ConHang.AutoSize = true;
            rbtn_ConHang.Location = new Point(350, 148);
            rbtn_ConHang.Name = "rbtn_ConHang";
            rbtn_ConHang.Size = new Size(96, 24);
            rbtn_ConHang.TabIndex = 30;
            rbtn_ConHang.TabStop = true;
            rbtn_ConHang.Text = "Còn Hàng";
            rbtn_ConHang.UseVisualStyleBackColor = true;
            // 
            // rbtn_HetHang
            // 
            rbtn_HetHang.AutoSize = true;
            rbtn_HetHang.Location = new Point(350, 178);
            rbtn_HetHang.Name = "rbtn_HetHang";
            rbtn_HetHang.Size = new Size(94, 24);
            rbtn_HetHang.TabIndex = 31;
            rbtn_HetHang.TabStop = true;
            rbtn_HetHang.Text = "Hết Hàng";
            rbtn_HetHang.UseVisualStyleBackColor = true;
            // 
            // Frm_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 522);
            Controls.Add(rbtn_HetHang);
            Controls.Add(rbtn_ConHang);
            Controls.Add(label5);
            Controls.Add(txt_Ma);
            Controls.Add(label11);
            Controls.Add(txt_timkiem);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbx_suplplier);
            Controls.Add(cbx_cate);
            Controls.Add(cbx_size);
            Controls.Add(cbx_color);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_quantity);
            Controls.Add(txt_price);
            Controls.Add(txt_des);
            Controls.Add(dtg_view);
            Controls.Add(txt_name);
            Margin = new Padding(2);
            Name = "Frm_Product";
            Text = "Frm_Product";
            Load += Frm_Product_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private DataGridView dtg_view;
        private TextBox txt_des;
        private TextBox txt_price;
        private TextBox txt_quantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox cbx_color;
        private ComboBox cbx_size;
        private ComboBox cbx_cate;
        private ComboBox cbx_suplplier;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_timkiem;
        private Label label11;
        private TextBox txt_Ma;
        private Label label5;
        private RadioButton rbtn_ConHang;
        private RadioButton rbtn_HetHang;
    }
}