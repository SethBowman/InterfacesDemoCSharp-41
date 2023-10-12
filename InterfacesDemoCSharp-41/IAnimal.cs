using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoCSharp_41
{
    public interface IAnimal
    {
        //Cannot have fieds in an interface
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        //Interface methods will be ALL stubbed out methods
        //In the background interfaces are completely abstract (even though we never use the word "abstract")
        public void Move();
        public void MakeNoise();
    }
}
