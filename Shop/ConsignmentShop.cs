using ShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop
{
    public partial class ConsignmentShop : Form
    {

        private Store store = new Store();//

        private List<Item> shoppingCartData = new List<Item>();

        private decimal storeProfit = 0;

        Connection loaddata = new Connection();

        public ConsignmentShop()
        {
            InitializeComponent();

            display();
        }

        private void display()
        {
            Connection loaddata = new Connection();
            loaddata.retrieveData("Select * From Items");
            storeItemsDataGridView.DataSource = loaddata.table;


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
            loaddata.commandExc("Delete From Items Where Price=" + storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString() + "");
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
            loaddata.retrieveData("Select * From People");

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
            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 1; i < excelDataGridView.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = excelDataGridView.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < excelDataGridView.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < excelDataGridView.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = excelDataGridView.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loaddata.retrieveData("Select * From Items");
            storeItemsDataGridView.DataSource = loaddata.table;
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
            frm.TitleTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.DescriptionTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PriceTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
        }
        private void removeItem_Click(object sender, EventArgs e)
        {
            loaddata.commandExc("Delete From Items Where Price=" + storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString() + "");
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
            loaddata.commandExc("Delete From Items Where Phone=" + vendorDataGridView.CurrentRow.Cells[2].Value.ToString() + "");

            foreach (DataGridViewRow row in vendorDataGridView.Rows)
            {
                vendorDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditItems frm = new EditItems();
            frm.TitleTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.DescriptionTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PriceTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[3].Value.ToString();
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
            loaddata.commandExc("Delete From Items Where Phone=" + vendorDataGridView.CurrentRow.Cells[2].Value.ToString() + "");

            foreach (DataGridViewRow row in vendorDataGridView.Rows)
            {
                vendorDataGridView.Rows.RemoveAt(row.Index);
            }
        }
    }

}