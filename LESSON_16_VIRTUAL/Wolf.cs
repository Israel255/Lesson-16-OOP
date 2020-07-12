using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_16_VIRTUAL
{
    class Wolf : Dog
    {
        public string _name_of_pack;

        public Wolf(string name_of_pack,string name,string favorite_dog_food) : base (name,favorite_dog_food)
        {
            _name_of_pack = name_of_pack;
        }

        public override string ToString()
        {
            return base.ToString() + " ,The name of the wolf pack is: " + _name_of_pack;
        }
    }
}
