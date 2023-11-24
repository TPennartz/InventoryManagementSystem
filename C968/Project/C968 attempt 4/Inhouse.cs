using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_attempt_4
{
    public class Inhouse : Part
    {
        public Inhouse(int partID, string name, double price, int inventory, int min, int max, string source) : base(partID, name, price, inventory, min, max, source)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min; Max = max;
            try
            {
                MachineID = Convert.ToInt32(source);

            }
            catch (Exception ex) { MachineID = 0; }


        }
        public int MachineID
        { get; set; }
    }
}
