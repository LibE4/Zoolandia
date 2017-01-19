using System;

namespace Zoolandia.Animals
{
    class Arctoides : Macaca
    {
        public Arctoides()
        {
            this.commonName = "stump-tailed (or bear) macaque";
            this.scientificName = "Macaca arctoides";
        }
        public override void walk ()
        {
            Console.WriteLine("Animal111 is now walking.");
        }
        public void walk (double speed)
        {
            Console.WriteLine("Animal111 is now walking at specified speed.");
        }
        public void climb ()
        {
            Console.WriteLine("Animal111 is now climbing.");
        }
    }
}