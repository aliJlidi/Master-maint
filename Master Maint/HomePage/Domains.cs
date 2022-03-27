using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint
{
    public partial class Domains : Form
    {
       public static SqlCommand com = new SqlCommand(); 
        // Step 1 : connectig to the dataBase
     public static   SqlConnection con = new SqlConnection();
        static public bool isHotel = false ;
        string Hotel = "Hotel";
        public Domains()
        {
            InitializeComponent();
            DomainLabel.Text = "Choisissez le type de votre organisation ! ";
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
           
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

        private void StateLabel_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            DomainLabel.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void FactoryBtn_Click(object sender, EventArgs e)
        {

        }

        public void HotelBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Domain";
            SqlDataReader dr = com.ExecuteReader();
            
                    if (dr.HasRows)
                    {
                        con.Close();
                        SqlCommand cmd = new SqlCommand("UPDATE Domain SET Name=@Name ", con);
                        cmd.Parameters.AddWithValue("@Name", Hotel);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.Close();
                      SqlCommand cmd = new SqlCommand("INSERT INTO Domain (Name) VALUES (@Name) ", con);
                        cmd.Parameters.AddWithValue("@Name", Hotel);
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            CustomizedErrorMessage.Show("Choix Validée .", "MSG", "OK !");
                        }
                        else
                        {
                            CustomizedErrorMessage.Show("Erreur ! verfier le source des données .", "MSG", "OK !");
                        }
                         
                    }
                con.Close();
                isHotel = true;
                this.Close();
            }
            
         
        }
    }

