using System.Numerics;

namespace InheritanceBeginnings
{
    public class Character
    {
        private String Name { get; set; }
        protected int Level { get; set; }

        protected Skilltree Skilltree;

        public String Hp { get; private set; }


        protected int BaseDmg { get; set; }


        public Character(string Name)
        {
            this.Name = Name;
            BaseDmg = 10;
        }

        public void Move(Vector2 direction)
        {

        }

        public int BaseAttack()
        {
            return BaseDmg;
        }

        public void ChangeXp(int xp)
        {
            Level += xp;
        }

        public void GetHeal(int heal)
        {
            Hp += heal;
            Console.WriteLine($"{Name} healed, current Hp {Hp}");
        }



    }

    public class Fighter : Character
    {
        protected bool isRaging { get; set; }
        protected int Strength { get; set; }
        protected int WeaponDamage { get; set; }

        public Fighter(string name) : base(name)
        {
            isRaging = false;
            Strength = 3;
            WeaponDamage = 41;
        }

        public int weaponAttack()
        {
            int damage = (BaseAttack() + WeaponDamage) * Strength;

            if (isRaging)
            {
                damage *= 2;
            }

            return damage;
        }

        public void shield(Character target) { }
    }
    public class Healer : Character
    {
        public Healer(string name) : base(name) { }
        public void Heal(Character target)
        {

            int h = 3 * Level;

            target.GetHeal(h);

        }

    }

    public class Mage : Character
    {
        public int Mana { get; set; }

        public int MagicDmg { get; set; }
        public Mage(string name) : base(name)
        {
            Mana = 1;
            MagicDmg = 2;

        }

        public int MagicAttack()
        {
            if (Mana < 10)
                return 0;


            return MagicDmg + BaseDmg * Level;
        }

    }
}
