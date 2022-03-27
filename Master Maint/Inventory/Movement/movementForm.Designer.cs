namespace Master_Maint.Inventory.Movement
{
    partial class movementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movementForm));
            this.editMovementBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workOrderLbl = new System.Windows.Forms.Label();
            this.BackToInventbtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.movementBtn = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.viewList = new Master_Maint.ViewIntervenantList();
            this.editMovementControl1 = new Master_Maint.Inventory.Movement.editMovementControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // editMovementBtn
            // 
            this.editMovementBtn.FlatAppearance.BorderSize = 0;
            this.editMovementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMovementBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.editMovementBtn.ForeColor = System.Drawing.Color.White;
            this.editMovementBtn.Image = ((System.Drawing.Image)(resources.GetObject("editMovementBtn.Image")));
            this.editMovementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editMovementBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.editMovementBtn.Location = new System.Drawing.Point(15, 253);
            this.editMovementBtn.Name = "editMovementBtn";
            this.editMovementBtn.Size = new System.Drawing.Size(182, 75);
            this.editMovementBtn.TabIndex = 7;
            this.editMovementBtn.Text = "   Gérer les\r\n  bons";
            this.editMovementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editMovementBtn.UseVisualStyleBackColor = true;
            this.editMovementBtn.Click += new System.EventHandler(this.editMovementBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.workOrderLbl);
            this.panel2.Controls.Add(this.BackToInventbtn);
            this.panel2.Controls.Add(this.MiniBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 50);
            this.panel2.TabIndex = 33;
            // 
            // workOrderLbl
            // 
            this.workOrderLbl.AutoSize = true;
            this.workOrderLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.workOrderLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.workOrderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.workOrderLbl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.workOrderLbl.Location = new System.Drawing.Point(285, 15);
            this.workOrderLbl.Name = "workOrderLbl";
            this.workOrderLbl.Size = new System.Drawing.Size(256, 21);
            this.workOrderLbl.TabIndex = 4;
            this.workOrderLbl.Text = "Les bons : entrée / sortie / retour";
            // 
            // BackToInventbtn
            // 
            this.BackToInventbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackToInventbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackToInventbtn.FlatAppearance.BorderSize = 0;
            this.BackToInventbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToInventbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BackToInventbtn.ForeColor = System.Drawing.Color.White;
            this.BackToInventbtn.Image = ((System.Drawing.Image)(resources.GetObject("BackToInventbtn.Image")));
            this.BackToInventbtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BackToInventbtn.Location = new System.Drawing.Point(0, 0);
            this.BackToInventbtn.Name = "BackToInventbtn";
            this.BackToInventbtn.Size = new System.Drawing.Size(50, 50);
            this.BackToInventbtn.TabIndex = 3;
            this.BackToInventbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackToInventbtn.UseVisualStyleBackColor = true;
            this.BackToInventbtn.Click += new System.EventHandler(this.BackToInventbtn_Click);
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
            this.panel1.Controls.Add(this.editMovementBtn);
            this.panel1.Controls.Add(this.movementBtn);
            this.panel1.Controls.Add(this.LogoPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 520);
            this.panel1.TabIndex = 34;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 158);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 75);
            this.SidePanel.TabIndex = 6;
            // 
            // movementBtn
            // 
            this.movementBtn.FlatAppearance.BorderSize = 0;
            this.movementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movementBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.movementBtn.ForeColor = System.Drawing.Color.White;
            this.movementBtn.Image = ((System.Drawing.Image)(resources.GetObject("movementBtn.Image")));
            this.movementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movementBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.movementBtn.Location = new System.Drawing.Point(15, 158);
            this.movementBtn.Name = "movementBtn";
            this.movementBtn.Size = new System.Drawing.Size(182, 75);
            this.movementBtn.TabIndex = 7;
            this.movementBtn.Text = "   Liste des\r\n  bons";
            this.movementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.movementBtn.UseVisualStyleBackColor = true;
            this.movementBtn.Click += new System.EventHandler(this.movementBtn_Click);
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
            this.viewList.Location = new System.Drawing.Point(200, 43);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(824, 473);
            this.viewList.TabIndex = 35;
            // 
            // editMovementControl1
            // 
            this.editMovementControl1.Location = new System.Drawing.Point(200, 47);
            this.editMovementControl1.Name = "editMovementControl1";
            this.editMovementControl1.Size = new System.Drawing.Size(827, 473);
            this.editMovementControl1.TabIndex = 36;
            // 
            // movementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.editMovementControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "movementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "movementForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editMovementBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label workOrderLbl;
        private System.Windows.Forms.Button BackToInventbtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button movementBtn;
        private System.Windows.Forms.PictureBox LogoPicture;
        private ViewIntervenantList viewList;
        private editMovementControl editMovementControl1;
    }
}