namespace InheritanceBeginnings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Healer Mercy = new("mercy");

            Fighter fighter = new("mike");

            Mage mage = new("gandalf");

            Console.WriteLine(fighter.Hp);
            Mercy.Heal(fighter);
        }
    }
}
