using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoolandia.Genus
{
  class Rana : Animal
  {
    private string _genus = "Rana";
    private int _legs = 4;
    private string _color;
    public string genus
    {
      get { return _genus; }
    }
    public int legs
    {
      get { return _legs; }
    }
    public string color
    {
      get { return _color; }
      set { _color = value; }
    }
    // Method overriding example
    public virtual string doSomething()
    {
      return "original value";
    }
  }
}
