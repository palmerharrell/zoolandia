﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class Mule : Equus
  {
    public string speciesName = "Mule";
    public string commonName = "Mule";
    // CONSTRUCTOR
    public Mule(string animalName)
    {
      name = animalName;
      isHybrid = true;
      isFertile = false;
    }
  }
}
