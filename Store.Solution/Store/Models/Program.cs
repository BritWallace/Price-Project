using System;
using System.Collections.Generic;
// namespace for the store below
using StoreTime;

namespace ProgramSpace
{
  public class Program
  {

    public static void Main()
    {
      
      Console.WriteLine("Welcome to Party Town!");
      Console.WriteLine("Would you like a snowcone? 'Y' for yes or enter 'N' for no");
      //if stuff here
      Console.Write("What color?: ");
      string newCone = Console.ReadLine();
      Console.Write("How many cones ya want?: ");
      string quantity = Console.ReadLine();

      //string price = //method to calculate priceConsole.ReadLine();

      // new store created
      StoreStuff newStore = new StoreStuff(newCone, quantity);
      Console.WriteLine(newStore.quantity);
      Console.WriteLine(newStore.typeOfCone);
      
    }
  }
}