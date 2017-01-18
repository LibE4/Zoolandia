using System;

namespace Zoolandia.Animals
{
    class Fascicularis : Macaca
    {
        string commonName = "crab-eating (or long-tailed) macaque";
        string scientificName = "Macaca fascicularis";
        public override void walk ()
        {
            Console.WriteLine("Animal444 is now walking.");
        }
        public void walk (double speed)
        {
            Console.WriteLine("Animal444 is now walking at specified speed.");
        }
    }
}