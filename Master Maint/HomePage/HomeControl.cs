using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master_Maint.Equipement;
using Master_Maint.Inventory;

namespace Master_Maint
{
    public partial class HomeControl : UserControl
    {
       
        public HomeControl()
        {
            InitializeComponent();
        }

        private void EquipementBtn_Click(object sender, EventArgs e)
        {
            EquipementForm equipement = new EquipementForm();
            equipement.Show();
            Home home = (Home)Application.OpenForms["Home"];
            home.Hide();

            
        }

        private void interventionBtn_Click(object sender, EventArgs e)
        {
            InterventionsForm intervention = new InterventionsForm();
            intervention.Show();
            Home home = (Home)Application.OpenForms["Home"];
            home.Hide();

        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            inventoryForm inventory = new inventoryForm();
            inventory.Show();
            Home home = (Home)Application.OpenForms["Home"];
            home.Hide();
        }
    }
}
