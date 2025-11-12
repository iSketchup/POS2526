using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimals
{
    public class Owner
    {
        public List<Animal> pets {  get; private set; }
        protected int Id { get; set; }
        protected string Name { get; set; }

        public Owner (string name, int id)
        {
            Name = name;
            Id = id;
            pets = new List<Animal>();
        }

        public void PrintPets()
        {
            Console.WriteLine(pets);
        }

        public void AddPet(Animal pet)
        {
            pets.Add(pet);
        }

    }
}
