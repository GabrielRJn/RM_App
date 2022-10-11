using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RM_App
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
            Connection con =Connection.getDBConnection();
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
            
        }
    }
}
