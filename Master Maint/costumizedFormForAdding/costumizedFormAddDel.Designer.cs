namespace Master_Maint.costumizedFormForAdding
{
    partial class costumizedFormAddDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(costumizedFormAddDel));
            this.captionLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.holderLbl = new System.Windows.Forms.Label();
            this.interventionPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.holderTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.holderList = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.interventionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // captionLbl
            // 
            this.captionLbl.AutoSize = true;
            this.captionLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captionLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.captionLbl.Location = new System.Drawing.Point(15, 16);
            this.captionLbl.Name = "captionLbl";
            this.captionLbl.Size = new System.Drawing.Size(76, 20);
            this.captionLbl.TabIndex = 8;
            this.captionLbl.Text = "Message";
            this.captionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(128, 194);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(40, 40);
            this.addBtn.TabIndex = 12;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // holderLbl
            // 
            this.holderLbl.AutoSize = true;
            this.holderLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holderLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.holderLbl.Location = new System.Drawing.Point(12, 95);
            this.holderLbl.Name = "holderLbl";
            this.holderLbl.Size = new System.Drawing.Size(91, 22);
            this.holderLbl.TabIndex = 14;
            this.holderLbl.Text = "Message";
            this.holderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interventionPanel
            // 
            this.interventionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.interventionPanel.Controls.Add(this.captionLbl);
            this.interventionPanel.Controls.Add(this.ExitBtn);
            this.interventionPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.interventionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.interventionPanel.Location = new System.Drawing.Point(0, 0);
            this.interventionPanel.Name = "interventionPanel";
            this.interventionPanel.Size = new System.Drawing.Size(550, 50);
            this.interventionPanel.TabIndex = 9;
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
            this.ExitBtn.Location = new System.Drawing.Point(495, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 50);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // holderTxt
            // 
            this.holderTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.holderTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.holderTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.holderTxt.BorderThickness = 3;
            this.holderTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.holderTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holderTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.holderTxt.isPassword = false;
            this.holderTxt.Location = new System.Drawing.Point(112, 87);
            this.holderTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.holderTxt.Name = "holderTxt";
            this.holderTxt.Size = new System.Drawing.Size(207, 39);
            this.holderTxt.TabIndex = 15;
            this.holderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // holderList
            // 
            this.holderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.holderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holderList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holderList.FormattingEnabled = true;
            this.holderList.ItemHeight = 17;
            this.holderList.Location = new System.Drawing.Point(328, 57);
            this.holderList.Name = "holderList";
            this.holderList.Size = new System.Drawing.Size(206, 223);
            this.holderList.TabIndex = 16;
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(188, 194);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(40, 40);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 281);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(540, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 281);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 10);
            this.panel3.TabIndex = 12;
            // 
            // costumizedFormAddDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 331);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.holderList);
            this.Controls.Add(this.holderTxt);
            this.Controls.Add(this.interventionPanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.holderLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "costumizedFormAddDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "costumizedFormForAdding";
            this.interventionPanel.ResumeLayout(false);
            this.interventionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label captionLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label holderLbl;
        private System.Windows.Forms.Panel interventionPanel;
        private System.Windows.Forms.Button ExitBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox holderTxt;
        private System.Windows.Forms.ListBox holderList;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}