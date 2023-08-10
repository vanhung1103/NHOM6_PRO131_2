using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = _1_DAL.Models.Color;

namespace _3_PL.Views
{
    public partial class Frm_Color : Form
    {
        IColorServices colorform;
        ColorView maus;
        public Frm_Color()
        {
            InitializeComponent();
            colorform = new ColorServices();
            maus = new ColorView();
        }

        private void Frm_Color_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dtg_color.Rows.Clear();
            dtg_color.ColumnCount = 2;
            dtg_color.Columns[0].Name = "Id";
            dtg_color.Columns[1].Name = "Name";
            foreach (var x in colorform.Get())
            {
                dtg_color.Rows.Add(x.Id, x.Name);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new ColorView()
            {
                Id = Guid.NewGuid(),
                Name = txt_name.Text,
            };
            if (them.Name == maus.Name)
            {
                MessageBox.Show("Da ton tai");
            }
            else
            {
                if (colorform.Add(them) != null)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (maus != null)
            {
                maus.Name = txt_name.Text;
                colorform.Update(maus);
                LoadData();
                MessageBox.Show("Sua thanh cong", "Sua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (maus != null)
            {
                colorform.Remove(maus.Id);
                LoadData();
                MessageBox.Show("Xoa thanh cong", "Xoa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = colorform.Get().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dtg_color.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dtg_color.Rows.Add(x.Id, x.Name);
            }
        }
        Guid id;
        private void dtg_color_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (selectedRow >= 0 && selectedRow < dtg_color.Rows.Count)
            {
                id = Guid.Parse(dtg_color.CurrentRow.Cells[0].Value.ToString());
                txt_name.Text = dtg_color.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
