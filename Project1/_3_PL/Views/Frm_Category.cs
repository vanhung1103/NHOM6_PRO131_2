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
        public Frm_Category()
        {
            InitializeComponent();
            cateform = new CategoryServices();
            loaisanphams = new CategoryView();
        }
        private void Frm_Category_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            dtg_cate.Rows.Clear();
            dtg_cate.ColumnCount = 2;
            dtg_cate.Columns[0].Name = "Id";
            dtg_cate.Columns[1].Name = "Name";
            foreach (var x in cateform.Get())
            {
                dtg_cate.Rows.Add(x.Id, x.Name);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (loaisanphams != null)
            {
                cateform.Remove(loaisanphams.Id);
                LoadData();
                MessageBox.Show("Xoa thanh cong", "Xoa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (loaisanphams != null)
            {
                loaisanphams.Name = txt_name.Text;
                cateform.Update(loaisanphams);
                LoadData();
                MessageBox.Show("Sua thanh cong", "Sua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new CategoryView()
            {
                Id = Guid.NewGuid(),
                Name = txt_name.Text,
            };
            if (them.Name == loaisanphams.Name)
            {
                MessageBox.Show("Da ton tai");
            }
            else
            {
                if (cateform.Add(them) != null)
                {
                    LoadData();
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
                }
            }
        
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = cateform.Get().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dtg_cate.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dtg_cate.Rows.Add(x.Id, x.Name);
            }
        }
        Guid id;
        private void dtg_color_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (selectedRow >= 0 && selectedRow < dtg_cate.Rows.Count)
            {
                id = Guid.Parse(dtg_cate.CurrentRow.Cells[0].Value.ToString());
                txt_name.Text = dtg_cate.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
