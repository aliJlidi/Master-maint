using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master_Maint.Equipement.manageEquip;
using Master_Maint.Equipement.Departement;
using Master_Maint.Equipement.treeOfEquip;

namespace Master_Maint.Equipement
{
    public partial class EquipementForm : Form
    {

        public EquipementForm()
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

        private void BackToHomebtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
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

        private void equipementSetBtn_Click(object sender, EventArgs e)
        {
            EquipForm fequipement = new EquipForm();
            fequipement.Show();
            EquipementForm equipementMenu = (EquipementForm)Application.OpenForms["EquipementForm"];
            equipementMenu.Hide();
        }

        private void departBtn_Click(object sender, EventArgs e)
        {
            departementForm fDepartement = new departementForm();
            fDepartement.Show();
            EquipementForm equipementMenu = (EquipementForm)Application.OpenForms["EquipementForm"];
            equipementMenu.Hide();
        }

        private void treeBtn_Click(object sender, EventArgs e)
        {
            equipTreeForm fEquipTreeForm = new equipTreeForm();
            fEquipTreeForm.Show();
            EquipementForm equipementMenu = (EquipementForm)Application.OpenForms["EquipementForm"];
            equipementMenu.Hide();
        }
    }
}
