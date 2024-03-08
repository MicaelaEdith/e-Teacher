using MaterialSkin;
using MaterialSkin.Controls;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentation
{
    public partial class Home : MaterialForm
    {
        private List<Courses> listCourses;

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
        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Grey900, Primary.Grey900,
            Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            dgvCourses.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dgvCourses.Width, dgvCourses.Height, 5, 5));
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            UpdateDiary();
            UpdateGrid();
            AddDataChart1();
        }
        private void UpdateGrid()
        {
            CoursesManager courses = new CoursesManager();

            dgvCourses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCourses.RowHeadersVisible = false;

            try
            {
                listCourses = courses.ListCoursesAvailable();
                foreach (Courses c in listCourses)
                {

                    int rowIndex = dgvCourses.Rows.Add();
                    DataGridViewRow row = dgvCourses.Rows[rowIndex];
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

        private void UpdateDiary()
        {



        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
           // DialogResult result = admin.ShowDialog();

            admin.ShowDialog();

          /*  if (result == DialogResult.OK)
            {
                UpdateGrid();
            }*/
        }

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void AddDataChart1()
        {
            CoursesManager coursesManager = new CoursesManager();
            Dictionary<string, int> countCourses = coursesManager.CountCourses();

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Interval = 1;
           
            Series serieC = new Series("Cursos");
            serieC.ChartType = SeriesChartType.Pie;

   

            foreach (var kvp in countCourses)
            {
                DataPoint point = new DataPoint();
                point.Label = $"{kvp.Key} ({kvp.Value})";
                point.SetValueY(kvp.Value);
                serieC.Points.Add(point);
                point["PieLabelStyle"] = "Disabled";
            }
            chart1.Series.Add(serieC);
        }
    }
}

