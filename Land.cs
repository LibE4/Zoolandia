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
        public Land(string name)
        {
            this.name = name;
        } 
        public Land(double weight) : this()
        {
            this.weight = weight;
        }        
        public Land(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }         
        public int legs { get; set; }
        public float runSpeed { get; set; }
        public override void sleep()
        {
             Console.WriteLine("A land animal is now sleeping.");
        }
    }
}