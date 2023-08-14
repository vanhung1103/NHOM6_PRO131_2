namespace _3_PL.Views
{
    partial class Frm_Category
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
            label1 = new Label();
            txt_search = new TextBox();
            txt_name = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            dtg_cate = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtg_cate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(438, 195);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(196, 76);
            txt_search.Margin = new Padding(2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(392, 31);
            txt_search.TabIndex = 16;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(476, 228);
            txt_name.Margin = new Padding(4, 4, 4, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(124, 31);
            txt_name.TabIndex = 17;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(646, 369);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(132, 49);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(646, 291);
            btn_update.Margin = new Padding(2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(132, 49);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(646, 208);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(132, 49);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dtg_cate
            // 
            dtg_cate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_cate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_cate.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dtg_cate.Location = new Point(42, 178);
            dtg_cate.Margin = new Padding(2);
            dtg_cate.Name = "dtg_cate";
            dtg_cate.RowHeadersWidth = 62;
            dtg_cate.RowTemplate.Height = 33;
            dtg_cate.Size = new Size(360, 225);
            dtg_cate.TabIndex = 11;
            dtg_cate.CellContentClick += dtg_color_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Frm_Category
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 465);
            Controls.Add(label1);
            Controls.Add(txt_search);
            Controls.Add(txt_name);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dtg_cate);
            Margin = new Padding(2);
            Name = "Frm_Category";
            Text = "Frm_Category";
            Load += Frm_Category_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_cate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_search;
        private TextBox txt_name;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private DataGridView dtg_cate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}