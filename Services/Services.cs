using System;
using System.Collections.Generic;
using System.Linq;
using Vendr.Interfaces;
using Vendr.Models;

namespace Vendr.Services
{
  class VendrService
  {
    internal string GetPurchasables()
    {
      var list = "ORDER FROM THE FOLLOWING: \n";
      List<IPurchasable> items = new List<IPurchasable>();

      for (int i = 0; i < items.Count; i++)
      {
        IPurchasable item = items[i];
        list += $"{i + 1}. {item.Price}";
      }
      return list;
    }
    public VendrService()
    {
      Snacks = new List<Snack>(){
        new Snack("poptart", "Desc1"),
        new Snack("your mom", "Desc2"),
        new Snack("your dad", "Desc3"),
        new Snack("Pickle in Bag", "Desc4")
      };
    }
  }
}
