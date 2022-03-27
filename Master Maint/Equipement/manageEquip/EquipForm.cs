using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint.Equipement.manageEquip
{
    public partial class EquipForm : Form
    {
        public EquipForm()
        {
            InitializeComponent();
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

        private void equipListBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = equipListBtn.Height;
            SidePanel.Top = equipListBtn.Top;
            viewList.BringToFront();
        }

        private void editEquipBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = editEquipBtn.Height;
            SidePanel.Top = editEquipBtn.Top;
            editEquipControl1.BringToFront();
        }

        private void BackToHomebtn_Click(object sender, EventArgs e)
        {
            EquipementForm equipementForm = (EquipementForm)Application.OpenForms["EquipementForm"];
            equipementForm.Show();
            this.Close();
        }

        private void viewList_Load(object sender, EventArgs e)
        {

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
