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
    public partial class Frm_Supplier : Form
    {
        ISupplierServices supform;
        SupplierView nhacungcaps;
        public Frm_Supplier()
        {
            InitializeComponent();
            supform = new SupplierServices();
            nhacungcaps = new SupplierView();
        }
        void LoadData()
        {
            dtg_sup.Rows.Clear();
            dtg_sup.ColumnCount = 2;
            dtg_sup.Columns[0].Name = "Id";
            dtg_sup.Columns[1].Name = "Name";
            foreach (var x in supform.GetSuppliers())
            {
                dtg_sup.Rows.Add(x.Id, x.Name);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new SupplierView()
            {
                Id = Guid.NewGuid(),
                Name = txt_name.Text,
            };
            if (them.Name == nhacungcaps.Name)
            {
                MessageBox.Show("Đã tồn tại nhà cung cấp");
            }
            else
            {
                if (supform.Add(them) != null)
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

        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (nhacungcaps != null)
            {
                nhacungcaps.Name = txt_name.Text;
                supform.Update(nhacungcaps);
                LoadData();
                MessageBox.Show("Sửa thành công", "Sửa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (nhacungcaps != null)
            {
                supform.Remove(nhacungcaps.Id);
                LoadData();
                MessageBox.Show("Xóa thành công", "Xóa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = supform.GetSuppliers().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dtg_sup.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dtg_sup.Rows.Add(x.Id, x.Name);
            }
        }
        Guid id;
        private void dtg_sup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (selectedRow >= 0 && selectedRow < dtg_sup.Rows.Count)
            {
                id = Guid.Parse(dtg_sup.CurrentRow.Cells[0].Value.ToString());
                txt_name.Text = dtg_sup.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
