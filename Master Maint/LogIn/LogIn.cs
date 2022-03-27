using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Master_Maint
{
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand(); 
        //check logIn
       public  static bool LogedIn = false; 
        public LogIn()
        {
             //Hide 
  
            // create new thread instance to start the loader page
            Thread trd = new Thread(new ThreadStart(formRun));
            // start the thread 
            trd.Start();
            // take some time to show the sliding
            Thread.Sleep(3500);
            InitializeComponent();
            // stop thread 
            trd.Abort();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        }

        private void formRun()
        {
            Application.Run(new LoadingPage());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

      

        private void PassTxtEnter(object sender, EventArgs e)
        {
            if (PassTxt.Text.Equals(@"Mot de passe"))
            {
                PassTxt.Text = "";
            }
        }
        

        private void PassTxtOut(object sender, EventArgs e)
        {
            if (PassTxt.Text.Equals(""))
            {
                PassTxt.Text = @"Mot de passe";
            }
        }
        private void UserTxtEnter(object sender, EventArgs e)
        {
            if (UserTxt.Text.Equals(@"Utilisateur"))
            {
                UserTxt.Text = "";
            }
        }

        private void UserTxtOut(object sender, EventArgs e)
        {
            if (UserTxt.Text.Equals(""))
            {
                UserTxt.Text = @"Utilisateur";
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Authorisation";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (PassTxt.Text.Equals(dr["Utilisateur"].ToString()) && UserTxt.Text.Equals(dr["MotDePasse"].ToString()))
                {
                    LogedIn = true;
                    con.Close();
                    this.Close();
                    
                }
                else
                {
                    CustomizedErrorMessage.Show("Mot de passe incorrect\n Réessayer !", "MSG", "OK !");
                   
                }
            }
            con.Close();
           
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            CustomizedErrorMessage.Show("si c'est votre première fois,\n utilisez le nom d'utilisateur et le mot de passe par défaut \n admin \n admin", "MSG", "OK !");
        }

  

        private bool mouseDown;
        private Point lastLocation;
        private void LogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LogIn_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
            
        

    
    }
}
