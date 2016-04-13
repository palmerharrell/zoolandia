using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoolandia
{
  class Habitat
  {
    public bool hasWalls = true;
    public string climateType = "";
    public bool isAquatic = false;
    public double baseTemperature = 0;
    public double width = 0;
    public double depth = 0;
    public double height = 0;
    public int windowCount = 0;
    public List<Animal> inhabitants;
  }
}
