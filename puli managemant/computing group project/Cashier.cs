using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using computing_group_project;

namespace computing_group_project
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUser user = new addUser();
            user.Show();
            this.Hide();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            register newuser = new register();
            newuser.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addChire newChire = new addChire();
            newChire.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteChire newChiree = new deleteChire();
            newChiree.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            order neworder = new order();
            neworder.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deleteOrder neworder = new deleteOrder();
            neworder.Show();
            this.Hide();
        }
    }
}

