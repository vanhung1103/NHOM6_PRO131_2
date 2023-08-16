using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Signup : Form
    {
        public IUserServices _iaccServices;
        public IRoleServices roleServices;
        public Frm_Signup()
        {
            InitializeComponent();
            _iaccServices = new UserServices();
            roleServices = new RoleService();
        }
        public void Add()
        {
            foreach (var item in roleServices.GetRole())
            {
                cb_gioitinh.Items.Add(item.Name);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void ShowForm()
        {
            Frm_Login mn = new Frm_Login();
            mn.ShowDialog();
        }
        private void btn_signup_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            bool email = Regex.IsMatch(txt_email.Text, pattern);
            if (txt_username.Text == "")
            {
                MessageBox.Show("Nhập tên tài khoản", "Thông báo");
            }
            else if (txt_password.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu", "Thông báo");
            }
            //else if (validates.CheckPass(tbx_pass.Texts) == false)
            //{
            //    MessageBox.Show("Nhập mật khẩu chứa số hoặc chữ", "Thông báo");
            //}
            else if (txt_repassword.Text == "")
            {
                MessageBox.Show("Nhập lại mật khẩu ", "Thông báo");
            }
            else if (cb_gioitinh.Text == "")
            {
                MessageBox.Show("Nhập role ", "Thông báo");
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Nhập email ", "Thông báo");
            }
            else if (!email)
            {
                MessageBox.Show("Email p đúng định dạng ", "Thông báo");
            }
            else if (txt_repassword.Text == txt_password.Text)
            {
                if (_iaccServices.CheckAccountExists(txt_username.Text))
                {
                    MessageBox.Show("Tài khoản đã tồn tại, mời kiểm tra lại", "Thông báo");
                    txt_username.Text = "";
                }
                else
                {
                    UserView acc = new UserView();
                    {
                        acc.UserName = txt_username.Text;
                        acc.PassWord = txt_password.Text;
                        acc.Email = txt_email.Text;
                        acc.role_Id = roleServices.GetRole().FirstOrDefault(c => c.Name == cb_gioitinh.Text).Id;
                    }

                    MessageBox.Show(_iaccServices.AddUser(acc));
                    Thread thread = new Thread(new ThreadStart(ShowForm)); //Tạo luồng mới
                    thread.Start(); //Khởi chạy luồng
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu chưa đúng với mật khẩu", "Thông báo");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
