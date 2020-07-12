using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_16_VIRTUAL
{
    class Program
    {
        static void Animal_Sing(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Make_Sound();
            }
        }
        static Horse[] Get_Racing_Horses(Horse[] horses)
        {
            int x = 0;
            int z = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i]._Racing_Horse == true)
                {
                    x++;
                }
            }
            Horse[] racing = new Horse[x];
            for (int y = 0; y < horses.Length; y++)
            {
                if (horses[y]._Racing_Horse == true)
                {
                    racing[z] = horses[y];
                    z++;
                }
            }
            for (int a = 0; a < racing.Length; a++)
            {
                Console.WriteLine("Horse number " + (a + 1) + ": " + racing[a]);
            }
            return racing;
        }
        static void Main(string[] args)
        {
            Poodle bell = new Poodle("Shnitzel", "Bell", 3);
            Wolf kika = new Wolf("Dogs lives matter", "Kika", "fish");
            Dog pit = new Dog("Pit", "bonzo");
            Horse joey = new Horse("Joey", true);
            Pet_Wolf jack = new Pet_Wolf("Dogs lives matter", "Jack", "milk");
            Horse star = new Horse("Star", false);
            Horse john = new Horse("John", false);
            Horse din = new Horse("Din", true);

            Console.WriteLine(bell);
            Console.WriteLine(kika);
            Console.WriteLine(pit);
            Console.WriteLine(joey);
            Console.WriteLine(jack);
            Animal[] animals = { bell, kika, pit, joey, jack };
            Animal_Sing(animals);
            Horse[] horses = { joey,star,john,din };
            Get_Racing_Horses(horses);
        }
    }
}
