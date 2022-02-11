using System.Collections.Generic;
using System;

using ProgramSpace;

namespace StoreTime
{
  public class StoreStuff
  {
    public string typeOfCone {get; set;}
    public int quantity {get; set;}

    public int Price {get; set;}

    public StoreStuff(string coneType, string qty)
    {
      typeOfCone = coneType;
      int quantityTemp;
      Int32.TryParse(qty, out quantityTemp);
      quantity = quantityTemp;
    }
  }
}