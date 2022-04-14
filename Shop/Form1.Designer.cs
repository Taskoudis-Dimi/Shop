namespace Shop
{
    partial class Form1
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
            this.itemsListoBox = new System.Windows.Forms.ListBox();
            this.ShoppingCartlistBox = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.itemsListBoxlabel = new System.Windows.Forms.Label();
            this.purchaseItem = new System.Windows.Forms.Button();
            this.ShoppingCartlabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
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
            // itemsListoBox
            // 
            this.itemsListoBox.FormattingEnabled = true;
            this.itemsListoBox.ItemHeight = 21;
            this.itemsListoBox.Location = new System.Drawing.Point(44, 137);
            this.itemsListoBox.Name = "itemsListoBox";
            this.itemsListoBox.Size = new System.Drawing.Size(210, 151);
            this.itemsListoBox.TabIndex = 1;
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
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Location = new System.Drawing.Point(44, 355);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(210, 151);
            this.listBox3.TabIndex = 3;
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
            // purchaseItem
            // 
            this.purchaseItem.Location = new System.Drawing.Point(318, 184);
            this.purchaseItem.Name = "purchaseItem";
            this.purchaseItem.Size = new System.Drawing.Size(114, 34);
            this.purchaseItem.TabIndex = 5;
            this.purchaseItem.Text = "Add To Cart";
            this.purchaseItem.UseVisualStyleBackColor = true;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.ShoppingCartlabel);
            this.Controls.Add(this.purchaseItem);
            this.Controls.Add(this.itemsListBoxlabel);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.ShoppingCartlistBox);
            this.Controls.Add(this.itemsListoBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerText;
        private ListBox itemsListoBox;
        private ListBox ShoppingCartlistBox;
        private ListBox listBox3;
        private Label itemsListBoxlabel;
        private Button purchaseItem;
        private Label ShoppingCartlabel;
        private Button makePurchase;
    }
}