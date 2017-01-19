using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string _commonName = "commonNam";
        public string _scientificName = "scientificName";        
        public string scientificName 
        { 
            get
            {
                return this._scientificName;
            } 
            set
            {
                this._scientificName = value;
            }
        }
        public string commonName { get; set; }
        public string name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public virtual void sleep ()
        {
            Console.WriteLine("Animal is now sleeping.");
        }
    }
}