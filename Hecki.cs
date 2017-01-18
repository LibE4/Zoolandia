using System;

namespace Zoolandia.Animals
{
    class Hecki : Macaca
    {
        string commonName = "Heck's macaque";
        string scientificName = "Macaca hecki";
        public override void walk ()
        {
            Console.WriteLine("Animal555 is now walking.");
        }
        public void walk (double speed)
        {
            Console.WriteLine("Animal555 is now walking at specified speed.");
        }
    }
}