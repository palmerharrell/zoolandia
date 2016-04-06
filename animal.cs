
close
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
}
Squirrel nutsy = new Squirrel();
Console.Write("I have a Squirrel named Nutsy who makes a noise that sounds like {0}. I'd rate  his cuteness as a {1}.", nutsy.Noise, nutsy.CutenessLevel);
