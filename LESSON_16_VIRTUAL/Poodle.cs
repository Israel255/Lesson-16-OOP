using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_16_VIRTUAL
{
    class Poodle : Dog
    {
        public int _Number_Of_Pony_Tails;

        public Poodle(string favorite_dog_food,string name,int number_Of_Pony_Tails) : base(name, favorite_dog_food)
        {
            _Number_Of_Pony_Tails = number_Of_Pony_Tails;
        }

        public override void Bark()
        {
            Console.WriteLine("I am a poodle!!");
        }

        public override string ToString()
        {
            return base.ToString() + " ,Number of ponytails: " + _Number_Of_Pony_Tails;
        }
    }
}
