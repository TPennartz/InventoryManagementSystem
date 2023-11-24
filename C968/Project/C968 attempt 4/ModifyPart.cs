using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_attempt_4
{
    public partial class ModifyPart : Form
    {
        public ModifyPart(Outsourced oldPart)
        {
            InitializeComponent();

            IDinput.Text = oldPart.PartID.ToString();
            NameInput.Text = oldPart.Name;
            _Inventory.Text = oldPart.Inventory.ToString();
            PriceInput.Text = oldPart.Price.ToString();
            Max.Text = oldPart.Max.ToString();
            Min.Text = oldPart.Min.ToString();
            MachineID.Text = oldPart.Source.ToString();
            MachineIDTitle.Text = "CompanyName:";
        }
        public ModifyPart(Inhouse oldPart)
        {
            InitializeComponent();

            IDinput.Text = oldPart.PartID.ToString();
            NameInput.Text = oldPart.Name;
            _Inventory.Text = oldPart.Inventory.ToString();
            PriceInput.Text = oldPart.Price.ToString();
            Max.Text = oldPart.Max.ToString();
            Min.Text = oldPart.Min.ToString();
            MachineID.Text = oldPart.Source.ToString();
        }

        private void Cancel_Modify(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Save_Modify(object sender, EventArgs e)
        {
            int inventory, max, min;
            int partID = Convert.ToInt32(IDinput.Text);
            double price;
            string name = NameInput.Text;

            try
            {
                inventory = Convert.ToInt32(_Inventory.Text);
                price = Convert.ToDouble(PriceInput.Text);
                max = Convert.ToInt32(Max.Text);
                min = Convert.ToInt32(Min.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure your Inventory, Price, Min and Max inputs contain valid values", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            inventory = Convert.ToInt32(_Inventory.Text);
            price = Convert.ToDouble(PriceInput.Text);
            max = Convert.ToInt32(Max.Text);
            min = Convert.ToInt32(Min.Text);

            if (min > max)
            {
                MessageBox.Show("Min should be less than Max.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (min > inventory || max < inventory)
            {
                MessageBox.Show("Inventory must be between the minimum and maximum stock values.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (In_house.Checked)
            {
                int machineID;
                try
                {
                    machineID = Convert.ToInt32(MachineID.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("The Machine ID can only have numeric values.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;

                }
                machineID = Convert.ToInt32(MachineID.Text);
                Inhouse newInhousePart = new Inhouse(partID, name, price, inventory, min, max, machineID.ToString());
                Inventory.updatePart(partID, newInhousePart);
            }
            else if (outsourced.Checked)
            {
                Outsourced newOutsourcedPart = new Outsourced(partID, name, price, inventory, min, max, CompanyName);
                Inventory.updatePart(partID, newOutsourcedPart);
            }
            this.Hide();

        }

        private void Outsourced_CheckedChange(object sender, EventArgs e)
        {
            MachineIDTitle.Text = "Company Name";
        }

        private void Inhouse_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDTitle.Text = "Machine ID";
        }
    }
}


