namespace Master_Maint
{
    partial class Domains
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Domains));
            this.panel2 = new System.Windows.Forms.Panel();
            this.DomainLabel = new System.Windows.Forms.Label();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.HotelBtn = new System.Windows.Forms.Button();
            this.FactoryBtn = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.DomainLabel);
            this.panel2.Controls.Add(this.MiniBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 50);
            this.panel2.TabIndex = 2;
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DomainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.DomainLabel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DomainLabel.Location = new System.Drawing.Point(300, 15);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(114, 21);
            this.DomainLabel.TabIndex = 4;
            this.DomainLabel.Text = "Les Domaines";
            this.DomainLabel.Click += new System.EventHandler(this.StateLabel_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.FlatAppearance.BorderSize = 0;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MiniBtn.ForeColor = System.Drawing.Color.White;
            this.MiniBtn.Image = ((System.Drawing.Image)(resources.GetObject("MiniBtn.Image")));
            this.MiniBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MiniBtn.Location = new System.Drawing.Point(719, 3);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(50, 50);
            this.MiniBtn.TabIndex = 3;
            this.MiniBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MiniBtn.UseVisualStyleBackColor = true;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ExitBtn.Location = new System.Drawing.Point(775, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 50);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // HotelBtn
            // 
            this.HotelBtn.BackColor = System.Drawing.Color.Transparent;
            this.HotelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotelBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.HotelBtn.Image = ((System.Drawing.Image)(resources.GetObject("HotelBtn.Image")));
            this.HotelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HotelBtn.Location = new System.Drawing.Point(47, 134);
            this.HotelBtn.Name = "HotelBtn";
            this.HotelBtn.Size = new System.Drawing.Size(201, 180);
            this.HotelBtn.TabIndex = 5;
            this.HotelBtn.Text = " Hôtel";
            this.HotelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HotelBtn.UseVisualStyleBackColor = false;
            this.HotelBtn.Click += new System.EventHandler(this.HotelBtn_Click);
            // 
            // FactoryBtn
            // 
            this.FactoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.FactoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FactoryBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.FactoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("FactoryBtn.Image")));
            this.FactoryBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FactoryBtn.Location = new System.Drawing.Point(286, 134);
            this.FactoryBtn.Name = "FactoryBtn";
            this.FactoryBtn.Size = new System.Drawing.Size(201, 180);
            this.FactoryBtn.TabIndex = 5;
            this.FactoryBtn.Text = " Usine";
            this.FactoryBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FactoryBtn.UseVisualStyleBackColor = false;
            this.FactoryBtn.Click += new System.EventHandler(this.FactoryBtn_Click);
            // 
            // ShopBtn
            // 
            this.ShopBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ShopBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShopBtn.Image")));
            this.ShopBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShopBtn.Location = new System.Drawing.Point(537, 134);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(201, 180);
            this.ShopBtn.TabIndex = 5;
            this.ShopBtn.Text = "Boutique";
            this.ShopBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShopBtn.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Domains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 471);
            this.ControlBox = false;
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.FactoryBtn);
            this.Controls.Add(this.HotelBtn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Domains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domains";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button HotelBtn;
        private System.Windows.Forms.Button FactoryBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Timer timer1;
    }
}