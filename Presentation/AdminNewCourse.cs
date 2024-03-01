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
using MaterialSkin.Controls;
using MaterialSkin;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class AdminNewCourse : Form
    {
        string days = "";
        string hsFinal = "";

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
        public AdminNewCourse()
        {
            InitializeComponent();
            setForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Courses c = new Courses();
            c.CoursesClasses = txtCourse.Text;
            c.Institution = txtInstitute.Text;
            c.Level = txtLevel.Text;
            c.Days = setDays();


            CoursesManager cm = new CoursesManager();

            if (txtCourse.Text != "" && txtCourse != null &&
                txtInstitute.Text != "" && txtInstitute != null &&
                txtLevel.Text != "" && txtLevel != null &&
                days != "" && hsFinal != "")
            {
                cm.AddCourse(c);

                if (this.Tag is Admin parentForm)
                {
                    parentForm.Close();
                }

            }
            else
            {
                // fix checked
                lblWarning.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.Tag is Admin parentForm)
            {
                parentForm.Close();
            }

        }

        private void setForm() {
           
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

        private static List<string> setHs()
        {
            List<string> list = new List<string>();

            
            for (int i = 6; i <= 23; i++)
            {
                for (int min = 0; min < 60; min += 30)
                {
                    string hs = $"{i % 12}:{min:D2} {(i< 12 ? "am" : "pm")}";
                    list.Add(hs);
                }
            }

            return list;
        }


        private string setDays()
        {
            if(cbxHs.SelectedIndex<cbxHs2.SelectedIndex)
                hsFinal = $" {cbxHs.Text} - {cbxHs2.Text}";

            List<string> Select = new List<string> { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            for (int i = 0; i < 7; i++)
            {
                CheckBox checkbox = (CheckBox)Controls.Find("check"+Select[i], true).FirstOrDefault();

                if (checkbox.Checked)
                {
                    if (days != "")
                        days += ", " + Select[i];
                    else
                        days += Select[i];
                }

            }
            days = days + "  - " + hsFinal;
            
            return days;
        }

    }
}
