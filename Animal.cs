using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public virtual void sleep ()
        {
            Console.WriteLine("Animal is now sleeping.");
        }
    }
}