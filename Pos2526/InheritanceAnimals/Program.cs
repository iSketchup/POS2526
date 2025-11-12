namespace InheritanceAnimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new("Sigma", 2, "pudel");
            Cat cat = new("kitty", 1, "gelb");

            Owner owner = new("luis", 0);

            owner.AddPet(cat);
            owner.AddPet(dog);

            Console.WriteLine("Orchester:");

            for (int i = 0; i < 5; i++)
            {
                foreach (Animal p in owner.pets)
                {
                    p.makeSound();
                }
            }
        }
    }
}
