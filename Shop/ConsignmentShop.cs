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
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //Figure out what is selected from the items list
            //Copy that item to the shopping cart
            //Do we remove the item from the items list? no
            //Item selectedItem = (Item)itemsData.SelectedItem;

            //
            //shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);

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

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = String.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
            

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            //itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);

        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemsListBox_MouseDown(object sender, MouseEventArgs e)
        {




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
    }
} 