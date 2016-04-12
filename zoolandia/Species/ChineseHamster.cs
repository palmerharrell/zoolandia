using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class ChineseHamster : Cricetulus
  {
    public string speciesName = "Cricetulus griseus";
    public string commonName = "Chinese Hamster";
    // Constructor
    public ChineseHamster(string animalName)
    {
      name = animalName;
      isDwarf = false;
    }
  }
}
