using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;


namespace Zoolandia.Species
{
  class Latastei : Rana
  {
    public string speciesName = "Rana latastei";
    public string commonName = "Italian Agile Frog";
    // Method overriding example
    public override string doSomething()
    {
      return "override value";
    }
    // Constructor
    public Latastei(string animalName)
    {
      name = animalName;
      color = "brown";
    }
  }
}
