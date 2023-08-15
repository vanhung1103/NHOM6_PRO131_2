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
using System.Windows.Documents;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Billl : Form
    {
        public Guid _idhd;
        public IBillServices _ibillServices;
        public ICustomerServices _icustomerService;
        public IUserServices _iuserService;
        public IVoucherServices _iVoucherServices;

        public List<BillView> _lstbillViews;

        public Frm_Billl()
        {
            _ibillServices = new BillServices();
            _iVoucherServices = new VoucherServices();
            _icustomerService = new CustomerServices();
            _iuserService = new UserServices();
            _lstbillViews = new List<BillView>();
            InitializeComponent();
            LoadTocbb();
            LoadTocbuser();
            _lstbillViews = _ibillServices.Get();
            LoadToGridView(_lstbillViews);
        }


        public void LoadTocbb()
        {
            foreach (var item in _icustomerService.GetCustomer())
            {
                cbx_customer.Items.Add(item.Name);
            }
        }
        public void LoadTocbuser()
        {
            foreach (var item in _iuserService.GetAllUser())
            {
                cbx_user.Items.Add(item.UserName);
            }
        }

        public void LoadToGridView(List<BillView> _lstbillViews)
        {
            int stt = 1;
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 12;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;

            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã hóa đơn";
            dtg_show.Columns[3].Name = "Discount";
            dtg_show.Columns[4].Name = "Ngày tạo";
            dtg_show.Columns[5].Name = "UserName";
            dtg_show.Columns[6].Name = "Tên khách";
            dtg_show.Columns[7].Name = "SĐT";
            dtg_show.Columns[8].Name = "Địa chỉ";
            dtg_show.Columns[9].Name = "Email";
            dtg_show.Columns[10].Name = "Giới Tính";
            dtg_show.Columns[11].Name = "Trạng thái";
            dtg_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_show.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtg_show.AllowUserToResizeColumns = false;
            foreach (var item in _lstbillViews)
            {
                dtg_show.Rows.Add(item.Id,
                    stt++,
                    item.MaHD,
                    item.Discount,
                    item.Create_Date,
                    (item.User_Id != null) ? _iuserService.GetAllUser().FirstOrDefault(c => c.Id == item.User_Id).UserName : " ",
                    //(item.Customer_Id != null) ? _icustomerService.GetCustomer().FirstOrDefault(c => c.CustomerId == item.Customer_Id).Name : " ",
                    //(item.Customer_Id != null) ? _icustomerService.GetCustomer().FirstOrDefault(c => c.CustomerId == item.Customer_Id).Phone : " ",
                    //(item.Customer_Id != null) ? _icustomerService.GetCustomer().FirstOrDefault(c => c.CustomerId == item.Customer_Id).Address : " ",
                    //(item.Customer_Id != null) ? _icustomerService.GetCustomer().FirstOrDefault(c => c.CustomerId == item.Customer_Id).Email : " ",
                    //(item.Customer_Id != null) ? _icustomerService.GetCustomer().FirstOrDefault(c => c.CustomerId == item.Customer_Id).Gender : " ",
                    item.Name,
                    item.Phone,
                    item.Address,
                    item.Email,
                    item.Gender,
                    item.Status == 1 ? "Đã thanh toán" : "Chưa thanh toán"
                    );
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            bool so = Regex.IsMatch(txt_discount.Text, @"^[0-9]");
            if (txt_mahd.Text == "" && txt_mahd.Text.Length < 5)
            {
                txt_mahd.BackColor = Color.Yellow;
                MessageBox.Show("Không để mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_mahd.Text.Contains(" "))
            {
                MessageBox.Show("Không được để dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_discount.Text == "")
            {
                MessageBox.Show("Không để trống discount", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_discount.Text.Contains(" "))
            {
                MessageBox.Show("Không được để dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so)
            {
                MessageBox.Show("Không được nhập chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (dtp_createdate.Created == false)
            {
                MessageBox.Show("Không để trống ngày", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_customer.Text == "")
            {
                MessageBox.Show("Không để trống khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbx_user.Text == "")
            {
                MessageBox.Show("Không để trống use", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!rdb_dathanhtoan.Checked && !rdb_chuathanhtoan.Checked)
            {
                MessageBox.Show("Chọn trạng thái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            else
            {
                BillView billView = new BillView()
                {
                    MaHD = txt_mahd.Text,
                    Discount = txt_discount.Text,
                    Create_Date = DateTime.Now,
                    Customer_Id = _icustomerService.GetCustomer().FirstOrDefault(c => c.Name == cbx_customer.Text).CustomerId,
                    User_Id = _iuserService.GetAllUser().FirstOrDefault(c => c.UserName == cbx_user.Text).Id,

                };
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_ibillServices.Add(billView));
                    _lstbillViews = _ibillServices.Get();
                    LoadToGridView(_lstbillViews);
                }
            }
            LoadToGridView(_lstbillViews);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bool so = Regex.IsMatch(txt_discount.Text, @"^[0-9]");
            if (txt_mahd.Text == "" && txt_mahd.Text.Length < 5)
            {
                txt_mahd.BackColor = Color.Yellow;
                MessageBox.Show("Không để mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_mahd.Text.Contains(" "))
            {
                MessageBox.Show("Không được để dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_discount.Text == "")
            {
                MessageBox.Show("Không để trống discount", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_discount.Text.Contains(" "))
            {
                MessageBox.Show("Không được để dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so)
            {
                MessageBox.Show("Không được nhập chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (dtp_createdate.Created == false)
            {
                MessageBox.Show("Không để trống ngày", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_customer.Text == "")
            {
                MessageBox.Show("Không để trống khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbx_user.Text == "")
            {
                MessageBox.Show("Không để trống use", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!rdb_dathanhtoan.Checked && !rdb_chuathanhtoan.Checked)
            {
                MessageBox.Show("Chọn trạng thái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            else
            {


                BillView billView = new BillView()
                {
                    Id = _idhd,
                    MaHD = txt_mahd.Text,
                    Discount = txt_discount.Text,
                    Create_Date = DateTime.Now,
                    Customer_Id = _icustomerService.GetCustomer().FirstOrDefault(C => C.Name == cbx_customer.Text).CustomerId,
                    User_Id = _iuserService.GetAllUser().FirstOrDefault(C => C.UserName == cbx_user.Text).Id,
                    Status = rdb_dathanhtoan.Checked == true ? 1 : 0,
                };
                DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_ibillServices.Update(billView));
                    _lstbillViews = _ibillServices.Get();
                    LoadToGridView(_lstbillViews);
                }
            }
            LoadToGridView(_lstbillViews);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_ibillServices.Remove(_idhd));
                _lstbillViews = _ibillServices.Get();
                LoadToGridView(_lstbillViews);
            }

            LoadToGridView(_lstbillViews);

        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idhd = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString());
            txt_mahd.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            txt_discount.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            dtp_createdate.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
            cbx_customer.Text = dtg_show.CurrentRow.Cells[6].Value.ToString();
            cbx_user.Text = dtg_show.CurrentRow.Cells[5].Value.ToString();
            if (Convert.ToString(dtg_show.CurrentRow.Cells[11].Value) == "Đã thanh toán") rdb_dathanhtoan.Checked = true;
            if (Convert.ToString(dtg_show.CurrentRow.Cells[11].Value) == "Chưa thanh toán") rdb_chuathanhtoan.Checked = true;

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            var a = _ibillServices.Get().Where(c => c.MaHD.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            if (a == null)
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
            LoadToGridView(a);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var a = _ibillServices.Get().Where(c => c.Phone.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            if (a == null)
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
            LoadToGridView(a);

        }
    }
}
