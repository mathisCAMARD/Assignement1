using System;
namespace Assignement1
{
    public class ItemOnSale : Item
    {
        protected double discount;

        // Default constructor base on Item
        public ItemOnSale() : base()
        {
            this.discount = 0;
        }

        // Parametrized Constructor base on Item
        public ItemOnSale(int c, string d, double p, string cat, double dis) : base(c, d, p, cat)
        {
            this.discount = dis/100;
        }

        // Copy Constructor base on Item
        public ItemOnSale(ItemOnSale i) : base(i)
        {
            this.discount = i.discount;
        }

        //Setter
        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }


        //Method that override method getPrince() in Item
        //return the price with discout
        public override double getPrice()
        {
            return base.getPrice() - base.getPrice()*this.discount;
        }

        public override string ToString()
        {
            return base.ToString() + " Discount : " + this.discount;
        }


        public static ItemOnSale createItemOnSale()
        {
            Console.WriteLine("Enter the the code :");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the designation :");
            string d = Console.ReadLine();
            Console.WriteLine("Enter the price :");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the category :");
            string cat = Console.ReadLine();
            Console.WriteLine("Enter the discount :");
            double dis = Convert.ToDouble(Console.ReadLine());
            try
            {
                ProcessString(dis);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            ItemOnSale i1 = new ItemOnSale(c, d, p, cat, dis);
            return i1;
        }

        //test if the price is > 0
        static void ProcessString(double s)
        {
            if (s <= 0)
            {
                throw new ArgumentNullException(paramName: nameof(s), message: "discount can't be null or < 0");
            }
        }
    }
}
