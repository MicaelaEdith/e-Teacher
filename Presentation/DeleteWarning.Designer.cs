
namespace Presentation
{
    partial class DeleteWarning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWarning1 = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnAcept = new MaterialSkin.Controls.MaterialButton();
            this.lblStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWarning1
            // 
            this.lblWarning1.AutoSize = true;
            this.lblWarning1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning1.ForeColor = System.Drawing.Color.Red;
            this.lblWarning1.Location = new System.Drawing.Point(142, 60);
            this.lblWarning1.Name = "lblWarning1";
            this.lblWarning1.Size = new System.Drawing.Size(232, 25);
            this.lblWarning1.TabIndex = 0;
            this.lblWarning1.Text = "Se eliminará el registro: ";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.lblCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.Black;
            this.lblCourse.Location = new System.Drawing.Point(133, 109);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(146, 26);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "nombre prueba";
            this.lblCourse.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(309, 189);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MaximumSize = new System.Drawing.Size(86, 36);
            this.btnDelete.MinimumSize = new System.Drawing.Size(86, 36);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(86, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "cancelar";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAcept
            // 
            this.btnAcept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcept.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAcept.Depth = 0;
            this.btnAcept.HighEmphasis = true;
            this.btnAcept.Icon = null;
            this.btnAcept.Location = new System.Drawing.Point(97, 189);
            this.btnAcept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAcept.MaximumSize = new System.Drawing.Size(86, 36);
            this.btnAcept.MinimumSize = new System.Drawing.Size(86, 36);
            this.btnAcept.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAcept.Size = new System.Drawing.Size(86, 36);
            this.btnAcept.TabIndex = 0;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAcept.UseAccentColor = false;
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.lblStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.Black;
            this.lblStudent.Location = new System.Drawing.Point(107, 109);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(150, 26);
            this.lblStudent.TabIndex = 4;
            this.lblStudent.Text = "nombre alumne";
            this.lblStudent.Visible = false;
            // 
            // DeleteWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(498, 371);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblWarning1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(498, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(498, 371);
            this.Name = "DeleteWarning";
            this.Text = "DeleteWarning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning1;
        private System.Windows.Forms.Label lblCourse;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnAcept;
        private System.Windows.Forms.Label lblStudent;
    }
}