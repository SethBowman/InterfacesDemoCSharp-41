using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoCSharp_41
{
    public class Dog : IAnimal, IDog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public string Breed { get; set; } = "Beagle";

        public void BurySomething()
        {
            Console.WriteLine("Dog buries something.");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Bark!");
        }

        public void Move()
        {
            Console.WriteLine("Dog runs!");
        }
    }
}
