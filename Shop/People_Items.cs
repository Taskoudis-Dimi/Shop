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
    public partial class People_Items : Form
    {
        public People_Items()
        {
            InitializeComponent();

            List<string> items = new List<string>();
            

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

        private void PeopleDataGridView_Load(object sender, EventArgs e)
        {
            Connection loaddata = new Connection();
            loaddata.retrieveData("Select * From People");
            PeopleDataGridView.DataSource = loaddata.table;


        }

        private void ItemsDataGridView_Load(object sender, EventArgs e)
        {
            Connection loaddata = new Connection();
            loaddata.retrieveData("Select * From Items");
            ItemsDataGridView.DataSource = loaddata.table;


        }

        private void PeopleDataGridView_MouseDown_1(object sender, MouseEventArgs e)
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuCopy = new ToolStripMenuItem("Copy");
            ToolStripMenuItem mnuCut = new ToolStripMenuItem("Cut");
            ToolStripMenuItem mnuPaste = new ToolStripMenuItem("Paste");
            //Assign event handlers
            //mnuCopy.Click += new EventHandler(mnuCopy_Click);
            //mnuCut.Click += new EventHandler(mnuCut_Click);
            //mnuPaste.Click += new EventHandler(mnuPaste_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuCopy, mnuCut, mnuPaste });
            //Assign to datagridview
            PeopleListBox.ContextMenuStrip = mnu;
        }
    }
}
