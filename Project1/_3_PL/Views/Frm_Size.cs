﻿using _1_DAL.Models;
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

namespace _3_PL.Views
{
    public partial class Frm_Size : Form
    {
        ISizeServices sizeform;
        SizeView kichcos;
        Guid id;
        public Frm_Size()
        {
            InitializeComponent();
            sizeform = new SizeServices();
            kichcos = new SizeView();
        }
        void LoadData()
        {
            dtg_size.Rows.Clear();
            dtg_size.ColumnCount = 2;
            dtg_size.Columns[0].Name = "Id";
            dtg_size.Columns[1].Name = "Name";
            foreach (var x in sizeform.GetSizes())
            {
                dtg_size.Rows.Add(x.Id, x.Name);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new SizeView()
            {
                Id = id,
                Name = txt_name.Text,
            };
            if (them.Name == kichcos.Name)
            {
                MessageBox.Show("Đã tồn tại kích cỡ sản phẩm");
            }
            else
            {
                if (sizeform.Add(them) != null)
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

        private void Frm_Size_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (kichcos != null)
            {
                kichcos.Id = id;
                kichcos.Name = txt_name.Text;
                sizeform.Update(kichcos);
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
            if (kichcos != null)
            {
                sizeform.Remove(kichcos.Id=id);
                LoadData();
                MessageBox.Show("Xóa thành công", "Xóa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void dtg_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (selectedRow >= 0 && selectedRow < dtg_size.Rows.Count)
            {
                id = Guid.Parse(dtg_size.CurrentRow.Cells[0].Value.ToString());
                txt_name.Text = dtg_size.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = sizeform.GetSizes().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dtg_size.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dtg_size.Rows.Add(x.Id, x.Name);
            }
        }
    }
}
