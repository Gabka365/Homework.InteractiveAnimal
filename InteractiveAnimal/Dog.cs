using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveAnimal
{
    public class Dog : Animal
    {
        public Dog() : base() { }

        public override void Eat()
        {
            Console.WriteLine($"\tСобака {GetName()} кушает.");
        }
    }
}
