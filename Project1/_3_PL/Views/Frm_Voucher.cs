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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Voucher : Form
    {
        public IVoucherServices voucherServices;
        public Guid Id;
        List<VoucherView> voucherList;
        public Frm_Voucher()
        {
            InitializeComponent();
            voucherServices = new VoucherServices();
            voucherList = new List<VoucherView>();
            LoadToGridView();
        }

        private void Frm_Voucher_Load(object sender, EventArgs e)
        {

        }

        public void LoadToGridView()
        {
            dgv_Voucher.Rows.Clear();
            dgv_Voucher.ColumnCount = 7;
            dgv_Voucher.Columns[0].Name = "ID";
            dgv_Voucher.Columns[0].Visible = false;
            dgv_Voucher.Columns[1].Name = "Tên Voucher";
            dgv_Voucher.Columns[2].Name = "Ngày bắt đầu";
            dgv_Voucher.Columns[3].Name = "Ngày kết thúc";
            dgv_Voucher.Columns[4].Name = "trạng thái";
            dgv_Voucher.Columns[5].Name = "Tiền giảm";
            dgv_Voucher.Columns[6].Name = "Gía áp dụng";
            dgv_Voucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Voucher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_Voucher.AllowUserToResizeColumns = false;
            foreach (var item in voucherServices.GetAllVoucher())
            {
                dgv_Voucher.Rows.Add(item.Id,
                    item.Name,
                    item.Create_Date,
                    item.End_Date,
                    item.Status == 1 ? "Đã Dùng" : "Chưa Dùng",
                    item.Voucher_Percent,
                    item.minPrice
                    );
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            bool so = Regex.IsMatch(txt_minprice.Text, @"^[0-9]");
            bool so1 = Regex.IsMatch(txt_VoucherPercent.Text, @"^[0-9]");

            if (txt_name.Text == "")
            {
                MessageBox.Show("Không để tên trống");
            }
            else if(dtp_createDate.Created == false)
            {
                MessageBox.Show("Không để trống ngày tạo");

            }
            else if (dtp_createDate.Created == false)
            {
                MessageBox.Show("Không để trống ngày tạo");

            }
            else if (dtp_createDate.Value > dtp_endDate.Value)
            {
                MessageBox.Show("Ngày tạo p nhỏ hơn ngày kết thúc");

            }
            else if (txt_minprice.Text == "")
            {
                MessageBox.Show("Không để trống giá áp dụng được voucher");

            }
            else if (!so)
            {
                MessageBox.Show("Nhập số");

            }
            else if (decimal.Parse(txt_minprice.Text) <= 0)
            {
                MessageBox.Show("Không được âm hoặc = 0");

            }
            else if (txt_VoucherPercent.Text == "")
             {
                    MessageBox.Show("Không để trống giá được giảm");

             }
            else if (!so1)
            {
                MessageBox.Show("Nhập số");

            }
            else if (decimal.Parse(txt_VoucherPercent.Text) <= 0)
            {
                MessageBox.Show("Không được âm hoặc = 0");

            }
            else
                    {
                        VoucherView voucherView = new VoucherView()
                        {
                            Name = txt_name.Text,
                            Create_Date = dtp_createDate.Value,
                            End_Date = dtp_endDate.Value,
                            minPrice = Convert.ToInt32(txt_minprice.Text),

                            Status = radioButton1.Checked == true ? 1 : 0,

                            Voucher_Percent = float.Parse(txt_VoucherPercent.Text)

                        };
                        DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            MessageBox.Show(voucherServices.AddVoucher(voucherView));
                            LoadToGridView();
                        }
                        LoadToGridView();
                    }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            VoucherView voucherView = new VoucherView()
            {
                Id = Id,
                Name = txt_name.Text,
                Create_Date = dtp_createDate.Value,
                End_Date = dtp_endDate.Value,
                minPrice = Convert.ToInt32(txt_minprice.Text),
                Status = radioButton1.Checked == true ? 1 : 0,
                Voucher_Percent = float.Parse(txt_VoucherPercent.Text)
            };
            DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(voucherServices.UpdateVoucher(voucherView));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(voucherServices.DeleteVoucher(Id));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_Search.Text.Trim();
            var filteredSuppliers = voucherServices.GetAllVoucher().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dgv_Voucher.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dgv_Voucher.Rows.Add(x.Id, x.Name);
            }
        }

        private void dgv_Voucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Id = Guid.Parse(dgv_Voucher.CurrentRow.Cells[0].Value.ToString());
            txt_name.Text = dgv_Voucher.CurrentRow.Cells[1].Value.ToString();
            dtp_createDate.Text = dgv_Voucher.CurrentRow.Cells[2].Value.ToString();
            dtp_endDate.Text = dgv_Voucher.CurrentRow.Cells[3].Value.ToString();
            if (Convert.ToString(dgv_Voucher.CurrentRow.Cells[4].Value) == "Đã Dùng") radioButton1.Checked = true;
            if (Convert.ToString(dgv_Voucher.CurrentRow.Cells[4].Value) == "Chưa Dùng") radioButton2.Checked = true;
            txt_VoucherPercent.Text = dgv_Voucher.CurrentRow.Cells[5].Value.ToString();
            txt_minprice.Text = dgv_Voucher.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
