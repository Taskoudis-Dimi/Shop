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
    public partial class EditItems : Form
    {

        Connection loaddata = new Connection();

        public EditItems()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            loaddata.commandExc("Update Items set Price='" + PriceTextBox.Text + "',Description='" + DescriptionTextBox.Text + "',Title='" + TitleTextBox.Text + ";");

            MessageBox.Show("Product added successfuly");
        }
    }
}