namespace Master_Maint
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.StatBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StateLabel = new System.Windows.Forms.Label();
            this.WebBtn = new System.Windows.Forms.Button();
            this.LinkBtn = new System.Windows.Forms.Button();
            this.NotifBtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.homeControl1 = new Master_Maint.HomeControl();
            this.statisticControl1 = new Master_Maint.StatisticControl();
            this.helpControl1 = new Master_Maint.HelpControl();
            this.settingControl1 = new Master_Maint.SettingControl();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.ControlPanel.Controls.Add(this.SidePanel);
            this.ControlPanel.Controls.Add(this.LogoPicture);
            this.ControlPanel.Controls.Add(this.HelpBtn);
            this.ControlPanel.Controls.Add(this.SettingBtn);
            this.ControlPanel.Controls.Add(this.StatBtn);
            this.ControlPanel.Controls.Add(this.HomeBtn);
            resources.ApplyResources(this.ControlPanel, "ControlPanel");
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            resources.ApplyResources(this.SidePanel, "SidePanel");
            this.SidePanel.Name = "SidePanel";
            // 
            // LogoPicture
            // 
            resources.ApplyResources(this.LogoPicture, "LogoPicture");
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.TabStop = false;
            this.LogoPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPicture_MouseDown);
            this.LogoPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoPicture_MouseMove);
            this.LogoPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogoPicture_MouseUp);
            // 
            // HelpBtn
            // 
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.HelpBtn, "HelpBtn");
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.SettingBtn, "SettingBtn");
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // StatBtn
            // 
            this.StatBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.StatBtn, "StatBtn");
            this.StatBtn.ForeColor = System.Drawing.Color.White;
            this.StatBtn.Name = "StatBtn";
            this.StatBtn.UseVisualStyleBackColor = true;
            this.StatBtn.Click += new System.EventHandler(this.StatBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.HomeBtn, "HomeBtn");
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.StateLabel);
            this.panel2.Controls.Add(this.WebBtn);
            this.panel2.Controls.Add(this.LinkBtn);
            this.panel2.Controls.Add(this.NotifBtn);
            this.panel2.Controls.Add(this.MiniBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // StateLabel
            // 
            resources.ApplyResources(this.StateLabel, "StateLabel");
            this.StateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.StateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(158)))), ((int)(((byte)(216)))));
            this.StateLabel.Name = "StateLabel";
            // 
            // WebBtn
            // 
            this.WebBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.WebBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.WebBtn, "WebBtn");
            this.WebBtn.ForeColor = System.Drawing.Color.White;
            this.WebBtn.Name = "WebBtn";
            this.WebBtn.UseVisualStyleBackColor = true;
            this.WebBtn.Click += new System.EventHandler(this.WebBtn_Click);
            // 
            // LinkBtn
            // 
            this.LinkBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.LinkBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.LinkBtn, "LinkBtn");
            this.LinkBtn.ForeColor = System.Drawing.Color.White;
            this.LinkBtn.Name = "LinkBtn";
            this.LinkBtn.UseVisualStyleBackColor = true;
            this.LinkBtn.Click += new System.EventHandler(this.LinkBtn_Click);
            // 
            // NotifBtn
            // 
            this.NotifBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.NotifBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.NotifBtn, "NotifBtn");
            this.NotifBtn.ForeColor = System.Drawing.Color.White;
            this.NotifBtn.Name = "NotifBtn";
            this.NotifBtn.UseVisualStyleBackColor = true;
            this.NotifBtn.Click += new System.EventHandler(this.NotifBtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.MiniBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.MiniBtn, "MiniBtn");
            this.MiniBtn.ForeColor = System.Drawing.Color.White;
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.UseVisualStyleBackColor = true;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // homeControl1
            // 
            resources.ApplyResources(this.homeControl1, "homeControl1");
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Load += new System.EventHandler(this.homeControl1_Load);
            this.homeControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homeControl1_MouseDown);
            this.homeControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.homeControl1_MouseMove);
            this.homeControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.homeControl1_MouseUp);
            // 
            // statisticControl1
            // 
            resources.ApplyResources(this.statisticControl1, "statisticControl1");
            this.statisticControl1.Name = "statisticControl1";
            // 
            // helpControl1
            // 
            this.helpControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            resources.ApplyResources(this.helpControl1, "helpControl1");
            this.helpControl1.Name = "helpControl1";
            // 
            // settingControl1
            // 
            resources.ApplyResources(this.settingControl1, "settingControl1");
            this.settingControl1.Name = "settingControl1";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.statisticControl1);
            this.Controls.Add(this.helpControl1);
            this.Controls.Add(this.settingControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Home_MouseUp);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button StatBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel SidePanel;
        private HomeControl homeControl1;
        private StatisticControl statisticControl1;
        private SettingControl settingControl1;
        private HelpControl helpControl1;
        private System.Windows.Forms.Button NotifBtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button WebBtn;
        private System.Windows.Forms.Button LinkBtn;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

