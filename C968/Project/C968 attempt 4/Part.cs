using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_attempt_4
{
    public class Part
    {

        public Part(int partID, string name, double price, int inventory, int min, int max, string source)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min;
            Max = max;
            Source = source;
        }
        public int PartID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Inventory { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Source { get; set; }
    }
}


