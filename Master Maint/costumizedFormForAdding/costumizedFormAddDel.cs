using GMAOLibrary;
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
    public partial class costumizedFormAddDel : Form
    {
        private List<mSpecialite> specList = new List<mSpecialite>();  
        
        public costumizedFormAddDel(string caption , string label )
        {
            InitializeComponent();
            this.captionLbl.Text = caption; 
            this.holderLbl.Text = label;
            wireUpList();
        }
        public void wireUpList()
        {
            holderList.DataSource = GlobalConfig.Connections.getspec_All();
            holderList.DisplayMember = "SpName"; 
        }




        private void ExitBtn_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (EditIntervenant.type == "spec")
            {

                mSpecialite specialite= new mSpecialite(holderTxt.Text);

                // save the intervenant 

                GlobalConfig.Connections.CreateSpecialite(specialite);

                holderTxt.Text = "";
                wireUpList();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (EditIntervenant.type == "spec")
            {

                mSpecialite specialite = (mSpecialite)holderList.SelectedItem;

                // save the intervenant 
                GlobalConfig.Connections.DeleteSpecialite(specialite);

                wireUpList();
            }
        }
    }
}
