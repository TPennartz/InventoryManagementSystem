using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_attempt_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dgvpart.DataSource = Inventory.AllParts;
            Inventory.InitializeInventory(); 

            dgvproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproduct.DataSource = Inventory.Products;
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvpart.ClearSelection();

        }
        private void ProDatabindComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvproduct.ClearSelection();

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgvpart.CurrentRow == null || !dgvpart.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected.", "Please make a Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this Part?", "Deleted parts cannot be recovered.", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (response == DialogResult.OK)
                {
                    Part S = dgvpart.CurrentRow.DataBoundItem as Part;
                    int Index = dgvpart.CurrentCell.RowIndex;
                    //Part.parts.Remove(S);
                    Inventory.AllParts.RemoveAt(Index);
                }

            }
            
           

        }

    private void Modify_Product(object sender, EventArgs e)
        {
            ModifyProduct modifyProduct = new ModifyProduct((Product)dgvproduct.CurrentRow.DataBoundItem); ;
            modifyProduct.Show();

        }

        private void Modify_Part(object sender, EventArgs e)
        {
            if (dgvpart.CurrentRow.DataBoundItem.GetType() == typeof(C968_attempt_4.Inhouse))
            {
                Inhouse newInhousePart = (Inhouse)dgvpart.CurrentRow.DataBoundItem;
                ModifyPart modifyPart = new ModifyPart(newInhousePart);
                modifyPart.Show();
            }
            else
            {
                Outsourced newOutsourcedPart = (Outsourced)dgvpart.CurrentRow.DataBoundItem;
                ModifyPart modifyPart = new ModifyPart(newOutsourcedPart);
                modifyPart.Show();
            }
 

        }

        private void Add_Product(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();

        }

        private void Quit_Program(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Parts(object sender, EventArgs e)
        {
            string searchText = PartSearchBar.Text;
            foreach (DataGridViewRow row in dgvpart.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() == searchText)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }

        }

        private void Search_Products(object sender, EventArgs e)
        {
            string searchText = ProductSearchBar.Text;
            foreach (DataGridViewRow row in dgvproduct.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() == searchText)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        private void Open_AddPartForm(object sender, EventArgs e)
        {
            AddPartScreen addPartScreen = new AddPartScreen();

            addPartScreen.Show();
        }

        private void Delete_Product(object sender, EventArgs e)
        {
            Product deleteProduct = (Product)dgvproduct.CurrentRow.DataBoundItem;
            if (deleteProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Please remove all associated parts from this product before deleting.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete? Deleted products cannot be recovered.", "Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (response == DialogResult.OK)
                {
                    Inventory.removeProduct(deleteProduct.ProductID);
                }
            }
        }
    }
}
