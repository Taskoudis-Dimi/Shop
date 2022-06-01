using ShopLibrary;
using ShopLibrary.SqlDataAccess;
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
    public partial class People_Items : Form
    {
        public People_Items()
        {
            InitializeComponent();

            SqlDataAccess loaddata = new SqlDataAccess();
            loaddata.retrieceData("Select * From People");

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addPeople form = new addPeople();
            form.ShowDialog();
            
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            addItems form = new addItems();
            form.ShowDialog();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
