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

        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
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
            //Mark each item in the cart as sold
            //Clear the cart

            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;

            }
            shoppingCartData.Clear();


            foreach (DataGridViewRow row in shoppingCartDataGridView.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.shoppingCartDataGridView.Rows.Add(rowData);




                //itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

                //storeProfitValue.Text = String.Format("${0}", storeProfit);

                //cartBinding.ResetBindings(false);
                //itemsBinding.ResetBindings(false);
                //vendorBinding.ResetBindings(false);

            }
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
            People_Items frm = new People_Items();
            frm.ShowDialog();

        }

        private void addPeopleButton_Click(object sender, EventArgs e)
        {
            People_Items frm = new People_Items();
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



        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemsListBox_MouseDown(object sender, MouseEventArgs e)
        {




        }

        private void refresh2Button_Click(object sender, EventArgs e)
        {
            loaddata.retrieveData("Select * From People");

        }


        private void sumButton_Click(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void CalcSum()
        {
            double sum = 0;
            for (int i = 0; i < shoppingCartDataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(shoppingCartDataGridView.Rows[i].Cells[0].Value) == true)
                {
                    sum += double.Parse(shoppingCartDataGridView.Rows[i].Cells[3].Value.ToString());

                }
            }

            sumTextBox.Text = sum.ToString();
        }


    }

}