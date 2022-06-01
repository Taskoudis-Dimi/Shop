using ShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";


            cartBinding.DataSource = shoppingCartData;
            ShoppingCartlistBox.DataSource = cartBinding;

            ShoppingCartlistBox.DisplayMember = "Display";
            ShoppingCartlistBox.ValueMember = "Display";

           


            vendorBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";


        }

        public void SetupData()
        {

            //TODO retrieve data from db

            //
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });


            //
            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about a boy",
                Price = 4.50M,
                Owner = store.Vendors[1]
            });

            store.Name = "Seconds are better";

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //Figure out what is selected from the items list
            //Copy that item to the shopping cart
            //Do we remove the item from the items list? no
            Item selectedItem = (Item)itemsListBox.SelectedItem;

            //
            shoppingCartData.Add(selectedItem);

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
    }
} 