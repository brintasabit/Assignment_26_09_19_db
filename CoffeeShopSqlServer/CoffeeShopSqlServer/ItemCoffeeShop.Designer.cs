namespace CoffeeShopSqlServer
{
    partial class ItemCoffeeShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delete By ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search By Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(46, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(46, 144);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(185, 26);
            this.priceTextBox.TabIndex = 2;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(176, 198);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(185, 26);
            this.searchTextBox.TabIndex = 5;
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(176, 253);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(185, 26);
            this.deleteTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(275, 117);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 31);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(383, 117);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(77, 31);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(415, 188);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 33);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(415, 249);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 34);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ShowButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.deleteTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Location = new System.Drawing.Point(344, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 333);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Location = new System.Drawing.Point(162, 380);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowTemplate.Height = 28;
            this.itemDataGridView.Size = new System.Drawing.Size(875, 287);
            this.itemDataGridView.TabIndex = 4;
            // 
            // ItemCoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 705);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemCoffeeShop";
            this.Text = "ItemCoffeeShop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView itemDataGridView;
    }
}