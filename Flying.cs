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
        public Flying(string name)
        {
            this.name = name;
        } 
        public Flying(double weight) : this()
        {
            this.weight = weight;
        } 
        public Flying(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }         
        public int wings { get; set; }
        public float flySpeed { get; set; }
        public override void sleep()
        {
             Console.WriteLine("A flying animal is now sleeping.");
        }
    }
}