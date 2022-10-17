using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RM_App_FrontEnd
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RM_App.Backend_classes.Controller.Loginpage_Backend.findUser(this, textBox1.Text, textBox2.Text);
            /* Connection con =Connection.getDBConnection();
             *//*Count the number of results found for the text entered into the textbox. 
              *Rz
              *//*
             DataSet result = con.getDataSet("SELECT Count(*) FROM rm_data WHERE email='"+ textBox1.Text + "'AND password = '"+ textBox2.Text+ "'");
             if (result.Tables[0].Rows[0][0].Equals(1))
             {
                 this.Hide();
                 MessageBox.Show("Login page is working");

             }
             else
             {
                 MessageBox.Show("Username or password is incorrect");
             }
             {

             }
             */

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
