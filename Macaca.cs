using System;

namespace Zoolandia.Animals
{
    class Macaca : Animal
    {
        public virtual void walk ()
        {
            Console.WriteLine("Animal is now walking.");
        }
        public virtual void eat ()
        {
            Console.WriteLine("Animal is now eating.");
        }
    }
}