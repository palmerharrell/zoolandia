using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoolandia.Genus;

namespace zoolandia.Species
{
  class Zebra : Equus
  {
    public string speciesName = "Equus quagga";
    public string commonName = "Zebra";
    // Constructor
    public Zebra(string animalName)
    {
      name = animalName;
      isHybrid = false;
    }
    // Method overloading example
    public Zebra(string animalName, bool hybrid)
    {
      name = animalName;
      if (hybrid == true)
      {
        isHybrid = true;
        isFertile = false;
      }
      else
      {
        isHybrid = false;
        isFertile = true;
      }
    }
  }
}
