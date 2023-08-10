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
    public partial class Frm_Role : Form
    {
        public Guid _Id;
        public IRoleServices roleServices;
        List<RoleView> roleViews;
        public Frm_Role()
        {
            InitializeComponent();
            roleViews = new List<RoleView>();
            roleServices = new RoleService();

        }
        public void LoadToGridView()
        {
      
            dgv_role.Rows.Clear();
            dgv_role.ColumnCount = 2;
            dgv_role.Columns[0].Name = "ID";
            dgv_role.Columns[0].Visible = false;

            dgv_role.Columns[1].Name = "Name";

            dgv_role.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_role.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_role.AllowUserToResizeColumns = false;
            foreach (var item in roleServices.GetRole())
            {
                dgv_role.Rows.Add(item.Id,
                    
                    item.Name
                    );
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            RoleView roleView = new RoleView()
            {
                Name = txt_name.Text,
            };
            DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(roleServices.CreateRole(roleView));
                LoadToGridView();
            }
            LoadToGridView();
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            RoleView roleView = new RoleView()
            {
                Id = _Id,
                Name = txt_name.Text
            };
            DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(roleServices.UpdateRole(roleView));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(roleServices.DeleteRole(_Id));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void dgv_role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _Id = Guid.Parse(dgv_role.CurrentRow.Cells[0].Value.ToString());
            txt_name.Text = dgv_role.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
