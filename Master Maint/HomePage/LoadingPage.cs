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
    public partial class LoadingPage : Form
    {
        int move = 2; 
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;

            if (panelSlide.Left > 285)
            {
                panelSlide.Left = 0; 
            }
            if (panelSlide.Left < 0)
            {
                move = 2; 
            }
        }
    }
}
