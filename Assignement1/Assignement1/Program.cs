using System;
using System.Collections.Generic;

namespace Assignement1
{
    class Program
    {
        static void Main(string[] args)
        {

            // TEST DE LA CLASSE ITEM
            bool test1 = false;
            Console.WriteLine("Create an Item with dafault constructor :");
            Item i1 = new Item();

            Console.WriteLine("Create an Item with 2 parametrized constructor :");
            Console.WriteLine("First one :");
            Item i2 = Item.createItem();
            Console.WriteLine("Second One :");
            Item i3 = Item.createItem();

            Console.WriteLine("Create an Item with copy constructor :");
            Item i4 = new Item(i3);

            Console.WriteLine(i1.ToString());
            Console.WriteLine(i2.ToString());
            Console.WriteLine(i3.ToString());
            Console.WriteLine(i4.ToString());

            test1 = i1.Equals(i2);
            Console.WriteLine(test1);
            test1 = i2.Equals(i3);
            Console.WriteLine(test1);
            test1 = i3.Equals(i4);
            Console.WriteLine(test1);

            //TEST DE LA CLASSE ITEMONSALE

            Console.WriteLine("Create an Item with dafault constructor :");
            ItemOnSale i5 = new ItemOnSale();

            Console.WriteLine("Create an Item with 2 parametrized constructor :");
            Console.WriteLine("First one :");
            ItemOnSale i6 = ItemOnSale.createItemOnSale();
            Console.WriteLine("Second One :");
            ItemOnSale i7 = ItemOnSale.createItemOnSale();

            Console.WriteLine("Create an Item with copy constructor :");
            ItemOnSale i8 = new ItemOnSale(i7);

            Console.WriteLine(i5.ToString());
            Console.WriteLine(i6.ToString());
            Console.WriteLine(i7.ToString());
            Console.WriteLine(i8.ToString());

            Console.WriteLine(i5.getPrice());
            Console.WriteLine(i6.getPrice());
            Console.WriteLine(i7.getPrice());
            Console.WriteLine(i8.getPrice());

            test1 = i5.Equals(i6);
            Console.WriteLine(test1);
            test1 = i6.Equals(i7);
            Console.WriteLine(test1);
            test1 = i7.Equals(i8);
            Console.WriteLine(test1);


            // TEST INVOICE

            Item i9 = new Item(1, "designation", 10, "category");
            Item i10 = new Item(2, "designation", 10, "category");

            Purchase p1 = new Purchase(i1, 1, 128);
            Purchase p2 = new Purchase(i1, 1, 129);
            Purchase p3 = new Purchase(i2, 5, 130);

            List<Purchase> list = new List<Purchase>();
            list.Add(p1);
            list.Add(p2);

            Invoice in1 = new Invoice(list);

            in1.Add(p3);
            in1.ToString();

            Console.WriteLine(p1.CompareTo(p1));
            Console.WriteLine(p1.CompareTo(p2));

        }
    }
}
