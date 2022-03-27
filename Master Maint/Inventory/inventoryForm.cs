using Master_Maint.Inventory.Items;
using Master_Maint.Inventory.Movement;
using Master_Maint.Inventory.Reshippement;
using Master_Maint.Inventory.Shops;
using Master_Maint.Inventory.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint.Inventory
{
    public partial class inventoryForm : Form
    {
        public inventoryForm()
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

        private void BackToHomebtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
            this.Close();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            shopsForm fShops = new shopsForm();
            fShops.Show();
            inventoryForm inventoryMenu = (inventoryForm)Application.OpenForms["inventoryForm"];
            inventoryMenu.Hide();
        }

        private void itmBtn_Click(object sender, EventArgs e)
        {
            itemsForm fItems = new itemsForm();
            fItems.Show();
            inventoryForm inventoryMenu = (inventoryForm)Application.OpenForms["inventoryForm"];
            inventoryMenu.Hide();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            suppliersForm fSuppliers = new suppliersForm();
            fSuppliers.Show();
            inventoryForm inventoryMenu = (inventoryForm)Application.OpenForms["inventoryForm"];
            inventoryMenu.Hide();
        }

        private void reshipementBtn_Click(object sender, EventArgs e)
        {
            reshipementForm fReshipement = new reshipementForm();
            fReshipement.Show();
            inventoryForm inventoryMenu = (inventoryForm)Application.OpenForms["inventoryForm"];
            inventoryMenu.Hide();
        }

        private void recieveBtn_Click(object sender, EventArgs e)
        {
            movementForm fmovement = new movementForm();
            fmovement.Show();
            inventoryForm inventoryMenu = (inventoryForm)Application.OpenForms["inventoryForm"];
            inventoryMenu.Hide();
        }
    }
}
