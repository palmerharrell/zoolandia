﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
  class Boylii : Rana
  {
    public string speciesName = "Rana boylii";
    public string commonName = "Foothill Yellow-legged Frog";
    // Constructor
    public Boylii(string animalName)
    {
      name = animalName;
      color = "green";
    }
  }
}
