using System;

namespace Zoolandia.Animals
{
    class Assamensis : Macaca
    {
        string commonName = "Assam macaque";
        string scientificName = "Macaca assamensis";
        public override void walk ()
        {
            Console.WriteLine("Animal222 is now walking.");
        }
        public void walk (double speed)
        {
            Console.WriteLine("Animal222 is now walking at specified speed.");
        }
    }
}