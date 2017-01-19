using System;

namespace Zoolandia.Animals
{
    class Macaca : Animal, IMacaca
    {
        public virtual void walk ()
        {
            Console.WriteLine("Animal is now walking.");
        }
        public virtual void eat ()
        {
            Console.WriteLine("Animal is now eating.");
        }
        public virtual void climb()
        {
            Console.WriteLine("Animal is now climbing.");
        }
    }
}