using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class Horse : Equus
  {
    public string speciesName = "Equus ferus caballus";
    public string commonName = "Horse";
    // Constructor
    public Horse(string animalName)
    {
      name = animalName;
      isHybrid = false;
    }
  }
}
