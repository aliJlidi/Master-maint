using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint
{
    public partial class IntervenantForm : Form
    {
        public IntervenantForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InterventionLabel_Click(object sender, EventArgs e)
        {

        }

       
        private void intListBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = intListBtn.Height;
            SidePanel.Top = intListBtn.Top;
            viewIntervenantList1.BringToFront();
        }

        private void editIntBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = editIntBtn.Height;
            SidePanel.Top = editIntBtn.Top;
            editIntervenant1.BringToFront();
        }

        private void editIntervenant1_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Home fintervention = (Home)Application.OpenForms["Home"];
            fintervention.Show();
            this.Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
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
