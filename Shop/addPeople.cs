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
    public partial class addPeople : Form
    {
        public addPeople()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            {
                SqlDataAccess loaddata = new SqlDataAccess();

                //loaddata.retrieceData("Select * From CategoryTbl");
            }
        }
    }
}
