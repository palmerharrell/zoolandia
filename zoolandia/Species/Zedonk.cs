using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoolandia.Genus;

namespace zoolandia.Species
{
  class Zedonk : Equus
  {
    public string speciesName = "Zebroid";
    public string commonName = "zedonk, zorse, zebra mule, zonkey, and zebmule";
    // CONSTRUCTOR
    public Zedonk(string animalName)
    {
      name = animalName;
      isHybrid = true;
      isFertile = false;
    }
  }
}
