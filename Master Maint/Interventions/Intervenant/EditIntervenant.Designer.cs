namespace Master_Maint
{
    partial class EditIntervenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIntervenant));
            this.StateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.intFirstNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.intLastNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.intAdresseTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.intNumberTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.intMailTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.intProvTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.addIntBtn = new System.Windows.Forms.Button();
            this.intervenantList = new System.Windows.Forms.ListBox();
            this.EditIntBtn = new System.Windows.Forms.Button();
            this.DeleteIntBtn = new System.Windows.Forms.Button();
            this.CalendarBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addSpecBtn = new System.Windows.Forms.Button();
            this.intSpecList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.StateLabel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StateLabel.Location = new System.Drawing.Point(25, 26);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(61, 24);
            this.StateLabel.TabIndex = 5;
            this.StateLabel.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label3.Location = new System.Drawing.Point(25, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Némuro Téle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label4.Location = new System.Drawing.Point(25, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label5.Location = new System.Drawing.Point(25, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "spécialité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label6.Location = new System.Drawing.Point(25, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "provenance professionnelle";
            // 
            // intFirstNameTxt
            // 
            this.intFirstNameTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.intFirstNameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intFirstNameTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.intFirstNameTxt.BorderThickness = 3;
            this.intFirstNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intFirstNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intFirstNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intFirstNameTxt.isPassword = false;
            this.intFirstNameTxt.Location = new System.Drawing.Point(175, 11);
            this.intFirstNameTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intFirstNameTxt.Name = "intFirstNameTxt";
            this.intFirstNameTxt.Size = new System.Drawing.Size(363, 39);
            this.intFirstNameTxt.TabIndex = 6;
            this.intFirstNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.intFirstNameTxt.OnValueChanged += new System.EventHandler(this.intFirstNameTxt_OnValueChanged);
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
            this.intLastNameTxt.Location = new System.Drawing.Point(175, 58);
            this.intLastNameTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intLastNameTxt.Name = "intLastNameTxt";
            this.intLastNameTxt.Size = new System.Drawing.Size(363, 39);
            this.intLastNameTxt.TabIndex = 6;
            this.intLastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.intLastNameTxt.OnValueChanged += new System.EventHandler(this.intLastNameTxt_OnValueChanged);
            // 
            // intAdresseTxt
            // 
            this.intAdresseTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.intAdresseTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intAdresseTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.intAdresseTxt.BorderThickness = 3;
            this.intAdresseTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intAdresseTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intAdresseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intAdresseTxt.isPassword = false;
            this.intAdresseTxt.Location = new System.Drawing.Point(175, 107);
            this.intAdresseTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intAdresseTxt.Name = "intAdresseTxt";
            this.intAdresseTxt.Size = new System.Drawing.Size(363, 39);
            this.intAdresseTxt.TabIndex = 6;
            this.intAdresseTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.intAdresseTxt.OnValueChanged += new System.EventHandler(this.intAdresseTxt_OnValueChanged);
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
            this.intNumberTxt.Location = new System.Drawing.Point(175, 156);
            this.intNumberTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intNumberTxt.Name = "intNumberTxt";
            this.intNumberTxt.Size = new System.Drawing.Size(363, 39);
            this.intNumberTxt.TabIndex = 6;
            this.intNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.intNumberTxt.OnValueChanged += new System.EventHandler(this.intNumberTxt_OnValueChanged);
            // 
            // intMailTxt
            // 
            this.intMailTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.intMailTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intMailTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.intMailTxt.BorderThickness = 3;
            this.intMailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intMailTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intMailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intMailTxt.isPassword = false;
            this.intMailTxt.Location = new System.Drawing.Point(175, 205);
            this.intMailTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intMailTxt.Name = "intMailTxt";
            this.intMailTxt.Size = new System.Drawing.Size(363, 39);
            this.intMailTxt.TabIndex = 6;
            this.intMailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.intMailTxt.OnValueChanged += new System.EventHandler(this.intMailTxt_OnValueChanged);
            // 
            // intProvTxt
            // 
            this.intProvTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.intProvTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intProvTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.intProvTxt.BorderThickness = 3;
            this.intProvTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intProvTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intProvTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intProvTxt.isPassword = false;
            this.intProvTxt.Location = new System.Drawing.Point(331, 299);
            this.intProvTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intProvTxt.Name = "intProvTxt";
            this.intProvTxt.Size = new System.Drawing.Size(207, 39);
            this.intProvTxt.TabIndex = 6;
            this.intProvTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addIntBtn
            // 
            this.addIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.addIntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIntBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIntBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.addIntBtn.Image = ((System.Drawing.Image)(resources.GetObject("addIntBtn.Image")));
            this.addIntBtn.Location = new System.Drawing.Point(125, 391);
            this.addIntBtn.Name = "addIntBtn";
            this.addIntBtn.Size = new System.Drawing.Size(74, 67);
            this.addIntBtn.TabIndex = 7;
            this.addIntBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addIntBtn.UseVisualStyleBackColor = false;
            this.addIntBtn.Click += new System.EventHandler(this.addIntBtn_Click);
            // 
            // intervenantList
            // 
            this.intervenantList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.intervenantList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intervenantList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervenantList.FormattingEnabled = true;
            this.intervenantList.ItemHeight = 17;
            this.intervenantList.Location = new System.Drawing.Point(587, 20);
            this.intervenantList.Name = "intervenantList";
            this.intervenantList.Size = new System.Drawing.Size(212, 325);
            this.intervenantList.TabIndex = 8;
            // 
            // EditIntBtn
            // 
            this.EditIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditIntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditIntBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditIntBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EditIntBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditIntBtn.Image")));
            this.EditIntBtn.Location = new System.Drawing.Point(220, 391);
            this.EditIntBtn.Name = "EditIntBtn";
            this.EditIntBtn.Size = new System.Drawing.Size(74, 67);
            this.EditIntBtn.TabIndex = 7;
            this.EditIntBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditIntBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteIntBtn
            // 
            this.DeleteIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteIntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteIntBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteIntBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DeleteIntBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteIntBtn.Image")));
            this.DeleteIntBtn.Location = new System.Drawing.Point(315, 391);
            this.DeleteIntBtn.Name = "DeleteIntBtn";
            this.DeleteIntBtn.Size = new System.Drawing.Size(74, 67);
            this.DeleteIntBtn.TabIndex = 7;
            this.DeleteIntBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteIntBtn.UseVisualStyleBackColor = false;
            this.DeleteIntBtn.Click += new System.EventHandler(this.DeleteIntBtn_Click);
            // 
            // CalendarBtn
            // 
            this.CalendarBtn.BackColor = System.Drawing.Color.Transparent;
            this.CalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CalendarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CalendarBtn.Image")));
            this.CalendarBtn.Location = new System.Drawing.Point(511, 391);
            this.CalendarBtn.Name = "CalendarBtn";
            this.CalendarBtn.Size = new System.Drawing.Size(74, 67);
            this.CalendarBtn.TabIndex = 7;
            this.CalendarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CalendarBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label7.Location = new System.Drawing.Point(591, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fixer une calendrier";
            // 
            // addSpecBtn
            // 
            this.addSpecBtn.BackColor = System.Drawing.Color.Transparent;
            this.addSpecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSpecBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSpecBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.addSpecBtn.Image = ((System.Drawing.Image)(resources.GetObject("addSpecBtn.Image")));
            this.addSpecBtn.Location = new System.Drawing.Point(380, 256);
            this.addSpecBtn.Name = "addSpecBtn";
            this.addSpecBtn.Size = new System.Drawing.Size(36, 34);
            this.addSpecBtn.TabIndex = 97;
            this.addSpecBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addSpecBtn.UseVisualStyleBackColor = false;
            this.addSpecBtn.Click += new System.EventHandler(this.addSpecBtn_Click);
            // 
            // intSpecList
            // 
            this.intSpecList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.intSpecList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intSpecList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intSpecList.FormattingEnabled = true;
            this.intSpecList.IntegralHeight = false;
            this.intSpecList.Location = new System.Drawing.Point(188, 260);
            this.intSpecList.Margin = new System.Windows.Forms.Padding(0);
            this.intSpecList.Name = "intSpecList";
            this.intSpecList.Size = new System.Drawing.Size(177, 30);
            this.intSpecList.TabIndex = 100;
            this.intSpecList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.intSpecList_MouseClick);
            // 
            // EditIntervenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intSpecList);
            this.Controls.Add(this.addSpecBtn);
            this.Controls.Add(this.intervenantList);
            this.Controls.Add(this.CalendarBtn);
            this.Controls.Add(this.DeleteIntBtn);
            this.Controls.Add(this.EditIntBtn);
            this.Controls.Add(this.addIntBtn);
            this.Controls.Add(this.intProvTxt);
            this.Controls.Add(this.intMailTxt);
            this.Controls.Add(this.intNumberTxt);
            this.Controls.Add(this.intAdresseTxt);
            this.Controls.Add(this.intLastNameTxt);
            this.Controls.Add(this.intFirstNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StateLabel);
            this.Name = "EditIntervenant";
            this.Size = new System.Drawing.Size(824, 473);
            this.Load += new System.EventHandler(this.EditIntervenant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox intFirstNameTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox intLastNameTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox intAdresseTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox intNumberTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox intMailTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox intProvTxt;
        private System.Windows.Forms.Button addIntBtn;
        private System.Windows.Forms.ListBox intervenantList;
        private System.Windows.Forms.Button EditIntBtn;
        private System.Windows.Forms.Button DeleteIntBtn;
        private System.Windows.Forms.Button CalendarBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addSpecBtn;
        private System.Windows.Forms.ComboBox intSpecList;

    }
}
