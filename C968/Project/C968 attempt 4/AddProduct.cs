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
    public partial class AddProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            PartsWithProduct.DataSource = addedParts;
            AllParts.DataSource = Inventory.AllParts;
            IDBox.Text = Inventory.Products.Count.ToString();
            
        }

        private void DataBindAllParts(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void DataBindProduct(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void SearchAllParts(object sender, EventArgs e)
        {
            int searchedPartID;
            try
            {
                searchedPartID = Convert.ToInt32(AllPartsSearchBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numeric values into this search box.");
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

        private void AddProduct_data(object sender, EventArgs e)
        {
            addedParts.Add((Part)AllParts.CurrentRow.DataBoundItem);
        }

        private void Save_productadded(object sender, EventArgs e)
        {
            int productID = Inventory.Products.Count;
            string productName = NameText.Text;
            int productInventrory, productMin, productMax;
            double productPrice;

            try
            {
                productInventrory = Convert.ToInt32(InventoryText.Text);
                productPrice = Convert.ToDouble(PriceText.Text);
                productMin = Convert.ToInt32(MinText.Text);
                productMax = Convert.ToInt32(MaxText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input valid data types for inputs.(Letters for name, numbers and decimals for price and numbers for all others)"); 
                return;
            }
            productInventrory = Convert.ToInt32(InventoryText.Text);
            productPrice = Convert.ToDouble(PriceText.Text);
            productMin = Convert.ToInt32(MinText.Text);
            productMax = Convert.ToInt32(MaxText.Text);

            if (productMin > productMax)
            {
                MessageBox.Show("Min cannot be greater than Max!", "Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (productMin > productInventrory || productMax < productInventrory)
            {
                MessageBox.Show("The inventory must be in between min and max.", "Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Product newProduct = new Product(Inventory.Products.Count, productName, productPrice, productInventrory, productMin, productMax);
            newProduct.AssociatedParts = addedParts;
            Inventory.addProduct(newProduct);
            this.Hide();
            this.Close();
        }

        private void Cancel_product(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Delete_product(object sender, EventArgs e)
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

        private void ID_enter(object sender, EventArgs e)
        {
            
        }
    }
}
