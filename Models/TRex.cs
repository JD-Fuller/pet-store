using System;

namespace classes.Models
{
  class TRex
  {
    public string Name { get; private set; }
    public string Color { get; private set; }

    public TRex(string name, string color)
    {
      Name = name;
      Color = color;
    }
  }




}