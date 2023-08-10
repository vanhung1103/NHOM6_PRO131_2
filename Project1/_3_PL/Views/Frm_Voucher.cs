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
    public partial class Frm_Voucher : Form
    {
        public IVoucherServices voucherServices;
        public Guid Id;
        List<VoucherView> voucherList;
        public Frm_Voucher()
        {
            InitializeComponent();
            voucherServices= new VoucherServices();
            voucherList = new List<VoucherView>();
        }

        private void Frm_Voucher_Load(object sender, EventArgs e)
        {

        }
        public void LoadToGridView()
        {
            dgv_Voucher.Rows.Clear();
            dgv_Voucher.ColumnCount = 6;
            dgv_Voucher.Columns[0].Name = "ID";
            dgv_Voucher.Columns[0].Visible = false;
            dgv_Voucher.Columns[1].Name = "Tên Voucher";
            dgv_Voucher.Columns[2].Name = "Ngày bắt đầu";
            dgv_Voucher.Columns[3].Name = "Ngày kết thúc";
            dgv_Voucher.Columns[4].Name = "trạng thái";
            dgv_Voucher.Columns[5].Name = "Phần trăm giảm giá";
            dgv_Voucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Voucher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_Voucher.AllowUserToResizeColumns = false;
            foreach (var item in voucherServices.GetAllVoucher())
            {
                dgv_Voucher.Rows.Add(item.Id,
                    item.Name,
                    item.Create_Date,
                    item.End_Date,
                    item.Status,
                    item.Voucher_Percent
                    );
            }
        }
            private void btn_add_Click(object sender, EventArgs e)
            {
                VoucherView voucherView = new VoucherView()
                {
                    Name = txt_name.Text,
                    Create_Date = dtp_createDate.Value,
                    End_Date = dtp_endDate.Value,
                    Status = Convert.ToInt32(txt_status.Text),
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            VoucherView voucherView = new VoucherView()
            {
                Id = Id,
                Name = txt_name.Text,
                Create_Date= dtp_createDate.Value,
                End_Date= dtp_endDate.Value,
                Status = Convert.ToInt32(txt_status.Text),
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
             dtp_createDate.Text= dgv_Voucher.CurrentRow.Cells[2].Value.ToString();
            dtp_endDate.Text = dgv_Voucher.CurrentRow.Cells[3].Value.ToString();
            txt_status.Text = dgv_Voucher.CurrentRow.Cells[4].Value.ToString();
            txt_VoucherPercent.Text = dgv_Voucher.CurrentRow.Cells[5].Value.ToString();
            
        }
    }
}
