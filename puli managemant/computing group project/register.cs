using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using computing_group_project;

namespace computing_group_project
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { /*
        
       
            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asus\\Desktop\\WindowsFormsApp13\\WindowsFormsApp13\\Database\\system.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string name = textBox1.Text;
                    string email = textBox2.Text;
                    string username = textBox3.Text;
                    string address = textBox4.Text;
                    string phoneNum = textBox5.Text;
                    string password = textBox7.Text;

                    con.Open();

                   SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES (@Name, @address, @email, @phone, @username, @password)",con);
                    
                        cmd.Parameters.AddWithValue("@Name", name );
                        cmd.Parameters.AddWithValue("@address",email);
                        cmd.Parameters.AddWithValue("@email",username);
                        cmd.Parameters.AddWithValue("@phone",address);
                        cmd.Parameters.AddWithValue("@username",phoneNum);
                        cmd.Parameters.AddWithValue("@password",password);

                        cmd.ExecuteNonQuery();
                        con.Close();
                }

                MessageBox.Show("Registered Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }*/
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void Registration_Click(object sender, EventArgs e)
        {

        }
    }
}

