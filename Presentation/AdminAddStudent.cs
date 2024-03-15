using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;


namespace Presentation
{
    public partial class AdminAddStudent : Form
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
        public AdminAddStudent()
        {
            InitializeComponent();
            txtLastName.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtLastName.Width, txtLastName.Height, 5, 5));
            txtName.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtName.Width, txtName.Height, 5, 5));
            cbxCourses.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxCourses.Width, cbxCourses.Height, 5, 5));
            cbxCoursesData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;

            StudentsManager sm = new StudentsManager();
            CoursesManager cm = new CoursesManager();
            List<Courses> list = cm.ListCoursesAvailable();
            int newId = sm.AddStudent(name, lastName);
            sm.AddCourse(newId, list[cbxCourses.SelectedIndex].Id);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void cbxCoursesData()
        {
            CoursesManager cm = new CoursesManager();
            List<Courses> list = cm.ListCoursesAvailable();
            string name = "";

            for (int i = 0; i < list.Count; i++)
            {
                name += list[i].CoursesClasses + " - " + list[i].Institution;
                cbxCourses.Items.Add(name);
                name = "";
            }

        }
    }
}
