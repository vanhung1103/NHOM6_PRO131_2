namespace _3_PL.Views
{
    partial class Frm_Color
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
            dtg_color = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txt_search = new TextBox();
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_color).BeginInit();
            SuspendLayout();
            // 
            // dtg_color
            // 
            dtg_color.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_color.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_color.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dtg_color.Location = new Point(40, 146);
            dtg_color.Margin = new Padding(2);
            dtg_color.Name = "dtg_color";
            dtg_color.RowHeadersWidth = 62;
            dtg_color.RowTemplate.Height = 33;
            dtg_color.Size = new Size(288, 180);
            dtg_color.TabIndex = 0;
            dtg_color.CellClick += dtg_color_CellClick;
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
            // btn_add
            // 
            btn_add.Location = new Point(519, 168);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 27);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(519, 234);
            btn_update.Margin = new Padding(2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(90, 27);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(519, 297);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(90, 27);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(159, 62);
            txt_search.Margin = new Padding(2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(297, 27);
            txt_search.TabIndex = 6;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 146);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(365, 170);
            txt_name.Margin = new Padding(2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(121, 27);
            txt_name.TabIndex = 4;
            // 
            // label2
            // 
            
            // 
            // Frm_Color
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
            Controls.Add(dtg_color);
            Margin = new Padding(2);
            Name = "Frm_Color";
            Text = "Frm_Color";
            Load += Frm_Color_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_color).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_color;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_search;
        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}