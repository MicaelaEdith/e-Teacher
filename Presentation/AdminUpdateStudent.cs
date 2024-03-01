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
    public partial class AdminUpdateStudent : Form
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

        private int id;
        public AdminUpdateStudent(Student student)
        {
            this.id = student.Id;
            InitializeComponent();
            txtName.Text = student.Name;
            txtLastName.Text = student.LastName;
            txtLastName.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtLastName.Width, txtLastName.Height, 5, 5));
            txtName.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtName.Width, txtName.Height, 5, 5));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = id;
            student.Name = txtName.Text;
            student.LastName = txtLastName.Text;

            StudentsManager sm = new StudentsManager();

            if (txtLastName.Text != "" && txtLastName != null && txtName.Text != "" && txtName != null)
            {
                sm.Update(student);
                Close();
            }
            else
                lblWarning.Visible = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
