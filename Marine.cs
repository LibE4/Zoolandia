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
        public Marine(string name)
        {
            this.name = name;
        }         
        public Marine(double weight) : this()
        {
            this.weight = weight;
        }        
        public Marine(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }        
        public int fins { get; set; }        
        public float swimSpeed { get; set; }
        public override void sleep()
        {
             Console.WriteLine("A marine animal is now sleeping.");
        }
    }
}