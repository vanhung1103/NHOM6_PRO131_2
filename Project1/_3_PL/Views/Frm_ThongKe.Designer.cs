namespace _3_PL.Views
{
    partial class Frm_ThongKe
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePickerThongKe = new DateTimePicker();
            buttonTKNgay = new Button();
            buttonTKThang = new Button();
            buttonTKNam = new Button();
            buttonLoad = new Button();
            dtg_TKHD = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dtg_TKSP = new DataGridView();
            masppp = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            cbx_TKNgay = new ComboBox();
            cbx_TKThang = new ComboBox();
            cbx_TKNam = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_TKHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_TKSP).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(120, 110);
            label2.Name = "label2";
            label2.Size = new Size(23, 28);
            label2.TabIndex = 1;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 39);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Tổng tiền hàng";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDark;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(321, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 202);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(117, 110);
            label4.Name = "label4";
            label4.Size = new Size(23, 28);
            label4.TabIndex = 2;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 39);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 1;
            label3.Text = "Số đơn hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 248);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 2;
            label5.Text = "Hóa đơn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(606, 248);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 3;
            label6.Text = "Sản phẩm";
            // 
            // dateTimePickerThongKe
            // 
            dateTimePickerThongKe.Location = new Point(606, 34);
            dateTimePickerThongKe.Name = "dateTimePickerThongKe";
            dateTimePickerThongKe.Size = new Size(378, 27);
            dateTimePickerThongKe.TabIndex = 4;
            // 
            // buttonTKNgay
            // 
            buttonTKNgay.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTKNgay.Location = new Point(606, 67);
            buttonTKNgay.Name = "buttonTKNgay";
            buttonTKNgay.Size = new Size(107, 48);
            buttonTKNgay.TabIndex = 5;
            buttonTKNgay.Text = "Ngày";
            buttonTKNgay.UseVisualStyleBackColor = true;
            buttonTKNgay.Click += buttonTKNgay_Click;
            // 
            // buttonTKThang
            // 
            buttonTKThang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTKThang.Location = new Point(606, 121);
            buttonTKThang.Name = "buttonTKThang";
            buttonTKThang.Size = new Size(107, 48);
            buttonTKThang.TabIndex = 6;
            buttonTKThang.Text = "Tháng";
            buttonTKThang.UseVisualStyleBackColor = true;
            buttonTKThang.Click += buttonTKThang_Click;
            // 
            // buttonTKNam
            // 
            buttonTKNam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTKNam.Location = new Point(606, 178);
            buttonTKNam.Name = "buttonTKNam";
            buttonTKNam.Size = new Size(107, 48);
            buttonTKNam.TabIndex = 7;
            buttonTKNam.Text = "Năm";
            buttonTKNam.UseVisualStyleBackColor = true;
            buttonTKNam.Click += buttonTKNam_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLoad.Location = new Point(839, 127);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(99, 47);
            buttonLoad.TabIndex = 9;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // dtg_TKHD
            // 
            dtg_TKHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_TKHD.BackgroundColor = SystemColors.ButtonHighlight;
            dtg_TKHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_TKHD.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column6 });
            dtg_TKHD.Location = new Point(12, 276);
            dtg_TKHD.Name = "dtg_TKHD";
            dtg_TKHD.RowHeadersWidth = 51;
            dtg_TKHD.RowTemplate.Height = 29;
            dtg_TKHD.Size = new Size(576, 358);
            dtg_TKHD.TabIndex = 10;
            dtg_TKHD.CellClick += dtg_TKHD_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Ngày tạo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.HeaderText = "Trạng thái";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Tổng tiền hàng";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // dtg_TKSP
            // 
            dtg_TKSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_TKSP.BackgroundColor = SystemColors.ButtonHighlight;
            dtg_TKSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_TKSP.Columns.AddRange(new DataGridViewColumn[] { masppp, Column3, Column4 });
            dtg_TKSP.Location = new Point(606, 276);
            dtg_TKSP.Name = "dtg_TKSP";
            dtg_TKSP.RowHeadersWidth = 51;
            dtg_TKSP.RowTemplate.Height = 29;
            dtg_TKSP.Size = new Size(378, 358);
            dtg_TKSP.TabIndex = 11;
            // 
            // masppp
            // 
            masppp.HeaderText = "Mã sản phẩm";
            masppp.MinimumWidth = 6;
            masppp.Name = "masppp";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên sản phẩm";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // cbx_TKNgay
            // 
            cbx_TKNgay.FormattingEnabled = true;
            cbx_TKNgay.Location = new Point(729, 79);
            cbx_TKNgay.Name = "cbx_TKNgay";
            cbx_TKNgay.Size = new Size(83, 28);
            cbx_TKNgay.TabIndex = 12;
            // 
            // cbx_TKThang
            // 
            cbx_TKThang.FormattingEnabled = true;
            cbx_TKThang.Location = new Point(729, 133);
            cbx_TKThang.Name = "cbx_TKThang";
            cbx_TKThang.Size = new Size(83, 28);
            cbx_TKThang.TabIndex = 13;
            // 
            // cbx_TKNam
            // 
            cbx_TKNam.FormattingEnabled = true;
            cbx_TKNam.Location = new Point(729, 190);
            cbx_TKNam.Name = "cbx_TKNam";
            cbx_TKNam.Size = new Size(83, 28);
            cbx_TKNam.TabIndex = 14;
            // 
            // Frm_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 646);
            Controls.Add(cbx_TKNam);
            Controls.Add(cbx_TKThang);
            Controls.Add(cbx_TKNgay);
            Controls.Add(dtg_TKSP);
            Controls.Add(dtg_TKHD);
            Controls.Add(buttonLoad);
            Controls.Add(buttonTKNam);
            Controls.Add(buttonTKThang);
            Controls.Add(buttonTKNgay);
            Controls.Add(dateTimePickerThongKe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_ThongKe";
            Text = "Frm_ThongKe";
            Load += Frm_ThongKe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_TKHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_TKSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerThongKe;
        private Button buttonTKNgay;
        private Button buttonTKThang;
        private Button buttonTKNam;
        private Button buttonLoad;
        private DataGridView dtg_TKHD;
        private DataGridView dtg_TKSP;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn masppp;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cbx_TKNgay;
        private ComboBox cbx_TKThang;
        private ComboBox cbx_TKNam;
    }
}