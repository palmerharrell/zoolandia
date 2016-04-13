using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoolandia
{
  class Habitat
  {
    public bool hasWalls;
    public bool outside;
    public string climateType;
    public bool isAquatic;
    public double baseTemperature;
    public double width;
    public double height;
    public double depth;
    public int windowCount;

    public List<Animal> inhabitants;
  }
}
