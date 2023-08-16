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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Customer : Form
    {

        public Guid _Id;
        public ICustomerServices customerServices;
        List<CustomerView> customerList;

        public Frm_Customer()
        {
            InitializeComponent();

            customerServices = new CustomerServices();
            customerList = new List<CustomerView>();
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");

            // Kiểm tra xem có cột nào trong DataGridView dgv_customer hay không
            if (dgv_customer.Columns.Count > 0)
            {
                // Đặt cột đầu tiên của DataGridView là chỉ đọc (ReadOnly)
                dgv_customer.Columns[0].ReadOnly = true;
            }
            customerList = customerServices.GetCustomer();   
            // Gọi hàm LoadData để nạp dữ liệu vào DataGridView
            LoadToGridView(customerList);

        }

        public void LoadToGridView(List<CustomerView> customerViews)
        {
            dgv_customer.Rows.Clear();
            dgv_customer.ColumnCount = 7;
            //dgv_customer.Columns[0].Visible = false;

            dgv_customer.Columns[0].Name = "CustomerId";
            dgv_customer.Columns[0].Visible = false;
            dgv_customer.Columns[1].Name = "Tên Khách Hàng";
            dgv_customer.Columns[2].Name = "Giới Tính";
            dgv_customer.Columns[3].Name = "Địa Chỉ";
            dgv_customer.Columns[4].Name = "Số Điện Thoại";
            dgv_customer.Columns[5].Name = "Email";
            dgv_customer.Columns[6].Name = "Phản hồi";
            dgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_customer.AllowUserToResizeColumns = false;
            foreach (var item in customerViews)
            {
                dgv_customer.Rows.Add(item.CustomerId,
                    item.Name,
                    item.Gender,
                    item.Address,
                    item.Phone,
                    item.Email,
                    item.Feedback

                    );
            }
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            bool sdt = Regex.IsMatch(txt_sdt.Text, @"^\d{10}$");
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            bool email = Regex.IsMatch(txt_email.Text, pattern);
            if (txt_ten.Text == "")
            {
                MessageBox.Show("Không để trống tên khách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_ten.Text.Length > 60)
            {
                MessageBox.Show("Nhập tên khách quá dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cb_gioitinh.Text == "")
            {
                MessageBox.Show("Nhập giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_diachi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ quá dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!sdt)
            {
                MessageBox.Show("Nhập sđt 10 số, không chứa kí tự hoặc chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Nhập email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!email)
            {
                MessageBox.Show("Email p đúng abc@....com", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_phanhoi.Text == "")
            {
                MessageBox.Show("Nhập phản hồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_phanhoi.Text.Length > 100)
            {
                MessageBox.Show("phản hồi dài quá ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                CustomerView customerView = new CustomerView()
                {
                    Name = txt_ten.Text,
                    Gender = cb_gioitinh.Text,
                    Address = txt_diachi.Text,
                    Phone = txt_sdt.Text,
                    Email = txt_email.Text,
                    Feedback = txt_phanhoi.Text,
                };
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(customerServices.AddCustomer(customerView));
                    customerList = customerServices.GetCustomer();
                    // Gọi hàm LoadData để nạp dữ liệu vào DataGridView
                    LoadToGridView(customerList);
                }
                customerList = customerServices.GetCustomer();
                // Gọi hàm LoadData để nạp dữ liệu vào DataGridView
                LoadToGridView(customerList);
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            bool sdt = Regex.IsMatch(txt_sdt.Text, @"^\d{10}$");
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            bool email = Regex.IsMatch(txt_email.Text, pattern);
            if (txt_ten.Text == "")
            {
                MessageBox.Show("Không để trống tên khách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_ten.Text.Length > 60)
            {
                MessageBox.Show("Nhập tên khách quá dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cb_gioitinh.Text == "")
            {
                MessageBox.Show("Nhập giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_diachi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ quá dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!sdt)
            {
                MessageBox.Show("Nhập sđt 10 số, không chứa kí tự hoặc chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Nhập email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!email)
            {
                MessageBox.Show("Email p đúng abc@....com", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_phanhoi.Text == "")
            {
                MessageBox.Show("Nhập phản hồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_phanhoi.Text.Length > 100)
            {
                MessageBox.Show("phản hồi dài quá ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                CustomerView customerView = new CustomerView()
                {
                    CustomerId = _Id,
                    Name = txt_ten.Text,
                    Gender = cb_gioitinh.Text,
                    Address = txt_diachi.Text,
                    Phone = txt_sdt.Text,
                    Email = txt_email.Text,
                    Feedback = txt_phanhoi.Text,
                };
                DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(customerServices.UpdateCustomer(customerView));
                    customerList = customerServices.GetCustomer();
                    // Gọi hàm LoadData để nạp dữ liệu vào DataGridView
                    LoadToGridView(customerList);
                }
                customerList = customerServices.GetCustomer();
                // Gọi hàm LoadData để nạp dữ liệu vào DataGridView
                LoadToGridView(customerList);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(customerServices.DeleteCustomer(_Id));
                customerList = customerServices.GetCustomer();
                // Gọi hàm LoadData để nạp dữ liệu vào DataGridView
                LoadToGridView(customerList);
            }
            customerList = customerServices.GetCustomer();
            // Gọi hàm LoadData để nạp dữ liệu vào DataGridView
            LoadToGridView(customerList);
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            _Id = Guid.Parse(dgv_customer.CurrentRow.Cells[0].Value.ToString());
            txt_ten.Text = dgv_customer.CurrentRow.Cells[1].Value.ToString();
            cb_gioitinh.Text = dgv_customer.CurrentRow.Cells[2].Value.ToString();
            txt_diachi.Text = dgv_customer.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = dgv_customer.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dgv_customer.CurrentRow.Cells[5].Value.ToString();
            txt_phanhoi.Text = dgv_customer.CurrentRow.Cells[6].Value.ToString();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = customerServices.GetCustomer().Where(x => x.Name.ToLower().Contains(searchText.ToLower()) && x.Phone.ToLower().Contains(searchText.ToLower())).ToList();
            if (filteredSuppliers == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            LoadToGridView(filteredSuppliers);
        }
    }
}




