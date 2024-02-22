
namespace Presentation
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Institucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnAdmin = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AllowUserToResizeColumns = false;
            this.dgvCourses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            this.dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCourses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 8, 8, 8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourses.ColumnHeadersHeight = 42;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.DiaHorario,
            this.Institucion,
            this.Nivel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCourses.EnableHeadersVisualStyles = false;
            this.dgvCourses.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCourses.Location = new System.Drawing.Point(60, 78);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCourses.RowTemplate.Height = 35;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(673, 391);
            this.dgvCourses.TabIndex = 0;
            // 
            // Curso
            // 
            this.Curso.FillWeight = 65.65144F;
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // DiaHorario
            // 
            this.DiaHorario.FillWeight = 203.0457F;
            this.DiaHorario.HeaderText = "Dia - Horario";
            this.DiaHorario.Name = "DiaHorario";
            this.DiaHorario.ReadOnly = true;
            // 
            // Institucion
            // 
            this.Institucion.FillWeight = 65.65144F;
            this.Institucion.HeaderText = "Institucion";
            this.Institucion.Name = "Institucion";
            this.Institucion.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.FillWeight = 65.65144F;
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.AllowDrop = true;
            this.monthCalendar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar.Location = new System.Drawing.Point(784, 80);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(11, 9, 11, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.TitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(784, 254);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(251, 217);
            this.materialCard1.TabIndex = 4;
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdmin.Depth = 0;
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.HighEmphasis = true;
            this.btnAdmin.Icon = null;
            this.btnAdmin.Location = new System.Drawing.Point(60, 474);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdmin.Size = new System.Drawing.Size(118, 36);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Administrar";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdmin.UseAccentColor = false;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1100, 550);
            this.MinimumSize = new System.Drawing.Size(1100, 514);
            this.Name = "Home";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Institucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        public System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnAdmin;
    }
}

