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
                listCourses = courses.ListCourses();

            try
            {
                dgvList.DataSource = listCourses;
                dgvList.Columns["id"].Visible = false;
                dgvList.ClearSelection();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void UpdateStudents()
        {
            StudentsManager students = new StudentsManager();
            listStudents = students.ListStudents();

            try
            {
                dgvList.DataSource = listStudents;
                dgvList.Columns["id"].Visible = false;
                dgvList.ClearSelection();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// check this 
        ///          ↓
        


        public event EventHandler<int> StudentSelected;
        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dgvList.SelectedRows[0];

                object idValue = selectedRow.Cells["id"].Value;

                if (idValue != null)
                {
                    int studentId = Convert.ToInt32(idValue);
                    AppData.id = studentId;

                    StudentSelected?.Invoke(this, studentId);
                }
            }

        }
    }
}
