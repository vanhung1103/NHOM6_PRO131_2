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
    public partial class Frm_BillDetail : Form
    {
        public Guid _idhdct;
        public IBillDetailServices _IbillDetailServices;
        public IProductService _iproductService;
        public IBillServices _ibillServices;
        public List<BillDetailView> _ibillDetailViews;
        public Frm_BillDetail()
        {
            _IbillDetailServices = new BillDetailServices();
            _iproductService = new ProductService();
            _ibillServices = new BillServices();
            _ibillDetailViews = new List<BillDetailView>();
            _ibillDetailViews = _IbillDetailServices.Get();
            InitializeComponent();
            LoadToGridView(_ibillDetailViews);
            LoadTocbb();
            LoadTocbpro();
        }
        public void LoadTocbb()
        {
            foreach (var item in _ibillServices.Get())
            {
                cbx_hd.Items.Add(item.MaHD);
            }
        }
        public void LoadTocbpro()
        {
            foreach (var item in _iproductService.GetAll())
            {
                cbx_pro.Items.Add(item.Name);
            }
        }
        public void LoadToGridView(List<BillDetailView> _ibillDetailViews)
        {
            int stt = 1;
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 8;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã hóa đơn CT";
            dtg_show.Columns[3].Name = "Mã hóa đơn ";
            dtg_show.Columns[4].Name = "Tên sản phẩm";
            dtg_show.Columns[5].Name = "Price";
            dtg_show.Columns[6].Name = "Quantity";
            dtg_show.Columns[7].Name = "Image";
            foreach (var item in _ibillDetailViews)
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
            bool chuso = Regex.IsMatch(txt_mahdct.Text, @"[A-Za-z0-9]");
            bool so = Regex.IsMatch(txt_price.Text, @"^[0-9]");
            bool so1 = Regex.IsMatch(txt_quantity.Text, @"^[0-9]");

            if (txt_mahdct.Text == "")
            {
                txt_mahdct.BackColor = Color.Yellow;
                MessageBox.Show("Không để trống mã hóa đơn, vui lòng nhập mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!chuso)
            {
                MessageBox.Show("Mã hóa đơn phải có chữ và số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_mahdct.Text.Length > 15)
            {
                MessageBox.Show("Mã hóa đơn quá dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_mahdct.Text.Contains(" "))
            {
                MessageBox.Show("Mã hóa đơn không chứa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_price.Text == "")
            {
                MessageBox.Show("Gía Không để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so)
            {
                MessageBox.Show("Gía Phải là số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (decimal.Parse(txt_price.Text).ToString().Length > 9)
            {
                MessageBox.Show("Gía quá cao", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_quantity.Text == "")
            {
                MessageBox.Show("Số lượng không để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_quantity.Text.Contains(" "))
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so1)
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (decimal.Parse(txt_quantity.Text).ToString().Length > 9)
            {
                MessageBox.Show("Số lượng quá lớn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_image.Text == "")
            {
                MessageBox.Show("Không để trống image", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_hd.Text == "")
            {
                MessageBox.Show("Không để trống mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_pro.Text == "")
            {
                MessageBox.Show("Không để trống tên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                    _ibillDetailViews = _IbillDetailServices.Get();
                    LoadToGridView(_ibillDetailViews);
                }
            }
            _ibillDetailViews = _IbillDetailServices.Get();
            LoadToGridView(_ibillDetailViews);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bool chuso = Regex.IsMatch(txt_mahdct.Text, @"[A-Za-z0-9]");
            bool so = Regex.IsMatch(txt_price.Text, @"^[0-9]");
            bool so1 = Regex.IsMatch(txt_quantity.Text, @"^[0-9]");

            if (txt_mahdct.Text == "")
            {
                txt_mahdct.BackColor = Color.Yellow;
                MessageBox.Show("Không để trống mã hóa đơn, vui lòng nhập mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!chuso)
            {
                MessageBox.Show("Mã hóa đơn phải có chữ và số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_mahdct.Text.Length > 15)
            {
                MessageBox.Show("Mã hóa đơn quá dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_mahdct.Text.Contains(" "))
            {
                MessageBox.Show("Mã hóa đơn không chứa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_price.Text == "")
            {
                MessageBox.Show("Gía Không để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so)
            {
                MessageBox.Show("Gía Phải là số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Convert.ToInt32(txt_price.Text).ToString().Length > 9)
            {
                MessageBox.Show("Gía quá cao", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_quantity.Text == "")
            {
                MessageBox.Show("Số lượng không để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_quantity.Text.Contains(" "))
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!so1)
            {
                MessageBox.Show("Số lượng không được chưa dấu cách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Convert.ToInt32(txt_quantity.Text).ToString().Length > 9)
            {
                MessageBox.Show("Số lượng quá lớn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_image.Text == "")
            {
                MessageBox.Show("Không để trống image", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_hd.Text == "")
            {
                MessageBox.Show("Không để trống mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbx_pro.Text == "")
            {
                MessageBox.Show("Không để trống tên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
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
                    _ibillDetailViews = _IbillDetailServices.Get();
                    LoadToGridView(_ibillDetailViews);
                }
                _ibillDetailViews = _IbillDetailServices.Get();
                LoadToGridView(_ibillDetailViews);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IbillDetailServices.Remove(_idhdct));
                _ibillDetailViews = _IbillDetailServices.Get();
                LoadToGridView(_ibillDetailViews);
            }
            _ibillDetailViews = _IbillDetailServices.Get();
            LoadToGridView(_ibillDetailViews);
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var lst = _IbillDetailServices.Get().Where(C => C.MaHDCT.Contains(txt_search.Text)).ToList();
            if (lst == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            LoadToGridView(lst);
                
                }
    }
}
