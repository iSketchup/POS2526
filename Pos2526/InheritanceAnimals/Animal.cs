using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimals
{
    public abstract class Animal
    {
        protected int Id  { get; private set; }

        protected string Name { get; private set; }

        protected Animal(string name, int id) { 
        
            Name = name;
            Id = id;
        }

        public abstract void makeSound();
        }
    

    public class Dog : Animal
    {
        protected string Breed { get; private set; }
        public Dog(string name, int id, string breed) : base(name, id)
        {
            Breed = breed;
        }

        public override void makeSound()
        {
            Console.WriteLine("wuff");
        }
    }

    public class Cat : Animal
    {
        protected string Furcolor { get; private set; }
        public Cat(string name, int id, string furcolor) : base(name, id)
        {
            Furcolor = furcolor;
        }

        public override void makeSound()
        {
            Console.WriteLine("miau");
        }
    }
}
