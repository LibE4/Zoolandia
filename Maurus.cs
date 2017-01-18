using System;

namespace Zoolandia.Animals
{
    class Maurus : Macaca
    {
        string commonName = "moor macaque";
        string scientificName = "Macaca maurus";
        public override void walk ()
        {
            Console.WriteLine("Animal666 is now walking.");
        }
        public void walk (double speed)
        {
            Console.WriteLine("Animal666 is now walking at specified speed.");
        }
    }
}