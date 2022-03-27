namespace Master_Maint.Equipement
{
    partial class EquipementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipementForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.InterventionLabel = new System.Windows.Forms.Label();
            this.BackToHomebtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.equipementSetBtn = new System.Windows.Forms.Button();
            this.departBtn = new System.Windows.Forms.Button();
            this.treeBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.InterventionLabel);
            this.panel2.Controls.Add(this.BackToHomebtn);
            this.panel2.Controls.Add(this.MiniBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 50);
            this.panel2.TabIndex = 3;
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
            this.InterventionLabel.Location = new System.Drawing.Point(409, 15);
            this.InterventionLabel.Name = "InterventionLabel";
            this.InterventionLabel.Size = new System.Drawing.Size(207, 21);
            this.InterventionLabel.TabIndex = 4;
            this.InterventionLabel.Text = "Gestion des Equipements";
            // 
            // BackToHomebtn
            // 
            this.BackToHomebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackToHomebtn.FlatAppearance.BorderSize = 0;
            this.BackToHomebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHomebtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BackToHomebtn.ForeColor = System.Drawing.Color.White;
            this.BackToHomebtn.Image = ((System.Drawing.Image)(resources.GetObject("BackToHomebtn.Image")));
            this.BackToHomebtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BackToHomebtn.Location = new System.Drawing.Point(0, 0);
            this.BackToHomebtn.Name = "BackToHomebtn";
            this.BackToHomebtn.Size = new System.Drawing.Size(50, 50);
            this.BackToHomebtn.TabIndex = 3;
            this.BackToHomebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackToHomebtn.UseVisualStyleBackColor = true;
            this.BackToHomebtn.Click += new System.EventHandler(this.BackToHomebtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.MiniBtn.FlatAppearance.BorderSize = 0;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MiniBtn.ForeColor = System.Drawing.Color.White;
            this.MiniBtn.Image = ((System.Drawing.Image)(resources.GetObject("MiniBtn.Image")));
            this.MiniBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MiniBtn.Location = new System.Drawing.Point(922, 0);
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
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ExitBtn.Location = new System.Drawing.Point(978, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 50);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // equipementSetBtn
            // 
            this.equipementSetBtn.BackColor = System.Drawing.Color.Transparent;
            this.equipementSetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equipementSetBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipementSetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.equipementSetBtn.Image = ((System.Drawing.Image)(resources.GetObject("equipementSetBtn.Image")));
            this.equipementSetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.equipementSetBtn.Location = new System.Drawing.Point(12, 66);
            this.equipementSetBtn.Name = "equipementSetBtn";
            this.equipementSetBtn.Size = new System.Drawing.Size(201, 180);
            this.equipementSetBtn.TabIndex = 6;
            this.equipementSetBtn.Text = "Gérer \r\nLes équipement";
            this.equipementSetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.equipementSetBtn.UseVisualStyleBackColor = false;
            this.equipementSetBtn.Click += new System.EventHandler(this.equipementSetBtn_Click);
            // 
            // departBtn
            // 
            this.departBtn.BackColor = System.Drawing.Color.Transparent;
            this.departBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.departBtn.Image = ((System.Drawing.Image)(resources.GetObject("departBtn.Image")));
            this.departBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.departBtn.Location = new System.Drawing.Point(237, 66);
            this.departBtn.Name = "departBtn";
            this.departBtn.Size = new System.Drawing.Size(201, 180);
            this.departBtn.TabIndex = 6;
            this.departBtn.Text = "Les départements";
            this.departBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.departBtn.UseVisualStyleBackColor = false;
            this.departBtn.Click += new System.EventHandler(this.departBtn_Click);
            // 
            // treeBtn
            // 
            this.treeBtn.BackColor = System.Drawing.Color.Transparent;
            this.treeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treeBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.treeBtn.Image = ((System.Drawing.Image)(resources.GetObject("treeBtn.Image")));
            this.treeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.treeBtn.Location = new System.Drawing.Point(456, 66);
            this.treeBtn.Name = "treeBtn";
            this.treeBtn.Size = new System.Drawing.Size(201, 180);
            this.treeBtn.TabIndex = 6;
            this.treeBtn.Text = "L\'arborescence des équipements";
            this.treeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.treeBtn.UseVisualStyleBackColor = false;
            this.treeBtn.Click += new System.EventHandler(this.treeBtn_Click);
            // 
            // EquipementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 520);
            this.ControlBox = false;
            this.Controls.Add(this.treeBtn);
            this.Controls.Add(this.departBtn);
            this.Controls.Add(this.equipementSetBtn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EquipementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipementForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InterventionLabel;
        private System.Windows.Forms.Button BackToHomebtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button equipementSetBtn;
        private System.Windows.Forms.Button departBtn;
        private System.Windows.Forms.Button treeBtn;
    }
}