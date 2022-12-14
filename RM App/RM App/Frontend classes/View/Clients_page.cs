using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM_App.Backend_classes.Controller;
using RM_App.Backend_classes.Model;
using RM_App.Backend_classes.Service;

namespace RM_App_FrontEnd
{
    public partial class Clients_page : Form
    {
        public Clients_page()
        {
            InitializeComponent();
        }

        private void Clients_page_Load(object sender, EventArgs e)
        {

             Clientpage_Backend.loadProfile(linkLabel1, label2);
            clientsDisplay.DataSource = ClientService.getAllClients();
            // TODO: This line of code loads data into the 'clientdisplay.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter2.Fill(this.clientdisplay.clients);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 0;
            NavbarFunctions.showNewPage(this, new Ideas_page());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clientpage_Backend.searchClient(clientsDisplay,searchBox.Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            RM_App.Backend_classes.Controller.NavbarFunctions.showNewPage(this, new Login_page());
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientpage_Backend.filterResults(clientsDisplay);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            addClientPanel.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Clientpage_Backend.checkEnteredEmail(emailBox.Text, errorLabel);
            RM_App.Backend_classes.Controller.Clientpage_Backend.saveClient(firstNameBox.Text, lastNameBox.Text, emailBox.Text);
            this.clientsBindingSource2.DataSource = RM_App.Backend_classes.Service.ClientService.getAllClients();
           
            clientsDisplay.Update();
            addClientPanel.Visible = false;
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewClientsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addClientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void tagsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            NavbarFunctions.showNewPage(this, new Login_page());
        }
    }
}
