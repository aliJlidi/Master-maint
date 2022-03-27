using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint.Inventory.Movement
{
    public partial class movementForm : Form
    {
        public movementForm()
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

        private void movementBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = movementBtn.Height;
            SidePanel.Top = movementBtn.Top;
            viewList.BringToFront();
        }

        private void editMovementBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = movementBtn.Height;
            SidePanel.Top = movementBtn.Top;
            editMovementControl1.BringToFront();
        }

        private void BackToInventbtn_Click(object sender, EventArgs e)
        {
            inventoryForm finventory = (inventoryForm)Application.OpenForms["inventoryForm"];
            finventory.Show();
            this.Close();
        }
    }
}
