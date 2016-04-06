
class Animal {
    public string AnimalName { get; set; }
}

class Species : Animal {
    public string SpeciesName { get; set; }
}

class Squirrel: Species {
    public string Noise {get; set;}
    public bool Exotic {get; set;}
    public string FavoriteFood {get; set;}
    public bool FluffyTail {get; set;}
    public int CutenessLevel {get; set;}
    public virtual string Transportation() {
    return "scurries";
  }
}

class FlyingSquirrel : Squirrel {
  public bool FearOfCars {get; set;}
  public override string Transportation() {
    return "flies";
  }
}

Squirrel nutsy = new Squirrel();
FlyingSquirrel batman = new FlyingSquirrel();

Console.WriteLine(nutsy.Transportation());
Console.WriteLine(batman.Transportation());

