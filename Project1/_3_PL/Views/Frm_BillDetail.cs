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
    public partial class Frm_BillDetail : Form
    {
        public Guid _idhdct;
        public IBillDetailServices _IbillDetailServices;
        public IProductService _iproductService;
        public IBillServices _ibillServices;

        public Frm_BillDetail()
        {
            _IbillDetailServices = new BillDetailServices();
            _iproductService = new ProductService();
            _ibillServices = new BillServices();

            InitializeComponent();
            LoadToGridView();
            LoadTocbb();
            LoadTocbpro();
        }
        public void LoadTocbb()
        {
            foreach (var item in _ibillServices.Get())
            {
                cbx_hd.Items.Add(item);
            }
        }
        public void LoadTocbpro()
        {
            foreach (var item in _iproductService.GetAll())
            {
                cbx_pro.Items.Add(item);
            }
        }
        public void LoadToGridView()
        {
            int stt = 1;
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 7;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã hóa đơn CT";
            dtg_show.Columns[3].Name = "Mã hóa đơn ";
            dtg_show.Columns[4].Name = "Tên sản phẩm";
            dtg_show.Columns[5].Name = "Price";
            dtg_show.Columns[6].Name = "Quantity";
            dtg_show.Columns[7].Name = "Image";
            foreach (var item in _IbillDetailServices.Get())
            {
                dtg_show.Rows.Add(
                    item.Id,
                    stt++,
                    item.MaHDCT,
                    (item.Bill_Id != null) ? _ibillServices.Get().FirstOrDefault(c => c.Id == item.Bill_Id).MaHD : " ",
                    (item.Pro_Id != null) ? _iproductService.GetAll().FirstOrDefault(c => c.Id == item.Pro_Id).Name : " ",

                    item.Price,
                    item.Quantity,
                    item.Image
                    );
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_mahdct.Text == "")
            {
                txt_mahdct.BackColor = Color.Yellow;
                MessageBox.Show("Không để trống mã hóa đơn, vui lòng nhập mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BillDetailView billDetailView = new BillDetailView()
                {
                    MaHDCT = txt_mahdct.Text,
                    Price = Convert.ToInt32(txt_price.Text),
                    Quantity = Convert.ToInt32(txt_quantity.Text),
                    Image = txt_image.Text,
                    Bill_Id = _ibillServices.Get().FirstOrDefault(C => C.MaHD == cbx_hd.Text).Id,
                    Pro_Id = _iproductService.GetAll().FirstOrDefault(C => C.Name == cbx_pro.Text).Id,


                };
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_IbillDetailServices.Add(billDetailView));
                    LoadToGridView();
                }
            }
            LoadToGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            BillDetailView billDetailView = new BillDetailView()
            {
                Id = _idhdct,
                MaHDCT = txt_mahdct.Text,
                Price = Convert.ToInt32(txt_price.Text),
                Quantity = Convert.ToInt32(txt_quantity.Text),
                Image = txt_image.Text,
                Bill_Id = _ibillServices.Get().FirstOrDefault(C => C.MaHD == cbx_hd.Text).Id,
                Pro_Id = _iproductService.GetAll().FirstOrDefault(C => C.Name == cbx_pro.Text).Id,

            };
            DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IbillDetailServices.Update(billDetailView));
                LoadToGridView();
            }
            LoadToGridView();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IbillDetailServices.Remove(_idhdct));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idhdct = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString());
            txt_mahdct.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            txt_price.Text = dtg_show.CurrentRow.Cells[5].Value.ToString();
            txt_quantity.Text = dtg_show.CurrentRow.Cells[6].Value.ToString();
            txt_image.Text = dtg_show.CurrentRow.Cells[7].Value.ToString();
            cbx_hd.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            cbx_pro.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
            
        }
    }
}
