﻿namespace Shop
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
            this.itemsListBoxlabel = new System.Windows.Forms.Label();
            this.addToCartItem = new System.Windows.Forms.Button();
            this.ShoppingCartlabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListBoxLabel = new System.Windows.Forms.Label();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addItemsButton = new System.Windows.Forms.Button();
            this.addPeopleButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.storeItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.vendorDataGridView = new System.Windows.Forms.DataGridView();
            this.sumButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.refresh2Button = new System.Windows.Forms.Button();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.remove2Button = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.edit2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storeItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerText.Location = new System.Drawing.Point(522, 21);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(243, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // itemsListBoxlabel
            // 
            this.itemsListBoxlabel.AutoSize = true;
            this.itemsListBoxlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsListBoxlabel.Location = new System.Drawing.Point(81, 114);
            this.itemsListBoxlabel.Name = "itemsListBoxlabel";
            this.itemsListBoxlabel.Size = new System.Drawing.Size(96, 21);
            this.itemsListBoxlabel.TabIndex = 4;
            this.itemsListBoxlabel.Text = "Store Items";
            // 
            // addToCartItem
            // 
            this.addToCartItem.Location = new System.Drawing.Point(326, 212);
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
            this.ShoppingCartlabel.Location = new System.Drawing.Point(490, 114);
            this.ShoppingCartlabel.Name = "ShoppingCartlabel";
            this.ShoppingCartlabel.Size = new System.Drawing.Size(119, 21);
            this.ShoppingCartlabel.TabIndex = 6;
            this.ShoppingCartlabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(771, 212);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(124, 34);
            this.makePurchase.TabIndex = 7;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorListBoxLabel.Location = new System.Drawing.Point(1036, 131);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(65, 21);
            this.vendorListBoxLabel.TabIndex = 9;
            this.vendorListBoxLabel.Text = "Vendor";
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitLabel.Location = new System.Drawing.Point(1294, 345);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(97, 21);
            this.storeProfitLabel.TabIndex = 10;
            this.storeProfitLabel.Text = "Store Profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitValue.Location = new System.Drawing.Point(1315, 366);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 21);
            this.storeProfitValue.TabIndex = 11;
            this.storeProfitValue.Text = "$ 0.00";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(151, 314);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(77, 33);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addItemsButton
            // 
            this.addItemsButton.Location = new System.Drawing.Point(12, 314);
            this.addItemsButton.Name = "addItemsButton";
            this.addItemsButton.Size = new System.Drawing.Size(58, 34);
            this.addItemsButton.TabIndex = 13;
            this.addItemsButton.Text = "Add";
            this.addItemsButton.UseVisualStyleBackColor = true;
            this.addItemsButton.Click += new System.EventHandler(this.addItemsButton_Click);
            // 
            // addPeopleButton
            // 
            this.addPeopleButton.Location = new System.Drawing.Point(901, 313);
            this.addPeopleButton.Name = "addPeopleButton";
            this.addPeopleButton.Size = new System.Drawing.Size(55, 33);
            this.addPeopleButton.TabIndex = 14;
            this.addPeopleButton.Text = "Add";
            this.addPeopleButton.UseVisualStyleBackColor = true;
            this.addPeopleButton.Click += new System.EventHandler(this.addPeopleButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(1288, 155);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(81, 34);
            this.exportButton.TabIndex = 15;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // storeItemsDataGridView
            // 
            this.storeItemsDataGridView.AllowUserToAddRows = false;
            this.storeItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeItemsDataGridView.Location = new System.Drawing.Point(12, 155);
            this.storeItemsDataGridView.Name = "storeItemsDataGridView";
            this.storeItemsDataGridView.RowTemplate.Height = 25;
            this.storeItemsDataGridView.Size = new System.Drawing.Size(295, 150);
            this.storeItemsDataGridView.TabIndex = 16;
            this.storeItemsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.storeItemsDataGridView_CellMouseClick);
            this.storeItemsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.storeItemsDataGridView_MouseDown);
            // 
            // shoppingCartDataGridView
            // 
            this.shoppingCartDataGridView.AllowUserToAddRows = false;
            this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartDataGridView.Location = new System.Drawing.Point(446, 155);
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.RowTemplate.Height = 25;
            this.shoppingCartDataGridView.Size = new System.Drawing.Size(319, 150);
            this.shoppingCartDataGridView.TabIndex = 17;
            // 
            // vendorDataGridView
            // 
            this.vendorDataGridView.AllowUserToAddRows = false;
            this.vendorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDataGridView.Location = new System.Drawing.Point(901, 155);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.RowTemplate.Height = 25;
            this.vendorDataGridView.Size = new System.Drawing.Size(381, 150);
            this.vendorDataGridView.TabIndex = 18;
            this.vendorDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vendorDataGridView_MouseDown);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(466, 311);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(61, 34);
            this.sumButton.TabIndex = 20;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(234, 313);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(73, 33);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // refresh2Button
            // 
            this.refresh2Button.Location = new System.Drawing.Point(1209, 316);
            this.refresh2Button.Name = "refresh2Button";
            this.refresh2Button.Size = new System.Drawing.Size(73, 32);
            this.refresh2Button.TabIndex = 22;
            this.refresh2Button.Text = "Refresh";
            this.refresh2Button.UseVisualStyleBackColor = true;
            this.refresh2Button.Click += new System.EventHandler(this.refresh2Button_Click);
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(542, 314);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(88, 29);
            this.sumTextBox.TabIndex = 23;
            // 
            // remove2Button
            // 
            this.remove2Button.Location = new System.Drawing.Point(1049, 314);
            this.remove2Button.Name = "remove2Button";
            this.remove2Button.Size = new System.Drawing.Size(79, 33);
            this.remove2Button.TabIndex = 24;
            this.remove2Button.Text = "Remove";
            this.remove2Button.UseVisualStyleBackColor = true;
            this.remove2Button.Click += new System.EventHandler(this.remove2Button_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(76, 315);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(69, 33);
            this.editButton.TabIndex = 25;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // edit2Button
            // 
            this.edit2Button.Location = new System.Drawing.Point(974, 314);
            this.edit2Button.Name = "edit2Button";
            this.edit2Button.Size = new System.Drawing.Size(54, 33);
            this.edit2Button.TabIndex = 26;
            this.edit2Button.Text = "Edit";
            this.edit2Button.UseVisualStyleBackColor = true;
            this.edit2Button.Click += new System.EventHandler(this.edit2Button_Click);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 423);
            this.Controls.Add(this.edit2Button);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.remove2Button);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.refresh2Button);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.vendorDataGridView);
            this.Controls.Add(this.shoppingCartDataGridView);
            this.Controls.Add(this.storeItemsDataGridView);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.addPeopleButton);
            this.Controls.Add(this.addItemsButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListBoxLabel);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.ShoppingCartlabel);
            this.Controls.Add(this.addToCartItem);
            this.Controls.Add(this.itemsListBoxlabel);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consignment Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsignmentShop_FormClosing);
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerText;
        private Label itemsListBoxlabel;
        private Button addToCartItem;
        private Label ShoppingCartlabel;
        private Button makePurchase;
        private Label vendorListBoxLabel;
        private Label storeProfitLabel;
        private Label storeProfitValue;
        private Button removeButton;
        private Button addItemsButton;
        private Button addPeopleButton;
        private Button exportButton;
        private DataGridView storeItemsDataGridView;
        private DataGridView shoppingCartDataGridView;
        private DataGridView vendorDataGridView;
        private Button sumButton;
        private Button refreshButton;
        private Button refresh2Button;
        private TextBox sumTextBox;
        private Button remove2Button;
        private Button editButton;
        private Button edit2Button;
    }
}