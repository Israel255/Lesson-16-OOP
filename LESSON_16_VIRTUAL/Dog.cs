using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_16_VIRTUAL
{
    class Dog : Animal
    {
        public string _Favorite_Dog_Food;

        public Dog(string name,string favorite_Dog_Food) : base(name)
        {
            _Favorite_Dog_Food = favorite_Dog_Food;
        }

        public override void Make_Sound()
        {
            Bark();
        }
        public virtual void Bark()
        {
            Console.WriteLine("Hello i am a dog");
        }

        public override string ToString()
        {
            return base.ToString() + " ,Favorite food: " + _Favorite_Dog_Food;
        }
    }
}
