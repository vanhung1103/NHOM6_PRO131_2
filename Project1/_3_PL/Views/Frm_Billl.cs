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
    public partial class Frm_Billl : Form
    {
        public Guid _idhd;
        public IBillServices _ibillServices;
        public ICustomerServices _icustomerService;
        public IUserServices _iuserService;
        public IVoucherServices _iVoucherServices;
        List<BillView> _lstbillViews;

        public Frm_Billl()
        {
            _ibillServices = new BillServices();
            _lstbillViews = new List<BillView>();
            _iVoucherServices = new VoucherServices();
            _icustomerService = new CustomerServices();
            _iuserService = new UserServices();

            InitializeComponent();
            LoadTocbb();
            LoadTocbuser();
            LoadTocbvoucher();
            LoadToGridView();
        }
        public void LoadTocbb()
        {
            foreach (var item in _icustomerService.GetCustomer())
            {
                cbx_customer.Items.Add(item);
            }
        }
        public void LoadTocbuser()
        {
            foreach (var item in _iuserService.GetAllUser())
            {
                cbx_user.Items.Add(item);
            }
        }
        public void LoadTocbvoucher()
        {
            foreach (var item in _iVoucherServices.GetAllVoucher())
            {
                cbx_voucher.Items.Add(item);
            }
        }
        public void LoadToGridView()
        {
            int stt = 1;
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 8;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;

            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã hóa đơn";
            dtg_show.Columns[3].Name = "Tên sản phẩm";
            dtg_show.Columns[4].Name = "Discount";
            dtg_show.Columns[5].Name = "Ngày tạo";
            dtg_show.Columns[6].Name = "Tổng";
            dtg_show.Columns[7].Name = "Mô tả";
            dtg_show.Columns[8].Name = "UserName";
            dtg_show.Columns[9].Name = "Tên khách";
            dtg_show.Columns[10].Name = "Voucher";
            dtg_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_show.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtg_show.AllowUserToResizeColumns = false;
            foreach (var item in _ibillServices.Get())
            {
                dtg_show.Rows.Add(item.Id,
                    stt++,
                    item.MaHD,
                    item.ProductName,
                    item.Discount,
                    item.Create_Date,
                    item.Total,
                    item.Description,
                    (item.User_Id != null) ? _iuserService.GetAllUser().FirstOrDefault(c => c.Id == item.User_Id).UserName : " ",
                    (item.Customer_Id != null) ? _icustomerService.GetCustomer().FirstOrDefault(c => c.CustomerId == item.Customer_Id).Name : " ",
                    (item.Voucher_Id != null) ? _iVoucherServices.GetAllVoucher().FirstOrDefault(c => c.Id == item.Voucher_Id).Name : " "

                    );
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text == "")
            {
                txt_mahd.BackColor = Color.Yellow;
                MessageBox.Show("Không để trống mã hóa đơn, vui lòng nhập mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BillView billView = new BillView()
                {
                    MaHD = txt_mahd.Text,
                    ProductName = txt_productname.Text,
                    Discount = txt_discount.Text,
                    Create_Date = DateTime.Now,
                    Total = Convert.ToInt32(txt_total.Text),
                    Description = txt_des.Text,
                    Customer_Id = _ibillServices.Get().FirstOrDefault(C => C.MaHD == cbx_customer.Text).Id,
                    User_Id = _ibillServices.Get().FirstOrDefault(C => C.MaHD == cbx_user.Text).Id,
                    Voucher_Id = _ibillServices.Get().FirstOrDefault(C => C.MaHD == cbx_voucher.Text).Id,

                };
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_ibillServices.Add(billView));
                    LoadToGridView();
                }
            }
            LoadToGridView();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            BillView billView = new BillView()
            {
                Id = _idhd,
                MaHD = txt_mahd.Text,
                ProductName = txt_productname.Text,
                Discount = txt_discount.Text,
                Create_Date = DateTime.Now,
                Total = Convert.ToInt32(txt_total.Text),
                Description = txt_des.Text,
                Customer_Id = _ibillServices.Get().FirstOrDefault(C => C.MaHD == cbx_customer.Text).Id,
                User_Id = _ibillServices.Get().FirstOrDefault(C => C.MaHD == cbx_user.Text).Id,
                Voucher_Id = _ibillServices.Get().FirstOrDefault(C => C.MaHD == cbx_voucher.Text).Id,
            };
            DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_ibillServices.Update(billView));
                LoadToGridView();
            }
            LoadToGridView();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_ibillServices.Remove(_idhd));
                LoadToGridView();
            }
            LoadToGridView();

        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idhd = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString());
            txt_mahd.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            txt_productname.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            txt_discount.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
            dtp_createdate.Text = dtg_show.CurrentRow.Cells[5].Value.ToString();
            txt_total.Text = dtg_show.CurrentRow.Cells[6].Value.ToString();
            txt_des.Text = dtg_show.CurrentRow.Cells[7].Value.ToString();
            cbx_customer.Text = dtg_show.CurrentRow.Cells[8].Value.ToString();
            cbx_user.Text = dtg_show.CurrentRow.Cells[9].Value.ToString();
            cbx_voucher.Text = dtg_show.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
