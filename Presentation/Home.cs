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

namespace Presentation
{
    public partial class Home : MaterialForm
    {
        private List<Courses> listCourses;
        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            CoursesManager courses = new CoursesManager();

            try
            {
                listCourses = courses.ListCourses();
                foreach (Courses c in listCourses) {

                    int rowIndex = dgvCourses.Rows.Add();
                    DataGridViewRow row = dgvCourses.Rows[rowIndex];
                    row.Cells[0].Value = c.CoursesClasses.ToUpper();
                    row.Cells[1].Value = c.Days;
                    row.Cells[2].Value = c.Institution;
                    row.Cells[3].Value = c.Level;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
