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
       
        public Frm_Product()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryServices = new CategoryServices();
            _sizeServices = new SizeServices();
            _colorServices = new ColorServices();
            _supplierServices = new SupplierServices();

            
            LoadData();

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


        public void LoadData()
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
            foreach (var x in _productService.GetAll())
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
                    x.MaSp, x.Name, x.Quantity, x.Price, x.Price, x.Description, x.Status == 1 ? "Còn Hàng" : "Hết Hàng");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new ProductView()
            {
                Id = Guid.NewGuid(),
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
                LoadData();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
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
                LoadData();
            }
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_productService.Remove(_id));
                LoadData();
            }
            LoadData();
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
           if(Convert.ToString(dtg_view.Rows[rd].Cells[10].Value) == "Còn Hàng") rbtn_ConHang.Checked = true;
           if( Convert.ToString(dtg_view.Rows[rd].Cells[10].Value) == "Hết Hàng") rbtn_HetHang.Checked = true;





        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {

        }
    }
}
