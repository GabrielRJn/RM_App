﻿namespace RM_App_FrontEnd
{
    partial class Clients_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterBy = new System.Windows.Forms.ComboBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.appInformationDataSet = new RM_App.Backend_classes.Repository.AppInformationDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new RM_App.Backend_classes.Repository.AppInformationDataSetTableAdapters.clientsTableAdapter();
            this.clientsDisplay = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferredtagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferredproductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientdisplay = new RM_App.clientdisplay();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appInformationDataSet1 = new RM_App.Backend_classes.Repository.AppInformationDataSet1();
            this.clientsTableAdapter1 = new RM_App.Backend_classes.Repository.AppInformationDataSet1TableAdapters.clientsTableAdapter();
            this.appInformationDataSet2 = new RM_App.Backend_classes.Repository.AppInformationDataSet();
            this.viewClientsPanel = new System.Windows.Forms.Panel();
            this.addClientPanel = new System.Windows.Forms.Panel();
            this.riskBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tagsBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clientsTableAdapter2 = new RM_App.clientdisplayTableAdapters.clientsTableAdapter();
            this.errorLabel = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appInformationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appInformationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appInformationDataSet2)).BeginInit();
            this.viewClientsPanel.SuspendLayout();
            this.addClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 856);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(272, 414);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1428, 411);
            this.panel5.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(3, 858);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(267, 71);
            this.button4.TabIndex = 4;
            this.button4.Text = "Log out";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(8, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = "View ideas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(8, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "View clients";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(3, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email@user.co.uk";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(14, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 32);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Profile";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1695, 105);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1227, 783);
            this.panel3.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(844, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.FilterBy);
            this.panel4.Controls.Add(this.addClientButton);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1426, 80);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1088, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Filter clients by:";
            // 
            // FilterBy
            // 
            this.FilterBy.FormattingEnabled = true;
            this.FilterBy.Items.AddRange(new object[] {
            "Date",
            "Name (A-Z)"});
            this.FilterBy.Location = new System.Drawing.Point(1264, 32);
            this.FilterBy.Name = "FilterBy";
            this.FilterBy.Size = new System.Drawing.Size(151, 33);
            this.FilterBy.TabIndex = 10;
            this.FilterBy.SelectedIndexChanged += new System.EventHandler(this.FilterBy_SelectedIndexChanged);
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addClientButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.ForeColor = System.Drawing.Color.White;
            this.addClientButton.Location = new System.Drawing.Point(904, 25);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(138, 40);
            this.addClientButton.TabIndex = 8;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(714, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tags";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // appInformationDataSet
            // 
            this.appInformationDataSet.DataSetName = "AppInformationDataSet";
            this.appInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.appInformationDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsDisplay
            // 
            this.clientsDisplay.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.clientsDisplay.AutoGenerateColumns = false;
            this.clientsDisplay.BackgroundColor = System.Drawing.Color.White;
            this.clientsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.clientsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.preferredtagsDataGridViewTextBoxColumn,
            this.preferredproductsDataGridViewTextBoxColumn});
            this.clientsDisplay.DataSource = this.clientsBindingSource2;
            this.clientsDisplay.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientsDisplay.Location = new System.Drawing.Point(-2, 77);
            this.clientsDisplay.Name = "clientsDisplay";
            this.clientsDisplay.RowHeadersWidth = 62;
            this.clientsDisplay.RowTemplate.Height = 28;
            this.clientsDisplay.Size = new System.Drawing.Size(1428, 758);
            this.clientsDisplay.TabIndex = 3;
            this.clientsDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // preferredtagsDataGridViewTextBoxColumn
            // 
            this.preferredtagsDataGridViewTextBoxColumn.DataPropertyName = "preferred_tags";
            this.preferredtagsDataGridViewTextBoxColumn.HeaderText = "preferred_tags";
            this.preferredtagsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.preferredtagsDataGridViewTextBoxColumn.Name = "preferredtagsDataGridViewTextBoxColumn";
            this.preferredtagsDataGridViewTextBoxColumn.Width = 150;
            // 
            // preferredproductsDataGridViewTextBoxColumn
            // 
            this.preferredproductsDataGridViewTextBoxColumn.DataPropertyName = "preferred_products";
            this.preferredproductsDataGridViewTextBoxColumn.HeaderText = "preferred_products";
            this.preferredproductsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.preferredproductsDataGridViewTextBoxColumn.Name = "preferredproductsDataGridViewTextBoxColumn";
            this.preferredproductsDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientsBindingSource2
            // 
            this.clientsBindingSource2.DataMember = "clients";
            this.clientsBindingSource2.DataSource = this.clientdisplay;
            // 
            // clientdisplay
            // 
            this.clientdisplay.DataSetName = "clientdisplay";
            this.clientdisplay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "clients";
            this.clientsBindingSource1.DataSource = this.appInformationDataSet1;
            // 
            // appInformationDataSet1
            // 
            this.appInformationDataSet1.DataSetName = "AppInformationDataSet1";
            this.appInformationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // appInformationDataSet2
            // 
            this.appInformationDataSet2.DataSetName = "AppInformationDataSet";
            this.appInformationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewClientsPanel
            // 
            this.viewClientsPanel.Controls.Add(this.addClientPanel);
            this.viewClientsPanel.Controls.Add(this.clientsDisplay);
            this.viewClientsPanel.Controls.Add(this.panel4);
            this.viewClientsPanel.Location = new System.Drawing.Point(266, 103);
            this.viewClientsPanel.Name = "viewClientsPanel";
            this.viewClientsPanel.Size = new System.Drawing.Size(1426, 838);
            this.viewClientsPanel.TabIndex = 4;
            this.viewClientsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.viewClientsPanel_Paint);
            // 
            // addClientPanel
            // 
            this.addClientPanel.BackColor = System.Drawing.Color.White;
            this.addClientPanel.Controls.Add(this.errorLabel);
            this.addClientPanel.Controls.Add(this.riskBox);
            this.addClientPanel.Controls.Add(this.label12);
            this.addClientPanel.Controls.Add(this.label11);
            this.addClientPanel.Controls.Add(this.tagsBox);
            this.addClientPanel.Controls.Add(this.label10);
            this.addClientPanel.Controls.Add(this.label9);
            this.addClientPanel.Controls.Add(this.label8);
            this.addClientPanel.Controls.Add(this.button6);
            this.addClientPanel.Controls.Add(this.emailBox);
            this.addClientPanel.Controls.Add(this.lastNameBox);
            this.addClientPanel.Controls.Add(this.firstNameBox);
            this.addClientPanel.Controls.Add(this.label7);
            this.addClientPanel.Location = new System.Drawing.Point(8, 0);
            this.addClientPanel.Name = "addClientPanel";
            this.addClientPanel.Size = new System.Drawing.Size(1418, 838);
            this.addClientPanel.TabIndex = 4;
            this.addClientPanel.Visible = false;
            this.addClientPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addClientPanel_Paint);
            // 
            // riskBox
            // 
            this.riskBox.Location = new System.Drawing.Point(93, 668);
            this.riskBox.Multiline = true;
            this.riskBox.Name = "riskBox";
            this.riskBox.Size = new System.Drawing.Size(62, 35);
            this.riskBox.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(87, 620);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 32);
            this.label12.TabIndex = 13;
            this.label12.Text = "Risk Percentage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 32);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tags";
            // 
            // tagsBox
            // 
            this.tagsBox.AllowDrop = true;
            this.tagsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagsBox.CheckOnClick = true;
            this.tagsBox.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsBox.FormattingEnabled = true;
            this.tagsBox.HorizontalExtent = 120;
            this.tagsBox.Items.AddRange(new object[] {
            "Technology",
            "Healthcare",
            "Financials",
            "Renewable Energy"});
            this.tagsBox.Location = new System.Drawing.Point(93, 503);
            this.tagsBox.MultiColumn = true;
            this.tagsBox.Name = "tagsBox";
            this.tagsBox.Size = new System.Drawing.Size(537, 93);
            this.tagsBox.TabIndex = 11;
            this.tagsBox.SelectedIndexChanged += new System.EventHandler(this.tagsBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(459, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "Last name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 32);
            this.label9.TabIndex = 9;
            this.label9.Text = "First name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(93, 748);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "Save client";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(93, 358);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(679, 41);
            this.emailBox.TabIndex = 3;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(464, 225);
            this.lastNameBox.Multiline = true;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(308, 41);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // firstNameBox
            // 
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameBox.Location = new System.Drawing.Point(93, 226);
            this.firstNameBox.Multiline = true;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(310, 40);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.TextChanged += new System.EventHandler(this.firstNameBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Light", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 74);
            this.label7.TabIndex = 0;
            this.label7.Text = "Add Client";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // clientsTableAdapter2
            // 
            this.clientsTableAdapter2.ClearBeforeFill = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(95, 414);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(171, 20);
            this.errorLabel.TabIndex = 15;
            this.errorLabel.Text = "* Please enter an email";
            this.errorLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(-1, 767);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(267, 71);
            this.button7.TabIndex = 5;
            this.button7.Text = "Log out";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // Clients_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1694, 942);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewClientsPanel);
            this.MaximizeBox = false;
            this.Name = "Clients_page";
            this.ShowIcon = false;
            this.Text = "Clients_page";
            this.Load += new System.EventHandler(this.Clients_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appInformationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appInformationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appInformationDataSet2)).EndInit();
            this.viewClientsPanel.ResumeLayout(false);
            this.addClientPanel.ResumeLayout(false);
            this.addClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private RM_App.Backend_classes.Repository.AppInformationDataSet appInformationDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private RM_App.Backend_classes.Repository.AppInformationDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridView clientsDisplay;
        private RM_App.Backend_classes.Repository.AppInformationDataSet1 appInformationDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private RM_App.Backend_classes.Repository.AppInformationDataSet1TableAdapters.clientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FilterBy;
        private RM_App.Backend_classes.Repository.AppInformationDataSet appInformationDataSet2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel viewClientsPanel;
        private System.Windows.Forms.Panel addClientPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox riskBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferredtagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferredproductsDataGridViewTextBoxColumn;
        private RM_App.clientdisplay clientdisplay;
        private System.Windows.Forms.BindingSource clientsBindingSource2;
        private RM_App.clientdisplayTableAdapters.clientsTableAdapter clientsTableAdapter2;
        private System.Windows.Forms.Label errorLabel;
        protected internal System.Windows.Forms.CheckedListBox tagsBox;
        private System.Windows.Forms.Button button7;
    }
}