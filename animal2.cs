class Animal {
	public string name { get; set; }
}

// GENUS
class Equus : Animal {
	private string _genus = "Equus";
	private int _legs = 4;
	public string genus {
    get { return _genus; }
  }
  public int legs {
    get { return _legs; }
  }
}


// SPECIES
class Horse : Equus {
	private bool _isHybrid = false;
	public bool isHybrid {
		get { return _isHybrid; }
		set { _isHybrid = value; }
	}
	// CONSTRUCTOR
	public Horse (string animalName) {
		name = animalName;
		isHybrid = false;
	}
}

class Zebra : Equus {
	private bool _isHybrid = false;
	public bool isHybrid {
		get { return _isHybrid; }
		set { _isHybrid = value; }
	}
	// CONSTRUCTOR
	public Zebra (string animalName) {
		name = animalName;
		isHybrid = false;
	}
}


// Create animal instances
Horse mrEd = new Horse("Mr. Ed");
Zebra stripey = new Zebra("Stripey");

// Output
Console.WriteLine(mrEd.name);
Console.WriteLine(mrEd.genus);
Console.WriteLine(mrEd.legs);
Console.WriteLine(mrEd.isHybrid);

Console.WriteLine(stripey.name);
Console.WriteLine(stripey.genus);
Console.WriteLine(stripey.legs);
Console.WriteLine(stripey.isHybrid);


