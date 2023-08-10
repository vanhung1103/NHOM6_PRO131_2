namespace _3_PL.Views
{
    partial class Frm_Supplier
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
            txt_name = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            dtg_sup = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtg_sup).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 38);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 18;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 144);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(157, 61);
            txt_search.Margin = new Padding(2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(297, 27);
            txt_search.TabIndex = 16;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(362, 169);
            txt_name.Margin = new Padding(2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(121, 27);
            txt_name.TabIndex = 15;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(517, 295);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(90, 27);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(517, 233);
            btn_update.Margin = new Padding(2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(90, 27);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(517, 166);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 27);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dtg_sup
            // 
            dtg_sup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_sup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sup.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dtg_sup.Location = new Point(34, 142);
            dtg_sup.Margin = new Padding(2);
            dtg_sup.Name = "dtg_sup";
            dtg_sup.RowHeadersWidth = 62;
            dtg_sup.RowTemplate.Height = 33;
            dtg_sup.Size = new Size(288, 180);
            dtg_sup.TabIndex = 11;
            dtg_sup.CellClick += dtg_sup_CellClick;
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
            // Frm_Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_search);
            Controls.Add(txt_name);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dtg_sup);
            Margin = new Padding(2);
            Name = "Frm_Supplier";
            Text = "Frm_Supplier";
            Load += Frm_Supplier_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_sup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_search;
        private TextBox txt_name;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private DataGridView dtg_sup;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}