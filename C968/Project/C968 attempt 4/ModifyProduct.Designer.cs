namespace C968_attempt_4
{
    partial class ModifyProduct
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
            this.SearchParts = new System.Windows.Forms.Button();
            this.AllPartsSearchBox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.PartsWithProduct = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ProductText = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductInventory = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.ProductMax = new System.Windows.Forms.TextBox();
            this.ProductMin = new System.Windows.Forms.TextBox();
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
            this.AllParts.Location = new System.Drawing.Point(533, 85);
            this.AllParts.MultiSelect = false;
            this.AllParts.Name = "AllParts";
            this.AllParts.ReadOnly = true;
            this.AllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllParts.Size = new System.Drawing.Size(558, 212);
            this.AllParts.TabIndex = 1;
            // 
            // SearchParts
            // 
            this.SearchParts.Location = new System.Drawing.Point(816, 56);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(75, 23);
            this.SearchParts.TabIndex = 6;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            this.SearchParts.Click += new System.EventHandler(this.AllParts_Search);
            // 
            // AllPartsSearchBox
            // 
            this.AllPartsSearchBox.Location = new System.Drawing.Point(897, 59);
            this.AllPartsSearchBox.Name = "AllPartsSearchBox";
            this.AllPartsSearchBox.Size = new System.Drawing.Size(194, 20);
            this.AllPartsSearchBox.TabIndex = 7;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(996, 303);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(95, 21);
            this.AddProductButton.TabIndex = 8;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // PartsWithProduct
            // 
            this.PartsWithProduct.AllowUserToAddRows = false;
            this.PartsWithProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsWithProduct.Location = new System.Drawing.Point(533, 330);
            this.PartsWithProduct.MultiSelect = false;
            this.PartsWithProduct.Name = "PartsWithProduct";
            this.PartsWithProduct.ReadOnly = true;
            this.PartsWithProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsWithProduct.Size = new System.Drawing.Size(558, 222);
            this.PartsWithProduct.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(996, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_Product);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(996, 585);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 21);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(897, 585);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(95, 21);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ProductText
            // 
            this.ProductText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProductText.Location = new System.Drawing.Point(103, 190);
            this.ProductText.Name = "ProductText";
            this.ProductText.ReadOnly = true;
            this.ProductText.Size = new System.Drawing.Size(159, 20);
            this.ProductText.TabIndex = 23;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(103, 219);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(159, 20);
            this.ProductName.TabIndex = 24;
            // 
            // ProductInventory
            // 
            this.ProductInventory.Location = new System.Drawing.Point(103, 249);
            this.ProductInventory.Name = "ProductInventory";
            this.ProductInventory.Size = new System.Drawing.Size(159, 20);
            this.ProductInventory.TabIndex = 25;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(103, 281);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(159, 20);
            this.ProductPrice.TabIndex = 26;
            // 
            // ProductMax
            // 
            this.ProductMax.Location = new System.Drawing.Point(298, 310);
            this.ProductMax.Name = "ProductMax";
            this.ProductMax.Size = new System.Drawing.Size(159, 20);
            this.ProductMax.TabIndex = 27;
            // 
            // ProductMin
            // 
            this.ProductMin.Location = new System.Drawing.Point(103, 310);
            this.ProductMin.Name = "ProductMin";
            this.ProductMin.Size = new System.Drawing.Size(159, 20);
            this.ProductMin.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Modify Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "All Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Parts Associated with Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Inventory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(268, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Min";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 625);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductMin);
            this.Controls.Add(this.ProductMax);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductInventory);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductText);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PartsWithProduct);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.AllPartsSearchBox);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.AllParts);
            this.Name = "ModifyProduct";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.AllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsWithProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllParts;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.TextBox AllPartsSearchBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridView PartsWithProduct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox ProductText;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductInventory;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.TextBox ProductMax;
        private System.Windows.Forms.TextBox ProductMin;
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