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
using Domain;
using Business;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class Admin : MaterialForm
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public Admin()
        {
            AppData.id = -1;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
             Primary.Grey900, Primary.Grey900,
             Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            cbxItems.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxItems.Width, cbxItems.Height, 5, 5));
            AddItems();
        }

        private Form activeForm = null;
        private void OpenPanel(Form form)
        {
            if (activeForm != null)
            {
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

        private void AddItems()
        {

            cbxItems.Items.Add("Cursos");
            cbxItems.Items.Add("Alumnos");
            cbxItems.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            swAvailable.Visible = false;
            lblAvailable.Visible = false;
            if (cbxItems.SelectedIndex == 0)
            {
                OpenPanel(new AdminNewCourse());
                AppData.openPanel = "AdminNewCourse";
            }
            else
            {
                OpenPanel(new AdminAddStudent());
                AppData.openPanel = "AdminAddStudent";
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            panelList(swAvailable.Checked);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (AppData.id > 0)
            {
                if (AppData.SelectedItem is Courses)
                {
                    OpenPanel(new AdminUpdate((Courses)AppData.SelectedItem));
                    AppData.openPanel = "AdminUpdate";

                }
                else
                {
                    OpenPanel(new AdminUpdateStudent((Student)AppData.SelectedItem));
                    AppData.openPanel = "AdminUpdateStudent";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(AppData.id!=-1)
            OpenPanel(new DeleteWarning(cbxItems.SelectedIndex));
            

        }
        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxItems.SelectedIndex == 1)
            {
                if (AppData.openPanel == "AdminNewCourse")
                {
                    OpenPanel(new AdminAddStudent());
                    AppData.openPanel = "AdminAddStudent";

                }
                else if (AppData.openPanel == "ListCourses")
                {
                    panelList(swAvailable.Checked);
                    AppData.openPanel = "ListStudents";

                }
                else if (AppData.openPanel == "AdminUpdate" || AppData.openPanel == "AdminUpdateStudent") {

                    panelList(swAvailable.Checked);
                }


            }
            else {
                if (AppData.openPanel == "AdminAddStudent")
                {
                    OpenPanel(new AdminNewCourse());
                    AppData.openPanel = "AdminNewCourse";
                }
                else if (AppData.openPanel == "ListStudents")
                {
                    panelList(swAvailable.Checked);
                    AppData.openPanel = "ListCourses";

                }


            }

        }

        private void swAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (swAvailable.Checked)
            {
                if (AppData.SelectedItem is Courses)
                {
                    panelList(true);
                }
                else
                {
                    panelList(true);
                }
            }
            else {

                panelList(false);
            }

        }

        private void panelList(bool Available) {

            OpenPanel(new AdminList(cbxItems.SelectedIndex,Available));
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            swAvailable.Visible = true;
            lblAvailable.Visible = true;

        }
    }
}
