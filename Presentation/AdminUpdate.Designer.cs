﻿
namespace Presentation
{
    partial class AdminUpdate
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCourse = new MaterialSkin.Controls.MaterialLabel();
            this.txtCourse = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.txtDays = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInstitute = new MaterialSkin.Controls.MaterialTextBox();
            this.lblInstitute = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLevel = new MaterialSkin.Controls.MaterialTextBox();
            this.lblLevel = new MaterialSkin.Controls.MaterialLabel();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.IndianRed;
            this.lblWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.White;
            this.lblWarning.Location = new System.Drawing.Point(151, 4);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(347, 24);
            this.lblWarning.TabIndex = 23;
            this.lblWarning.Text = " Todos los campos son obligatorios ";
            this.lblWarning.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Location = new System.Drawing.Point(164, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 58);
            this.panel5.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(164, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(96, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(24, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(88, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Guardar";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCourse);
            this.panel4.Controls.Add(this.txtCourse);
            this.panel4.Location = new System.Drawing.Point(9, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 53);
            this.panel4.TabIndex = 21;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Depth = 0;
            this.lblCourse.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCourse.Location = new System.Drawing.Point(-1, 14);
            this.lblCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(119, 19);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Curso / Materia :";
            // 
            // txtCourse
            // 
            this.txtCourse.AnimateReadOnly = false;
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourse.Depth = 0;
            this.txtCourse.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourse.LeadingIcon = null;
            this.txtCourse.LeaveOnEnterKey = true;
            this.txtCourse.Location = new System.Drawing.Point(118, 1);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(0);
            this.txtCourse.MaxLength = 50;
            this.txtCourse.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCourse.Multiline = false;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(280, 50);
            this.txtCourse.TabIndex = 2;
            this.txtCourse.Text = "";
            this.txtCourse.TrailingIcon = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDays);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Location = new System.Drawing.Point(10, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 64);
            this.panel3.TabIndex = 20;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Depth = 0;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(16, 26);
            this.lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(101, 19);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Dia y Horario :";
            // 
            // txtDays
            // 
            this.txtDays.AnimateReadOnly = false;
            this.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDays.Depth = 0;
            this.txtDays.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDays.LeadingIcon = null;
            this.txtDays.Location = new System.Drawing.Point(117, 9);
            this.txtDays.Margin = new System.Windows.Forms.Padding(0);
            this.txtDays.MaxLength = 50;
            this.txtDays.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDays.Multiline = false;
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(281, 50);
            this.txtDays.TabIndex = 5;
            this.txtDays.Text = "";
            this.txtDays.TrailingIcon = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtInstitute);
            this.panel2.Controls.Add(this.lblInstitute);
            this.panel2.Location = new System.Drawing.Point(13, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 65);
            this.panel2.TabIndex = 19;
            // 
            // txtInstitute
            // 
            this.txtInstitute.AnimateReadOnly = false;
            this.txtInstitute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstitute.Depth = 0;
            this.txtInstitute.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInstitute.LeadingIcon = null;
            this.txtInstitute.Location = new System.Drawing.Point(113, 10);
            this.txtInstitute.Margin = new System.Windows.Forms.Padding(0);
            this.txtInstitute.MaxLength = 50;
            this.txtInstitute.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInstitute.Multiline = false;
            this.txtInstitute.Name = "txtInstitute";
            this.txtInstitute.Size = new System.Drawing.Size(281, 50);
            this.txtInstitute.TabIndex = 7;
            this.txtInstitute.Text = "";
            this.txtInstitute.TrailingIcon = null;
            // 
            // lblInstitute
            // 
            this.lblInstitute.AutoSize = true;
            this.lblInstitute.Depth = 0;
            this.lblInstitute.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInstitute.Location = new System.Drawing.Point(22, 25);
            this.lblInstitute.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInstitute.Name = "lblInstitute";
            this.lblInstitute.Size = new System.Drawing.Size(83, 19);
            this.lblInstitute.TabIndex = 6;
            this.lblInstitute.Text = "Institución :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Location = new System.Drawing.Point(61, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 59);
            this.panel1.TabIndex = 18;
            // 
            // txtLevel
            // 
            this.txtLevel.AnimateReadOnly = false;
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Depth = 0;
            this.txtLevel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLevel.LeadingIcon = null;
            this.txtLevel.Location = new System.Drawing.Point(65, 5);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(0);
            this.txtLevel.MaxLength = 50;
            this.txtLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLevel.Multiline = false;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(281, 50);
            this.txtLevel.TabIndex = 9;
            this.txtLevel.Text = "";
            this.txtLevel.TrailingIcon = null;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Depth = 0;
            this.lblLevel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLevel.Location = new System.Drawing.Point(4, 19);
            this.lblLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(44, 19);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Nivel :";
            // 
            // AdminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(578, 443);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(578, 443);
            this.MinimumSize = new System.Drawing.Size(578, 443);
            this.Name = "AdminUpdate";
            this.Text = "AdminUpdate";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel lblCourse;
        private MaterialSkin.Controls.MaterialTextBox txtCourse;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox txtDays;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txtInstitute;
        private MaterialSkin.Controls.MaterialLabel lblInstitute;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtLevel;
        private MaterialSkin.Controls.MaterialLabel lblLevel;
    }
}