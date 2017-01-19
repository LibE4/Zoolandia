using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
  public class Habitat
  {
      // Instantiated a new list, which will contain animals.
      // You will add animals at run time (i.e. in `static void Main()
      // `)
      public List<Animal> inhabitants  = new List<Animal>();
      public string public_name { get; set; }
  }
  public interface ITreeHabitat
  {
    void climb();

  }

  public class Forest : Habitat, ITreeHabitat
  {
      public void climb()
      {
        Console.WriteLine("A forest animal is now climbing.");
      }
      public Forest (string name)
      {
          this.public_name = name;
      }
  }
}