using System;

namespace Zoolandia.Animals
{
    // The species for a Red Pana
    class Marine : Animal
    {
        // Define simple properties for a Red Panda
        public Marine()
        {
            this.name = "myMarine";
        }        
        public int fins { get; set; }        
        public float swimSpeed { get; set; }
        public override void sleep()
        {
             Console.WriteLine("A marine animal is now sleeping.");
        }
    }
}