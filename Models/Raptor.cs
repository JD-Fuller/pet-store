using System;

namespace classes.Models
{
  class Raptor
  {
    public string Name { get; private set; }
    public string Color { get; private set; }


    public Raptor(string name, string color)
    {
      Name = name;
      Color = color;
    }
  }




}