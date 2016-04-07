class Animal {
	public string name { get; set; }
}

// GENUS
class Equus : Animal {
	private string _genus = "Equus";
	private int _legs = 4;
	private bool _isHybrid;
	private bool _isFertile = true;
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
  public bool isFertile {
  	get { return _isFertile; }
  	set { _isFertile = value; }
  }
}

class Cricetulus : Animal {
	private string _genus = "Cricetulus";
	private int _legs = 4;
	private bool _isDwarf;
	public bool isDwarf {
		get { return _isDwarf; }
		set { _isDwarf = value; }
	}
	public string genus {
    get { return _genus; }
  }
  public int legs {
    get { return _legs; }
  }
}

class Rana : Animal {
	private string _genus = "Rana";
	private int _legs = 4;
	private string _color;
	public string genus {
    get { return _genus; }
  }
  public int legs {
    get { return _legs; }
  }
  public string color {
  	get { return _color; }
  	set { _color = value; }
  }
}


// ~~~~~ SPECIES (Genus: Rana) ~~~~~
class Latastei : Rana {
	public string speciesName = "Italian Agile Frog";
	// Constructor
	public Latastei (string animalName) {
		name = animalName;
		color = "brown";
	}
}

class Iberica : Rana {
	public string speciesName = "Iberian Frog";
	// Constructor
	public Iberica (string animalName) {
		name = animalName;
		color = "red";
	}
}

class Arvalis : Rana {
	public string speciesName = "Moor Frog";
	// Constructor
	public Arvalis (string animalName) {
		name = animalName;
		color = "blue";
	}
}

class Boylii : Rana {
	public string speciesName = "Foothill Yellow-legged Frog";
	// Constructor
	public Boylii (string animalName) {
		name = animalName;
		color = "green";
	}
}

class Chensinensis : Rana {
	public string speciesName = "Asiatic Grass Frog";
	// Constructor
	public Chensinensis (string animalName) {
		name = animalName;
		color = "purple";
	}
}


// ~~~~~ SPECIES (Genus: Cricetulus) ~~~~~
class TibetanHamster : Cricetulus {
	public string speciesName = "Tibetan Dwarf Hamster";
	// Constructor
	public TibetanHamster (string animalName) {
		name = animalName;
		isDwarf = true;
	}
}

class ChineseDwarfHamster : Cricetulus {
	public string speciesName = "Chinese Dwarf Hamster";
	// Constructor
	public ChineseDwarfHamster (string animalName) {
		name = animalName;
		isDwarf = true;
	}
}

class ChineseHamster : Cricetulus {
	public string speciesName = "Chinese Hamster";
	// Constructor
	public ChineseHamster (string animalName) {
		name = animalName;
		isDwarf = false;
	}
}

class GreyDwarfHamster : Cricetulus {
	public string speciesName = "Grey Dwarf Hamster";
	// Constructor
	public GreyDwarfHamster (string animalName) {
		name = animalName;
		isDwarf = true;
	}
}

class LongTailedDwarfHamster : Cricetulus {
	public string speciesName = "Long-tailed Dwarf Hamster";
	// Constructor
	public LongTailedDwarfHamster (string animalName) {
		name = animalName;
		isDwarf = true;
	}
}


// ~~~~~ SPECIES (Genus: Equus) ~~~~~
class Horse : Equus {
	public string speciesName = "Horse";
	// Constructor
	public Horse (string animalName) {
		name = animalName;
		isHybrid = false;
	}
}

class Zebra : Equus {
	public string speciesName = "Zebra";
	// Constructor
	public Zebra (string animalName) {
		name = animalName;
		isHybrid = false;
	}
	// Method overloading example
	public Zebra (string animalName, bool hybrid) {
		name = animalName;
		if(hybrid == true) {
			isHybrid = true;
			isFertile = false;
		} else {
			isHybrid = false;
			isFertile = true;
		}
	}
}

class Donkey : Equus {
	public string speciesName = "Donkey";
	// Constructor
	public Donkey (string animalName) {
		name = animalName;
		isHybrid = false;
	}
}

class Mule : Equus {
	public string speciesName = "Mule";
	// CONSTRUCTOR
	public Mule (string animalName) {
		name = animalName;
		isHybrid = true;
		isFertile = false;
	}
}

class Zedonk : Equus {
	public string speciesName = "Zedonk";
	// CONSTRUCTOR
	public Zedonk (string animalName) {
		name = animalName;
		isHybrid = true;
		isFertile = false;
	}
}


// ANIMAL INSTANCES
Horse mrEd = new Horse("Mr. Ed");
Zebra stripey = new Zebra("Stripey", false);
Donkey eeyore = new Donkey("Eeyore");
Mule stumpy = new Mule("Stumpy");
Zedonk zippy = new Zedonk("Zippy");

TibetanHamster roger = new TibetanHamster("Roger");
ChineseDwarfHamster larry = new ChineseDwarfHamster("Larry");
ChineseHamster nick = new ChineseHamster("Nick Petit");
GreyDwarfHamster sally = new GreyDwarfHamster("Sally");
LongTailedDwarfHamster todd = new LongTailedDwarfHamster("Todd");

Latastei marco = new Latastei("Marco");
Iberica robert = new Iberica("Robert");
Arvalis doug = new Arvalis("Doug");
Boylii steveFrench = new Boylii("Steve French");
Chensinensis ricky = new Chensinensis("Ricky");


