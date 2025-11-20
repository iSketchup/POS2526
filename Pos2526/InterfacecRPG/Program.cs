using System.Drawing;
using System.Numerics;

namespace InterfacecRPG
{
    public interface IDamagable
    {
        public void TakeDamage(int damage);
    }

    public interface IMoveable
    {
        public void move(Vector2 vec);
    }


    public abstract class Character : IMoveable
    {
        protected PointF pos = new(0,0);
        public int Hp { get; set; } = 100;
        public string Name { get; set; } = "";

        public Character(int hp, string name)
        {
            Hp = hp;
            Name = name;
        }

        public void move(Vector2 vec)
        {
            pos = new PointF(pos.X + vec.X, pos.Y + vec.Y);
        }
    }


    public class Mage : Character, IDamagable
    {
        public Mage(int hp, string name) : base(hp, name)
        {

        }


        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
