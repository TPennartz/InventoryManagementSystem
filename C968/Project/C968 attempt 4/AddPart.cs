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
    public partial class AddPartScreen : Form
    {

        public AddPartScreen()
        {
            InitializeComponent();
            partIDText.Text = Inventory.AllParts.Count.ToString();
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceID.Text = "Machine ID";
            partIDText.Text = (Inventory.AllParts.Count).ToString();
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceID.Text = "Company Name";
            partIDText.Text = (Inventory.AllParts.Count).ToString();
        }

        private void CancelAddPartClick_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void SavePartClick_Click(object sender, EventArgs e)
        {
            int inventory, max, min;
            double price;
            string name = partNameText.Text;

            try
            {
                inventory = Convert.ToInt32(partInventoryText.Text);
                price = Convert.ToDouble(partPriceText.Text);
                max = Convert.ToInt32(partMaxText.Text);
                min = Convert.ToInt32(partMinText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure your Inventory, Price, Min and Max inputs do not contain invalid values (i.e., letters, symbols other than '.')", "INVALID ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            inventory = Convert.ToInt32(partInventoryText.Text);
            price = Convert.ToDouble(partPriceText.Text);
            max = Convert.ToInt32(partMaxText.Text);
            min = Convert.ToInt32(partMinText.Text);

            if (min > max)
            {
                MessageBox.Show("Max Stock should be greater than min", "INVALID MIN OR MAX STOCK", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (min > inventory || max < inventory)
            {
                MessageBox.Show("Inventory must be between min and max.", "INVALID MIN, MAX OR CURRENT STOCK", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (InHouseRadio.Checked)
            {
                int machineID;
                try
                {
                    machineID = Convert.ToInt32(SourceIDLabel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Machine ID must only contain numeric values", "INVALID MACHINE ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // I want the parts to never reuse a number
                machineID = Convert.ToInt32(SourceIDLabel.Text);
                Inhouse newInhousePart = new Inhouse(Inventory.AllParts.Count , name, price, inventory, min, max, machineID.ToString());
                Inventory.addPart(newInhousePart);
                this.Hide();
            }
            else if (OutsourcedRadio.Checked)
            {
                Outsourced newOutsourcedPart = new Outsourced(Inventory.AllParts.Count , name, price, inventory, min, max, SourceIDLabel.Text);
                Inventory.addPart(newOutsourcedPart);
                this.Hide();
            }
        }

        private void Make_Go_Away(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}