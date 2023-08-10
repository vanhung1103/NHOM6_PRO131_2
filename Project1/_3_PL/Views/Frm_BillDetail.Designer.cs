namespace _3_PL.Views
{
    partial class Frm_BillDetail
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
            cbx_pro = new ComboBox();
            cbx_hdct = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txt_image = new TextBox();
            label3 = new Label();
            txt_price = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_search = new TextBox();
            txt_mahdct = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            dtg_show = new DataGridView();
            txt_quantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // cbx_pro
            // 
            cbx_pro.FormattingEnabled = true;
            cbx_pro.Location = new Point(701, 299);
            cbx_pro.Name = "cbx_pro";
            cbx_pro.Size = new Size(182, 33);
            cbx_pro.TabIndex = 63;
            // 
            // cbx_hdct
            // 
            cbx_hdct.FormattingEnabled = true;
            cbx_hdct.Location = new Point(266, 302);
            cbx_hdct.Name = "cbx_hdct";
            cbx_hdct.Size = new Size(182, 33);
            cbx_hdct.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(132, 302);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 60;
            label9.Text = "Hóa đơn ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(579, 302);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 59;
            label8.Text = "Sản Phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 70);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 58;
            label7.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 164);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 57;
            label6.Text = "Ảnh";
            // 
            // txt_image
            // 
            txt_image.Location = new Point(318, 213);
            txt_image.Name = "txt_image";
            txt_image.Size = new Size(251, 31);
            txt_image.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 51;
            label3.Text = "Gía";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(-4, 220);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(251, 31);
            txt_price.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, -8);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 49;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 48;
            label1.Text = "Mã Hóa Đơn CT";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(275, 21);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(391, 31);
            txt_search.TabIndex = 47;
            // 
            // txt_mahdct
            // 
            txt_mahdct.Location = new Point(-4, 113);
            txt_mahdct.Name = "txt_mahdct";
            txt_mahdct.Size = new Size(251, 31);
            txt_mahdct.TabIndex = 46;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(865, 182);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(133, 49);
            btn_delete.TabIndex = 45;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(865, 104);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(133, 49);
            btn_update.TabIndex = 44;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(865, 21);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(133, 49);
            btn_add.TabIndex = 43;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(12, 396);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 62;
            dtg_show.RowTemplate.Height = 33;
            dtg_show.Size = new Size(981, 225);
            dtg_show.TabIndex = 42;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(318, 113);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(251, 31);
            txt_quantity.TabIndex = 64;
            // 
            // Frm_BillDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 633);
            Controls.Add(txt_quantity);
            Controls.Add(cbx_pro);
            Controls.Add(cbx_hdct);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_image);
            Controls.Add(label3);
            Controls.Add(txt_price);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_search);
            Controls.Add(txt_mahdct);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dtg_show);
            Name = "Frm_BillDetail";
            Text = "Frm_BillDetail";
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_pro;
        private ComboBox cbx_hdct;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txt_image;
        private Label label3;
        private TextBox txt_price;
        private Label label2;
        private Label label1;
        private TextBox txt_search;
        private TextBox txt_mahdct;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private DataGridView dtg_show;
        private TextBox txt_quantity;
    }
}