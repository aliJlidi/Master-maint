using GMAOLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint.costumizedFormForAdding
{
    public partial class ConfirmationForm : Form
    {
      
        public ConfirmationForm()
        {
            InitializeComponent();
           
        }
        static ConfirmationForm conForm ; 
        public static void Show(string caption, string label)
        {
            conForm = new ConfirmationForm(); 
            conForm.captionLbl.Text = caption;
            conForm.holderLbl.Text = label;
            conForm.Show();
        }

        private void validBtn_Click(object sender, EventArgs e)
        {
            EditIntervenant UeditInt = new EditIntervenant();
            UeditInt.deleteIntervenant();
            UeditInt.WireUpLists();
            this.Close(); 
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
