using _1_DAL.Data;
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
    public partial class Frm_User : Form
    {
        public Guid id;
        public IUserServices _userServices;
        List<UserView> userViews;
        public IRoleServices _iroleServices;
        public Frm_User()
        {
            InitializeComponent();
            _userServices = new UserServices();
            userViews = new List<UserView>();
            _iroleServices = new RoleService();
            LoadRole();
        }
        public void LoadToGridView()
        {
            dgv_user.Rows.Clear();
            dgv_user.ColumnCount =6;
            dgv_user.Columns[0].Name = "ID";
            dgv_user.Columns[0].Visible = false;
            dgv_user.Columns[1].Name= "ID";
            dgv_user.Columns[2].Name = "UserName";
            dgv_user.Columns[3].Name = "PassWord";
            dgv_user.Columns[4].Name = "Email";
            dgv_user.Columns[5].Name = "Chức vụ";
            dgv_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_user.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_user.AllowUserToResizeColumns = false;
            foreach (var item in _userServices.GetAllUser())
            {
                dgv_user.Rows.Add(item.Id,
                    item.UserName,
                    item.PassWord,
                    item.Email,
                    (item.role_Id != null) ? _iroleServices.GetRole().FirstOrDefault(c => c.Id == item.role_Id).Name : " "
                    );
            }
        }
        public void LoadRole()
        {
            foreach (var item in _iroleServices.GetRole())
            {
                cb_role.Items.Add(item.Name);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            UserView userView = new UserView()
            {
                UserName = txt_name.Text,
                PassWord = txt_pass.Text,
                Email = txt_email.Text,
                role_Id = _iroleServices.GetRole().FirstOrDefault(c => c.Name == cb_role.Text).Id,
            };
            DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_userServices.AddUser(userView));
                LoadToGridView();
            }

            LoadToGridView();
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            UserView userView = new UserView()
            {
                UserName = txt_name.Text,
                PassWord = txt_pass.Text,
                Email = txt_email.Text,
                role_Id = _iroleServices.GetRole().FirstOrDefault(c => c.Name == cb_role.Text).Id,

            };
            DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_userServices.UpdateUser(userView));
                LoadToGridView();
            }
            LoadToGridView();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_userServices.DeleteUser(id));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Guid.Parse(dgv_user.CurrentRow.Cells[0].Value.ToString());
            txt_name.Text = dgv_user.CurrentRow.Cells[1].Value.ToString();
            txt_pass.Text = dgv_user.CurrentRow.Cells[2].Value.ToString();
            txt_email.Text = dgv_user.CurrentRow.Cells[3].Value.ToString();
            cb_role.Text = dgv_user.CurrentRow.Cells[4].Value.ToString();

        }

        private void Frm_User_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = _userServices.GetAllUser().Where(x => x.UserName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dgv_user.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dgv_user.Rows.Add(x.Id, x.UserName);
            }
        }
    }
}
