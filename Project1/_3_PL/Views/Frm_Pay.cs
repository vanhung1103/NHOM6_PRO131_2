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
    public partial class Frm_Pay : Form
    {
        public IBillServices _ibillServices;
        public IBillDetailServices _ibillDetailServices;
        public IProductService _iproductService;
        public ICustomerServices _icustomerService;
        public IUserServices _iuserService;
        public List<ProductView> _lstpro;

        public ICategoryServices _categoryServices;
        public ISizeServices _sizeServices;
        public IColorServices _colorServices;
        public ISupplierServices _supplierServices;
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
                    x.MaSp, x.Name, x.Quantity, x.Price, x.Description, x.Status == 1 ? "Còn Hàng" : "Hết Hàng");
            }
        }
        public void LoadToCart()
        {
            dtg_giohang.Rows.Clear();
            dtg_giohang.ColumnCount = 6;
            dtg_giohang.Columns[0].Name = "Id";
            dtg_giohang.Columns[0].Visible = false;
            dtg_giohang.Columns[1].Name = "Tên sản phẩm";
            dtg_giohang.Columns[2].Name = "Số lượng";
            dtg_giohang.Columns[3].Name = "Gía";
            dtg_giohang.Columns[4].Name = "Tổng tiền";
            dtg_giohang.Columns[5].Name = "Mô tả";
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
                    item.Price * item.Quantity,
                    item.Description
                    );
            }
        }
        public void HoaDonCho()
        {
            dtg_hoadoncho.Rows.Clear();
            dtg_hoadoncho.ColumnCount = 5;
            dtg_hoadoncho.Columns[0].Name = "Id";
            dtg_hoadoncho.Columns[0].Visible = false;

            dtg_hoadoncho.Columns[1].Name = "Mã hóa đơn";

            dtg_hoadoncho.Columns[2].Name = "Tên khách hàng";
            dtg_hoadoncho.Columns[3].Name = "Phone";

            dtg_hoadoncho.Columns[4].Name = "Ngày tạo hóa đơn";
            foreach (var item in _ibillServices.Get())
            {
                dtg_hoadoncho.Rows.Add(item.Id,
                    item.MaHD,
                    (item.Customer_Id != null) ?_icustomerService.GetCustomer().FirstOrDefault( c => c.CustomerId == item.Customer_Id).Name : " ",
                    (item.Customer_Id != null) ?_icustomerService.GetCustomer().FirstOrDefault( c => c.CustomerId == item.Customer_Id).Phone : " ",

                    item.Create_Date
                    );
            }
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                MessageBox.Show("Nhập đủ thông tin khách hàng");
            }
            else
            {
                
            }
        }
    }
}
