using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public virtual void sleep ()
        {
            Console.WriteLine("Animal is now sleeping.");
        }
    }
}