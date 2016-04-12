using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Zoolandia.Genus;
using Zoolandia.Species;

namespace Zoolandia
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Animal larry = new Animal();
            // larry.name = args[0];

            // ANIMAL INSTANCES
            Zedonk zippy = new Zedonk("Zippy");
            Latastei marco = new Latastei("Marco");
            Iberica robert = new Iberica("Robert");

            // CONSOLE OUTPUT
            Console.WriteLine("Name:: " + zippy.name);
            Console.WriteLine("Genus: " + zippy.genus);
            Console.WriteLine("Species: " + zippy.speciesName);
            Console.WriteLine("Common Name: " + zippy.commonName);
            Console.WriteLine("Legs: " + zippy.legs);
            Console.WriteLine("Hybrid: " + zippy.isHybrid);
            Console.WriteLine("Fertile: " + zippy.isFertile);
            Console.WriteLine("");

            Console.WriteLine("Name: " + marco.name);
            Console.WriteLine("Genus: " + marco.genus);
            Console.WriteLine("Species: " + marco.speciesName);
            Console.WriteLine("Common Name: " + marco.commonName);
            Console.WriteLine("Legs: " + marco.legs);
            Console.WriteLine("Color: " + marco.color);
            Console.WriteLine("Override test: " + marco.doSomething());
            Console.WriteLine("");

            Console.WriteLine("Name: " + robert.name);
            Console.WriteLine("Genus: " + robert.genus);
            Console.WriteLine("Species: " + robert.speciesName);
            Console.WriteLine("Common Name: " + robert.commonName);
            Console.WriteLine("Legs: " + robert.legs);
            Console.WriteLine("Color: " + robert.color);
            Console.WriteLine("Override test: " + robert.doSomething());
            Console.WriteLine("");

        }
    }
}
