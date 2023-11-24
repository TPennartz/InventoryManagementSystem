using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_attempt_4
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();

       
        public ModifyProduct(Product oldProduct)
        {
            InitializeComponent();
            ProductText.Text = oldProduct.ProductID.ToString();
            ProductName.Text = oldProduct.ProductName;
            ProductPrice.Text = oldProduct.ProductPrice.ToString();
            ProductInventory.Text = oldProduct.ProductInventory.ToString();
            ProductMin.Text = oldProduct.ProductMin.ToString();
            ProductMax.Text = oldProduct.ProductMax.ToString();
            addedParts = oldProduct.AssociatedParts;
            PartsWithProduct.DataSource = addedParts;
            AllParts.DataSource = Inventory.AllParts;

        }

        private void CancelButtonClick_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            addedParts.Add((Part)AllParts.CurrentRow.DataBoundItem);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(ProductText.Text);
            string productName = ProductName.Text;
            int productInventory, productMin, productMax;
            double productPrice;

            try
            {
                productInventory = Convert.ToInt32(ProductInventory.Text);
                productPrice = Convert.ToDouble(ProductPrice.Text);
                productMin = Convert.ToInt32(ProductMax.Text);
                productMax = Convert.ToInt32(ProductMin.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure your Inventory, Price, Min and Max inputs do not contain invalid values (letters, symbols other than '.')", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            productInventory = Convert.ToInt32(ProductInventory.Text);
            productPrice = Convert.ToDouble(ProductPrice.Text);
            productMin = Convert.ToInt32(ProductMin.Text);
            productMax = Convert.ToInt32(ProductMax.Text);

            if (productMin > productMax)
            {
                MessageBox.Show("The minimum value must be lower than the maximum value.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (productMin > productInventory || productMax < productInventory)
            {
                MessageBox.Show("Inventory must be between the minimum and maximum stock values.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Product updatedProduct = new Product(productID, productName, productPrice, productInventory, productMin, productMax);
            updatedProduct.AssociatedParts = addedParts;
            Inventory.updateProduct(productID, updatedProduct);
            this.Hide();

        }

        private void Delete_Product(object sender, EventArgs e)
        {
            if (PartsWithProduct.CurrentRow != null)
            {
                DialogResult selection = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (selection == DialogResult.Yes)
                {
                    addedParts.Remove((Part)PartsWithProduct.CurrentRow.DataBoundItem);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AllParts_Search(object sender, EventArgs e)
        {
            int searchedPartID;
            try
            {
                searchedPartID = Convert.ToInt32(AllPartsSearchBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numeric characters into the search box.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            searchedPartID = Convert.ToInt32(AllPartsSearchBox.Text);

            foreach (DataGridViewRow row in AllParts.Rows)
            {
                Part currentRow = (Part)row.DataBoundItem;
                if (currentRow.PartID == searchedPartID)
                {
                    AllParts.ClearSelection();
                    row.Selected = true;
                }
            }
        }

        private void AllPartsSearchText_Enter(object sender, EventArgs e)
        {
            AllPartsSearchBox.Clear();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

