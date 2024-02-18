using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;

namespace Presentation
{
    public partial class AdminList : Form
    {
        private List<Courses> listCourses;
        private List<Student> listStudents;
        public AdminList(int index)
        {
            InitializeComponent();
            if (index == 0)
                UpdateCourses();
            else
                UpdateStudents();

        }

        private void UpdateCourses()
        {
            CoursesManager courses = new CoursesManager();

            dgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvList.RowHeadersVisible = false;
            dgvList.Rows[4].Visible = false;
            dgvList.Rows[5].Visible = false;

            try
            {
                listCourses = courses.ListCourses();
                foreach (Courses c in listCourses)
                {

                    int rowIndex = dgvList.Rows.Add();
                    DataGridViewRow row = dgvList.Rows[rowIndex];
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

        private void UpdateStudents()
        {
            StudentsManager students = new StudentsManager();

            dgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvList.RowHeadersVisible = false;
            dgvList.Rows[0].Visible = false;
            dgvList.Rows[1].Visible = false;
            dgvList.Rows[2].Visible = false;
            dgvList.Rows[3].Visible = false;
            try
            {
                listStudents = students.ListStudents();
                foreach (Student s in listStudents)
                {

                    int rowIndex = dgvList.Rows.Add();
                    DataGridViewRow row = dgvList.Rows[rowIndex];
                    row.Cells[4].Value = s.Name.ToUpper();
                    row.Cells[5].Value = s.LastName;
;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
