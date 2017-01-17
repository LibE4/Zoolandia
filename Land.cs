using System;

namespace Zoolandia.Animals
{
    // The species for a Red Pana
    class Land : Animal
    {
        // Define simple properties for a Red Panda
        public Land()
        {
            this.name = "myLand";
        }
        public int legs { get; set; }
        public float runSpeed { get; set; }
        public override void sleep()
        {
             Console.WriteLine("A land animal is now sleeping.");
        }
    }
}