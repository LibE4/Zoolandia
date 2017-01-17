using System;

namespace Zoolandia.Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var jellyfish = new Marine();
            jellyfish.fins = 0;
            jellyfish.swimSpeed = 5;
            var tiger =  new Land();
            tiger.legs = 4;
            tiger.runSpeed = 60;
            var robin =  new Flying();
            robin.wings = 2;
            robin.flySpeed = 100;
            Console.WriteLine($"I have a jellyfish named {jellyfish.name} who has {jellyfish.fins} fins and can swim at {jellyfish.swimSpeed}mph.");
            Console.WriteLine($"I have a tiger named {tiger.name} who has {tiger.legs} legs and can run at {tiger.runSpeed}mph.");
            Console.WriteLine($"I have a robin named {robin.name} who has {robin.wings} wings and can fly at {robin.flySpeed}mph.");
            jellyfish.sleep();
            tiger.sleep();
            robin.sleep();
            jellyfish.name = "Rainbow";            
            tiger.name = "Bigcat";            
            robin.name = "Featherball";            
            Console.WriteLine($"I have a jellyfish named {jellyfish.name} who has {jellyfish.fins} fins and can swim at {jellyfish.swimSpeed}mph.");
            Console.WriteLine($"I have a tiger named {tiger.name} who has {tiger.legs} legs and can run at {tiger.runSpeed}mph.");
            Console.WriteLine($"I have a robin named {robin.name} who has {robin.wings} wings and can fly at {robin.flySpeed}mph.");
        }
    }
}
