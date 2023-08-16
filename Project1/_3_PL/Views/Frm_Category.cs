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
    public partial class Frm_Category : Form
    {
        ICategoryServices cateform;
        CategoryView loaisanphams;
        Guid id;
        public Frm_Category()
        {
            InitializeComponent();
            cateform = new CategoryServices();
            loaisanphams = new CategoryView();
        }
        private void Frm_Category_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dtg_cate.Rows.Clear();
            dtg_cate.ColumnCount = 2;
            dtg_cate.Columns[0].Name = "Id";
            dtg_cate.Columns[1].Name = "Name";
            foreach (var x in cateform.GetCategorys())
            {
                dtg_cate.Rows.Add(x.Id, x.Name);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (loaisanphams != null)
            {
                cateform.Remove(loaisanphams.Id=id);
                LoadData();
                MessageBox.Show("Xóa thành công", "Xóa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (loaisanphams != null)
            {
                loaisanphams.Id = id;
                loaisanphams.Name = txt_name.Text;
                cateform.Update(loaisanphams);
                LoadData();
                MessageBox.Show("Sửa thành công", "Sửa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new CategoryView()
            {
                Id = id,
                Name = txt_name.Text,
            };
            if (them.Name == loaisanphams.Name)
            {
                MessageBox.Show("Đã tồn tại loại sản phẩm");
            }
            else
            {
                if (cateform.Add(them) != null)
                {
                    LoadData();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Error", "Lỗi", MessageBoxButtons.OK);
                }
            }

        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = cateform.GetCategorys().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dtg_cate.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dtg_cate.Rows.Add(x.Id, x.Name);
            }
        }
        private void dtg_color_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (selectedRow >= 0 && selectedRow < dtg_cate.Rows.Count)
            {
                id = Guid.Parse(dtg_cate.CurrentRow.Cells[0].Value.ToString());
                txt_name.Text = dtg_cate.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
