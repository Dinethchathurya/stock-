using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Data.SqlClient;
using computing_group_project;

namespace computing_group_project
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
           
             
        string username = textBox1.Text;
         string pass = textBox2.Text;
            if (username == "" || pass == "")
            {
                MessageBox.Show("Enter username and password");
            }
            else
            {
                try 
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus\Desktop\puli managemant\minuchairs.mdf"";Integrated Security=True;Connect Timeout=30");

                    int i = 0;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select *  From registration where User_Name = @username   and Password=  @password ", con);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", pass);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    if (i == 0)
                    {
                        MessageBox.Show("This user name and password does not match");
                    }
                    else
                    {
                        if (username == "dasith" && pass == "d123")
                        {
                            Cashier chsh = new Cashier();
                            chsh.Show();
                        }

                        else if (username == "admin" && pass == "admin123")
                        {
                            admin admin = new admin();
                            admin.Show();
                        }

                        this.Hide();
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                
                }
                
               

            }

        }

       
    }
}
