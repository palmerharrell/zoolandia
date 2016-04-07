class Animal {
	public string name { get; set; }
}

// GENUS
class Equus : Animal {
	private string _genus = "Equus";
	private int _legs = 4;
	private bool _isHybrid;
	public bool isHybrid {
		get { return _isHybrid; }
		set { _isHybrid = value; }
	}
	public string genus {
    get { return _genus; }
  }
  public int legs {
    get { return _legs; }
  }
}


// SPECIES (Genus: Equus)
class Horse : Equus {
	public string speciesName = "Horse";
	private bool _isHybrid = false;
	// CONSTRUCTOR
	public Horse (string animalName) {
		name = animalName;
		isHybrid = false;
	}
}

class Zebra : Equus {
	public string speciesName = "Zebra";
	private bool _isHybrid = false;
	// CONSTRUCTOR
	public Zebra (string animalName) {
		name = animalName;
		isHybrid = false;
	}
}

class Donkey : Equus {
	public string speciesName = "Donkey";
	private bool _isHybrid = false;
	// CONSTRUCTOR
	public Donkey (string animalName) {
		name = animalName;
		isHybrid = false;
	}
}

class Mule : Equus {
	public string speciesName = "Mule";
	private bool _isHybrid = true;
	// CONSTRUCTOR
	public Mule (string animalName) {
		name = animalName;
		isHybrid = true;
	}
}

class Zedonk : Equus {
	public string speciesName = "Zedonk";
	private bool _isHybrid = true;
	// CONSTRUCTOR
	public Zedonk (string animalName) {
		name = animalName;
		isHybrid = true;
	}
}

// Create animal instances
Horse mrEd = new Horse("Mr. Ed");
Zebra stripey = new Zebra("Stripey");
Donkey eeyore = new Donkey("Eeyore");
Mule stumpy = new Mule("Stumpy");
Zedonk zippy = new Zedonk("Zippy");

// Output
Console.WriteLine("");

Console.WriteLine(mrEd.name);
Console.WriteLine(mrEd.genus);
Console.WriteLine(mrEd.speciesName);
Console.WriteLine(mrEd.legs);
Console.WriteLine(mrEd.isHybrid);
Console.WriteLine("");

Console.WriteLine(stripey.name);
Console.WriteLine(stripey.genus);
Console.WriteLine(stripey.speciesName);
Console.WriteLine(stripey.legs);
Console.WriteLine(stripey.isHybrid);
Console.WriteLine("");

Console.WriteLine(eeyore.name);
Console.WriteLine(eeyore.genus);
Console.WriteLine(eeyore.speciesName);
Console.WriteLine(eeyore.speciesName);
Console.WriteLine(eeyore.legs);
Console.WriteLine(eeyore.isHybrid);
Console.WriteLine("");

Console.WriteLine(stumpy.name);
Console.WriteLine(stumpy.genus);
Console.WriteLine(stumpy.speciesName);
Console.WriteLine(stumpy.legs);
Console.WriteLine(stumpy.isHybrid);
Console.WriteLine("");

Console.WriteLine(zippy.name);
Console.WriteLine(zippy.genus);
Console.WriteLine(zippy.speciesName);
Console.WriteLine(zippy.legs);
Console.WriteLine(zippy.isHybrid);
Console.WriteLine("");




