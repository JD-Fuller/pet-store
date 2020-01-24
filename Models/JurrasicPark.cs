using System.Collections.Generic;

namespace classes.Models

{
  class JurassicPark
  {


    public List<Raptor> Raptors { get: private set; } = new List<Raptor>();

    public List<Raptor> TRexs { get: private set; } = new List<Raptor>();

    public void AddDino(Raptor raptor)
    {
      Raptors.Add(raptor);
    }
    public void AddDino(TRex tRex)
    {
      TRexs.Add(tRex);
    }

    public void AddDino(List<Raptor> raptors)
    {
      Raptors.AddRange(raptors);
    }
    public void AddDino(List<TRex> tRexs)
    {

      TRexs.AddRange(tRexs);
    }

    public DinoStore()
    {
      Raptors;
      TRexs;
    }

  }


}