﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class ChineseDwarfHamster : Cricetulus
  {
    public string speciesName = "Cricetulus barabensis";
    public string commonName = "Chinese Striped Hamster or Striped Dwarf Hamster";
    // Constructor
    public ChineseDwarfHamster(string animalName)
    {
      name = animalName;
      isDwarf = true;
    }
  }
}
