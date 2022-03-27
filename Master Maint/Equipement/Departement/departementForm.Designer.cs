namespace Master_Maint.Equipement.Departement
{
    partial class departementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(departementForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.InterventionLabel = new System.Windows.Forms.Label();
            this.BackEquipbtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.editDepartBtn = new System.Windows.Forms.Button();
            this.departListBtn = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.viewList = new Master_Maint.ViewIntervenantList();
            this.editDepartControl1 = new Master_Maint.Equipement.Departement.editDepartControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.InterventionLabel);
            this.panel2.Controls.Add(this.BackEquipbtn);
            this.panel2.Controls.Add(this.MiniBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 50);
            this.panel2.TabIndex = 13;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // InterventionLabel
            // 
            this.InterventionLabel.AutoSize = true;
            this.InterventionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.InterventionLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.InterventionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.InterventionLabel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.InterventionLabel.Location = new System.Drawing.Point(321, 15);
            this.InterventionLabel.Name = "InterventionLabel";
            this.InterventionLabel.Size = new System.Drawing.Size(150, 21);
            this.InterventionLabel.TabIndex = 4;
            this.InterventionLabel.Text = "Les departements";
            // 
            // BackEquipbtn
            // 
            this.BackEquipbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackEquipbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackEquipbtn.FlatAppearance.BorderSize = 0;
            this.BackEquipbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackEquipbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BackEquipbtn.ForeColor = System.Drawing.Color.White;
            this.BackEquipbtn.Image = ((System.Drawing.Image)(resources.GetObject("BackEquipbtn.Image")));
            this.BackEquipbtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BackEquipbtn.Location = new System.Drawing.Point(0, 0);
            this.BackEquipbtn.Name = "BackEquipbtn";
            this.BackEquipbtn.Size = new System.Drawing.Size(50, 50);
            this.BackEquipbtn.TabIndex = 3;
            this.BackEquipbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackEquipbtn.UseVisualStyleBackColor = true;
            this.BackEquipbtn.Click += new System.EventHandler(this.BackEquipbtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.MiniBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MiniBtn.FlatAppearance.BorderSize = 0;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MiniBtn.ForeColor = System.Drawing.Color.White;
            this.MiniBtn.Image = ((System.Drawing.Image)(resources.GetObject("MiniBtn.Image")));
            this.MiniBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MiniBtn.Location = new System.Drawing.Point(727, 0);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(50, 50);
            this.MiniBtn.TabIndex = 3;
            this.MiniBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MiniBtn.UseVisualStyleBackColor = true;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ExitBtn.Location = new System.Drawing.Point(777, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 50);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.editDepartBtn);
            this.panel1.Controls.Add(this.departListBtn);
            this.panel1.Controls.Add(this.LogoPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 520);
            this.panel1.TabIndex = 14;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 158);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 69);
            this.SidePanel.TabIndex = 6;
            // 
            // editDepartBtn
            // 
            this.editDepartBtn.FlatAppearance.BorderSize = 0;
            this.editDepartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDepartBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.editDepartBtn.ForeColor = System.Drawing.Color.White;
            this.editDepartBtn.Image = ((System.Drawing.Image)(resources.GetObject("editDepartBtn.Image")));
            this.editDepartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editDepartBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.editDepartBtn.Location = new System.Drawing.Point(15, 233);
            this.editDepartBtn.Name = "editDepartBtn";
            this.editDepartBtn.Size = new System.Drawing.Size(185, 69);
            this.editDepartBtn.TabIndex = 7;
            this.editDepartBtn.Text = "Gérer les Départements";
            this.editDepartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editDepartBtn.UseVisualStyleBackColor = true;
            this.editDepartBtn.Click += new System.EventHandler(this.editDepartBtn_Click);
            // 
            // departListBtn
            // 
            this.departListBtn.FlatAppearance.BorderSize = 0;
            this.departListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departListBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.departListBtn.ForeColor = System.Drawing.Color.White;
            this.departListBtn.Image = ((System.Drawing.Image)(resources.GetObject("departListBtn.Image")));
            this.departListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.departListBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.departListBtn.Location = new System.Drawing.Point(15, 158);
            this.departListBtn.Name = "departListBtn";
            this.departListBtn.Size = new System.Drawing.Size(185, 69);
            this.departListBtn.TabIndex = 7;
            this.departListBtn.Text = "Liste des departement";
            this.departListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.departListBtn.UseVisualStyleBackColor = true;
            this.departListBtn.Click += new System.EventHandler(this.departListBtn_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LogoPicture.Location = new System.Drawing.Point(31, 15);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(104, 98);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 5;
            this.LogoPicture.TabStop = false;
            // 
            // viewList
            // 
            this.viewList.Location = new System.Drawing.Point(200, 47);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(824, 473);
            this.viewList.TabIndex = 15;
            // 
            // editDepartControl1
            // 
            this.editDepartControl1.Location = new System.Drawing.Point(200, 47);
            this.editDepartControl1.Name = "editDepartControl1";
            this.editDepartControl1.Size = new System.Drawing.Size(827, 473);
            this.editDepartControl1.TabIndex = 16;
            // 
            // departementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.editDepartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "departementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "departementForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InterventionLabel;
        private System.Windows.Forms.Button BackEquipbtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button editDepartBtn;
        private System.Windows.Forms.Button departListBtn;
        private System.Windows.Forms.PictureBox LogoPicture;
        private ViewIntervenantList viewList;
        private editDepartControl editDepartControl1;
    }
}