using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_16_VIRTUAL
{
    abstract class Animal
    {
        public string _name;

        public Animal(string name)
        {
            _name = name;
        }

        public abstract void Make_Sound();

        public override string ToString()
        {
            return "Animal name: " + _name;
        }
    }
}
