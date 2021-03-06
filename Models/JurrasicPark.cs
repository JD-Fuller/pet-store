using System.Collections.Generic;

namespace classes.Models

{
  class JurassicPark
  {

    //INSTANTIATING Lists
    public List<Raptor> Raptors { get; private set; } = new List<Raptor>();

    // public List<TRex> TRexs { get; private set; } = new List<TRex>();
    // METHODS
    public void AddDino(Raptor raptor)
    {
      Raptors.Add(raptor);
    }
    // public void AddDino(TRex tRex)
    // {
    //   TRexs.Add(tRex);
    // }
    public void AddDino(List<Raptor> raptors)
    {
      Raptors.AddRange(raptors);
    }
    public void AddDino(Raptor[] raptors)
    {
      Raptors.AddRange(raptors);
    }
    // public void AddDino(TRex[] tRexs)
    // {
    //   TRexs.AddRange(tRexs);
    // }
    // public void AddDino(List<TRex> tRexs)
    // {
    //   TRexs.AddRange(tRexs);
    // }
    public JurassicPark()
    {
      System.Console.WriteLine("Let's Make a Park");

    }

  }


}