using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoolandia.Genus;

namespace zoolandia.Species
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
