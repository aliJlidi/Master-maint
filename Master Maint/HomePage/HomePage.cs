using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint
{
    public partial class Home : Form
    {
        
        
        public Home()
        {
             
            // while showing the slide initialize the home page 
            InitializeComponent();
            SidePanel.Height = HomeBtn.Height;
            homeControl1.BringToFront();
            StateLabel.Text = "L'entreprise n'est pas encore définie ! "; 
            // make the window resizable 
            


        }

        
     
       
      
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HelpBtn.Height;
            SidePanel.Top = HelpBtn.Top;
            helpControl1.BringToFront();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingBtn.Height;
            SidePanel.Top = SettingBtn.Top;
            settingControl1.BringToFront();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {

            Application.Exit();
           
        }
        private void MiniBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void NotifBtn_Click(object sender, EventArgs e)
        {
            //
        }
        private void LinkBtn_Click(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com/in/jelidi-ali-a66296151");
        }
        private void WebBtn_Click(object sender, EventArgs e)
        {
            Process.Start("www.isetjb.rnu.tn");
        }
        private void homeControl1_Load(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top; 
            homeControl1.BringToFront();
        }

        private void StatBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = StatBtn.Height;
            SidePanel.Top = StatBtn.Top; 
            statisticControl1.BringToFront();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LogoPicture_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LogoPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LogoPicture_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void homeControl1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void homeControl1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void homeControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            StateLabel.ForeColor = Color.FromArgb(A, R, G, B);
               
                
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
