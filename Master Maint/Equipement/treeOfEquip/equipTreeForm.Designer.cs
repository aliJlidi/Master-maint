namespace Master_Maint.Equipement.treeOfEquip
{
    partial class equipTreeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipTreeForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Equipements");
            this.panel2 = new System.Windows.Forms.Panel();
            this.InterventionLabel = new System.Windows.Forms.Label();
            this.BackEquipbtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.equipTreeBtn = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            this.InterventionLabel.Location = new System.Drawing.Point(280, 15);
            this.InterventionLabel.Name = "InterventionLabel";
            this.InterventionLabel.Size = new System.Drawing.Size(266, 21);
            this.InterventionLabel.TabIndex = 4;
            this.InterventionLabel.Text = "L\'arborescence des équipements";
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
            this.panel1.Controls.Add(this.equipTreeBtn);
            this.panel1.Controls.Add(this.LogoPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
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
            // equipTreeBtn
            // 
            this.equipTreeBtn.FlatAppearance.BorderSize = 0;
            this.equipTreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equipTreeBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.equipTreeBtn.ForeColor = System.Drawing.Color.White;
            this.equipTreeBtn.Image = ((System.Drawing.Image)(resources.GetObject("equipTreeBtn.Image")));
            this.equipTreeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equipTreeBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.equipTreeBtn.Location = new System.Drawing.Point(15, 158);
            this.equipTreeBtn.Name = "equipTreeBtn";
            this.equipTreeBtn.Size = new System.Drawing.Size(185, 69);
            this.equipTreeBtn.TabIndex = 7;
            this.equipTreeBtn.Text = "L\'arborescence";
            this.equipTreeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.equipTreeBtn.UseVisualStyleBackColor = true;
            this.equipTreeBtn.Click += new System.EventHandler(this.equipTreeBtn_Click);
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
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.treeView1.Location = new System.Drawing.Point(260, 78);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Equipements";
            treeNode1.Text = "Equipements";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(334, 369);
            this.treeView1.TabIndex = 15;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // equipTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 500);
            this.ControlBox = false;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "equipTreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "equipTreeForm";
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
        private System.Windows.Forms.Button equipTreeBtn;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.TreeView treeView1;
    }
}