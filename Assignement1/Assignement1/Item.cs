using System;
namespace Assignement1
{
    public class Item
    {

        protected int code;
        protected string designation;
        protected double price;
        protected string category;

        // Default constructor
        public Item()
        {
            this.code = 0;
            this.designation = "";
            this.price = 0;
            this.category = "";

        }

        // Parametrized Constructor 
        public Item(int c, string d, double p, string cat)
        {
            
            this.code = c;
            this.designation = d;
            this.price = p;
            this.category = cat;
        }

        // Copy Constructor
        public Item(Item i)
        {
            this.code = i.code;
            this.designation = i.designation ;
            this.price = i.price;
            this.category = i.category;
        }

        // Getters
        
        public virtual double getPrice()
        {
            return this.price;
        }


        //Properties
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }


        //Method that override the ToString() Method
        //return a string with all the parameters on the class
        public override string ToString()
        {
            return "Code : " + this.code + " Designation : " + this.designation + " Price : " + this.price + " Category : " + this.category;
        }

        //Method that  verify if two object of the class Item have the same parameters
        //Return a boolean
        public bool Equals(Item i1)
        {
            if ((this.code == i1.code) && (this.designation.Equals(i1.designation)) && (this.price == i1.price) && (this.category.Equals(i1.category)))
                return true;
            else
                return false;
        }

        //Method that create an Item with the user that enter his values
        public static Item createItem()
        {
            Console.WriteLine("Enter the the code :");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the designation :");
            string d = Console.ReadLine();
            Console.WriteLine("Enter the price :");
            double p = Convert.ToDouble(Console.ReadLine());
            try
            {
                ProcessString(p);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Enter the category :");
            string cat = Console.ReadLine();
            try
            {
                CategoryInvalidException(cat);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Item i1 = new Item(c, d, p, cat);
            return i1;
        }

        //test if the price is > 0
        static void ProcessString(double s)
        {
            if (s <= 0)
            {
                throw new ArgumentNullException(paramName: nameof(s), message: "price can't be null or < 0");
            }
        }

        // test if it's the ggod category
        static void CategoryInvalidException(string s)
        {
            if ((!s.Equals("Computer Science")) && (!s.Equals("Office Automation")))
            {
                throw new ArgumentNullException(paramName: nameof(s), message: "category has to be Computer Science or Office Automation");
            }
        }

    }
}
