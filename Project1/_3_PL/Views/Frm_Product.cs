using _1_DAL.IResponsitory;
using _1_DAL.Models;
using _1_DAL.Responsitory;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Product : Form
    {
        public IProductService _productService;
        public ICategoryServices _categoryServices;
        public ISizeServices _sizeServices;
        public IColorServices _colorServices;
        public ISupplierServices _supplierServices;
        public Guid _id;
        public List<ProductView> _lstProduct;
        public Frm_Product()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryServices = new CategoryServices();
            _sizeServices = new SizeServices();
            _colorServices = new ColorServices();
            _supplierServices = new SupplierServices();
            _lstProduct = new List<ProductView>();
            _lstProduct = _productService.GetAll();
            LoadData(_lstProduct);
            L0ad();
            LoadColor();
            LoadSize();
            LoadCategory();
            LoadSup();
        }

        public void LoadColor()
        {
            foreach (var x in _colorServices.GetColors())
            {
                cbx_color.Items.Add(x.Name);
            }
            //cbx_color.SelectedIndex = 0;
        }
        public void LoadSize()
        {
            foreach (var x in _sizeServices.GetSizes())
            {
                cbx_size.Items.Add(x.Name);
            }
            //cbx_size.SelectedIndex = 0;
        }
        public void LoadCategory()
        {

            foreach (var x in _categoryServices.GetCategorys())
            {
                cbx_cate.Items.Add(x.Name);
            }
            //cbx_cate.SelectedIndex = 0;

        }
        public void LoadSup()
        {

            foreach (var x in _supplierServices.GetSuppliers())
            {
                cbx_suplplier.Items.Add(x.Name);
            }
            //cbx_suplplier.SelectedIndex = 0;

        }


        public void LoadData(List<ProductView> _productViews)
        {
            dtg_view.ColumnCount = 11;
            dtg_view.Columns[0].Name = "Id";
            dtg_view.Columns[0].Visible = false;
            dtg_view.Columns[1].Name = "Cate";

            dtg_view.Columns[2].Name = "Size";

            dtg_view.Columns[3].Name = "Color";

            dtg_view.Columns[4].Name = "Supplier";

            dtg_view.Columns[5].Name = "Ma";
            dtg_view.Columns[6].Name = "Name";
            dtg_view.Columns[7].Name = "Quantity";
            dtg_view.Columns[8].Name = "Price";
            dtg_view.Columns[9].Name = "Description";
            dtg_view.Columns[10].Name = "Status";
            dtg_view.Rows.Clear();
            foreach (var x in _productViews)
            {

                dtg_view.Rows.Add(x.Id,
                    (x.Cate_Id != null) ? _categoryServices.GetCategorys().FirstOrDefault(c => c.Id == x.Cate_Id).Name : " ",
                    (x.Size_Id != null) ? _sizeServices.GetSizes().FirstOrDefault(c => c.Id == x.Size_Id).Name : " ",
                    (x.Color_Id != null) ? _colorServices.GetColors().FirstOrDefault(c => c.Id == x.Color_Id).Name : " ",
                    (x.Supplier_Id != null) ? _supplierServices.GetSuppliers().FirstOrDefault(c => c.Id == x.Supplier_Id).Name : " ",
                    x.MaSp, x.Name, x.Quantity, x.Price, x.Description, x.Status == 1 ? "Còn Hàng" : "Hết Hàng");
            }
        }
        private void dtg_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_view.ColumnCount = 10;
            dtg_view.Columns[0].Name = "Id";
            dtg_view.Columns[0].Visible = false;
            dtg_view.Columns[1].Name = "Cate";

            dtg_view.Columns[2].Name = "Size";

            dtg_view.Columns[3].Name = "Color";

            dtg_view.Columns[4].Name = "Supplier";

            dtg_view.Columns[5].Name = "Ma";
            dtg_view.Columns[6].Name = "Name";
            dtg_view.Columns[7].Name = "Quantity";
            dtg_view.Columns[8].Name = "Price";
            dtg_view.Columns[9].Name = "Description";
            dtg_view.Columns[10].Name = "Status";
            dtg_view.Rows.Clear();
            foreach (var x in _productService.GetAll())
            {

                dtg_view.Rows.Add(x.Id,
                    (x.Cate_Id != null) ? _categoryServices.GetCategorys().FirstOrDefault(c => c.Id == x.Cate_Id).Name : " ",
                    (x.Size_Id != null) ? _sizeServices.GetSizes().FirstOrDefault(c => c.Id == x.Size_Id).Name : " ",
                    (x.Color_Id != null) ? _colorServices.GetColors().FirstOrDefault(c => c.Id == x.Color_Id).Name : " ",
                    (x.Supplier_Id != null) ? _supplierServices.GetSuppliers().FirstOrDefault(c => c.Id == x.Supplier_Id).Name : " ",
                    x.MaSp, x.Name,
                    x.Quantity,
                    x.Price,
                    x.Price,
                    x.Description,
                    x.Status == 1 ? "Còn Hàng" : "Hết Hàng");
            }
        }
        public void L0ad()
        {
            var pro = _productService.GetAll().FirstOrDefault();
            if (pro.Quantity == 0)
            {
                pro.Status = 0;
                _productService.Update(pro);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[0-9])(?=.*[a-zA-Z])[a-zA-Z0-9]+$";
            bool chuso = Regex.IsMatch(txt_Ma.Text, pattern);
            bool so = Regex.IsMatch(txt_price.Text, @"^[0-9]");
            bool so1 = Regex.IsMatch(txt_quantity.Text, @"^[0-9]");
            var lst = _productService.GetAll();
            string maCanKiemTra = txt_Ma.Text;

            bool isMaTrung = lst.Any(product => product.MaSp == maCanKiemTra);

            if (txt_name.Text == "")
            {
                MessageBox.Show("Không để trống tên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_name.Text.Length > 40)
            {
                MessageBox.Show("Nhập tên sản phẩm quá dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_quantity.Text == "")
            {
                MessageBox.Show("Số lượng không để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_quantity.Text.Contains(" "))
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so1)
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (decimal.Parse(txt_quantity.Text).ToString().Length > 9)
            {
                MessageBox.Show("Số lượng quá lớn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (txt_price.Text == "")
            {
                MessageBox.Show("Không để trống giá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_price.Text.Contains(" "))
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so)
            {
                MessageBox.Show("Gía Phải là số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (decimal.Parse(txt_price.Text).ToString().Length > 9)
            {
                MessageBox.Show("Gía quá cao", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_Ma.Text == "")
            {
                MessageBox.Show("Không để mã hóa đơn trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Ma.Text.Length > 15)
            {
                MessageBox.Show("Không để mã hóa đơn dài quá 15 kí tự", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_Ma.Text.Contains(" "))
            {
                MessageBox.Show("Nhập mã không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (!chuso)
            {
                MessageBox.Show("Nhập mã phải chứa số và chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (isMaTrung)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_des.Text == "")
            {
                MessageBox.Show("Không để trống mô tả", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_des.Text.Length > 120)
            {
                MessageBox.Show("Mô tả dài quá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!rbtn_ConHang.Checked && !rbtn_HetHang.Checked)
            {
                MessageBox.Show("Chọn trạng thái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_color.Text == "")
            {
                MessageBox.Show("Không để trống màu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_size.Text == "")
            {
                MessageBox.Show("Không để trống size", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (cbx_cate.Text == "")
            {
                MessageBox.Show("Không để trống cate", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_suplplier.Text == "")
            {
                MessageBox.Show("Không để trống nhà cung cấp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            else
            {
                var them = new ProductView()
                {
                    Cate_Id = _categoryServices.GetCategorys().FirstOrDefault(C => C.Name == cbx_cate.Text).Id,
                    Size_Id = _sizeServices.GetSizes().FirstOrDefault(C => C.Name == cbx_size.Text).Id,
                    Color_Id = _colorServices.GetColors().FirstOrDefault(C => C.Name == cbx_color.Text).Id,
                    Supplier_Id = _supplierServices.GetSuppliers().FirstOrDefault(C => C.Name == cbx_suplplier.Text).Id,
                    MaSp = txt_Ma.Text,
                    Name = txt_name.Text,
                    Quantity = Convert.ToInt32(txt_quantity.Text),
                    Price = Convert.ToInt32(txt_price.Text),
                    Description = txt_des.Text,
                    Status = rbtn_ConHang.Checked == true ? 1 : 0,
                };
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(
                    _productService.Add(them));
                    _lstProduct = _productService.GetAll();
                    LoadData(_lstProduct);
                }
                _lstProduct = _productService.GetAll();
                LoadData(_lstProduct);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[0-9])(?=.*[a-zA-Z])[a-zA-Z0-9]+$";
            bool chuso = Regex.IsMatch(txt_Ma.Text, pattern);
            bool so = Regex.IsMatch(txt_price.Text, @"^[0-9]");
            bool so1 = Regex.IsMatch(txt_quantity.Text, @"^[0-9]");
            var lst = _productService.GetAll();
            string maCanKiemTra = txt_Ma.Text;

            bool isMaTrung = lst.Any(product => product.MaSp == maCanKiemTra);

            if (txt_name.Text == "")
            {
                MessageBox.Show("Không để trống tên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_name.Text.Length > 40)
            {
                MessageBox.Show("Nhập tên sản phẩm quá dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_quantity.Text == "")
            {
                MessageBox.Show("Số lượng không để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_quantity.Text.Contains(" "))
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so1)
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (decimal.Parse(txt_quantity.Text).ToString().Length > 9)
            {
                MessageBox.Show("Số lượng quá lớn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (txt_price.Text == "")
            {
                MessageBox.Show("Không để trống giá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_price.Text.Contains(" "))
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so)
            {
                MessageBox.Show("Gía Phải là số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (decimal.Parse(txt_price.Text).ToString().Length > 9)
            {
                MessageBox.Show("Gía quá cao", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_Ma.Text == "")
            {
                MessageBox.Show("Không để mã hóa đơn trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Ma.Text.Length > 15)
            {
                MessageBox.Show("Không để mã hóa đơn dài quá 15 kí tự", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_Ma.Text.Contains(" "))
            {
                MessageBox.Show("Nhập mã không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (!chuso)
            {
                MessageBox.Show("Nhập mã phải chứa số và chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (txt_des.Text == "")
            {
                MessageBox.Show("Không để trống mô tả", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_des.Text.Length > 120)
            {
                MessageBox.Show("Mô tả dài quá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!rbtn_ConHang.Checked && !rbtn_HetHang.Checked)
            {
                MessageBox.Show("Chọn trạng thái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_color.Text == "")
            {
                MessageBox.Show("Không để trống màu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_size.Text == "")
            {
                MessageBox.Show("Không để trống size", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (cbx_cate.Text == "")
            {
                MessageBox.Show("Không để trống cate", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_suplplier.Text == "")
            {
                MessageBox.Show("Không để trống nhà cung cấp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




            else
            {
                ProductView pr = new ProductView()
                {
                    Id = _id,
                    Cate_Id = _categoryServices.GetCategorys().FirstOrDefault(C => C.Name == cbx_cate.Text).Id,
                    Size_Id = _sizeServices.GetSizes().FirstOrDefault(C => C.Name == cbx_size.Text).Id,
                    Color_Id = _colorServices.GetColors().FirstOrDefault(C => C.Name == cbx_color.Text).Id,
                    Supplier_Id = _supplierServices.GetSuppliers().FirstOrDefault(C => C.Name == cbx_suplplier.Text).Id,
                    MaSp = txt_Ma.Text,
                    Name = txt_name.Text,
                    Quantity = Convert.ToInt32(txt_quantity.Text),
                    Price = Convert.ToInt32(txt_price.Text),
                    Description = txt_des.Text,
                    Status = rbtn_ConHang.Checked == true ? 1 : 0,


                };
                DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_productService.Update(pr));
                    _lstProduct = _productService.GetAll();
                    LoadData(_lstProduct);
                }
                _lstProduct = _productService.GetAll();
                LoadData(_lstProduct);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_productService.Remove(_id));
                _lstProduct = _productService.GetAll();
                LoadData(_lstProduct);
            }
            _lstProduct = _productService.GetAll();
            LoadData(_lstProduct);
        }



        private void dtg_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= _productService.GetAll().Count())
            {
                return;
            }
            _id = Guid.Parse(Convert.ToString(dtg_view.Rows[rd].Cells[0].Value));
            cbx_cate.Text = Convert.ToString(dtg_view.Rows[rd].Cells[1].Value);
            cbx_size.Text = Convert.ToString(dtg_view.Rows[rd].Cells[2].Value);
            cbx_color.Text = Convert.ToString(dtg_view.Rows[rd].Cells[3].Value);
            cbx_suplplier.Text = Convert.ToString(dtg_view.Rows[rd].Cells[4].Value);
            txt_Ma.Text = Convert.ToString(dtg_view.Rows[rd].Cells[5].Value);
            txt_name.Text = Convert.ToString(dtg_view.Rows[rd].Cells[6].Value);
            txt_quantity.Text = Convert.ToString(dtg_view.Rows[rd].Cells[7].Value);
            txt_price.Text = Convert.ToString(dtg_view.Rows[rd].Cells[8].Value);
            txt_des.Text = Convert.ToString(dtg_view.Rows[rd].Cells[9].Value);
            if (Convert.ToString(dtg_view.Rows[rd].Cells[10].Value) == "Còn Hàng") rbtn_ConHang.Checked = true;
            if (Convert.ToString(dtg_view.Rows[rd].Cells[10].Value) == "Hết Hàng") rbtn_HetHang.Checked = true;





        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var lst = _productService.GetAll().Where(c => c.Name.Contains(txt_timkiem.Text.ToLower())).ToList();
            if (lst == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            LoadData(lst);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Color frm1 = new Frm_Color();
            frm1.ShowDialog();
            frm1.MdiParent = this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Size frm2 = new Frm_Size();
            frm2.ShowDialog();
            frm2.MdiParent = this;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Category frm3 = new Frm_Category();
            frm3.ShowDialog();
            frm3.MdiParent = this;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Supplier frm4 = new Frm_Supplier();
            frm4.ShowDialog();
            frm4.MdiParent = this;
        }
    }
}
