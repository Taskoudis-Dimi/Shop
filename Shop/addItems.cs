﻿using ShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class addItems : Form
    {


        public addItems()
        {
            InitializeComponent();



            
        }

        private void display()
        {
            Connection loaddata = new Connection();
            loaddata.retrieveData("Select * From Items");
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Connection loaddata = new Connection();
                loaddata.commandExc("Insert Into Items Values(" + PriceTextBox.Text + ",'" + DescriptionTextBox.Text + "','" + TitleTextBox.Text + "')");
                MessageBox.Show("Success!");
                //display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}


