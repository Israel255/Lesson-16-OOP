using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_16_VIRTUAL
{
    class Pet_Wolf : Wolf
    {
        public override void Bark()
        {
            Console.WriteLine("I don't know how to bark!");
        }

        public Pet_Wolf(string name_of_pack, string name, string favorite_dog_food) : base(name_of_pack, name, favorite_dog_food)
        {

        }
    }
}
