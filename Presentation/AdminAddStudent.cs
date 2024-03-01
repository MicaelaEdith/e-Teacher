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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;

            StudentsManager sm = new StudentsManager();
            sm.AddStudent(name, lastName);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
