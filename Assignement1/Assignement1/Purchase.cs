using System;
using System.Collections.Generic;
using System.Text;

namespace Assignement1
{
    class Purchase
    {
        //attributes
        protected Item purchased_item;
        protected double quantity_purchased;
        protected int code_purchased;


        //properties
        public Item Purchased_item
        {
            get { return purchased_item; }
            set { purchased_item = value; }
        }

        public double Quantity_purchased
        {
            get { return quantity_purchased; }
            set { quantity_purchased = value; }
        }

        public int Code_purchased
        {
            get { return code_purchased; }
            set { code_purchased = value; }
        }
        //default constructor
        public Purchase()
        {
            // this.purchased_item = ;
            this.quantity_purchased = 0;
            this.code_purchased = 0;
        }

        //parametrize constructor
        public Purchase(Item i_pur, int quanti, int code)
        {
            this.purchased_item = i_pur;
            this.quantity_purchased = quanti;
            this.code_purchased = code;
        }

        //copy constructor
        public Purchase(Purchase original)
        {
            this.purchased_item = original.Purchased_item;
            this.quantity_purchased = original.Quantity_purchased;
            this.code_purchased = original.Code_purchased;
        }

        //method to compare two purchase and return if they are equals, based on the item purchased and the quantity
        public bool CompareTo(Purchase p)
        {
            Console.WriteLine("purchase " + this.code_purchased + " equals purchase " + p.Code_purchased + "?");
            if (this.purchased_item.Equals(p.Purchased_item) && this.quantity_purchased == p.Quantity_purchased)
                return true;
            else
                return false;
        }
    }
}