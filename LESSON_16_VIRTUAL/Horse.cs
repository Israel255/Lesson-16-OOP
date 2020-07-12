using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_16_VIRTUAL
{
    class Horse : Animal
    {
        public bool _Racing_Horse;

        public Horse(string name,bool racing_Horse) : base(name)
        {
            _Racing_Horse = racing_Horse;
        }

        public override void Make_Sound()
        {
            Neigh();
        }
        public virtual void Neigh()
        {
            Console.WriteLine("Hello i am a horse");
        }

        public override string ToString()
        {
            return base.ToString() + " ,Is this a racing horse?: " + _Racing_Horse;
        }
    }
}
