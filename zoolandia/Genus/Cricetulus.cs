using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoolandia.Genus
{
  class Cricetulus : Animal
  {
    private string _genus = "Cricetulus";
    private int _legs = 4;
    private bool _isDwarf;
    public bool isDwarf
    {
      get { return _isDwarf; }
      set { _isDwarf = value; }
    }
    public string genus
    {
      get { return _genus; }
    }
    public int legs
    {
      get { return _legs; }
    }
  }
}
