namespace Master_Maint
{
    partial class CustomizedErrorMessage
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
            this.wrongbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Caption = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrongbtn
            // 
            this.wrongbtn.FlatAppearance.BorderSize = 0;
            this.wrongbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrongbtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.wrongbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wrongbtn.Location = new System.Drawing.Point(244, 203);
            this.wrongbtn.Name = "wrongbtn";
            this.wrongbtn.Size = new System.Drawing.Size(167, 46);
            this.wrongbtn.TabIndex = 4;
            this.wrongbtn.Text = "Ok";
            this.wrongbtn.UseVisualStyleBackColor = true;
            this.wrongbtn.Click += new System.EventHandler(this.wrongbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.Caption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 41);
            this.panel1.TabIndex = 7;
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Caption.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caption.ForeColor = System.Drawing.Color.White;
            this.Caption.Location = new System.Drawing.Point(3, 10);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(76, 20);
            this.Caption.TabIndex = 8;
            this.Caption.Text = "Message";
            this.Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Caption.Click += new System.EventHandler(this.errorMsg_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorMsg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.White;
            this.errorMsg.Location = new System.Drawing.Point(28, 78);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(76, 20);
            this.errorMsg.TabIndex = 8;
            this.errorMsg.Text = "Message";
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorMsg.Click += new System.EventHandler(this.errorMsg_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(1, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 218);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(435, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 218);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(2, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 1);
            this.panel4.TabIndex = 11;
            // 
            // CustomizedErrorMessage
            // 
            this.AcceptButton = this.wrongbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wrongbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomizedErrorMessage";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomizedErrorMessage";
            this.Load += new System.EventHandler(this.CustomizedErrorMessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wrongbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Caption;
    }
}