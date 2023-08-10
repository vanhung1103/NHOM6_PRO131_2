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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Customer : Form
    {
        public Guid _Id;
        public ICustomerServices customerServices;
        List<CustomerView> customerList;
        public IVoucherServices voucherServices;

        public Frm_Customer()
        {
            InitializeComponent();
            customerServices= new CustomerServices();
            customerList= new List<CustomerView>();
            voucherServices = new VoucherServices();

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

            // Gọi hàm LoadData để nạp dữ liệu vào DataGridView
            LoadToGridView();
            LoadVoucher();
        }
        public void LoadVoucher()
        {
            foreach (var item in voucherServices.GetAllVoucher())
            {
                cb_voucher.Items.Add(item.Name);
            }
        }
        public void LoadToGridView()
        {

            dgv_customer.Rows.Clear();
            dgv_customer.ColumnCount = 9;
            //dgv_customer.Columns[0].Visible = false;

            dgv_customer.Columns[0].Name = "CustomerId";
            dgv_customer.Columns[1].Name = "Tên Khách Hàng";
            dgv_customer.Columns[2].Name = "Giới Tính";
            dgv_customer.Columns[3].Name = "Địa Chỉ";
            dgv_customer.Columns[4].Name = "Số Điện Thoại";
            dgv_customer.Columns[5].Name = "Email";
            dgv_customer.Columns[6].Name = "Lịch Sử Mua";
            dgv_customer.Columns[7].Name = "Phản hồi";
            dgv_customer.Columns[8].Name = "Giảm Giá";
            dgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_customer.AllowUserToResizeColumns = false;
            foreach (var item in customerServices.GetCustomer())
            {
                dgv_customer.Rows.Add(item.CustomerId,
                    item.Name,
                    item.Gender,
                    item.Address,
                    item.Phone,
                    item.Email,
                    item.PurchaseHistory,
                    item.Feedback,
                    (item.Voucher_Id != null) ? voucherServices.GetAllVoucher().FirstOrDefault(c => c.Id == item.Voucher_Id).Name : " "

                    );
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView()
            {
                Name = txt_ten.Text,
                Gender =cb_gioitinh.Text,
                Address =txt_diachi.Text,
                Phone =txt_sdt.Text,
                Email = txt_email.Text,
                PurchaseHistory =Convert.ToInt32(txt_lsmua.Text),
                Feedback = txt_phanhoi.Text,
                Voucher_Id = voucherServices.GetAllVoucher().FirstOrDefault(c => c.Name == cb_voucher.Text).Id,
            };
            DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(customerServices.AddCustomer(customerView));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView()
            {
                CustomerId = _Id,
                Name = txt_ten.Text,
                Gender = cb_gioitinh.Text,
                Address = txt_diachi.Text,
                Phone = txt_sdt.Text,
                Email = txt_email.Text,
                PurchaseHistory = Convert.ToInt32(txt_lsmua.Text),
                Feedback = txt_phanhoi.Text,
                Voucher_Id = voucherServices.GetAllVoucher().FirstOrDefault(c => c.Name == cb_voucher.Text).Id,
            };
            DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(customerServices.UpdateCustomer(customerView));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(customerServices.DeleteCustomer(_Id));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _Id = Guid.Parse(dgv_customer.CurrentRow.Cells[0].Value.ToString());
            txt_ten.Text = dgv_customer.CurrentRow.Cells[1].Value.ToString();
            cb_gioitinh.Text = dgv_customer.CurrentRow.Cells[2].Value.ToString();
            txt_diachi.Text = dgv_customer.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = dgv_customer.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dgv_customer.CurrentRow.Cells[5].Value.ToString();
            txt_lsmua.Text = dgv_customer.CurrentRow.Cells[6].Value.ToString();
            txt_phanhoi.Text = dgv_customer.CurrentRow.Cells[7].Value.ToString();
            cb_voucher.Text = dgv_customer.CurrentRow.Cells[8].Value.ToString();

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = customerServices.GetCustomer().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dgv_customer.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dgv_customer.Rows.Add(x.CustomerId, x.Name, x.Gender, x.Address, x.Phone, x.Email, x.PurchaseHistory, x.Feedback);
            }
        }
    }
}



