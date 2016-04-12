using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class Iberica : Rana
  {
    public string speciesName = "Rana iberica";
    public string commonName = "Iberian Frog";
    // Constructor
    public Iberica(string animalName)
    {
      name = animalName;
      color = "red";
    }
  }
}
