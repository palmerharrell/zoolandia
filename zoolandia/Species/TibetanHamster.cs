using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class TibetanHamster : Cricetulus
  {
    public string speciesName = "Cricetulus alticola";
    public string commonName = "Tibetan Dwarf Hamster";
    // Constructor
    public TibetanHamster(string animalName)
    {
      name = animalName;
      isDwarf = true;
    }
  }
}
