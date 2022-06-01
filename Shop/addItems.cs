using ShopLibrary;
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


            Connection loaddata = new Connection();
            loaddata.commandExc("Select * From Shop");
            listBox1.DataSource = loaddata.table;


        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnector loaddata = new SqlConnector();
            //    //loaddata.commandExc("Insert Into Items values(" + TitleTextBox.Text + ",'" + DescriptionTextBox.Text + "','" + PriceTextBox.Text + "')");
            //    loaddata.commandExc("Select * From Shop");
            //    MessageBox.Show("Success!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            Connection loaddata = new Connection();
            MessageBox.Show("Test");
        }
    }
}


