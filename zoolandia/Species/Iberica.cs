using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoolandia.Genus;

namespace zoolandia.Species
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
