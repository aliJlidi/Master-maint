using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint.Inventory.Suppliers
{
    public partial class suppliersForm : Form
    {
        public suppliersForm()
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

        private void suppBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = suppBtn.Height;
            SidePanel.Top = suppBtn.Top;
            viewList.BringToFront();
        }

        private void editSuppBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = editSuppBtn.Height;
            SidePanel.Top = editSuppBtn.Top;
            editSupplierControl1.BringToFront();
        }

        private void BackToInventbtn_Click(object sender, EventArgs e)
        {
            inventoryForm finventory = (inventoryForm)Application.OpenForms["inventoryForm"];
            finventory.Show();
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
