using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint.Interventions.Planning
{
    public partial class PlanningForm : Form
    {
        public PlanningForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
            this.Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void planningBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = planningBtn.Height;
            SidePanel.Top = planningBtn.Top;
            viewList.BringToFront();
            
        }

        private void editPlanningBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = editPlanningBtn.Height;
            SidePanel.Top = editPlanningBtn.Top;
            editPlanningControl1.BringToFront(); 
        }

        private void BackToIntbtn_Click(object sender, EventArgs e)
        {
            InterventionsForm fintervention = (InterventionsForm)Application.OpenForms["InterventionsForm"];
            fintervention.Show();
            this.Close();
        }

        private bool mouseDown;
        private Point lastLocation;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
