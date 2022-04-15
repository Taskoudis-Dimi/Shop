namespace Shop
{
    partial class ConsignmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.ShoppingCartlistBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxlabel = new System.Windows.Forms.Label();
            this.addToCartItem = new System.Windows.Forms.Button();
            this.ShoppingCartlabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListBoxLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerText.Location = new System.Drawing.Point(28, 27);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(243, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 21;
            this.itemsListBox.Location = new System.Drawing.Point(44, 137);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(210, 151);
            this.itemsListBox.TabIndex = 1;
            // 
            // ShoppingCartlistBox
            // 
            this.ShoppingCartlistBox.FormattingEnabled = true;
            this.ShoppingCartlistBox.ItemHeight = 21;
            this.ShoppingCartlistBox.Location = new System.Drawing.Point(514, 137);
            this.ShoppingCartlistBox.Name = "ShoppingCartlistBox";
            this.ShoppingCartlistBox.Size = new System.Drawing.Size(210, 151);
            this.ShoppingCartlistBox.TabIndex = 2;
            // 
            // itemsListBoxlabel
            // 
            this.itemsListBoxlabel.AutoSize = true;
            this.itemsListBoxlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsListBoxlabel.Location = new System.Drawing.Point(44, 103);
            this.itemsListBoxlabel.Name = "itemsListBoxlabel";
            this.itemsListBoxlabel.Size = new System.Drawing.Size(96, 21);
            this.itemsListBoxlabel.TabIndex = 4;
            this.itemsListBoxlabel.Text = "Store Items";
            // 
            // addToCartItem
            // 
            this.addToCartItem.Location = new System.Drawing.Point(318, 184);
            this.addToCartItem.Name = "addToCartItem";
            this.addToCartItem.Size = new System.Drawing.Size(114, 34);
            this.addToCartItem.TabIndex = 5;
            this.addToCartItem.Text = "Add To Cart";
            this.addToCartItem.UseVisualStyleBackColor = true;
            this.addToCartItem.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // ShoppingCartlabel
            // 
            this.ShoppingCartlabel.AutoSize = true;
            this.ShoppingCartlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShoppingCartlabel.Location = new System.Drawing.Point(514, 103);
            this.ShoppingCartlabel.Name = "ShoppingCartlabel";
            this.ShoppingCartlabel.Size = new System.Drawing.Size(119, 21);
            this.ShoppingCartlabel.TabIndex = 6;
            this.ShoppingCartlabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(519, 305);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(114, 34);
            this.makePurchase.TabIndex = 7;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorListBoxLabel.Location = new System.Drawing.Point(44, 352);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(65, 21);
            this.vendorListBoxLabel.TabIndex = 9;
            this.vendorListBoxLabel.Text = "Vendor";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 21;
            this.vendorListBox.Location = new System.Drawing.Point(44, 386);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(210, 151);
            this.vendorListBox.TabIndex = 8;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitLabel.Location = new System.Drawing.Point(493, 370);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(97, 21);
            this.storeProfitLabel.TabIndex = 10;
            this.storeProfitLabel.Text = "Store Profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitValue.Location = new System.Drawing.Point(627, 370);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 21);
            this.storeProfitValue.TabIndex = 11;
            this.storeProfitValue.Text = "$ 0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListBoxLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.ShoppingCartlabel);
            this.Controls.Add(this.addToCartItem);
            this.Controls.Add(this.itemsListBoxlabel);
            this.Controls.Add(this.ShoppingCartlistBox);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerText;
        private ListBox itemsListBox;
        private ListBox ShoppingCartlistBox;
        private Label itemsListBoxlabel;
        private Button addToCartItem;
        private Label ShoppingCartlabel;
        private Button makePurchase;
        private Label vendorListBoxLabel;
        private ListBox vendorListBox;
        private Label storeProfitLabel;
        private Label storeProfitValue;
    }
}