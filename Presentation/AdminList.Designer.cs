
namespace Presentation
{
    partial class AdminList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnDetails = new MaterialSkin.Controls.MaterialButton();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cbxAdd = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddData = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Gray;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvList.ColumnHeadersHeight = 40;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(12, 13);
            this.dgvList.MaximumSize = new System.Drawing.Size(554, 315);
            this.dgvList.MinimumSize = new System.Drawing.Size(554, 315);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 32;
            this.dgvList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(554, 315);
            this.dgvList.TabIndex = 2;
            this.dgvList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_RowEnter);
            // 
            // btnDetails
            // 
            this.btnDetails.AutoSize = false;
            this.btnDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetails.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDetails.Depth = 0;
            this.btnDetails.HighEmphasis = true;
            this.btnDetails.Icon = null;
            this.btnDetails.Location = new System.Drawing.Point(29, 350);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetails.Size = new System.Drawing.Size(122, 26);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Detalle";
            this.btnDetails.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetails.UseAccentColor = false;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(26, 13);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 19);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "materialLabel1";
            this.lblTitle.Visible = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Gray;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvData.ColumnHeadersHeight = 40;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(25, 35);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 30;
            this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(409, 192);
            this.dgvData.TabIndex = 5;
            this.dgvData.Visible = false;
            // 
            // cbxAdd
            // 
            this.cbxAdd.AutoResize = false;
            this.cbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxAdd.Depth = 0;
            this.cbxAdd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxAdd.DropDownHeight = 174;
            this.cbxAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAdd.DropDownWidth = 121;
            this.cbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxAdd.FormattingEnabled = true;
            this.cbxAdd.IntegralHeight = false;
            this.cbxAdd.ItemHeight = 43;
            this.cbxAdd.Location = new System.Drawing.Point(25, 246);
            this.cbxAdd.MaxDropDownItems = 4;
            this.cbxAdd.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxAdd.Name = "cbxAdd";
            this.cbxAdd.Size = new System.Drawing.Size(409, 49);
            this.cbxAdd.StartIndex = 0;
            this.cbxAdd.TabIndex = 6;
            this.cbxAdd.Visible = false;
            // 
            // btnAddData
            // 
            this.btnAddData.AutoSize = false;
            this.btnAddData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddData.Depth = 0;
            this.btnAddData.DrawShadows = false;
            this.btnAddData.HighEmphasis = true;
            this.btnAddData.Icon = null;
            this.btnAddData.Location = new System.Drawing.Point(310, 346);
            this.btnAddData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddData.Size = new System.Drawing.Size(122, 26);
            this.btnAddData.TabIndex = 7;
            this.btnAddData.Text = "agregar";
            this.btnAddData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddData.UseAccentColor = false;
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Visible = false;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // AdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(578, 443);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.cbxAdd);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(578, 443);
            this.MinimumSize = new System.Drawing.Size(578, 443);
            this.Name = "AdminList";
            this.Text = "AdminList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private MaterialSkin.Controls.MaterialButton btnDetails;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.DataGridView dgvData;
        private MaterialSkin.Controls.MaterialComboBox cbxAdd;
        private MaterialSkin.Controls.MaterialButton btnAddData;
    }
}