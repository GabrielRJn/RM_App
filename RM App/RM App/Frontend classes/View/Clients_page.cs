﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM_App.Backend_classes.Model;

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
            // TODO: This line of code loads data into the 'appInformationDataSet1.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.appInformationDataSet1.clients);
            // TODO: This line of code loads data into the 'appInformationDataSet.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.appInformationDataSet.clients);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 0;

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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            //clientsDisplay.DataSource = RM_App.Backend_classes.Controller.Clientpage_Backend.getAllClients();
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
            Client er = new Client("Gab", "John");

            Client er2 = new Client("123", "John");

            List<Client> clients = new List<Client>();
            clients.Add(er);
            clients.Add(er2);

            listBox1.DataSource = clients;
            

        }
    }
}
