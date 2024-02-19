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
    public partial class DeleteWarning : Form
    {
        private int index;
        public DeleteWarning(int index)
        {
            this.index = index;
            InitializeComponent();
            if (index == 0)
            {
                CoursesManager cm = new CoursesManager();
                lblCourse.Visible = true;
                lblStudent.Visible = false;
                lblCourse.Text = "Curso/Materia: "+ cm.findNameByid(AppData.id);

            }
            else
            {
                StudentsManager sm = new StudentsManager();
                lblCourse.Visible = false;
                lblStudent.Visible = true;
                lblStudent.Text = "Alumno: " + sm.findNameByid(AppData.id);
            }
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                CoursesManager cm = new CoursesManager();
                cm.Delete(AppData.id);
            }
            else
            {            
                StudentsManager sm = new StudentsManager();
                sm.Delete(AppData.id);
            }
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
