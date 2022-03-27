namespace Master_Maint.Inventory.Items
{
    partial class itemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemsForm));
            this.editItemsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workOrderLbl = new System.Windows.Forms.Label();
            this.BackToInventbtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.itemsBtn = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.viewList = new Master_Maint.ViewIntervenantList();
            this.editItemsControl1 = new Master_Maint.Inventory.Items.editItemsControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // editItemsBtn
            // 
            this.editItemsBtn.FlatAppearance.BorderSize = 0;
            this.editItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemsBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.editItemsBtn.ForeColor = System.Drawing.Color.White;
            this.editItemsBtn.Image = ((System.Drawing.Image)(resources.GetObject("editItemsBtn.Image")));
            this.editItemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editItemsBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.editItemsBtn.Location = new System.Drawing.Point(15, 253);
            this.editItemsBtn.Name = "editItemsBtn";
            this.editItemsBtn.Size = new System.Drawing.Size(182, 75);
            this.editItemsBtn.TabIndex = 7;
            this.editItemsBtn.Text = "   Gérer les\r\n    articles";
            this.editItemsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editItemsBtn.UseVisualStyleBackColor = true;
            this.editItemsBtn.Click += new System.EventHandler(this.editItemsBtn_Click);
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
            this.panel2.TabIndex = 21;
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
            this.workOrderLbl.Location = new System.Drawing.Point(358, 15);
            this.workOrderLbl.Name = "workOrderLbl";
            this.workOrderLbl.Size = new System.Drawing.Size(94, 21);
            this.workOrderLbl.TabIndex = 4;
            this.workOrderLbl.Text = "Les Articles";
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
            this.panel1.Controls.Add(this.editItemsBtn);
            this.panel1.Controls.Add(this.itemsBtn);
            this.panel1.Controls.Add(this.LogoPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 520);
            this.panel1.TabIndex = 22;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 158);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 75);
            this.SidePanel.TabIndex = 6;
            // 
            // itemsBtn
            // 
            this.itemsBtn.FlatAppearance.BorderSize = 0;
            this.itemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.itemsBtn.ForeColor = System.Drawing.Color.White;
            this.itemsBtn.Image = ((System.Drawing.Image)(resources.GetObject("itemsBtn.Image")));
            this.itemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.itemsBtn.Location = new System.Drawing.Point(15, 158);
            this.itemsBtn.Name = "itemsBtn";
            this.itemsBtn.Size = new System.Drawing.Size(182, 75);
            this.itemsBtn.TabIndex = 7;
            this.itemsBtn.Text = "   Liste\r\n   des articles";
            this.itemsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemsBtn.UseVisualStyleBackColor = true;
            this.itemsBtn.Click += new System.EventHandler(this.itemsBtn_Click);
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
            this.viewList.TabIndex = 23;
            // 
            // editItemsControl1
            // 
            this.editItemsControl1.Location = new System.Drawing.Point(200, 47);
            this.editItemsControl1.Name = "editItemsControl1";
            this.editItemsControl1.Size = new System.Drawing.Size(827, 473);
            this.editItemsControl1.TabIndex = 24;
            // 
            // itemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.editItemsControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "itemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "itemsForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editItemsBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label workOrderLbl;
        private System.Windows.Forms.Button BackToInventbtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button itemsBtn;
        private System.Windows.Forms.PictureBox LogoPicture;
        private ViewIntervenantList viewList;
        private editItemsControl editItemsControl1;
    }
}