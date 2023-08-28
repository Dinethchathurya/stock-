using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;

using computing_group_project;
using System.Runtime.Intrinsics.X86;

namespace computing_group_project
{
    public partial class addChire : Form
    {
        public addChire()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addChire_Load(object sender, EventArgs e)
        {
            string chireModle = textBox1.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chairName = textBox1.Text;
            string supplireName = textBox2.Text;
            string quantity = textBox3.Text;
             try
            {
                
            }
            catch 
            { }




        }
    }
}
