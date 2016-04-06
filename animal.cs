
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
  public Squirrel (string sound) {
        Noise = sound;
  }
  public Squirrel (int adorable) {
        CutenessLevel = adorable;
  }
  public Squirrel (int adorable, string sound) {
        CutenessLevel = adorable;
        Noise = sound;
  }
}

//class FlyingSquirrel : Squirrel {
//  public bool FearOfCars {get; set;}
//  public override string Transportation() {
//    return "flies";
//  }
//}

Squirrel nutsy = new Squirrel("chatter");
Squirrel fluffy = new Squirrel(6);
Squirrel superSquirrel = new Squirrel(4, "chitterchatter");
// FlyingSquirrel batman = new FlyingSquirrel();

Console.WriteLine(nutsy.Transportation());
Console.WriteLine(nutsy.Noise);
Console.WriteLine(fluffy.CutenessLevel);
Console.WriteLine(superSquirrel.CutenessLevel);
Console.WriteLine(superSquirrel.Noise);
// Console.WriteLine(batman.Transportation());



