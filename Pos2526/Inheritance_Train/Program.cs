namespace Inheritance_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train = new()
            {
                Name = "train"

            };

            Steamlocomotiv steamlocomotiv = new()
            {
                Name = "Thomas"
            };


            List<Train> trainList = new();

            trainList.Add(train);
            trainList.Add(steamlocomotiv); // kann dank polymorphysm auch geaddet werden

            foreach (Train t in trainList) {
                t.Horn();
            }

        }
    }

    public class Train
    {
        public double Speed { get; set; }

        public string Name {  get; set; }

        public virtual void Horn() // virtual erlaubt overrides von kinderklassen
        { 
            Console.WriteLine("tut tut tut sahur");
        }
    }
    public class Steamlocomotiv : Train
    {
        public int Coal { get; set; }

       
        public override void Horn() // override überscheibt das verhalten der methode 
        {
            Console.WriteLine("cho cho");
        }
    
    }

}
