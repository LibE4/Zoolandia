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
            var jellyfishNew = new Marine("Rainbow");
            var tigerNew =  new Land("Bigcat");
            var robinNew =  new Flying("Featherball");
            Console.WriteLine($"I have a jellyfish named {jellyfishNew.name} who has {jellyfishNew.fins} fins and can swim at {jellyfishNew.swimSpeed}mph.");
            Console.WriteLine($"I have a tiger named {tigerNew.name} who has {tigerNew.legs} legs and can run at {tigerNew.runSpeed}mph.");
            Console.WriteLine($"I have a robin named {robinNew.name} who has {robinNew.wings} wings and can fly at {robinNew.flySpeed}mph.");
            var jellyfishNewN1 = new Marine(20);
            var tigerNewN1 =  new Land(600);
            var robinNewN1 =  new Flying(0.5);
            Console.WriteLine($"I have a jellyfish named {jellyfishNewN1.name} who has {jellyfishNewN1.weight} lb.");
            Console.WriteLine($"I have a tiger named {tigerNewN1.name} who has {tigerNewN1.weight} lb.");
            Console.WriteLine($"I have a robin named {robinNewN1.name} who has {robinNewN1.weight} lb.");
            var jellyfishNewN = new Marine("RainbowNew", 20);
            var tigerNewN =  new Land("BigcatNew", 600);
            var robinNewN =  new Flying("FeatherballNew", 0.5);
            Console.WriteLine($"I have a jellyfish named {jellyfishNewN.name} who has {jellyfishNewN.weight} lb.");
            Console.WriteLine($"I have a tiger named {tigerNewN.name} who has {tigerNewN.weight} lb.");
            Console.WriteLine($"I have a robin named {robinNewN.name} who has {robinNewN.weight} lb.");
            var myMonkey = new Arctoides();
            myMonkey.walk();
            myMonkey.walk(50);
        }
    }
}
