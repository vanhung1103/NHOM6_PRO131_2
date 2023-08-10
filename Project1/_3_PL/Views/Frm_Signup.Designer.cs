namespace _3_PL.Views
{
    partial class Frm_Signup
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
            btn_signup = new Button();
            label3 = new Label();
            txt_password = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_username = new TextBox();
            txt_repassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(418, 375);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(112, 34);
            btn_signup.TabIndex = 11;
            btn_signup.Text = "Signup";
            btn_signup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 55);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 10;
            label3.Text = "SignUp";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(334, 222);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(282, 31);
            txt_password.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 228);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 8;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 146);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(334, 140);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(282, 31);
            txt_username.TabIndex = 6;
            // 
            // txt_repassword
            // 
            txt_repassword.Location = new Point(334, 297);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.Size = new Size(282, 31);
            txt_repassword.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 303);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 13;
            label4.Text = "RePassword";
            // 
            // Frm_Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txt_repassword);
            Controls.Add(btn_signup);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Name = "Frm_Signup";
            Text = "Frm_Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_signup;
        private Label label3;
        private TextBox txt_password;
        private Label label2;
        private Label label1;
        private TextBox txt_username;
        private TextBox txt_repassword;
        private Label label4;
    }
}