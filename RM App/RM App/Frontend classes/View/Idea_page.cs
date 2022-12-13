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

namespace RM_App_FrontEnd
{
    public partial class Ideas_page : Form
    {
        public Ideas_page()
        {
            InitializeComponent();
        }

        private void Clients_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ideasData.ideas' table. You can move, or remove it, as needed.
            this.ideasTableAdapter1.Fill(this.ideasData.ideas);
            // TODO: This line of code loads data into the 'clientdisplay.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter2.Fill(this.clientdisplay.clients);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
            MultipageFunctions.showNewPage(this, new Clients_page());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

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
            RM_App.Backend_classes.Controller.MultipageFunctions.showNewPage(this, new Login_page());
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
            RM_App.Backend_classes.Controller.Clientpage_Backend.saveClient(firstNameBox.Text, lastNameBox.Text, emailBox.Text);
            this.clientsBindingSource2.DataSource = RM_App.Backend_classes.Service.ClientService.getAllClients();
            ideasDisplay.Update();
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ideasTableAdapter.FillBy(this.appInformationDataSet3.ideas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MultipageFunctions.showNewPage(this, new Login_page());
        }
    }
}
