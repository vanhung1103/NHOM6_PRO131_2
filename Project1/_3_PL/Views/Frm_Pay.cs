using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModel;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Pay : Form
    {
        public IBillServices _ibillServices;
        public IBillDetailServices _ibillDetailServices;
        public IProductService _iproductService;
        public ICustomerServices _icustomerService;
        public IUserServices _iuserService;
        public List<ProductView> _lstpro;
        public IVoucherServices _IvoucherServices;
        public ICategoryServices _categoryServices;
        public ISizeServices _sizeServices;
        public IColorServices _colorServices;
        public ISupplierServices _supplierServices;
        public Guid _id;
        public Frm_Pay()
        {
            InitializeComponent();
            _ibillServices = new BillServices();
            _ibillDetailServices = new BillDetailServices();
            _iproductService = new ProductService();
            _icustomerService = new CustomerServices();
            _iuserService = new UserServices();
            _categoryServices = new CategoryServices();
            _sizeServices = new SizeServices();
            _colorServices = new ColorServices();
            _supplierServices = new SupplierServices();
            _IvoucherServices = new VoucherServices();

            _lstpro = new List<ProductView>();
            L0ad();
            LoadToCart();
            LoadToProduct();
            LoadKH();
            Loaduser();
            LoadHoaDonCho();
            lb_hoantien.Visible = false;
            btn_thanhtoan.Enabled = false;
            txt_tongtien.ReadOnly = true;
            txt_giamgia.ReadOnly = true;
            txt_khachtra.ReadOnly = true;
        }

        public void L0ad()
        {
            var pro = _iproductService.GetAll().FirstOrDefault();
            if (pro.Quantity == 0)
            {
                pro.Status = 0;
                _iproductService.Update(pro);
            }
        }
        public void LoadKH()
        {
            foreach (var item in _icustomerService.GetCustomer())
            {
                cbx_customer.Items.Add(item.Name);
            }
        }

        public void Loaduser()
        {
            foreach (var item in _iuserService.GetAllUser())
            {
                cbx_user.Items.Add(item.UserName);
            }
        }
        public void LoadToProduct()
        {
            dtg_sanpham.ColumnCount = 11;
            dtg_sanpham.Columns[0].Name = "Id";
            dtg_sanpham.Columns[0].Visible = false;
            dtg_sanpham.Columns[1].Name = "Cate";

            dtg_sanpham.Columns[2].Name = "Size";

            dtg_sanpham.Columns[3].Name = "Color";

            dtg_sanpham.Columns[4].Name = "Supplier";

            dtg_sanpham.Columns[5].Name = "Ma";
            dtg_sanpham.Columns[6].Name = "Name";
            dtg_sanpham.Columns[7].Name = "Quantity";
            dtg_sanpham.Columns[8].Name = "Price";
            dtg_sanpham.Columns[9].Name = "Description";
            dtg_sanpham.Columns[10].Name = "Status";
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "select";
                button.HeaderText = "select";
                button.Text = ("select");
                button.UseColumnTextForButtonValue = true;
                this.dtg_sanpham.Columns.Add(button);
            }
            dtg_sanpham.Rows.Clear();
            foreach (var x in _iproductService.GetAll())
            {

                dtg_sanpham.Rows.Add(x.Id,
                    (x.Cate_Id != null) ? _categoryServices.GetCategorys().FirstOrDefault(c => c.Id == x.Cate_Id).Name : " ",
                    (x.Size_Id != null) ? _sizeServices.GetSizes().FirstOrDefault(c => c.Id == x.Size_Id).Name : " ",
                    (x.Color_Id != null) ? _colorServices.GetColors().FirstOrDefault(c => c.Id == x.Color_Id).Name : " ",
                    (x.Supplier_Id != null) ? _supplierServices.GetSuppliers().FirstOrDefault(c => c.Id == x.Supplier_Id).Name : " ",
                    x.MaSp, x.Name, x.Quantity, x.Price, x.Description,
                    x.Status == 1 ? "Còn Hàng" : "Hết Hàng");
            }
        }
        public void LoadToCart()
        {
            dtg_giohang.Rows.Clear();
            dtg_giohang.ColumnCount = 5;
            dtg_giohang.Columns[0].Name = "Id";
            dtg_giohang.Columns[0].Visible = false;

            dtg_giohang.Columns[1].Name = "Tên sản phẩm";
            dtg_giohang.Columns[2].Name = "Số lượng";
            dtg_giohang.Columns[3].Name = "Gía";
            dtg_giohang.Columns[4].Name = "Mô tả";
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "delete";
                button.HeaderText = "delete";
                button.Text = ("delete");
                button.UseColumnTextForButtonValue = true;
                dtg_giohang.Columns.Add(button);
            }
            foreach (var item in _lstpro)
            {
                dtg_giohang.Rows.Add(item.Id,
                    item.Name,
                    item.Quantity,
                    item.Price,
                    item.Description
                    );
            }
        }
        public void LoadHoaDonCho()
        {
            var lst = _ibillServices.Get().Where(c => c.Status == 0).ToList();

            dtg_hoadoncho.Rows.Clear();
            dtg_hoadoncho.ColumnCount = 7;
            dtg_hoadoncho.Columns[0].Name = "Id";
            dtg_hoadoncho.Columns[0].Visible = false;
            dtg_hoadoncho.Columns[1].Name = "User_Id";
            dtg_hoadoncho.Columns[1].Visible = false;
            dtg_hoadoncho.Columns[2].Name = "Customer_Id";
            dtg_hoadoncho.Columns[2].Visible = false;
            dtg_hoadoncho.Columns[3].Name = "Mã hóa đơn";
            dtg_hoadoncho.Columns[4].Name = "Tên khách hàng";
            dtg_hoadoncho.Columns[5].Name = "Ngày tạo hóa đơn";
            dtg_hoadoncho.Columns[6].Name = "Trạng thái";
            foreach (var item in _ibillServices.Get())
            {
                var customerName = (item.Customer_Id != null) ? _icustomerService.GetCustomer().FirstOrDefault(c => c.CustomerId == item.Customer_Id).Name : " ";
                var statusText = (item.Status == 1) ? "Đã thanh toán" : "Chưa thanh toán";

                var rowIndex = dtg_hoadoncho.Rows.Add(
                    item.Id,
                    item.User_Id,
                    item.Customer_Id,
                    item.MaHD,
                    customerName,
                    item.Create_Date,
                    statusText
                );

                if (item.Status == 1)
                {
                    dtg_hoadoncho.Rows[rowIndex].Visible = false; // Ẩn hàng đã thanh toán
                }
            }


        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            if (cbx_customer.Text == "")
            {
                MessageBox.Show("Nhập thông tin khách hàng");
            }
            else if (cbx_user.Text == "")
            {
                MessageBox.Show("Nhập nhân viên");

            }
            else
            {
                Random random = new Random();
                int minValue = 10;
                int maxValue = 99;
                int randomNumberInRange = random.Next(minValue, maxValue);
                BillView billView = new BillView()
                {
                    MaHD = "HD--" + randomNumberInRange,
                    Customer_Id = _icustomerService.GetCustomer().FirstOrDefault(c => c.Name == cbx_customer.Text).CustomerId,
                    Create_Date = DateTime.Now,
                    Discount = "không",
                    User_Id = _iuserService.GetAllUser().FirstOrDefault(c => c.UserName == cbx_user.Text).Id,
                    Status = 0
                };
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_ibillServices.Add(billView));
                    LoadHoaDonCho();
                }

            }
        }


        public void Reset()
        {
            txt_khachthanhtoan.Text = "";
            txt_tongtien.Text = "";
            txt_khachtra.Text = "";
            txt_giamgia.Text = "";
            txt_searchvoucher.Text = "";

        }

        private void dtg_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.RowIndex >= 0 && e.ColumnIndex == dtg_sanpham.Columns["select"].Index)
            {
                Guid id = Guid.Parse(dtg_sanpham.Rows[row].Cells["Id"].Value.ToString());
                ProductView productView = _iproductService.GetAll().FirstOrDefault(c => c.Id == id);
                var existingProduct = _lstpro.FirstOrDefault(p => p.Id == id);
                if (productView.Quantity > 0)
                {

                    if (existingProduct != null)
                    {
                        existingProduct.Quantity += 1;

                    }
                    else
                    {
                        productView.Quantity = 1;
                        _lstpro.Add(productView);
                    }

                    LoadToCart();
                    txt_tongtien.Text = _lstpro.Sum(c => c.Price * c.Quantity).ToString();
                    txt_khachtra.Text = _lstpro.Sum(c => c.Price * c.Quantity).ToString();
                }
                else
                {
                    var pro = _iproductService.GetAll().FirstOrDefault(c => c.Id == id);
                    if (pro.Quantity == 0)
                    {
                        pro.Status = 0;
                        _iproductService.Update(pro);
                        MessageBox.Show("Sản phẩm đã hết hàng");
                    }

                }
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_khachthanhtoan.Text == "")
            {
                MessageBox.Show("Nhập số tiền khách đưa.");



                var lst = _ibillServices.Get().FirstOrDefault(c => c.Id == _id);
                if (lst == null)
                {
                    MessageBox.Show("Hóa đơn không tồn tại hoặc có lỗi xảy ra.");
                }
                else
                {
                    if (lst.Status == 1)
                    {
                        MessageBox.Show("Hóa đơn đã được thanh toán.");
                    }
                    else
                    {
                        lst.Status = 1;
                        _ibillServices.Update(lst);
                        for (int i = 0; i < dtg_giohang.Rows.Count; i++)
                        {
                            var row = dtg_giohang.Rows[i];
                            var proIdValue = row.Cells[0].Value;

                            if (proIdValue != null && proIdValue != DBNull.Value)
                            {
                                if (Guid.TryParse(proIdValue.ToString(), out Guid proId))
                                {
                                    Random random = new Random();
                                    int minValue = 10;
                                    int maxValue = 99;
                                    int randomNumberInRange = random.Next(minValue, maxValue);
                                    BillDetailView billDetailView = new BillDetailView
                                    {
                                        MaHDCT = "HDCT--" + randomNumberInRange,
                                        Image = "Không có ảnh",
                                        Bill_Id = _id,
                                        Pro_Id = proId,
                                        Quantity = Convert.ToInt32(row.Cells[2].Value + ""),
                                        Price = Convert.ToInt32(row.Cells[3].Value + "")
                                    };
                                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không", "Thông báo", MessageBoxButtons.YesNo);

                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        MessageBox.Show(_ibillDetailServices.Add(billDetailView));

                                    }

                                    var product = _iproductService.GetAll().FirstOrDefault(c => c.Id == billDetailView.Pro_Id);
                                    if (product.Quantity < billDetailView.Quantity)
                                    {
                                        MessageBox.Show("Sản phẩm không đủ số lượng");
                                    }
                                    else
                                    {
                                        product.Quantity = product.Quantity - billDetailView.Quantity;
                                        _iproductService.Update(product);
                                    }

                                }

                                else
                                {
                                    MessageBox.Show("Giá trị Pro_Id không hợp lệ để chuyển đổi thành Guid.");
                                }
                            }
                            else
                            {

                            }


                        }

                    }
                }

                Reset();
                LoadHoaDonCho();
                LoadToCart();
                LoadToProduct();
                dtg_sanpham.Enabled = true;
                dtg_giohang.Rows.Clear();
            }
        }

        private void dtg_hoadoncho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_giohang.Rows.Clear();
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            _id = Guid.Parse(dtg_hoadoncho.CurrentRow.Cells[0].Value.ToString());
            dtg_sanpham.Enabled = true;

        }

        private void dtg_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var row = dtg_giohang.Rows[e.RowIndex];
                var id_Product = row.Cells[0].Value;

                if (id_Product != null && id_Product != DBNull.Value)
                {
                    var id = Guid.Parse(id_Product.ToString());
                    var address = _lstpro.FindIndex(x => x.Id == id);

                    if (address >= 0)
                    {
                        _lstpro.RemoveAt(address);
                        LoadToCart();
                    }
                }
                dtg_giohang.Rows.Clear();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void dtg_giohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void dtg_hoadoncho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cbx_user_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbx_voucher_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void cbx_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txt_khachthanhtoan_TextChanged(object sender, EventArgs e)
        {
            bool tien = Regex.IsMatch(txt_khachthanhtoan.Text, @"[0-9]");

            if (!tien)
            {
                MessageBox.Show("Nhập số không được nhập chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_khachthanhtoan.Text.Contains(" "))
            {
                MessageBox.Show("Không được dùng dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txt_khachthanhtoan.Text == "")
            {
                MessageBox.Show("Không để trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (decimal.Parse(txt_khachthanhtoan.Text).ToString().Length > 9 )
            {
                MessageBox.Show("Số tiền quá lớn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                if (decimal.TryParse(txt_khachthanhtoan.Text, out decimal khachThanhToan) &&
                decimal.TryParse(txt_tongtien.Text, out decimal tongTien))
                {
                    decimal discount = !string.IsNullOrEmpty(txt_giamgia.Text) ? decimal.Parse(txt_giamgia.Text) : 0;


                    if (txt_giamgia.Text != "")
                    {
                        decimal khachTra = tongTien - discount;
                        if (khachTra <= 0)
                        {
                            txt_khachtra.Text = 0 + "";
                        }
                        else
                        {
                            txt_khachtra.Text = khachTra.ToString();

                        }
                        if (khachThanhToan <= 0)
                        {
                            lb_hoantien.Visible = true;
                            lb_hoantien.Text = "0";

                        }
                        else
                        {
                            decimal hoanTien1 = khachThanhToan - khachTra;

                            lb_hoantien.Text = hoanTien1.ToString();
                            if (hoanTien1 >= 0)
                            {
                                btn_thanhtoan.Enabled = true;
                            }
                        }

                    }
                    else
                    {
                        decimal hoanTien = khachThanhToan - tongTien;

                        if (hoanTien <= 0)
                        {
                            lb_hoantien.Text = "0";
                            lb_hoantien.Visible = true;
                        }
                        else
                        {
                            lb_hoantien.Text = hoanTien.ToString();
                            lb_hoantien.Visible = true;
                        }
                        if (hoanTien >= 0)
                        {
                            btn_thanhtoan.Enabled = true;
                        }

                    }



                }
                else
                {
                }


                if (decimal.Parse(lb_hoantien.Text) >= 0)
                {
                    btn_thanhtoan.Enabled = true;
                }
            }

        }


        

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txt_khachtra_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dtp_createdate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lb_tienthua_Click(object sender, EventArgs e)
        {
        }

        private void lb_hoantien_Click(object sender, EventArgs e)
        {


        }

        private void lb_hoantien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_searchvoucher_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timvoucher_Click(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var lst = _IvoucherServices.GetAllVoucher().FirstOrDefault(c => c.Name == txt_searchvoucher.Text);
            if (lst.Status == 1)
            {
                MessageBox.Show("Voucher đã được sử dụng", "Thông báo");

            }
            else
            {
                if (lst == null)
                {
                    MessageBox.Show(" Không tìm thấy voucher", "Thông báo");
                }
                else
                {


                    if (lst.minPrice <= Convert.ToInt32(txt_tongtien.Text))
                    {
                        txt_giamgia.Text = lst.Voucher_Percent.ToString();
                        lst.Status = 1;
                        _IvoucherServices.UpdateVoucher(lst);
                        int tongTien, discount;

                        if (
                            int.TryParse(txt_tongtien.Text, out tongTien) &&
                            int.TryParse(txt_giamgia.Text, out discount)
                            )
                        {

                            decimal khachTra = tongTien - discount;


                            if (khachTra <= 0)
                            {
                                txt_khachtra.Text = 0 + "";
                            }
                            // Hiển thị nút thanh toán nếu có hoàn tiền
                        }

                    }
                    else
                    {
                        MessageBox.Show("Voucher không áp dụng cho đơn hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }
    }
}
