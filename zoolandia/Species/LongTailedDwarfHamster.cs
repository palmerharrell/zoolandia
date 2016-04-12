using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class LongTailedDwarfHamster : Cricetulus
  {
    public string speciesName = "Cricetulus longicaudatus";
    public string commonName = "Long-tailed Dwarf Hamster";
    // Constructor
    public LongTailedDwarfHamster(string animalName)
    {
      name = animalName;
      isDwarf = true;
    }
  }
}
