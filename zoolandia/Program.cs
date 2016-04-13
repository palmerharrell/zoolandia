using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoolandia.Species;

namespace zoolandia
{
    
  class Program
  {
    static void Main(string[] args)
    {
      Habitat savanna = new Habitat();
      savanna.inhabitants = new List<Animal>();
        
      // Animal larry = new Animal();
      // larry.name = args[0];

      // ANIMAL INSTANCES
      Zedonk zippy = new Zedonk("Zippy");
      Latastei marco = new Latastei("Marco");
      Iberica robert = new Iberica("Robert");

      savanna.inhabitants.Add(zippy);
      savanna.inhabitants.Add(marco);

      // CONSOLE OUTPUT
      foreach (Animal a in savanna.inhabitants)
      {
        Console.WriteLine("List/foreach example: " + a.name);
      }
    }
  }
}
