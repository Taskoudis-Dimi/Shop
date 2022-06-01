namespace Shop
{
    partial class People_Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PeopleListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.itemsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleListBox
            // 
            this.PeopleListBox.FormattingEnabled = true;
            this.PeopleListBox.ItemHeight = 15;
            this.PeopleListBox.Location = new System.Drawing.Point(50, 67);
            this.PeopleListBox.Name = "PeopleListBox";
            this.PeopleListBox.Size = new System.Drawing.Size(270, 139);
            this.PeopleListBox.TabIndex = 2;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(444, 67);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(270, 139);
            this.ItemsListBox.TabIndex = 3;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(50, 233);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeopleLabel.Location = new System.Drawing.Point(50, 24);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(103, 40);
            this.PeopleLabel.TabIndex = 5;
            this.PeopleLabel.Text = "People";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(444, 24);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(87, 40);
            this.ItemsLabel.TabIndex = 6;
            this.ItemsLabel.Text = "Items";
            // 
            // itemsButton
            // 
            this.itemsButton.Location = new System.Drawing.Point(444, 223);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(75, 23);
            this.itemsButton.TabIndex = 7;
            this.itemsButton.Text = "Add";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // People_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.PeopleListBox);
            this.Name = "People_Items";
            this.Text = "People";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox PeopleListBox;
        private ListBox ItemsListBox;
        private Button addButton;
        private Label PeopleLabel;
        private Label ItemsLabel;
        private Button itemsButton;
    }
}