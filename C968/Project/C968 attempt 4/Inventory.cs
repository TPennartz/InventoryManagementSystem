using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C968_attempt_4
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void InitializeInventory()
        {
            AllParts.Add(new Inhouse( 0, "Desk Drawer Slide", 2.99, 32, 20, 40, "325"));
            AllParts.Add(new Inhouse(1, "Chair Leg", 5.99, 20, 20, 40, "425"));
            AllParts.Add(new Outsourced(2, "Curtain Rod Holder", 1.99, 50, 20, 100, "Window Decor"));
            AllParts.Add(new Outsourced(3, "Lamp Shade", 15.99, 5, 2, 40, "Shady Place"));
            AllParts.Add(new Inhouse(4, "Light Bulbs", 7.99, 30, 20, 80, "225"));
            AllParts.Add(new Inhouse(5, "Screws", 0.05, 350, 200, 800, "125"));
            AllParts.Add(new Outsourced(6, "Sofa Cushion", 100.99, 5, 2, 5, "Soft Sitting"));

            Products.Add(new Product( 0, "Chair", 45.99, 4, 2, 12));
            Products.Add(new Product( 1, "Sofa", 899.59, 4, 1, 5));
            Products.Add(new Product(2, "End Table", 61.99, 6, 2, 8));
            Products.Add(new Product(3, "Desk", 85.99, 3, 1, 3));
        }

        public static void addProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public static bool removeProduct(int productID)
        {
            Product removeProduct = lookupProduct(productID);
            return Products.Remove(removeProduct);
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public static void updateProduct(int productID, Product newProduct)
        {
            Product oldProduct = lookupProduct(productID);
            oldProduct.AssociatedParts = newProduct.AssociatedParts;
            oldProduct.ProductName = newProduct.ProductName;
            oldProduct.ProductPrice = newProduct.ProductPrice;
            oldProduct.ProductInventory = newProduct.ProductInventory;
            oldProduct.ProductMin = newProduct.ProductMin;
            oldProduct.ProductMax = newProduct.ProductMax;
        }

        public static void addPart(Part newPart)
        {
            AllParts.Add(newPart);
        }

        public static bool deletePart(Part deletePart)
        {
            return AllParts.Remove(deletePart);
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public static void updatePart(int partID, Part newPart)
        {
            Part oldPart = lookupPart(partID);
            AllParts.Remove(oldPart);
            AllParts.Add(newPart);
        }
    }
}