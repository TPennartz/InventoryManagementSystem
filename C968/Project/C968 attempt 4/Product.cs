using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace C968_attempt_4
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductInventory {  get; set; }
        public int ProductMin {  get; set; }
        public int ProductMax { get; set; }

        public Product(int productID, string name, double price, int inventory, int min, int max)
        {
            ProductID = productID;
            ProductName = name;
            ProductPrice = price;
            ProductInventory = inventory;
            ProductMin = min;
            ProductMax = max;
        }



        public void addAssociatedParts(Part newPart)
        {
            this.AssociatedParts.Add(newPart); 
        }
        public bool removeAssociatedParts(int partID)
        {
            Part removePart = LookupAssociatedPart(partID);
            return AssociatedParts.Remove(removePart);
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach(Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
