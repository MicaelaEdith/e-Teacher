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
    public partial class AdminNewCourse : Form
    {
        public AdminNewCourse()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Courses c = new Courses();
            c.CoursesClasses = txtCourse.Text;
            c.Days = txtDays.Text;
            c.Institution = txtInstitute.Text;
            c.Level = txtLevel.Text;

            CoursesManager cm = new CoursesManager();
            cm.AddCourse(c);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
