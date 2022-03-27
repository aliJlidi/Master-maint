namespace Master_Maint.Inventory
{
    partial class inventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.InterventionLabel = new System.Windows.Forms.Label();
            this.BackToHomebtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.shopBtn = new System.Windows.Forms.Button();
            this.itmBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.reshipementBtn = new System.Windows.Forms.Button();
            this.recieveBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.InterventionLabel);
            this.panel2.Controls.Add(this.BackToHomebtn);
            this.panel2.Controls.Add(this.MiniBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 50);
            this.panel2.TabIndex = 4;
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
            this.InterventionLabel.Size = new System.Drawing.Size(140, 21);
            this.InterventionLabel.TabIndex = 4;
            this.InterventionLabel.Text = "Gestion de stock";
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
            // shopBtn
            // 
            this.shopBtn.BackColor = System.Drawing.Color.Transparent;
            this.shopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.shopBtn.Image = ((System.Drawing.Image)(resources.GetObject("shopBtn.Image")));
            this.shopBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.shopBtn.Location = new System.Drawing.Point(33, 68);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(201, 180);
            this.shopBtn.TabIndex = 7;
            this.shopBtn.Text = "Les \r\nmagasins";
            this.shopBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.shopBtn.UseVisualStyleBackColor = false;
            this.shopBtn.Click += new System.EventHandler(this.shopBtn_Click);
            // 
            // itmBtn
            // 
            this.itmBtn.BackColor = System.Drawing.Color.Transparent;
            this.itmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itmBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.itmBtn.Image = ((System.Drawing.Image)(resources.GetObject("itmBtn.Image")));
            this.itmBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.itmBtn.Location = new System.Drawing.Point(286, 68);
            this.itmBtn.Name = "itmBtn";
            this.itmBtn.Size = new System.Drawing.Size(201, 180);
            this.itmBtn.TabIndex = 7;
            this.itmBtn.Text = "Les \r\narticles";
            this.itmBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itmBtn.UseVisualStyleBackColor = false;
            this.itmBtn.Click += new System.EventHandler(this.itmBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.BackColor = System.Drawing.Color.Transparent;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.supplierBtn.Image = ((System.Drawing.Image)(resources.GetObject("supplierBtn.Image")));
            this.supplierBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.supplierBtn.Location = new System.Drawing.Point(539, 68);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(201, 180);
            this.supplierBtn.TabIndex = 7;
            this.supplierBtn.Text = "Les \rfournisseurs";
            this.supplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.supplierBtn.UseVisualStyleBackColor = false;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // reshipementBtn
            // 
            this.reshipementBtn.BackColor = System.Drawing.Color.Transparent;
            this.reshipementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reshipementBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reshipementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.reshipementBtn.Image = ((System.Drawing.Image)(resources.GetObject("reshipementBtn.Image")));
            this.reshipementBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reshipementBtn.Location = new System.Drawing.Point(792, 68);
            this.reshipementBtn.Name = "reshipementBtn";
            this.reshipementBtn.Size = new System.Drawing.Size(201, 180);
            this.reshipementBtn.TabIndex = 7;
            this.reshipementBtn.Text = "Réapprovisionne-ment";
            this.reshipementBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reshipementBtn.UseVisualStyleBackColor = false;
            this.reshipementBtn.Click += new System.EventHandler(this.reshipementBtn_Click);
            // 
            // recieveBtn
            // 
            this.recieveBtn.BackColor = System.Drawing.Color.Transparent;
            this.recieveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recieveBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.recieveBtn.Image = ((System.Drawing.Image)(resources.GetObject("recieveBtn.Image")));
            this.recieveBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recieveBtn.Location = new System.Drawing.Point(33, 267);
            this.recieveBtn.Name = "recieveBtn";
            this.recieveBtn.Size = new System.Drawing.Size(201, 180);
            this.recieveBtn.TabIndex = 7;
            this.recieveBtn.Text = "Les \r\nbons";
            this.recieveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recieveBtn.UseVisualStyleBackColor = false;
            this.recieveBtn.Click += new System.EventHandler(this.recieveBtn_Click);
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 520);
            this.ControlBox = false;
            this.Controls.Add(this.reshipementBtn);
            this.Controls.Add(this.supplierBtn);
            this.Controls.Add(this.itmBtn);
            this.Controls.Add(this.recieveBtn);
            this.Controls.Add(this.shopBtn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventoryForm";
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
        private System.Windows.Forms.Button shopBtn;
        private System.Windows.Forms.Button itmBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button reshipementBtn;
        private System.Windows.Forms.Button recieveBtn;
    }
}