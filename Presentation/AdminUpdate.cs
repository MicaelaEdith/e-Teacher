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
    public partial class AdminUpdate : Form
    {

        public AdminUpdate(Courses cour)
        {
            InitializeComponent();
            txtCourse.Text = cour.CoursesClasses;
            txtDays.Text = cour.Days;
            txtInstitute.Text = cour.Institution;
            txtLevel.Text = cour.Level;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoursesManager cm = new CoursesManager();
            Courses course = new Courses();
            course.CoursesClasses = txtCourse.Text;
            course.Days = txtDays.Text;
            course.Institution = txtInstitute.Text;
            course.Level = txtLevel.Text;
            course.Id = AppData.id;

            if (txtCourse.Text != "" && txtCourse != null &&
               txtDays.Text != "" && txtDays != null &&
               txtInstitute.Text != "" && txtInstitute != null &&
               txtLevel.Text != "" && txtLevel != null)
            {
                cm.Update(course);
            }
            else
                lblWarning.Visible = true;
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
