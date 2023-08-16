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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Llb_signup = new LinkLabel();
            Llb_ForgotPass = new LinkLabel();
            btn_login = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(292, 406);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(292, 347);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, 43);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Llb_signup
            // 
            Llb_signup.AutoSize = true;
            Llb_signup.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Llb_signup.LinkColor = Color.Black;
            Llb_signup.Location = new Point(511, 470);
            Llb_signup.Margin = new Padding(4, 0, 4, 0);
            Llb_signup.Name = "Llb_signup";
            Llb_signup.Size = new Size(88, 32);
            Llb_signup.TabIndex = 17;
            Llb_signup.TabStop = true;
            Llb_signup.Text = "SignUp";
            Llb_signup.LinkClicked += Llb_signup_LinkClicked;
            // 
            // Llb_ForgotPass
            // 
            Llb_ForgotPass.AutoSize = true;
            Llb_ForgotPass.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Llb_ForgotPass.LinkColor = Color.Black;
            Llb_ForgotPass.Location = new Point(273, 470);
            Llb_ForgotPass.Margin = new Padding(4, 0, 4, 0);
            Llb_ForgotPass.Name = "Llb_ForgotPass";
            Llb_ForgotPass.Size = new Size(195, 32);
            Llb_ForgotPass.TabIndex = 16;
            Llb_ForgotPass.TabStop = true;
            Llb_ForgotPass.Text = "Forgot password?";
            Llb_ForgotPass.LinkClicked += Llb_ForgotPass_LinkClicked;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Cyan;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(402, 540);
            btn_login.Margin = new Padding(2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(161, 59);
            btn_login.TabIndex = 15;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(363, 412);
            txt_password.Margin = new Padding(2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(282, 35);
            txt_password.TabIndex = 14;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(363, 353);
            txt_username.Margin = new Padding(2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(282, 35);
            txt_username.TabIndex = 13;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 643);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Llb_signup);
            Controls.Add(Llb_ForgotPass);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "Frm_Login";
            Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private LinkLabel Llb_signup;
        private LinkLabel Llb_ForgotPass;
        private Button btn_login;
        private TextBox txt_password;
        private TextBox txt_username;
    }
}