// CONSOLE OUTPUT
Console.WriteLine("");
Console.WriteLine("~~~~~~~~~~~~~~~~");
Console.WriteLine("Equus Instances:");
Console.WriteLine("~~~~~~~~~~~~~~~~");
Console.WriteLine("");

Console.WriteLine("Name: " + mrEd.name);
Console.WriteLine("Genus: " + mrEd.genus);
Console.WriteLine("Species: " + mrEd.speciesName);
Console.WriteLine("Legs: " + mrEd.legs);
Console.WriteLine("Hybrid: " + mrEd.isHybrid);
Console.WriteLine("Fertile: " + mrEd.isFertile);
Console.WriteLine("");

Console.WriteLine("Name: " + stripey.name);
Console.WriteLine("Genus: " + stripey.genus);
Console.WriteLine("Species: " + stripey.speciesName);
Console.WriteLine("Legs: " + stripey.legs);
Console.WriteLine("Hybrid: " + stripey.isHybrid);
Console.WriteLine("Fertile: " + stripey.isFertile);
Console.WriteLine("");

Console.WriteLine("Name: " + eeyore.name);
Console.WriteLine("Genus: " + eeyore.genus);
Console.WriteLine("Species: " + eeyore.speciesName);
Console.WriteLine("Legs: " + eeyore.legs);
Console.WriteLine("Hybrid: " + eeyore.isHybrid);
Console.WriteLine("Fertile: " + eeyore.isFertile);
Console.WriteLine("");

Console.WriteLine("Name: " + stumpy.name);
Console.WriteLine("Genus: " + stumpy.genus);
Console.WriteLine("Species: " + stumpy.speciesName);
Console.WriteLine("Legs: " + stumpy.legs);
Console.WriteLine("Hybrid: " + stumpy.isHybrid);
Console.WriteLine("Fertile: " + stumpy.isFertile);
Console.WriteLine("");

Console.WriteLine("Name: " + zippy.name);
Console.WriteLine("Genus: " + zippy.genus);
Console.WriteLine("Species: " + zippy.speciesName);
Console.WriteLine("Legs: " + zippy.legs);
Console.WriteLine("Hybrid: " + zippy.isHybrid);
Console.WriteLine("Fertile: " + zippy.isFertile);
Console.WriteLine("");

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Cricetulus Instances:");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("");

Console.WriteLine("Name: " + roger.name);
Console.WriteLine("Genus: " + roger.genus);
Console.WriteLine("Species: " + roger.speciesName);
Console.WriteLine("Legs: " + roger.legs);
Console.WriteLine("Dwarf: " + roger.isDwarf);
Console.WriteLine("");

Console.WriteLine("Name: " + larry.name);
Console.WriteLine("Genus: " + larry.genus);
Console.WriteLine("Species: " + larry.speciesName);
Console.WriteLine("Legs: " + larry.legs);
Console.WriteLine("Dwarf: " + larry.isDwarf);
Console.WriteLine("");

Console.WriteLine("Name: " + nick.name);
Console.WriteLine("Genus: " + nick.genus);
Console.WriteLine("Species: " + nick.speciesName);
Console.WriteLine("Legs: " + nick.legs);
Console.WriteLine("Dwarf: " + nick.isDwarf);
Console.WriteLine("");

Console.WriteLine("Name: " + sally.name);
Console.WriteLine("Genus: " + sally.genus);
Console.WriteLine("Species: " + sally.speciesName);
Console.WriteLine("Legs: " + sally.legs);
Console.WriteLine("Dwarf: " + sally.isDwarf);
Console.WriteLine("");

Console.WriteLine("Name: " + todd.name);
Console.WriteLine("Genus: " + todd.genus);
Console.WriteLine("Species: " + todd.speciesName);
Console.WriteLine("Legs: " + todd.legs);
Console.WriteLine("Dwarf: " + todd.isDwarf);
Console.WriteLine("");

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Rana Instances:");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("");

Console.WriteLine("Name: " + marco.name);
Console.WriteLine("Genus: " + marco.genus);
Console.WriteLine("Species: " + marco.speciesName);
Console.WriteLine("Legs: " + marco.legs);
Console.WriteLine("Color: " + marco.color);
Console.WriteLine("");

Console.WriteLine("Name: " + robert.name);
Console.WriteLine("Genus: " + robert.genus);
Console.WriteLine("Species: " + robert.speciesName);
Console.WriteLine("Legs: " + robert.legs);
Console.WriteLine("Color: " + robert.color);
Console.WriteLine("");

Console.WriteLine("Name: " + doug.name);
Console.WriteLine("Genus: " + doug.genus);
Console.WriteLine("Species: " + doug.speciesName);
Console.WriteLine("Legs: " + doug.legs);
Console.WriteLine("Color: " + doug.color);
Console.WriteLine("");

Console.WriteLine("Name: " + steveFrench.name);
Console.WriteLine("Genus: " + steveFrench.genus);
Console.WriteLine("Species: " + steveFrench.speciesName);
Console.WriteLine("Legs: " + steveFrench.legs);
Console.WriteLine("Color: " + steveFrench.color);
Console.WriteLine("");

Console.WriteLine("Name: " + ricky.name);
Console.WriteLine("Genus: " + ricky.genus);
Console.WriteLine("Species: " + ricky.speciesName);
Console.WriteLine("Legs: " + ricky.legs);
Console.WriteLine("Color: " + ricky.color);
Console.WriteLine("");


