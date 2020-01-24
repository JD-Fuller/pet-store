using System;
using classes.Models;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      Raptor blue = new Raptor("Blue", "Purplish-blue");

      Console.WriteLine($@"It's Dinosaur Time!
      
Here is your Dinosaur");

      System.Console.WriteLine($@"His name is {blue.Name} and it is {blue.Color}");

      System.Console.WriteLine("Hit A key to add a dinosaur to your list and D to delete a dinosaur from your list");

      String res = Console.ReadLine().ToLower();

      bool validate = true;
      while (validate)
      {
        if (res != "A")
        {

          Console.WriteLine("Success - a dino has been added");
          return;
        }
        else
        {
          Console.WriteLine("Well, that didn't do anything");
        }
      }





      System.Console.WriteLine("Are you ready to make a park?");
      JurassicPark isla = new JurassicPark();
      System.Console.WriteLine("Congrats...you just made a park.");

      isla.AddDino(blue);



    }
  }
}
