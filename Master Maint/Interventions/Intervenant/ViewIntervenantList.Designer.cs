namespace Master_Maint
{
    partial class ViewIntervenantList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.intDataList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.intDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // intDataList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.intDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.intDataList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.intDataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intDataList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.intDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.intDataList.DoubleBuffered = true;
            this.intDataList.EnableHeadersVisualStyles = false;
            this.intDataList.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.intDataList.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.intDataList.Location = new System.Drawing.Point(13, 25);
            this.intDataList.Name = "intDataList";
            this.intDataList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.intDataList.Size = new System.Drawing.Size(794, 430);
            this.intDataList.TabIndex = 0;
            // 
            // ViewIntervenantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intDataList);
            this.Name = "ViewIntervenantList";
            this.Size = new System.Drawing.Size(824, 473);
            ((System.ComponentModel.ISupportInitialize)(this.intDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid intDataList;
    }
}
