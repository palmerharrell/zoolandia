using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class Donkey : Equus
  {
    public string speciesName = "Equus africanus asinus";
    public string commonName = "Donkey";
    // Constructor
    public Donkey(string animalName)
    {
      name = animalName;
      isHybrid = false;
    }
  }
}
