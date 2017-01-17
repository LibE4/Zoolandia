using System;

namespace Zoolandia.Animals
{
    // The species for a Red Pana
    class Flying : Animal
    {
        // Define simple properties for a Red Panda
        public Flying()
        {
            this.name = "myFlying";
        } 
        public int wings { get; set; }
        public float flySpeed { get; set; }
        public override void sleep()
        {
             Console.WriteLine("A flying animal is now sleeping.");
        }
    }
}