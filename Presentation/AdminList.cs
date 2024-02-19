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
        private int index;
        private Student selectedStudent;
        private Courses selectedCourses;
        private CoursesManager courses = new CoursesManager();
        private StudentsManager students = new StudentsManager();
        private bool swAvailable;
        public AdminList(int index, bool Available)
        {
            this.swAvailable = Available;
            this.index = index;
            InitializeComponent();
            if (index == 0)
                UpdateCourses();
            else
                UpdateStudents();

            dgvList.ClearSelection();
            dgvList.CurrentCell = null;


        }

        private void UpdateCourses()
        {                
            listCourses = courses.ListCourses();

            try
            {
                dgvList.DataSource = listCourses;
                dgvList.Columns["id"].Visible = false;
                if(!swAvailable)
                    dgvList.Columns["available"].Visible = false;

                dgvList.ClearSelection();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void UpdateStudents()
        {
            listStudents = students.ListStudents();

            try
            {
                dgvList.DataSource = listStudents;
                dgvList.Columns["id"].Visible = false;
                if (!swAvailable)
                    dgvList.Columns["available"].Visible = false;

                dgvList.ClearSelection();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvList.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dgvList.SelectedRows[0];

                int idValue = (int)selectedRow.Cells["id"].Value;
                AppData.id = idValue;
                Console.WriteLine(AppData.id);
                if (index == 0)
                {
                    selectedCourses = courses.findByid(idValue);
                    AppData.SelectedItem = selectedCourses;
                
                }
                else
                {
                    selectedStudent = students.findByid(idValue);
                    AppData.SelectedItem = selectedStudent;
                }

            }

        }
    }
}
