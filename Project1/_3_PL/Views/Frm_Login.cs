using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Login : Form
    {
        public IUserServices _iaccServices;
        public Frm_Login()
        {
            InitializeComponent();
            _iaccServices = new UserServices();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                MessageBox.Show("Nhập tên tài khoản", "Thông báo");
            }
            else if (txt_password.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu", "Thông báo");
            }
            else if (_iaccServices.CheckEmtyDB())
            {
                MessageBox.Show("Account không tồn tại", "Thông báo");
            }
            else
            {
                User account = _iaccServices.CheckLogin(txt_username.Text, txt_password.Text);
                if (account == null)
                {
                    MessageBox.Show("Tài khoản mật khẩu không chính xác");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Thread thread = new Thread(new ThreadStart(ShowFormMenu)); //Tạo luồng mới
                    thread.Start(); //Khởi chạy luồng
                    this.Close();
                }
            }
        }
        public void ShowFormMenu()
        {
            Frm_Menu mn = new Frm_Menu();
            mn.ShowDialog();
        }
        private void Llb_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Signup frm_Signup = new Frm_Signup();
            frm_Signup.Show();
            this.Hide();
        }

        private void Llb_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ForgotPass frm_ForgotPass = new Frm_ForgotPass();
            frm_ForgotPass.Show();
            this.Hide();
        }
    }
}
