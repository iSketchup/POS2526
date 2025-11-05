using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBeginnings
{
    public class Character
    {
        private String Name { get; set; }
        protected int Level { get; set; }

        protected Skilltree Skilltree;

        protected  String Hp { get; set; }


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

    }

    public class Fighter : Character 
    {
        public bool isRaging {  get; set; }
        public int Strength { get; set;}
        public int WeaponDamage { get; set;}

        public Fighter(string name) : base(name)
        {
            isRaging = false;
            Strength = 3;
            WeaponDamage = 41;
        }

        public int weaponAttack()
        {
            return (BaseAttack() + WeaponDamage)* Strength;
        }

        public void shield(Character target) { }
    }

    public class Healer : Character 
    {
        public Healer (string name) : base(name) { }
        public void Heal (Character target)  { }
    }

    public class Mage : Character
    {
        public int Mana { get; set; }

        public int MagicDmg {  get; set; }
        public Mage(string name) : base(name) {
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
