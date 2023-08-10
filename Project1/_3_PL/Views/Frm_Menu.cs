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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }
        public Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product());

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_User());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Billl());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Role());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Pay());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_BillDetail());
        }
    }
}
