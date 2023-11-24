using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_attempt_4
{
    public class Outsourced : Part
    {
        public Outsourced(int partID, string name, double price, int inventory, int min, int max, string source) : base(partID, name, price, inventory, min, max, source)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min;
            Max = max;
            CompanyName = source;
        }
        public string CompanyName { get; set; }
        }
    }

