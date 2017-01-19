using System;

namespace Zoolandia.Animals
{
    class Maurus : Macaca
    {
        public Maurus()
        {
            this.commonName = "moor macaque";
            this.scientificName = "Macaca maurus";
        }
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