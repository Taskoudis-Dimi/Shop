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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsignmentShop));
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
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerText.Location = new System.Drawing.Point(364, 23);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(367, 55);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 32;
            this.itemsListBox.Location = new System.Drawing.Point(100, 154);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(270, 164);
            this.itemsListBox.TabIndex = 1;
            // 
            // ShoppingCartlistBox
            // 
            this.ShoppingCartlistBox.FormattingEnabled = true;
            this.ShoppingCartlistBox.ItemHeight = 32;
            this.ShoppingCartlistBox.Location = new System.Drawing.Point(727, 154);
            this.ShoppingCartlistBox.Name = "ShoppingCartlistBox";
            this.ShoppingCartlistBox.Size = new System.Drawing.Size(280, 164);
            this.ShoppingCartlistBox.TabIndex = 2;
            // 
            // itemsListBoxlabel
            // 
            this.itemsListBoxlabel.AutoSize = true;
            this.itemsListBoxlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsListBoxlabel.Location = new System.Drawing.Point(162, 103);
            this.itemsListBoxlabel.Name = "itemsListBoxlabel";
            this.itemsListBoxlabel.Size = new System.Drawing.Size(143, 32);
            this.itemsListBoxlabel.TabIndex = 4;
            this.itemsListBoxlabel.Text = "Store Items";
            // 
            // addToCartItem
            // 
            this.addToCartItem.Location = new System.Drawing.Point(480, 231);
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
            this.ShoppingCartlabel.Location = new System.Drawing.Point(800, 103);
            this.ShoppingCartlabel.Name = "ShoppingCartlabel";
            this.ShoppingCartlabel.Size = new System.Drawing.Size(178, 32);
            this.ShoppingCartlabel.TabIndex = 6;
            this.ShoppingCartlabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(775, 391);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(143, 42);
            this.makePurchase.TabIndex = 7;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorListBoxLabel.Location = new System.Drawing.Point(480, 427);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(96, 32);
            this.vendorListBoxLabel.TabIndex = 9;
            this.vendorListBoxLabel.Text = "Vendor";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 32;
            this.vendorListBox.Location = new System.Drawing.Point(402, 471);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(270, 164);
            this.vendorListBox.TabIndex = 8;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitLabel.Location = new System.Drawing.Point(60, 528);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(145, 32);
            this.storeProfitLabel.TabIndex = 10;
            this.storeProfitLabel.Text = "Store Profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitValue.Location = new System.Drawing.Point(246, 528);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(84, 32);
            this.storeProfitValue.TabIndex = 11;
            this.storeProfitValue.Text = "$ 0.00";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(113, 338);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(114, 34);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 679);
            this.Controls.Add(this.removeButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Button removeButton;
    }
}