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

            if (txtCourse.Text != "" && txtCourse != null &&
                txtDays.Text != "" && txtDays != null &&
                txtInstitute.Text != "" && txtInstitute != null &&
                txtLevel.Text != "" && txtLevel != null)
            {
                cm.AddCourse(c);
                if (this.Tag is Admin parentForm)
                {
                    parentForm.Close();
                }

            }
            else
                lblWarning.Visible = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.Tag is Admin parentForm)
            {
                parentForm.Close();
            }

        }
    }
}
