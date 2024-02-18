
namespace Presentation
{
    partial class Admin
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
            this.cbxItems = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnList = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxItems
            // 
            this.cbxItems.AutoResize = false;
            this.cbxItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxItems.Depth = 0;
            this.cbxItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxItems.DropDownHeight = 174;
            this.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItems.DropDownWidth = 121;
            this.cbxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.IntegralHeight = false;
            this.cbxItems.ItemHeight = 43;
            this.cbxItems.Location = new System.Drawing.Point(25, 15);
            this.cbxItems.MaxDropDownItems = 4;
            this.cbxItems.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(133, 49);
            this.cbxItems.StartIndex = 0;
            this.cbxItems.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnList);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cbxItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 443);
            this.panel1.TabIndex = 4;
            // 
            // btnList
            // 
            this.btnList.AutoSize = false;
            this.btnList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnList.Depth = 0;
            this.btnList.HighEmphasis = true;
            this.btnList.Icon = null;
            this.btnList.Location = new System.Drawing.Point(25, 110);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnList.Name = "btnList";
            this.btnList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnList.Size = new System.Drawing.Size(133, 38);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Listar";
            this.btnList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnList.UseAccentColor = false;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(25, 260);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(133, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "   Eliminar   ";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseMnemonic = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(25, 160);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(133, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = false;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(25, 210);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(133, 38);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdmin.Location = new System.Drawing.Point(188, 64);
            this.pnlAdmin.MaximumSize = new System.Drawing.Size(634, 443);
            this.pnlAdmin.MinimumSize = new System.Drawing.Size(634, 443);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(634, 443);
            this.pnlAdmin.TabIndex = 5;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 510);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(825, 510);
            this.MinimumSize = new System.Drawing.Size(825, 510);
            this.Name = "Admin";
            this.Sizable = false;
            this.Text = "Administrar";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cbxItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAdmin;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnList;
    }
}