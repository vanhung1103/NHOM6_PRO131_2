namespace _3_PL.Views
{
    partial class Frm_Login
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
            txt_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_password = new TextBox();
            label3 = new Label();
            btn_login = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(261, 136);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(282, 31);
            txt_username.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 142);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 268);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(261, 268);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(282, 31);
            txt_password.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 51);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(359, 378);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 320);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 6;
            label4.Text = "Forgot password?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 320);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 7;
            label5.Text = "SignUp";
            label5.Click += label5_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Name = "Frm_Login";
            Text = "Frm_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private Label label3;
        private Button btn_login;
        private Label label4;
        private Label label5;
    }
}