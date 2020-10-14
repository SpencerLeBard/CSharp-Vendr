using System;
using System.Collections.Generic;
using System.Linq;
using Vendr.Interfaces;
using Vendr.Models;

namespace Vendr.Services
{
  class VendrService
  {
    public List<Snack> Snacks { get; set; }
    internal string GetPurchasables()
    {
      var list = "THANK YOU FOR PURCHASING \n";
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
        new Snack("poptart", 1 ,"Desc1"),
        new Snack("your mom", 2 ,"Desc2"),
        new Snack("your dad", 3 ,"Desc3"),
        new Snack("PickleRick", 4 ,"Desc4")
      };
    }
  }
}
