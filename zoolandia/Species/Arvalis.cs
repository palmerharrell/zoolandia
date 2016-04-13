﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoolandia.Genus;

namespace zoolandia.Species
{
  class Arvalis : Rana
  {
    public string speciesName = "Rana arvalis";
    public string commonName = "Moor Frog";
    // Constructor
    public Arvalis(string animalName)
    {
      name = animalName;
      color = "blue";
    }
  }
}
