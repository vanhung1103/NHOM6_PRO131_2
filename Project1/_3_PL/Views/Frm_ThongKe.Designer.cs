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
            dateTimePickerThongKe = new DateTimePicker();
            buttonTKNgay = new Button();
            buttonTKThang = new Button();
            buttonTKNam = new Button();
            buttonLoad = new Button();
            dtg_TKHD = new DataGridView();
            cbx_TKNgay = new ComboBox();
            cbx_TKThang = new ComboBox();
            cbx_TKNam = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_TKHD).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 30);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(334, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(27, 32);
            label2.TabIndex = 1;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 0;
            label1.Text = "Tổng tiền hàng";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDark;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(401, 30);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(334, 252);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(146, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 32);
            label4.TabIndex = 2;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 32);
            label3.TabIndex = 1;
            label3.Text = "Số đơn hàng";
            // 
            // dateTimePickerThongKe
            // 
            dateTimePickerThongKe.Location = new Point(758, 42);
            dateTimePickerThongKe.Margin = new Padding(4);
            dateTimePickerThongKe.Name = "dateTimePickerThongKe";
            dateTimePickerThongKe.Size = new Size(472, 31);
            dateTimePickerThongKe.TabIndex = 4;
            // 
            // buttonTKNgay
            // 
            buttonTKNgay.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTKNgay.Location = new Point(758, 84);
            buttonTKNgay.Margin = new Padding(4);
            buttonTKNgay.Name = "buttonTKNgay";
            buttonTKNgay.Size = new Size(134, 60);
            buttonTKNgay.TabIndex = 5;
            buttonTKNgay.Text = "Ngày";
            buttonTKNgay.UseVisualStyleBackColor = true;
            buttonTKNgay.Click += buttonTKNgay_Click;
            // 
            // buttonTKThang
            // 
            buttonTKThang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTKThang.Location = new Point(758, 151);
            buttonTKThang.Margin = new Padding(4);
            buttonTKThang.Name = "buttonTKThang";
            buttonTKThang.Size = new Size(134, 60);
            buttonTKThang.TabIndex = 6;
            buttonTKThang.Text = "Tháng";
            buttonTKThang.UseVisualStyleBackColor = true;
            buttonTKThang.Click += buttonTKThang_Click;
            // 
            // buttonTKNam
            // 
            buttonTKNam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTKNam.Location = new Point(758, 222);
            buttonTKNam.Margin = new Padding(4);
            buttonTKNam.Name = "buttonTKNam";
            buttonTKNam.Size = new Size(134, 60);
            buttonTKNam.TabIndex = 7;
            buttonTKNam.Text = "Năm";
            buttonTKNam.UseVisualStyleBackColor = true;
            buttonTKNam.Click += buttonTKNam_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLoad.Location = new Point(1049, 159);
            buttonLoad.Margin = new Padding(4);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(124, 59);
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
            dtg_TKHD.Location = new Point(15, 345);
            dtg_TKHD.Margin = new Padding(4);
            dtg_TKHD.Name = "dtg_TKHD";
            dtg_TKHD.RowHeadersWidth = 51;
            dtg_TKHD.RowTemplate.Height = 29;
            dtg_TKHD.Size = new Size(1121, 448);
            dtg_TKHD.TabIndex = 10;
            dtg_TKHD.CellClick += dtg_TKHD_CellClick;
            dtg_TKHD.CellContentClick += dtg_TKHD_CellContentClick;
            // 
            // cbx_TKNgay
            // 
            cbx_TKNgay.FormattingEnabled = true;
            cbx_TKNgay.Location = new Point(911, 99);
            cbx_TKNgay.Margin = new Padding(4);
            cbx_TKNgay.Name = "cbx_TKNgay";
            cbx_TKNgay.Size = new Size(103, 33);
            cbx_TKNgay.TabIndex = 12;
            // 
            // cbx_TKThang
            // 
            cbx_TKThang.FormattingEnabled = true;
            cbx_TKThang.Location = new Point(911, 166);
            cbx_TKThang.Margin = new Padding(4);
            cbx_TKThang.Name = "cbx_TKThang";
            cbx_TKThang.Size = new Size(103, 33);
            cbx_TKThang.TabIndex = 13;
            // 
            // cbx_TKNam
            // 
            cbx_TKNam.FormattingEnabled = true;
            cbx_TKNam.Location = new Point(911, 238);
            cbx_TKNam.Margin = new Padding(4);
            cbx_TKNam.Name = "cbx_TKNam";
            cbx_TKNam.Size = new Size(103, 33);
            cbx_TKNam.TabIndex = 14;
            // 
            // Frm_ThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 808);
            Controls.Add(cbx_TKNam);
            Controls.Add(cbx_TKThang);
            Controls.Add(cbx_TKNgay);
            Controls.Add(dtg_TKHD);
            Controls.Add(buttonLoad);
            Controls.Add(buttonTKNam);
            Controls.Add(buttonTKThang);
            Controls.Add(buttonTKNgay);
            Controls.Add(dateTimePickerThongKe);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "Frm_ThongKe";
            Text = "Frm_ThongKe";
            Load += Frm_ThongKe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_TKHD).EndInit();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn masppp;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cbx_TKNgay;
        private ComboBox cbx_TKThang;
        private ComboBox cbx_TKNam;
    }
}