using Master_Maint.Interventions.History;
using Master_Maint.Interventions.Planning;
using Master_Maint.Interventions.SubContructor;
using Master_Maint.Interventions.WorkOrder;
using Master_Maint.Interventions.WorkReports;
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
    public partial class InterventionsForm : Form
    {
        public InterventionsForm()
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

    
        private bool mouseDown;
        private Point lastLocation;
        private void interventionPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void interventionPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void interventionPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BackToHomebtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
            this.Close();
        }

        private void IntervenantBtn_Click(object sender, EventArgs e)
        {
            IntervenantForm fIntervenant = new IntervenantForm();
            fIntervenant.Show();
            InterventionsForm interventionMenu = (InterventionsForm)Application.OpenForms["InterventionsForm"];
            interventionMenu.Hide();
        }

        private void askForIntBtn_Click(object sender, EventArgs e)
        {
            workDemandForm fWorkDemand = new workDemandForm();
            fWorkDemand.Show();
            InterventionsForm interventionMenu = (InterventionsForm)Application.OpenForms["InterventionsForm"];
            interventionMenu.Hide();
        }

        private void OrderWorkBtn_Click(object sender, EventArgs e)
        {
            workOrderForm fWorkOrder = new workOrderForm();
            fWorkOrder.Show();
            InterventionsForm interventionMenu = (InterventionsForm)Application.OpenForms["InterventionsForm"];
            interventionMenu.Hide();
        }

        private void RepportIntBtn_Click(object sender, EventArgs e)
        {
            workReportsForm fWorkRepports = new workReportsForm();
            fWorkRepports.Show();
            InterventionsForm interventionMenu = (InterventionsForm)Application.OpenForms["InterventionsForm"];
            interventionMenu.Hide();
        }

     
        private void PlanningBtn_Click_1(object sender, EventArgs e)
        {
            PlanningForm fWorkPlan = new PlanningForm();
            fWorkPlan.Show();
            InterventionsForm interventionMenu = (InterventionsForm)Application.OpenForms["InterventionsForm"];
            interventionMenu.Hide();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            HistoryForm fWorkHistory = new HistoryForm();
            fWorkHistory.Show();
            InterventionsForm interventionMenu = (InterventionsForm)Application.OpenForms["InterventionsForm"];
            interventionMenu.Hide();
        }

        private void SubContractorBtn_Click(object sender, EventArgs e)
        {
            subContructorForm fWorkSubContract = new subContructorForm();
            fWorkSubContract.Show();
            InterventionsForm interventionMenu = (InterventionsForm)Application.OpenForms["InterventionsForm"];
            interventionMenu.Hide();
        }
    }
}
