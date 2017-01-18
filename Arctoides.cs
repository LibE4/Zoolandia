using System;

namespace Zoolandia.Animals
{
    class Arctoides : Macaca
    {
        string commonName = "stump-tailed (or bear) macaque";
        string scientificName = "Macaca arctoides";
        public override void walk ()
        {
            Console.WriteLine("Animal111 is now walking.");
        }
        public void walk (double speed)
        {
            Console.WriteLine("Animal111 is now walking at specified speed.");
        }
    }
}