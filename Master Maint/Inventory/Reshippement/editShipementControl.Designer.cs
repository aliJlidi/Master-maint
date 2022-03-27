namespace Master_Maint.Inventory.Reshippement
{
    partial class editShipementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editShipementControl));
            this.suppList = new System.Windows.Forms.ListBox();
            this.DeleteIntBtn = new System.Windows.Forms.Button();
            this.EditIntBtn = new System.Windows.Forms.Button();
            this.addIntBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.bunifuDropdown3 = new Bunifu.Framework.UI.BunifuDropdown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // suppList
            // 
            this.suppList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.suppList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suppList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppList.FormattingEnabled = true;
            this.suppList.ItemHeight = 17;
            this.suppList.Location = new System.Drawing.Point(537, 34);
            this.suppList.Name = "suppList";
            this.suppList.Size = new System.Drawing.Size(264, 325);
            this.suppList.TabIndex = 44;
            // 
            // DeleteIntBtn
            // 
            this.DeleteIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteIntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteIntBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteIntBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DeleteIntBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteIntBtn.Image")));
            this.DeleteIntBtn.Location = new System.Drawing.Point(315, 393);
            this.DeleteIntBtn.Name = "DeleteIntBtn";
            this.DeleteIntBtn.Size = new System.Drawing.Size(74, 67);
            this.DeleteIntBtn.TabIndex = 43;
            this.DeleteIntBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteIntBtn.UseVisualStyleBackColor = false;
            // 
            // EditIntBtn
            // 
            this.EditIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditIntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditIntBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditIntBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EditIntBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditIntBtn.Image")));
            this.EditIntBtn.Location = new System.Drawing.Point(220, 393);
            this.EditIntBtn.Name = "EditIntBtn";
            this.EditIntBtn.Size = new System.Drawing.Size(74, 67);
            this.EditIntBtn.TabIndex = 42;
            this.EditIntBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditIntBtn.UseVisualStyleBackColor = false;
            // 
            // addIntBtn
            // 
            this.addIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.addIntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIntBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIntBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.addIntBtn.Image = ((System.Drawing.Image)(resources.GetObject("addIntBtn.Image")));
            this.addIntBtn.Location = new System.Drawing.Point(125, 393);
            this.addIntBtn.Name = "addIntBtn";
            this.addIntBtn.Size = new System.Drawing.Size(74, 67);
            this.addIntBtn.TabIndex = 41;
            this.addIntBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addIntBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date Execution";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.StateLabel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StateLabel.Location = new System.Drawing.Point(25, 45);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(118, 24);
            this.StateLabel.TabIndex = 29;
            this.StateLabel.Text = "Fournisseur";
            // 
            // bunifuDropdown3
            // 
            this.bunifuDropdown3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown3.BorderRadius = 3;
            this.bunifuDropdown3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown3.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown3.Items = new string[0];
            this.bunifuDropdown3.Location = new System.Drawing.Point(252, 34);
            this.bunifuDropdown3.Name = "bunifuDropdown3";
            this.bunifuDropdown3.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.bunifuDropdown3.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.bunifuDropdown3.selectedIndex = -1;
            this.bunifuDropdown3.Size = new System.Drawing.Size(250, 35);
            this.bunifuDropdown3.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(333, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 47);
            this.button1.TabIndex = 82;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 81;
            this.label2.Text = "Les Articles";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(252, 162);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(250, 36);
            this.bunifuDatepicker1.TabIndex = 83;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 5, 4, 2, 3, 49, 303);
            // 
            // editShipementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuDropdown3);
            this.Controls.Add(this.suppList);
            this.Controls.Add(this.DeleteIntBtn);
            this.Controls.Add(this.EditIntBtn);
            this.Controls.Add(this.addIntBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StateLabel);
            this.Name = "editShipementControl";
            this.Size = new System.Drawing.Size(824, 473);
            this.Load += new System.EventHandler(this.editShipementControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox suppList;
        private System.Windows.Forms.Button DeleteIntBtn;
        private System.Windows.Forms.Button EditIntBtn;
        private System.Windows.Forms.Button addIntBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StateLabel;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
    }
}
