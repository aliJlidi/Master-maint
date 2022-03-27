using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint.Interventions.WorkReports
{
    public partial class workReportsForm : Form
    {
        public workReportsForm()
        {
            InitializeComponent();
        }

        private void repportsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = repportsBtn.Height;
            SidePanel.Top = repportsBtn.Top;
            viewList.BringToFront();
        }

        private void editReportsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = editReportsBtn.Height;
            SidePanel.Top = editReportsBtn.Top;
            editRepportsControl1.BringToFront();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
            this.Close();
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
