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

        }
        public void Loadđ()
        {
            int rowCount = dtg_TKHD.RowCount -1;

            label4.Text = rowCount.ToString();
            
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            lOad();
            Loadđ();

        }
        public void loadto0(){

        }
        public void lOad()
        {


            dtg_TKHD.Rows.Clear();
            dtg_TKHD.ColumnCount = 4;
           
            dtg_TKHD.Columns[0].Name = "Mã hóa đơn";
            dtg_TKHD.Columns[1].Name = "Tên khách hàng";
            dtg_TKHD.Columns[2].Name = "Ngày tạo hóa đơn";
            dtg_TKHD.Columns[3].Name = "Trạng thái";
            
                float totalValue = 0; // Khởi tạo biến để tính tổng giá trị

            foreach (var x in billServices.Get())
            {
                dtg_TKHD.Rows.Add(x.MaHD,x.Name, x.Create_Date, x.Status == 1 ? "Đã thanh toán" : "Chưa Thanh Toán");
            }

            foreach (var x in billDetailServices.Get())
            {
                totalValue += x.Quantity * x.Price; // Cộng dồn giá trị sản phẩm vào tổng
            }

            label2.Text = totalValue.ToString();
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

            bool foundDataForDay = false; // Đặt cờ để kiểm tra xem có dữ liệu cho tháng đã chọn hay không

            if (cbx_TKNgay.SelectedItem != null)
            {
                int selectedDay = (int)cbx_TKNgay.SelectedItem;
                dtg_TKHD.Rows.Clear();

                foreach (var x in billServices.Get())
                {
                    if (x.Create_Date.Day == selectedDay)
                    {
                        dtg_TKHD.Rows.Add(x.MaHD, x.Create_Date, x.Status, x.Name);
                        foundDataForDay = true; // Đánh dấu có dữ liệu cho tháng đã chọn

                        foreach (var x1 in billDetailServices.Get())
                        {
                            if (x1.Bill_Id == x.Id)
                            {
                                label2.Text = (x1.Quantity * x1.Price).ToString();
                            }

                        }
                    }


                }

                if (foundDataForDay)
                {
                    MessageBox.Show("Đã thống kê được ngày.");
                    
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho ngày này.");
                    label2.Text = "0";
                    Loadđ();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ngày từ combobox.");
            }

        }

        private void buttonTKThang_Click(object sender, EventArgs e)
        {
            bool foundDataForMonth = false; // Đặt cờ để kiểm tra xem có dữ liệu cho tháng đã chọn hay không

            if (cbx_TKThang.SelectedItem != null)
            {
                int selectedMonth = (int)cbx_TKThang.SelectedItem;
                dtg_TKHD.Rows.Clear();

                foreach (var x in billServices.Get())
                {
                    if (x.Create_Date.Month == selectedMonth)
                    {
                        dtg_TKHD.Rows.Add(x.MaHD, x.Create_Date, x.Status, x.Name);
                        foundDataForMonth = true; // Đánh dấu có dữ liệu cho tháng đã chọn

                        foreach (var x1 in billDetailServices.Get())
                        {
                            if (x1.Bill_Id == x.Id)
                            {
                                label2.Text = (x1.Quantity * x1.Price).ToString();
                            }

                        }
                    }


                }
                if (foundDataForMonth)
                {
                    MessageBox.Show("Đã thống kê được tháng.");
                   
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho tháng này.");
                    label2.Text = "0";
                    Loadđ();

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tháng từ combobox.");
            }


        }

        private void buttonTKNam_Click(object sender, EventArgs e)
        {
            bool foundDataForYear = false; // Đặt cờ để kiểm tra xem có dữ liệu cho tháng đã chọn hay không

            if (cbx_TKNam.SelectedItem != null)
            {
                int selectedYear = (int)cbx_TKNam.SelectedItem;
                dtg_TKHD.Rows.Clear();

                foreach (var x in billServices.Get())
                {
                    if (x.Create_Date.Year == selectedYear)
                    {
                        dtg_TKHD.Rows.Add(x.MaHD, x.Create_Date, x.Status, x.Name);
                        foundDataForYear = true; // Đánh dấu có dữ liệu cho tháng đã chọn

                        foreach (var x1 in billDetailServices.Get())
                        {
                            if (x1.Bill_Id == x.Id)
                            {
                                label2.Text = (x1.Quantity * x1.Price).ToString();
                            }

                        }
                    }


                }

                if (foundDataForYear)
                {
                    MessageBox.Show("Đã thống kê được năm.");
                   
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho năm này.");
                    label2.Text = "0";
                    Loadđ();

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

        private void dtg_TKHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}