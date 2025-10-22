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
        public String Name { get; set; }
        private int Level { get; set; }

        private Skilltree Skilltree;

        public  String Hp { get; set; }
        public Character(string Name)
        {
            this.Name = Name;
        }

        public void Move(Vector2 direction)
        {

        }

        public void Attack(int enemyId)
        {

        }

        public void ChangeXp(int xp)
        {

        }

    }

    public class Fighter : Character 
    {
        public bool isRaging; 

        public Fighter(string name) : base(name)
        {
            isRaging = false;
        }

        public void shield(Character target) { }
    }

    public class Healer : Character 
    {
        public void Heal (Character target) { }
    }

    public class Mage : Character 
    {
        public int Mana;
    }
}
