using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMAOLibrary.Models;
using GMAOLibrary;
using GMAOLibrary.DataAccess;
using Master_Maint.costumizedFormForAdding;


namespace Master_Maint
{
    public partial class EditIntervenant : UserControl
    {
        List<Intervenants> intListBox = new List<Intervenants>();
        List<mSpecialite> intSpecListBox = new List<mSpecialite>(); 
        public static string type = "";
        public EditIntervenant()
        {
            InitializeComponent();
            WireUpLists();
        }
         public void WireUpLists()
        {
            intervenantList.DataSource = null;
            this.intervenantList.DataSource = GlobalConfig.Connections.intervenant_GetAll();
            this.intervenantList.DisplayMember = "fullName";
            intSpecList.DataSource = null;
            intSpecList.DataSource = GlobalConfig.Connections.getspec_All();
            intSpecList.DisplayMember = "SpName";

        }

        private void addIntBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                Intervenants intervenant = new Intervenants(intFirstNameTxt.Text, intLastNameTxt.Text, intAdresseTxt.Text,
                   intMailTxt.Text, intNumberTxt.Text, intSpecList.GetItemText(this.intSpecList.SelectedValue), intProvTxt.Text);

                // save the intervenant 

                GlobalConfig.Connections.CreateIntervenant(intervenant);
                
                intFirstNameTxt.Text ="";
                intLastNameTxt.Text ="";
                intAdresseTxt.Text ="";
                intMailTxt.Text ="";
                intNumberTxt.Text ="";
                intProvTxt.Text = "";
                WireUpLists();
                CustomizedErrorMessage.Show("intervenant créé", "Intervenant", "OK !");
            }
            else
            {
                CustomizedErrorMessage.Show("Certains champs ne sont pas valides ! \n vérifiez à nouveau", "Erreur", "OK !");
            }
        }
        private bool validateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(intNumberTxt.Text, out placeNumber);
            if (placeNumberValidNumber == false)
            {
                output = false; 
            }
            if (intFirstNameTxt.Text.Length == 0 || intLastNameTxt.Text.Length == 0 || intSpecList.SelectedValue.ToString().Length == 0
                || intAdresseTxt.Text.Length ==0 || intMailTxt.Text.Length == 0 || intProvTxt.Text.Length == 0 )
            {
                output = false; 
            }


            return output ; 
        }

        private void intFirstNameTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (intFirstNameTxt.Text.Length >= 2)
            {
                intFirstNameTxt.BorderColorIdle = Color.Green; 
            }
            else
            {
                intFirstNameTxt.BorderColorIdle = Color.Gray;
            }
        }

        private void intLastNameTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (intLastNameTxt.Text.Length >= 2)
            {
                intLastNameTxt.BorderColorIdle = Color.Green;
            }
            else
            {
                intLastNameTxt.BorderColorIdle = Color.Gray;
            }
        }

        private void intAdresseTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (intAdresseTxt.Text.Length >= 10)
            {
                intAdresseTxt.BorderColorIdle = Color.Green;
            }
            else
            {
                intAdresseTxt.BorderColorIdle = Color.Gray;
            }
        }

        private void intNumberTxt_OnValueChanged(object sender, EventArgs e)
        {
             int placeNumber = 0;
             if (int.TryParse(intNumberTxt.Text, out placeNumber) && intNumberTxt.Text.Length >= 6 )
             {
                 intNumberTxt.BorderColorIdle = Color.Green; 
             }
             else
             {
                 intNumberTxt.BorderColorIdle = Color.Gray; 
             }
        }

        private void EditIntervenant_Load(object sender, EventArgs e)
        {
         
        }

        private void intMailTxt_OnValueChanged(object sender, EventArgs e)
        {
            try { 
            var addr = new System.Net.Mail.MailAddress(intMailTxt.Text);
            if (addr.Address == intMailTxt.Text)
               {
                intMailTxt.BorderColorIdle = Color.Green; 
               }
            }
           catch
            {
                intMailTxt.BorderColorIdle = Color.Gray;
            }
        }

        private void addSpecBtn_Click(object sender, EventArgs e)
        {
            costumizedFormAddDel specForm = new costumizedFormAddDel("Modifier Les specialities","Specialité");
            type = "spec"; 
            specForm.Show();
        }

        private void intSpecList_MouseClick(object sender, MouseEventArgs e)
        {
            WireUpLists();
        }

        private void DeleteIntBtn_Click(object sender, EventArgs e)
        {
            if (intervenantList.SelectedValue != null)
            {
                string intervenantString = intervenantList.GetItemText(this.intervenantList.SelectedItem);
                ConfirmationForm.Show("Confirmation", "êtes-vous sûr de supprimer l'intervenant :\n" + intervenantString);
              
              
            }
            else
            {
                CustomizedErrorMessage.Show("Erreur", "vous devez d'abord sélectionner quelle entité a supprimer", "Ok !");
            }

            /*Intervenants intervenant = (Intervenants)intervenantList.SelectedItem;
            // save the intervenant 
            GlobalConfig.Connections.DeleteIntervenant(intervenant);
            WireUpLists(); */
        }

        public void deleteIntervenant()
        {
            
                Intervenants intervenant = (Intervenants)intervenantList.SelectedItem;
                // save the intervenant 
                GlobalConfig.Connections.DeleteIntervenant(intervenant);
            
        }
    }
}
