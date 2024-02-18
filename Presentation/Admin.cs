using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Admin : MaterialForm
    {
        public Admin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Grey900, Primary.Grey900,
            Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            AddItems();
        }

        private Form activeForm = null;
        private void OpenPanel(Form form) {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlAdmin.Controls.Add(form);
            pnlAdmin.Tag = form;
            form.Tag = this;
            form.Show();
        
        }

        private void AddItems() {

            cbxItems.Items.Add("Cursos");
            cbxItems.Items.Add("Alumnos");
            cbxItems.SelectedIndex=0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbxItems.SelectedIndex==0)
                OpenPanel(new AdminNewCourse());
            else
                OpenPanel(new AdminAddStudent());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            OpenPanel(new AdminList(cbxItems.SelectedIndex));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cbxItems.SelectedIndex == 0)
                OpenPanel(new AdminUpdate());
            else
                OpenPanel(new AdminUpdateStudent());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OpenPanel(new AdminDelete());
        }
    }
}
