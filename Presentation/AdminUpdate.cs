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
    public partial class AdminUpdate : Form
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

        public AdminUpdate(Courses cour)
        {
            InitializeComponent();
            txtCourse.Text = cour.CoursesClasses;
            //txtDays.Text = cour.Days;
            txtInstitute.Text = cour.Institution;
            txtLevel.Text = cour.Level;
            txtCourse.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCourse.Width, txtCourse.Height, 5, 5));
            txtInstitute.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtInstitute.Width, txtInstitute.Height, 5, 5));
            txtLevel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtLevel.Width, txtLevel.Height, 5, 5));
            cbxHs.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxHs.Width, cbxHs.Height, 5, 5));
            cbxHs2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxHs2.Width, cbxHs2.Height, 5, 5));
            cbxHs.DataSource = setHs();
            cbxHs2.DataSource = setHs();

            cbxHs.SelectedIndex = -1;
            cbxHs2.SelectedIndex = -1;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoursesManager cm = new CoursesManager();
            Courses course = new Courses();
            course.CoursesClasses = txtCourse.Text;
           // course.Days = txtDays.Text;
            course.Institution = txtInstitute.Text;
            course.Level = txtLevel.Text;
            course.Id = AppData.id;

            if (txtCourse.Text != "" && txtCourse != null &&
              // txtDays.Text != "" && txtDays != null &&
               txtInstitute.Text != "" && txtInstitute != null &&
               txtLevel.Text != "" && txtLevel != null)
            {
                cm.Update(course);
            }
            else
                lblWarning.Visible = true;
            Close();

        }

        private static List<string> setHs()
        {
            List<string> list = new List<string>();


            for (int i = 6; i <= 23; i++)
            {
                for (int min = 0; min < 60; min += 30)
                {
                    string hs = $"{i % 12}:{min:D2} {(i < 12 ? "am" : "pm")}";
                    list.Add(hs);
                }
            }

            return list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
