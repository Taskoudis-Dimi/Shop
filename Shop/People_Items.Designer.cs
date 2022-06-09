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
            this.PeopleDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleListBox
            // 
            this.PeopleListBox.FormattingEnabled = true;
            this.PeopleListBox.ItemHeight = 15;
            this.PeopleListBox.Location = new System.Drawing.Point(12, 299);
            this.PeopleListBox.Name = "PeopleListBox";
            this.PeopleListBox.Size = new System.Drawing.Size(270, 139);
            this.PeopleListBox.TabIndex = 2;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(424, 299);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(270, 139);
            this.ItemsListBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 224);
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
            this.PeopleLabel.Location = new System.Drawing.Point(4, 24);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(103, 40);
            this.PeopleLabel.TabIndex = 5;
            this.PeopleLabel.Text = "People";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(424, 24);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(87, 40);
            this.ItemsLabel.TabIndex = 6;
            this.ItemsLabel.Text = "Items";
            // 
            // itemsButton
            // 
            this.itemsButton.Location = new System.Drawing.Point(424, 223);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(75, 23);
            this.itemsButton.TabIndex = 7;
            this.itemsButton.Text = "Add";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // PeopleDataGridView
            // 
            this.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleDataGridView.Location = new System.Drawing.Point(4, 67);
            this.PeopleDataGridView.Name = "PeopleDataGridView";
            this.PeopleDataGridView.RowTemplate.Height = 25;
            this.PeopleDataGridView.Size = new System.Drawing.Size(394, 150);
            this.PeopleDataGridView.TabIndex = 8;
            this.PeopleDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeopleDataGridView_MouseDown_1);
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(424, 67);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowTemplate.Height = 25;
            this.ItemsDataGridView.Size = new System.Drawing.Size(356, 150);
            this.ItemsDataGridView.TabIndex = 9;
            this.ItemsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemsDataGridView_MouseDown);
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(586, 223);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(88, 23);
            this.sumTextBox.TabIndex = 10;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(505, 224);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 11;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // People_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 470);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.PeopleDataGridView);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.PeopleListBox);
            this.Name = "People_Items";
            this.Text = "People - Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.People_Items_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
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
        private DataGridView PeopleDataGridView;
        private DataGridView ItemsDataGridView;
        private TextBox sumTextBox;
        private Button sumButton;
    }
}