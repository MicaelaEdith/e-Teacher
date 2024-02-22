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
    public partial class AdminUpdateStudent : Form
    {
       private int id;
        public AdminUpdateStudent(Student student)
        {
            this.id = student.Id;
            InitializeComponent();
            txtName.Text = student.Name;
            txtLastName.Text = student.LastName;
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
