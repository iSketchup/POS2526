namespace AbstractClassCook
{



    public abstract class Product
    {
        public string name { get; protected set; }
        public double price { get; protected set; }
        protected string PRID { get; set; }

        protected Product(string n, double p, string id)
        {
            name = n;
            price = p;
            PRID = id;
        }
    }
    public class Food : Product
    {
        public DateOnly ExpireDate { get; protected set; }

        public Food(string n, double p, string id, DateOnly exd) : base(n, p, id)
        {
            ExpireDate = exd;

        }
    }

    public class Frigeware : Food
    {
        public double MinTemp { get; protected set; }
        public double MaxTemp { get; protected set; }
        public Frigeware(string n, double p, string id, DateOnly exp, double min, double max) : base(n, p, id, exp)
        {
            MinTemp = min;
            MaxTemp = max;
        }
    }

    public class NonFood : Product
    {

        public NonFood(string n, double p, string id) : base(n, p, id)
        {
        }
    }

    public class Clothing : NonFood
    {
        public string size { get; protected set; }
        public DateOnly ProductionDate { get; protected set; }
        public Clothing(string n, double p, string id, DateOnly pd, string size) : base(n, p, id)
        {
            ProductionDate = pd;
            this.size = size;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                DateOnly date = new DateOnly();
                Clothing shirt = new("Cooles shirt", 14.99, "0", date, "XL");
                Clothing hat = new("Hat", 4.99, "1", date, "40");


                Frigeware milk = new("milk", 2.99, "23", date, 4, -20);
                Frigeware cheese = new("Gauda", 4.55, "45", date, 4, -10);

                List<Product> products = new List<Product>();
                products.Add(shirt);
                products.Add(hat);
                products.Add(cheese);
                products.Add(milk);

                foreach (Product product in products)
                {
                    Console.WriteLine(product.ToString());
                }



            }
        }
    }
}
