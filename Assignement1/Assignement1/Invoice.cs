using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace Assignement1
{

    class Invoice
    {
        //attributes
        static int invoice_number = 0;
        DateTime invoice_date;
        List<Purchase> purchaseCollection = new List<Purchase>();

        //properties
        public int Invoice_number
        {
            get { return invoice_number; }
            set { invoice_number = value; }
        }

        public DateTime Invoice_date
        {
            get { return invoice_date; }
            set { invoice_date = value; }
        }

        public List<Purchase> PurchaseCollection
        {
            get { return purchaseCollection; }
            set { purchaseCollection = value; }
        }

        //default constructor
        public Invoice()
        {
            invoice_number++;
            this.invoice_date = DateTime.Today;
        }

        //parametrize constructor
        public Invoice(List<Purchase> a)
        {
            this.invoice_date = DateTime.Today;
            invoice_number++;
            foreach (Purchase i in a)
                this.purchaseCollection.Add(i);
        }

        //copy constructor
        public Invoice(Invoice original)
        {
            invoice_number++;
            this.invoice_date = original.Invoice_date;
            foreach (Purchase i in original.PurchaseCollection)
                this.purchaseCollection.Add(i);
        }

        //adds a purchase in purchaseCollection, only if it does not already exist in the collection
        public void Add(Purchase a)
        {
            if (this.purchaseCollection.Contains(a))
                Console.WriteLine("Error : this purchase is already in purchaseCollection");
            else
                this.purchaseCollection.Add(a);
        }

        //returns the total amount in the invoice
        public double InvoiceAmount()
        {
            double amount = 0;
            foreach (Purchase p in this.purchaseCollection)
            {
                amount += p.Purchased_item.getPrice() * p.Quantity_purchased;
            }
            return amount;
        }

        //Save in a XML file the list of purchases
        public void SavePurchase(string path)
        {
            FileStream f = File.Open(path, FileMode.Open);
            XmlSerializer s = new XmlSerializer(typeof(List<Purchase>));
            s.Serialize(f, this.purchaseCollection);
            f.Close();
        }

        //ToString methos to display the information on the Invoice
        public override string ToString()
        {
            string display;
            display = "Invoice number : " + invoice_number + " invoice date " + this.invoice_date + "\nList of purchases\n";
            foreach (Purchase p in this.purchaseCollection)
            {
                display += "\nDesignation : " + p.Purchased_item.Designation + " ; Price (in Euro) : " + p.Purchased_item.getPrice() + " ; quantity : " + p.Quantity_purchased + " ; Total Price : " + p.Purchased_item.getPrice() * p.Quantity_purchased;
            }
            display += "\nInvoice amount : " + this.InvoiceAmount();
            Console.WriteLine(display);
            return display;
        }
    }
}