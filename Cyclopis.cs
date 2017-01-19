using System;

namespace Zoolandia.Animals
{
    class Cyclopis : Macaca
    {
         public Cyclopis()
        {
            this.commonName = "Taiwan (or Formosan rock) macaque";
            this.scientificName = "Macaca cyclopis";
        }
        public override void walk ()
        {
            Console.WriteLine("Animal333 is now walking.");
        }
        public void walk (double speed)
        {
            Console.WriteLine("Animal333 is now walking at specified speed.");
        }
    }
}