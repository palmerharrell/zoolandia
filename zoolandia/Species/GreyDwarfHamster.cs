using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class GreyDwarfHamster : Cricetulus
  {
    public string speciesName = "Grey Dwarf Hamster, Gray Hamster or Migratory Hamster";
    public string commonName = "Cricetulus migratorius";
    // Constructor
    public GreyDwarfHamster(string animalName)
    {
      name = animalName;
      isDwarf = true;
    }
  }
}
