using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoolandia.Genus;

namespace zoolandia.Species
{
  class Chensinensis : Rana
  {
    public string speciesName = "Rana chensinensis";
    public string commonName = "Asiatic Grass Frog or Chinese Brown Frog";
    // Constructor
    public Chensinensis(string animalName)
    {
      name = animalName;
      color = "purple";
    }
  }
}
