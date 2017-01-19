using System;

namespace Zoolandia.Animals
{
    class Assamensis : Macaca
    {
        public Assamensis()
        {
            this.commonName = "Assam macaque";
            this.scientificName = "Macaca assamensis";
        }
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