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



            DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridViewCheckBoxColumn.Name = "Select";
            dataGridViewCheckBoxColumn.HeaderText = "Select";
            dataGridViewCheckBoxColumn.ReadOnly = false;
            ItemsDataGridView.Columns.Add(dataGridViewCheckBoxColumn);

            display();
            fill_peopleListBox();
        }

        private void display()
        {
            Connection loaddata = new Connection();
            loaddata.retrieveData("Select * From Items");
            ItemsDataGridView.DataSource = loaddata.table;


            Connection loaddata2 = new Connection();
            loaddata2.retrieveData("Select * From People");
            PeopleDataGridView.DataSource = loaddata2.table;


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

        private void PeopleDataGridView_MouseDown_1(object sender, MouseEventArgs e)
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            //Assign event handlers
            mnuEdit.Click += new EventHandler(mnuEditPeople_Click);
            mnuDelete.Click += new EventHandler(mnuDeletePeople_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDelete });
            //Assign to datagridview
            PeopleDataGridView.ContextMenuStrip = mnu;
        }

        private void mnuEditPeople_Click(object sender, EventArgs e)
        {
            EditPeople frm = new EditPeople();
            frm.ShowDialog();
        }

        private void mnuDeletePeople_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PeopleDataGridView.Rows)
            {
                PeopleDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void ItemsDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            mnuEdit.Click += new EventHandler(mnuEditItems_Click);
            mnuDelete.Click += new EventHandler(mnuDeleteItems_Click);
            mnu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDelete });
            ItemsDataGridView.ContextMenuStrip = mnu;
            ItemsDataGridView.AllowUserToAddRows = false;


        }

        public void mnuEditItems_Click(object sender, EventArgs e)
        {
            EditItems frm = new EditItems();
            frm.PriceTextBox.Text = ItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.TitleTextBox.Text = ItemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.DescriptionTextBox.Text = ItemsDataGridView.CurrentRow.Cells[3].Value.ToString();

            frm.ShowDialog();
        }

        private void mnuDeleteItems_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                ItemsDataGridView.Rows.RemoveAt(row.Index);
            }
        }


        private void People_Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm To Close Edit", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void CalcSum()
        {
            double sum = 0;
            for (int i = 0; i < ItemsDataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(ItemsDataGridView.Rows[i].Cells[0].Value) == true)
                {
                    sum += double.Parse(ItemsDataGridView.Rows[i].Cells[3].Value.ToString());

                }
            }

            sumTextBox.Text = sum.ToString();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void fill_peopleListBox()
        {
            Connection loaddata = new Connection();
            loaddata.retrieveData("Select * From People");
            PeopleListBox.DataSource = loaddata.table;
            PeopleListBox.DisplayMember = "FirstName";


            Connection loaddata2 = new Connection();
            loaddata2.retrieveData("Select * From Items");
            ItemsListBox.DataSource = loaddata2.table;
            ItemsListBox.DisplayMember = "Title";

        }


    }
}

