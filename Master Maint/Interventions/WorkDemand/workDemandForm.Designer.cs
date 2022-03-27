namespace Master_Maint
{
    partial class workDemandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workDemandForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.workOrderLbl = new System.Windows.Forms.Label();
            this.BackToIntbtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.editWorkDemandBtn = new System.Windows.Forms.Button();
            this.workDemandBtn = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.editWorkDemandControl1 = new Master_Maint.Interventions.WorkDemand.EditWorkDemandControl();
            this.viewList = new Master_Maint.ViewIntervenantList();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.workOrderLbl);
            this.panel2.Controls.Add(this.BackToIntbtn);
            this.panel2.Controls.Add(this.MiniBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 50);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // workOrderLbl
            // 
            this.workOrderLbl.AutoSize = true;
            this.workOrderLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.workOrderLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.workOrderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.workOrderLbl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.workOrderLbl.Location = new System.Drawing.Point(295, 15);
            this.workOrderLbl.Name = "workOrderLbl";
            this.workOrderLbl.Size = new System.Drawing.Size(258, 21);
            this.workOrderLbl.TabIndex = 4;
            this.workOrderLbl.Text = "Les Demandes des interventions";
            // 
            // BackToIntbtn
            // 
            this.BackToIntbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackToIntbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackToIntbtn.FlatAppearance.BorderSize = 0;
            this.BackToIntbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToIntbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BackToIntbtn.ForeColor = System.Drawing.Color.White;
            this.BackToIntbtn.Image = ((System.Drawing.Image)(resources.GetObject("BackToIntbtn.Image")));
            this.BackToIntbtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BackToIntbtn.Location = new System.Drawing.Point(0, 0);
            this.BackToIntbtn.Name = "BackToIntbtn";
            this.BackToIntbtn.Size = new System.Drawing.Size(50, 50);
            this.BackToIntbtn.TabIndex = 3;
            this.BackToIntbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackToIntbtn.UseVisualStyleBackColor = true;
            this.BackToIntbtn.Click += new System.EventHandler(this.BackToIntbtn_Click);
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
            this.MiniBtn.Location = new System.Drawing.Point(724, 0);
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
            this.ExitBtn.Location = new System.Drawing.Point(774, 0);
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
            this.panel1.Controls.Add(this.editWorkDemandBtn);
            this.panel1.Controls.Add(this.workDemandBtn);
            this.panel1.Controls.Add(this.LogoPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 520);
            this.panel1.TabIndex = 10;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 158);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 75);
            this.SidePanel.TabIndex = 6;
            // 
            // editWorkDemandBtn
            // 
            this.editWorkDemandBtn.FlatAppearance.BorderSize = 0;
            this.editWorkDemandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editWorkDemandBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.editWorkDemandBtn.ForeColor = System.Drawing.Color.White;
            this.editWorkDemandBtn.Image = ((System.Drawing.Image)(resources.GetObject("editWorkDemandBtn.Image")));
            this.editWorkDemandBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editWorkDemandBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.editWorkDemandBtn.Location = new System.Drawing.Point(15, 253);
            this.editWorkDemandBtn.Name = "editWorkDemandBtn";
            this.editWorkDemandBtn.Size = new System.Drawing.Size(185, 75);
            this.editWorkDemandBtn.TabIndex = 7;
            this.editWorkDemandBtn.Text = "Gérer les demandes des interventions";
            this.editWorkDemandBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editWorkDemandBtn.UseVisualStyleBackColor = true;
            this.editWorkDemandBtn.Click += new System.EventHandler(this.editWorkDemandBtn_Click);
            // 
            // workDemandBtn
            // 
            this.workDemandBtn.FlatAppearance.BorderSize = 0;
            this.workDemandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workDemandBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.workDemandBtn.ForeColor = System.Drawing.Color.White;
            this.workDemandBtn.Image = ((System.Drawing.Image)(resources.GetObject("workDemandBtn.Image")));
            this.workDemandBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.workDemandBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.workDemandBtn.Location = new System.Drawing.Point(15, 158);
            this.workDemandBtn.Name = "workDemandBtn";
            this.workDemandBtn.Size = new System.Drawing.Size(185, 75);
            this.workDemandBtn.TabIndex = 7;
            this.workDemandBtn.Text = "Liste des demandes des interventions";
            this.workDemandBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.workDemandBtn.UseVisualStyleBackColor = true;
            this.workDemandBtn.Click += new System.EventHandler(this.workDemandBtn_Click);
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
            // editWorkDemandControl1
            // 
            this.editWorkDemandControl1.Location = new System.Drawing.Point(200, 47);
            this.editWorkDemandControl1.Name = "editWorkDemandControl1";
            this.editWorkDemandControl1.Size = new System.Drawing.Size(824, 473);
            this.editWorkDemandControl1.TabIndex = 12;
            // 
            // viewList
            // 
            this.viewList.Location = new System.Drawing.Point(200, 47);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(824, 473);
            this.viewList.TabIndex = 11;
            // 
            // workDemandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.editWorkDemandControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "workDemandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "workDemandForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label workOrderLbl;
        private System.Windows.Forms.Button BackToIntbtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button editWorkDemandBtn;
        private System.Windows.Forms.Button workDemandBtn;
        private System.Windows.Forms.PictureBox LogoPicture;
        private ViewIntervenantList viewList;
        private Interventions.WorkDemand.EditWorkDemandControl editWorkDemandControl1;
    }
}