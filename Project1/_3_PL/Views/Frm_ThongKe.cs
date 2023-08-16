using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
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
    public partial class Frm_ThongKe : Form
    {
        IBillServices billServices;
        IBillDetailServices billDetailServices;
        IProductService productServices;
        BillDetail billDetailList;
        public Frm_ThongKe()
        {
            InitializeComponent();
            billServices = new BillServices();
            billDetailServices = new BillDetailServices();
            productServices = new ProductService();
            billDetailList = new BillDetail();
            LoadProduct();
        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 32; i++)
            {
                cbx_TKNgay.Items.Add(i);
            }
            for (int i = 1; i < 13; i++)
            {
                cbx_TKThang.Items.Add(i);
            }
            int currentYear = DateTime.Now.Year;
            for (int i = 2000; i <= currentYear; i++)
            {
                cbx_TKNam.Items.Add(i);
            }
        }
        private void Dtg_TKHD_RowsAdded(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            int rowCount = 0;
            foreach (DataGridViewRow row in dtg_TKHD.Rows)
            {
                bool rowHasData = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        rowHasData = true;
                        break;
                    }
                }
                if (rowHasData)
                {
                    rowCount = rowCount + 1;
                   
                }
            }
            label4.Text= rowCount.ToString();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            dtg_TKHD.RowsAdded += Dtg_TKHD_RowsAdded;
            foreach (var x in billServices.Get())
            {
                dtg_TKHD.Rows.Clear();
                dtg_TKHD.Rows.Add(x.MaHD, x.Create_Date, x.Status, x.Name);
                 
            }
            foreach (var x in billDetailServices.Get()) 
            { 
                dtg_TKSP.Rows.Clear();
                dtg_TKSP.Rows.Add( (x.Pro_Id != null) ? productServices.GetAll().FirstOrDefault(c => c.Id == x.Pro_Id).MaSp : " ",
                    (x.Pro_Id != null) ? productServices.GetAll().FirstOrDefault(c => c.Id == x.Pro_Id).Name : " ",
                    x.Quantity);
                label2.Text = (x.Price*x.Quantity).ToString();
            }
        }
        public void LoadProduct()
        {
            dtg_TKHD.RowsAdded += Dtg_TKHD_RowsAdded;

            dtg_TKHD.Rows.Clear();
            foreach (var x in billServices.Get())
            {
                dtg_TKHD.Rows.Clear();
                dtg_TKHD.Rows.Add(x.MaHD, x.Create_Date, x.Status);
            }
            dtg_TKSP.Rows.Clear();
            foreach (var x in billDetailServices.Get())
            {
                dtg_TKSP.Rows.Clear();
                dtg_TKSP.Rows.Add((x.Pro_Id != null) ? productServices.GetAll().FirstOrDefault(c => c.Id == x.Pro_Id).MaSp : " ",
                    (x.Pro_Id != null) ? productServices.GetAll().FirstOrDefault(c => c.Id == x.Pro_Id).Name : " ",
                    x.Quantity);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // tong tien hang
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // so hoa don
        }

        private void buttonTKNgay_Click(object sender, EventArgs e)
        {
            if (cbx_TKNgay.SelectedItem != null)
            {
                int selectedDay = (int)cbx_TKNgay.SelectedItem;
                foreach (var x in billServices.Get())
                {
                    if (x.Create_Date.Day == selectedDay)
                    {
                        MessageBox.Show("Đã thống kê được ngày");
                        dtg_TKHD.Rows.Clear();
                        dtg_TKHD.Rows.Add(x.MaHD, x.Create_Date, x.Status);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu cho ngày này.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ngày từ combobox.");
            }
        }

        private void buttonTKThang_Click(object sender, EventArgs e)
        {
            if (cbx_TKThang.SelectedItem != null)
            {
                int selectedMonth = (int)cbx_TKThang.SelectedItem;
                foreach (var x in billServices.Get())
                {
                    if (x.Create_Date.Month == selectedMonth)
                    {
                        MessageBox.Show("Đã thống kê được tháng");
                        dtg_TKHD.Rows.Clear();
                        dtg_TKHD.Rows.Add(x.MaHD, x.Create_Date, x.Status,x.Name);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu cho tháng này.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tháng từ combobox.");
            }
        }

        private void buttonTKNam_Click(object sender, EventArgs e)
        {
            if (cbx_TKNam.SelectedItem != null)
            {
                int selectedYear = (int)cbx_TKNam.SelectedItem;
                foreach (var x in billServices.Get())
                {
                    if (x.Create_Date.Year == selectedYear)
                    {
                        MessageBox.Show("Đã thống kê được năm");
                        dtg_TKHD.Rows.Clear();
                        dtg_TKHD.Rows.Add(x.MaHD, x.Create_Date, x.Status, x.Name);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu cho năm này.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ngày từ combobox.");
            }
        }

        private void dtg_TKHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dtg_TKHD.CurrentRow.Cells[3].Value.ToString();
        }
    }
}