using ShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;



namespace Shop
{
    public partial class ConsignmentShop : Form
    {

        private Store store = new Store();//        


        public ConsignmentShop()
        {
            InitializeComponent();

            display();
            MainMenu();
        }


        private void MainMenu()
        {
            MenuStrip MnuStrip = new MenuStrip();
            //Control is added to the Form using the Add property
            this.Controls.Add(MnuStrip);

            string[] row = new string[] { "File", "Edit", "About" };
            foreach (string Row in row)
            {
                ToolStripMenuItem MnuStripItem = new ToolStripMenuItem(Row);
                MnuStrip.Items.Add(MnuStripItem);
                SubMenu(MnuStripItem, Row);

            }

        
        }

        private void ClickChild(object sender, EventArgs e)
        {
            MessageBox.Show(string.Concat("You have Clicked '", sender.ToString(), "' Menu"), "Menu Items Event",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void SubMenu(ToolStripMenuItem MnuItems, string var)
        {
            if (var == "File")
            {
                string[] row = new string[] { "New", "Open", "Add", "Close", "Close Solution" };
                foreach (string rw in row)
                {
                    ToolStripMenuItem SSMenu = new ToolStripMenuItem(rw, null, ClickChild);
                    SubMenu(SSMenu, rw);
                    MnuItems.DropDownItems.Add(SSMenu);
                }
            }

            if (var == "New")
            {
                string[] row = new string[] { "Project", "Web Site", "File..", "Project From Existing Code" };
                foreach (string rw in row)
                {
                    ToolStripMenuItem SSSMenu = new ToolStripMenuItem(rw, null, ClickChild);
                    MnuItems.DropDownItems.Add(SSSMenu);
                }
            }
        }


        private void display()
        {
            Connection loaddata1 = new Connection();
            loaddata1.retrieveData("Select * From Items");
            storeItemsDataGridView.DataSource = loaddata1.table;


            Connection loaddata2 = new Connection();
            loaddata2.retrieveData("Select * From People");
            vendorDataGridView.DataSource = loaddata2.table;


            shoppingCartDataGridView.ColumnCount = 3;
            shoppingCartDataGridView.Columns[0].Name = "Title";
            shoppingCartDataGridView.Columns[1].Name = "Description";
            shoppingCartDataGridView.Columns[2].Name = "Price";

            vendorDataGridView.Columns.Add("Price", "Price");


            storeItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shoppingCartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridViewCheckBoxColumn.Name = "Select";
            dataGridViewCheckBoxColumn.HeaderText = "Select";
            dataGridViewCheckBoxColumn.ReadOnly = false;
            shoppingCartDataGridView.Columns.Add(dataGridViewCheckBoxColumn);
            shoppingCartDataGridView.Columns["Select"].DisplayIndex = 0;


        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //Figure out what is selected from the items list
            //Copy that item to the shopping cart
            //Do we remove the item from the items list? no



            foreach (DataGridViewRow row in storeItemsDataGridView.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.shoppingCartDataGridView.Rows.Add(rowData);
            }




        }

        private void makePurchase_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in shoppingCartDataGridView.Rows)
            {

            }


            //Mark each item in the cart as sold
            //Clear the cart

            //foreach (Item item in shoppingCartData)
            //{
            //    item.Sold = true;
            //    item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
            //    //storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;

            //}
            //shoppingCartData.Clear();




            //itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            //storeProfitValue.Text = String.Format("${0}", storeProfit);

            //cartBinding.ResetBindings(false);
            //itemsBinding.ResetBindings(false);
            //vendorBinding.ResetBindings(false);

            //}
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            Connection loaddata3 = new Connection();
            loaddata3.commandExc("Delete From Items Where Price=" + storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString() + "");
            foreach (DataGridViewRow row in storeItemsDataGridView.Rows)
            {
                storeItemsDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void addItemsButton_Click(object sender, EventArgs e)
        {
            Items frm = new Items();
            frm.ShowDialog();

        }

        private void addPeopleButton_Click(object sender, EventArgs e)
        {
            People frm = new People();
            frm.ShowDialog();
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void ConsignmentShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit from app", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void refresh2Button_Click(object sender, EventArgs e)
        {
            Connection loaddata4 = new Connection();
            loaddata4.retrieveData("Select * From People");

        }


        private void CalcSum()
        {
            double sum = 0;
            for (int i = 0; i < shoppingCartDataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(shoppingCartDataGridView.Rows[i].Cells[3].Value) == true)
                {
                    sum += double.Parse(shoppingCartDataGridView.Rows[i].Cells[2].Value.ToString());

                }
            }

            sumTextBox.Text = sum.ToString();
        }
        private void sumButton_Click(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Connection loaddata5 = new Connection();
            loaddata5.retrieveData("Select * From Items");
            storeItemsDataGridView.DataSource = loaddata5.table;
        }

        private void storeItemsDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem addItem = new ToolStripMenuItem("Add");
            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
            ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
            addItem.Click += new EventHandler(addItem_Click);
            editItem.Click += new EventHandler(editItem_Click);
            removeItem.Click += new EventHandler(removeItem_Click);
            menu.Items.AddRange(new ToolStripItem[] { addItem, editItem, removeItem });
            storeItemsDataGridView.ContextMenuStrip = menu;
            storeItemsDataGridView.AllowUserToAddRows = false;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            Items frm = new Items();
            frm.ShowDialog();
        }
        private void editItem_Click(object sender, EventArgs e)
        {
            EditItems frm = new EditItems();
            frm.TitleTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[0].Value.ToString();
            frm.DescriptionTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.PriceTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
        }
        private void removeItem_Click(object sender, EventArgs e)
        {
            Connection loaddata6 = new Connection();
            loaddata6.commandExc("Delete From Items Where Price=" + storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString() + "");
            foreach (DataGridViewRow row in storeItemsDataGridView.Rows)
            {
                storeItemsDataGridView.Rows.RemoveAt(row.Index);
            }
        }



        private void edit2Button_Click(object sender, EventArgs e)
        {
            EditPeople frm = new EditPeople();
            frm.FirstNameTextBox.Text = vendorDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.LastNameTextBox.Text = vendorDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PhoneTextBox.Text = vendorDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
        }

        private void remove2Button_Click(object sender, EventArgs e)
        {
            Connection loaddata7 = new Connection();
            loaddata7.commandExc("Delete From Items Where Phone=" + vendorDataGridView.CurrentRow.Cells[2].Value.ToString() + "");

            foreach (DataGridViewRow row in vendorDataGridView.Rows)
            {
                vendorDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditItems frm = new EditItems();
            frm.TitleTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[0].Value.ToString();
            frm.DescriptionTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.PriceTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
        }

        private void vendorDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem addItem = new ToolStripMenuItem("Add");
            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
            ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
            addItem.Click += new EventHandler(addPeople_Click);
            editItem.Click += new EventHandler(editPeople_Click);
            removeItem.Click += new EventHandler(removePeople_Click);
            menu.Items.AddRange(new ToolStripItem[] { addItem, editItem, removeItem });
            storeItemsDataGridView.ContextMenuStrip = menu;
            storeItemsDataGridView.AllowUserToAddRows = false;
        }

        private void addPeople_Click(object sender, EventArgs e)
        {
            People frm = new People();
            frm.ShowDialog();
        }
        private void editPeople_Click(object sender, EventArgs e)
        {
            EditPeople frm = new EditPeople();
            frm.FirstNameTextBox.Text = vendorDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.LastNameTextBox.Text = vendorDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PhoneTextBox.Text = vendorDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
        }
        private void removePeople_Click(object sender, EventArgs e)
        {
            Connection loaddata8 = new Connection();
            loaddata8.commandExc("Delete From Items Where Phone=" + vendorDataGridView.CurrentRow.Cells[2].Value.ToString() + "");

            foreach (DataGridViewRow row in vendorDataGridView.Rows)
            {
                vendorDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void storeItemsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            DataGridViewCell cell = dataGridView[e.ColumnIndex, e.RowIndex];
            DataGridViewColumn col = dataGridView.Columns[e.ColumnIndex];
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            int selectedRows_Count = dataGridView.SelectedRows.Count;
            
            if (e.Button == MouseButtons.Right)
            {

            }

            if (e.Button == MouseButtons.Left)
            {

            }



        }
    }

}