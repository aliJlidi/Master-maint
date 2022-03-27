namespace Master_Maint.Interventions.WorkDemand
{
    partial class EditWorkDemandControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWorkDemandControl));
            this.workDemandList = new System.Windows.Forms.ListBox();
            this.DeleteIntBtn = new System.Windows.Forms.Button();
            this.EditIntBtn = new System.Windows.Forms.Button();
            this.addIntBtn = new System.Windows.Forms.Button();
            this.intNumberTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.intLastNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.descLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.senderLbl = new System.Windows.Forms.Label();
            this.eqNomLbl = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // workDemandList
            // 
            this.workDemandList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.workDemandList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workDemandList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workDemandList.FormattingEnabled = true;
            this.workDemandList.ItemHeight = 17;
            this.workDemandList.Location = new System.Drawing.Point(465, 22);
            this.workDemandList.Name = "workDemandList";
            this.workDemandList.Size = new System.Drawing.Size(334, 325);
            this.workDemandList.TabIndex = 28;
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
            this.DeleteIntBtn.TabIndex = 26;
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
            this.EditIntBtn.TabIndex = 25;
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
            this.addIntBtn.TabIndex = 24;
            this.addIntBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addIntBtn.UseVisualStyleBackColor = false;
            // 
            // intNumberTxt
            // 
            this.intNumberTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.intNumberTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intNumberTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.intNumberTxt.BorderThickness = 3;
            this.intNumberTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intNumberTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intNumberTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intNumberTxt.isPassword = false;
            this.intNumberTxt.Location = new System.Drawing.Point(185, 159);
            this.intNumberTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intNumberTxt.Name = "intNumberTxt";
            this.intNumberTxt.Size = new System.Drawing.Size(232, 39);
            this.intNumberTxt.TabIndex = 23;
            this.intNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // intLastNameTxt
            // 
            this.intLastNameTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.intLastNameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intLastNameTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.intLastNameTxt.BorderThickness = 3;
            this.intLastNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intLastNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intLastNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intLastNameTxt.isPassword = false;
            this.intLastNameTxt.Location = new System.Drawing.Point(185, 61);
            this.intLastNameTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intLastNameTxt.Name = "intLastNameTxt";
            this.intLastNameTxt.Size = new System.Drawing.Size(232, 39);
            this.intLastNameTxt.TabIndex = 18;
            this.intLastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.descLbl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.descLbl.Location = new System.Drawing.Point(13, 172);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(122, 24);
            this.descLbl.TabIndex = 12;
            this.descLbl.Text = "Description";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.DateLbl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DateLbl.Location = new System.Drawing.Point(13, 124);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(155, 24);
            this.DateLbl.TabIndex = 11;
            this.DateLbl.Text = "Date Souhaité";
            // 
            // senderLbl
            // 
            this.senderLbl.AutoSize = true;
            this.senderLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.senderLbl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.senderLbl.Location = new System.Drawing.Point(13, 76);
            this.senderLbl.Name = "senderLbl";
            this.senderLbl.Size = new System.Drawing.Size(103, 24);
            this.senderLbl.TabIndex = 10;
            this.senderLbl.Text = "Emetteur";
            // 
            // eqNomLbl
            // 
            this.eqNomLbl.AutoSize = true;
            this.eqNomLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqNomLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.eqNomLbl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.eqNomLbl.Location = new System.Drawing.Point(13, 28);
            this.eqNomLbl.Name = "eqNomLbl";
            this.eqNomLbl.Size = new System.Drawing.Size(134, 24);
            this.eqNomLbl.TabIndex = 9;
            this.eqNomLbl.Text = "Equipement";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(185, 18);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(232, 35);
            this.bunifuDropdown1.TabIndex = 29;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(185, 115);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(232, 36);
            this.bunifuDatepicker1.TabIndex = 30;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 5, 2, 5, 5, 1, 463);
            // 
            // EditWorkDemandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.workDemandList);
            this.Controls.Add(this.DeleteIntBtn);
            this.Controls.Add(this.EditIntBtn);
            this.Controls.Add(this.addIntBtn);
            this.Controls.Add(this.intNumberTxt);
            this.Controls.Add(this.intLastNameTxt);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.senderLbl);
            this.Controls.Add(this.eqNomLbl);
            this.Name = "EditWorkDemandControl";
            this.Size = new System.Drawing.Size(824, 473);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workDemandList;
        private System.Windows.Forms.Button DeleteIntBtn;
        private System.Windows.Forms.Button EditIntBtn;
        private System.Windows.Forms.Button addIntBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox intNumberTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox intLastNameTxt;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label senderLbl;
        private System.Windows.Forms.Label eqNomLbl;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
    }
}
