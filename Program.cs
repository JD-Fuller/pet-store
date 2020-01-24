using System;
using classes.Models;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("It's Dinosaur Time!");
      Raptor blue = new Raptor("Blue", "Purplish-blue");
      System.Console.WriteLine(blue.Name + "&&" + blue.Color);



      System.Console.WriteLine("Are you ready to make a park?");
      JurassicPark isla = new JurassicPark();
      System.Console.WriteLine("Congrats...you just made a park.");

      isla.AddDino(blue);



    }
  }
}
