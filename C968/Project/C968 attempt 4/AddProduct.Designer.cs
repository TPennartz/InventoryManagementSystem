namespace C968_attempt_4
{
    partial class AddProduct
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
            this.AllParts = new System.Windows.Forms.DataGridView();
            this.PartsWithProduct = new System.Windows.Forms.DataGridView();
            this.SearchParts = new System.Windows.Forms.Button();
            this.AllPartsSearchBox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.InventoryText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.MaxText = new System.Windows.Forms.TextBox();
            this.MinText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsWithProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // AllParts
            // 
            this.AllParts.AllowUserToAddRows = false;
            this.AllParts.AllowUserToDeleteRows = false;
            this.AllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllParts.Location = new System.Drawing.Point(503, 76);
            this.AllParts.MultiSelect = false;
            this.AllParts.Name = "AllParts";
            this.AllParts.ReadOnly = true;
            this.AllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllParts.Size = new System.Drawing.Size(486, 223);
            this.AllParts.TabIndex = 0;
            this.AllParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindAllParts);
            // 
            // PartsWithProduct
            // 
            this.PartsWithProduct.AllowUserToAddRows = false;
            this.PartsWithProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsWithProduct.Location = new System.Drawing.Point(503, 348);
            this.PartsWithProduct.MultiSelect = false;
            this.PartsWithProduct.Name = "PartsWithProduct";
            this.PartsWithProduct.ReadOnly = true;
            this.PartsWithProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsWithProduct.Size = new System.Drawing.Size(486, 206);
            this.PartsWithProduct.TabIndex = 1;
            this.PartsWithProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindProduct);
            // 
            // SearchParts
            // 
            this.SearchParts.Location = new System.Drawing.Point(720, 32);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(75, 23);
            this.SearchParts.TabIndex = 2;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            this.SearchParts.Click += new System.EventHandler(this.SearchAllParts);
            // 
            // AllPartsSearchBox
            // 
            this.AllPartsSearchBox.Location = new System.Drawing.Point(811, 35);
            this.AllPartsSearchBox.Name = "AllPartsSearchBox";
            this.AllPartsSearchBox.Size = new System.Drawing.Size(178, 20);
            this.AllPartsSearchBox.TabIndex = 3;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(894, 305);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(95, 21);
            this.AddProductButton.TabIndex = 7;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProduct_data);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_productadded);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(896, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_product);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(894, 597);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 21);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Cancel_product);
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IDBox.Location = new System.Drawing.Point(169, 167);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(159, 20);
            this.IDBox.TabIndex = 11;
            this.IDBox.Enter += new System.EventHandler(this.ID_enter);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(169, 208);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(159, 20);
            this.NameText.TabIndex = 12;
            // 
            // InventoryText
            // 
            this.InventoryText.Location = new System.Drawing.Point(169, 290);
            this.InventoryText.Name = "InventoryText";
            this.InventoryText.Size = new System.Drawing.Size(159, 20);
            this.InventoryText.TabIndex = 13;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(169, 252);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(159, 20);
            this.PriceText.TabIndex = 14;
            // 
            // MaxText
            // 
            this.MaxText.Location = new System.Drawing.Point(264, 332);
            this.MaxText.Name = "MaxText";
            this.MaxText.Size = new System.Drawing.Size(85, 20);
            this.MaxText.TabIndex = 20;
            // 
            // MinText
            // 
            this.MinText.Location = new System.Drawing.Point(116, 332);
            this.MinText.Name = "MinText";
            this.MinText.Size = new System.Drawing.Size(85, 20);
            this.MinText.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "All Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Parts Associated with the Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Inventory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "ID";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 630);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinText);
            this.Controls.Add(this.MaxText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.InventoryText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.AllPartsSearchBox);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.PartsWithProduct);
            this.Controls.Add(this.AllParts);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.AllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsWithProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllParts;
        private System.Windows.Forms.DataGridView PartsWithProduct;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.TextBox AllPartsSearchBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox InventoryText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox MaxText;
        private System.Windows.Forms.TextBox MinText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}