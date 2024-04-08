using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveAnimal
{
    public abstract class Animal
    {
        private string? _name;


        protected Animal() 
        { 
            _name = string.Empty;
        }


        public void SetName(string? name)
        {
            _name = name;
        }

        public string? GetName()
        {
            return _name;
        }

        public abstract void Eat();

    }
}
